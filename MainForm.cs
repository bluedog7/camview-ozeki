using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Ozeki.Camera;
using Ozeki.Media;
using _02_PTZ_Camera_Motion_Control.LOG;
using System.Configuration;
namespace Camview
{
    public partial class MainForm : Form
    {
        private IpCameraHandler _model;
        private  IpCameraHandler[] _models;
        private RadioButton[] Ctlchecked;
        private VideoViewerWF[] videoViewerWFs;
        private CameraURLBuilderWF _myCameraUrlBuilder;
        private String[] connectStr;
        private Speaker _speaker;
        private int CurrentCamera = 0;
        AppSettingsReader ar;
        public MainForm()
        {
            InitializeComponent();
            ar = new AppSettingsReader();
            _speaker = Speaker.GetDefaultDevice();
            Ctlchecked = new RadioButton[24];
            connectStr = new String[24];
            Log.OnLogMessageReceived += Log_OnLogMessageReceived;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _model = new IpCameraHandler(0);
            _models = new IpCameraHandler[24];
            videoViewerWFs = new VideoViewerWF[24];

            for (int i = 0; i < 4; i++)
            {
                _models[i] = new IpCameraHandler(i);
                _models[i].CameraStateChanged += ModelCameraStateChanged;
                _models[i].CameraErrorOccured += ModelCameraErrorOccured;
                videoViewerWFs[i] = (VideoViewerWF)this.Controls["videoViewerWF" + (i + 1).ToString()];
                videoViewerWFs[i].SetImageProvider(_models[i].ImageProvider);
                Ctlchecked[i] = (RadioButton)this.Controls["radioButton" + (i + 1).ToString()];
                Ctlchecked[i].Checked = false;
                Ctlchecked[i].Text = (String)ar.GetValue("group" + (i + 1).ToString(), typeof(String));
                connectStr[i] = "http://" + (String)ar.GetValue("cam" + (i + 1).ToString(), typeof(String)) + ":80;Username=admin;Password=" 
                              + (String)ar.GetValue("password" + (i + 1).ToString(), typeof(String)) + ";Transport=TCP;";

            }

          
            _myCameraUrlBuilder = new CameraURLBuilderWF();

            InitializeViewer();

            comboBox_Direction.DataSource = Enum.GetValues(typeof(PatrolDirection));

            CurrentCamera = 0;

            Ctlchecked[CurrentCamera].Checked = true;
        }

        private void InitializeViewer()
        {
            ControlToCenter();

            heightText.Text = videoViewerWFs[0].Size.Height.ToString(CultureInfo.InvariantCulture);
            widthText.Text = videoViewerWFs[1].Size.Width.ToString(CultureInfo.InvariantCulture);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
          //  IpCameraHandler Camera = sender as IpCameraHandler;
            _models[1].Stop();
        }

        private void ModelCameraStateChanged(object sender, CameraStateEventArgs e)
        {
            IpCameraHandler Camera = sender as IpCameraHandler;
            InvokeGuiThread(() =>
            {
                Log.Write("Camera state: " +e.State);

                switch (e.State)
                {
                    // The list of streams become available at the Streaming state.
                    case CameraState.Streaming:

                        button_Connect.Enabled = false;

                        videoViewerWFs[Camera.Camnum].Start();
                        ClearFields();
                        GetCameraStreams(Camera.Camnum);

                     //   button_Disconnect.Enabled = true;

                       // if (_models[Camera.Camnum].Camera.UriType != CameraUriType.RTSP)
                       //     InitializeTrackBars();

                        break;

                    case CameraState.Disconnected:
                      //  button_Disconnect.Enabled = false;
                        videoViewerWFs[Camera.Camnum].Stop();
                        button_Connect.Enabled = true;
                        break;
                }
            });
        }

        private void GetCameraStreams(int Camnum)
        {
            if (_models[Camnum].Camera.AvailableStreams.Any())
            {
                var selected = 0;
                InvokeGuiThread(() =>
                {
                    for (var index = 0; index < _models[Camnum].Camera.AvailableStreams.Count(); index++)
                    {
                        if (_models[Camnum].Camera.CurrentStream.Name == _models[Camnum].Camera.AvailableStreams[index].Name)
                        {
                            selected = index;
                        }

                        var name = _models[Camnum].Camera.AvailableStreams[index].Name + " " + (_models[Camnum].Camera.AvailableStreams[index].VideoEncoding != null ? _models[Camnum].Camera.AvailableStreams[index].VideoEncoding.Resolution.ToString() : "_" + index);
                        StreamCombo.Items.Add(name);
                    }
                  //  StreamCombo.SelectedIndex = selected;

                });
            }
        }

        private void ModelCameraErrorOccured(object sender, CameraErrorEventArgs e)
        {
            InvokeGuiThread(() => Log.Write("Camera error: " + (e.Details ?? e.Error.ToString())));
        }

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var link = new LinkLabel.Link { LinkData = "http://www.camera-sdk.com/" };

            if (link.LinkData != null) Process.Start(link.LinkData as string);
        }

        #region Connect - Disconnect

        private void button_Connect_Click(object sender, EventArgs e)
        {
          //  ClearFields();
            // ONVIF
            ConnectIpCam();
            GetCameraStreams(0);
            GetCameraStreams(1);
            GetCameraStreams(2);
            GetCameraStreams(3);
            AudioInfoText.Clear();
            VideoInfoText.Clear();
           // while (_models[CurrentCamera].Camera.AvailableStreams.Count<2)
                    System.Threading.Thread.Sleep(5000);
            var CurrentStream = _models[CurrentCamera].Camera.AvailableStreams[2];
            if (CurrentStream == null) throw new ArgumentNullException("Stream");
            Log.Write("0 Camera changed stream to " + CurrentStream.Name);
            _models[0].Camera.Start(CurrentStream);
            _models[0].AudioOff();
            //while (_models[1].Camera.AvailableStreams.Count < 2)
            //    System.Threading.Thread.Sleep(1000);
            for (int i = 1; i < 4; i++)
            {
                CurrentStream = _models[i].Camera.AvailableStreams[2];
                if (CurrentStream == null) throw new ArgumentNullException("Stream");
                Log.Write("1 Camera changed stream to " + CurrentStream.Name);
                _models[i].Camera.Start(CurrentStream);
                _models[i].AudioOff();
            }
            //while (_models[2].Camera.AvailableStreams.Count < 2)
            //    System.Threading.Thread.Sleep(1000);
         /*   CurrentStream = _models[2].Camera.AvailableStreams[2];
            if (CurrentStream == null) throw new ArgumentNullException("Stream");
            Log.Write("2 Camera changed stream to " + CurrentStream.Name);
            _models[2].Camera.Start(CurrentStream);
            _models[2].AudioOff();
            CurrentStream = _models[3].Camera.AvailableStreams[2];
            if (CurrentStream == null) throw new ArgumentNullException("Stream");
            Log.Write("2 Camera changed stream to " + CurrentStream.Name);
            _models[3].Camera.Start(CurrentStream);
            _models[3].AudioOff(); */
            // _models[CurrentCamera].Camera.AudioChannel.
        }

        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            if (_models[CurrentCamera].Camera != null)
                _models[CurrentCamera].Disconnect();

            ClearFields();
        }

        private void ConnectIpCam()
        {
           // _models[0].ConnectOnvifCamera(_myCameraUrlBuilder.CameraURL);
            for (int i = 0; i < 4; i++)
            {
                _models[i].ConnectOnvifCamera(connectStr[i]);
         //       _models[2].ConnectOnvifCamera("http://168.131.101.191:80;Username=admin;Password=ibst2997730;Transport=TCP;");
            }
            for (int i = 0; i < 4; i++)
            {
                videoViewerWFs[i].Start();
            }
        }

        #endregion

        #region LOG

        void Log_OnLogMessageReceived(object sender, LogEventArgs e)
        {
            InvokeGuiThread(() =>
            {
                logListBox.Items.Add(e.LogMessage);
                LogScroll();
            });
        }

        void LogScroll()
        {
            logListBox.SelectedIndex = logListBox.Items.Count - 1;
            logListBox.SelectedIndex = -1;
        }

        #endregion



        private void ClearFields()
        {
            InvokeGuiThread(() =>
            {
                StreamCombo.Items.Clear();
                AudioInfoText.Clear();
                VideoInfoText.Clear();
                DetailsText.Clear();
                StreamCombo.Text = String.Empty;
            });
        }

        #region Stream select

        private void StreamCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combo = sender as ComboBox;
            if (combo == null || combo.SelectedIndex == -1) return;
            AudioInfoText.Clear();
            VideoInfoText.Clear();

            var CurrentStream = _models[CurrentCamera].Camera.AvailableStreams[StreamCombo.SelectedIndex];
            if (CurrentStream == null) throw new ArgumentNullException("Stream");
            Log.Write("Camera changed stream to " + CurrentStream.Name);

            _models[CurrentCamera].Camera.Start(CurrentStream);

            InvokeGuiThread(() =>
            {
                DetailsText.Text = _models[CurrentCamera].GetDeviceInfo();
                AudioInfoText.Text = _models[CurrentCamera].StreamInfoAudio();
                VideoInfoText.Text = _models[CurrentCamera].StreamInfoVideo();
            });
        }
        #endregion

        #region Image Size
        private void applyButton_Click(object sender, EventArgs e)
        {
            try
            {
                var height = int.Parse(heightText.Text);
                var width = int.Parse(widthText.Text);
                if (!(height < 40 || height > 320)) // 40 - 320
                    videoViewerWF1.Height = height;
                else
                {
                    if (!(height >= 40))
                    {
                        videoViewerWFs[CurrentCamera].Height = 40;
                        heightText.Text = videoViewerWFs[CurrentCamera].Height.ToString();
                    }

                    if (!(height <= 320))
                    {
                        videoViewerWFs[CurrentCamera].Height = 320;
                        heightText.Text = videoViewerWFs[CurrentCamera].Height.ToString();
                    }

                }
                if (!(width < 50 || width > 400)) // 50 - 400
                    videoViewerWFs[CurrentCamera].Width = width;
                else
                {
                    if (!(width >= 50))
                    {
                        videoViewerWFs[CurrentCamera].Width = 50;
                        widthText.Text = videoViewerWFs[CurrentCamera].Width.ToString();
                    }
                    videoViewerWFs[CurrentCamera].Width = 50;
                    if (!(width <= 400))
                    {
                        videoViewerWFs[CurrentCamera].Width = 400;
                        widthText.Text = videoViewerWFs[CurrentCamera].Width.ToString();
                    }

                }
                ControlToCenter();
            }
            catch (Exception exception)
            {
                Log.Write(exception.Message);
            }
        }

        void ControlToCenter()
        {
            videoViewerWF1.Anchor = AnchorStyles.None;
            videoViewerWF1.Dock = DockStyle.None;
            var pt = DisplayRectangle.Location;
            pt.X += (DisplayRectangle.Width - videoViewerWF1.Width) / 2;

            pt.Y += (DisplayRectangle.Height - videoViewerWF1.Height) / 2;

         //   videoViewerWF1.Location = pt;
        }

        #endregion


        #region Image Settings

        private void TrackbarPropertiesScroll(object sender, EventArgs e)
        {
            var config = new CameraImaging
            {
                Brightness = TrackBarBrightness.Value,
                BackLightCompensation = TrackBarBackLight.Value,
                ColorSaturation = TrackBarSaturation.Value,
                Contrast = TrackBarContrast.Value,
                Sharpness = TrackBarSharpness.Value,
                WhiteBalance = new CameraWhiteBalance
                {
                    CbGain = TrackBarWhiteBalanceCB.Value,
                    CrGain = TrackBarWhiteBalanceCR.Value
                }
            };


            if (_models[CurrentCamera].Camera.ImagingSettings != null)
            {
                _models[CurrentCamera].Camera.ImagingSettings.SetAttributes(config);
                _models[CurrentCamera].Camera.ImagingSettings.RefreshProperties();
                RefreshTrackBars();
            }

            if (_models[CurrentCamera].Camera.CurrentStream.VideoEncoding == null) return;
            _models[CurrentCamera].Camera.CurrentStream.VideoEncoding.SetAttributes(new IPCameraVideoEncoding { FrameRate = TrackBarFrameRate.Value });
            _models[CurrentCamera].Camera.CurrentStream.VideoEncoding.RefreshProperties();
            RefreshFrameRate();
        }

        private void RefreshTrackBars()
        {
            brightnessLabel.Text = _models[CurrentCamera].Camera.ImagingSettings.Brightness.ToString(CultureInfo.InvariantCulture);
            TrackBarBrightness.Value = (int)_models[CurrentCamera].Camera.ImagingSettings.Brightness;

            ContrastLabel.Text = _models[CurrentCamera].Camera.ImagingSettings.Contrast.ToString(CultureInfo.InvariantCulture);
            TrackBarContrast.Value = (int)_models[CurrentCamera].Camera.ImagingSettings.Contrast;

            BackLightLabel.Text = _models[CurrentCamera].Camera.ImagingSettings.BackLightCompensation.ToString(CultureInfo.InvariantCulture);
            TrackBarBackLight.Value = (int)_models[CurrentCamera].Camera.ImagingSettings.BackLightCompensation;

            SaturationLabel.Text = _models[CurrentCamera].Camera.ImagingSettings.ColorSaturation.ToString(CultureInfo.InvariantCulture);
            TrackBarSaturation.Value = (int)_models[CurrentCamera].Camera.ImagingSettings.ColorSaturation;

            SharpnessLabel.Text = _models[CurrentCamera].Camera.ImagingSettings.Sharpness.ToString(CultureInfo.InvariantCulture);
            TrackBarSharpness.Value = (int)_models[CurrentCamera].Camera.ImagingSettings.Sharpness;

            WhiteBalanceCBLabel.Text = _models[CurrentCamera].Camera.ImagingSettings.WhiteBalance.CbGain.ToString(CultureInfo.InvariantCulture);
            TrackBarWhiteBalanceCB.Value = (int)_models[CurrentCamera].Camera.ImagingSettings.WhiteBalance.CbGain;

            WhiteBalanceCRLabel.Text = _models[CurrentCamera].Camera.ImagingSettings.WhiteBalance.CrGain.ToString(CultureInfo.InvariantCulture);
            TrackBarWhiteBalanceCR.Value = (int)_models[CurrentCamera].Camera.ImagingSettings.WhiteBalance.CrGain;
        }

        private void RefreshFrameRate()
        {
            FrameRateLabel.Text = _models[CurrentCamera].Camera.CurrentStream.VideoEncoding.FrameRate.ToString(CultureInfo.InvariantCulture);
            TrackBarFrameRate.Value = _models[CurrentCamera].Camera.CurrentStream.VideoEncoding.FrameRate;
        }

        private void InitializeTrackBars()
        {
            if (_models[CurrentCamera].Camera.ImagingSettings == null) return;
            InvokeGuiThread(() =>
            {
                TrackBarBrightness.Minimum = (int)_models[CurrentCamera].Camera.ImagingSettings.BrightnessInterval.Min;
                TrackBarBrightness.Maximum = (int)_models[CurrentCamera].Camera.ImagingSettings.BrightnessInterval.Max;
                TrackBarBrightness.Value = (int)_models[CurrentCamera].Camera.ImagingSettings.Brightness;
                brightnessLabel.Text = _models[CurrentCamera].Camera.ImagingSettings.Brightness.ToString(CultureInfo.InvariantCulture);

                TrackBarContrast.Minimum = (int)_models[CurrentCamera].Camera.ImagingSettings.ContrastInterval.Min;
                TrackBarContrast.Maximum = (int)_models[CurrentCamera].Camera.ImagingSettings.ContrastInterval.Max;
                TrackBarContrast.Value = (int)_models[CurrentCamera].Camera.ImagingSettings.Contrast;
                ContrastLabel.Text = _models[CurrentCamera].Camera.ImagingSettings.Contrast.ToString(CultureInfo.InvariantCulture);

                TrackBarSaturation.Minimum = (int)_models[CurrentCamera].Camera.ImagingSettings.ColorSaturationInterval.Min;
                TrackBarSaturation.Maximum = (int)_models[CurrentCamera].Camera.ImagingSettings.ColorSaturationInterval.Max;
                TrackBarSaturation.Value = (int)_models[CurrentCamera].Camera.ImagingSettings.ColorSaturation;
                SaturationLabel.Text = _models[CurrentCamera].Camera.ImagingSettings.ColorSaturation.ToString(CultureInfo.InvariantCulture);

                TrackBarSharpness.Minimum = (int)_models[CurrentCamera].Camera.ImagingSettings.SharpnessInterval.Min;
                TrackBarSharpness.Maximum = (int)_models[CurrentCamera].Camera.ImagingSettings.SharpnessInterval.Max;
                TrackBarSharpness.Value = (int)_models[CurrentCamera].Camera.ImagingSettings.Sharpness;
                SharpnessLabel.Text = _models[CurrentCamera].Camera.ImagingSettings.Sharpness.ToString(CultureInfo.InvariantCulture);

                TrackBarBackLight.Minimum = (int)_models[CurrentCamera].Camera.ImagingSettings.BackLightInterval.Min;
                TrackBarBackLight.Maximum = (int)_models[CurrentCamera].Camera.ImagingSettings.BackLightInterval.Max;
                TrackBarBackLight.Value = (int)_models[CurrentCamera].Camera.ImagingSettings.BackLightCompensation;
                BackLightLabel.Text = _models[CurrentCamera].Camera.ImagingSettings.BackLightCompensation.ToString(CultureInfo.InvariantCulture);

                TrackBarWhiteBalanceCR.Minimum = (int)_models[CurrentCamera].Camera.ImagingSettings.WhiteBalanceYrGainInterval.Min;
                TrackBarWhiteBalanceCR.Maximum = (int)_models[CurrentCamera].Camera.ImagingSettings.WhiteBalanceYrGainInterval.Max;
                TrackBarWhiteBalanceCR.Value = (int)_models[CurrentCamera].Camera.ImagingSettings.WhiteBalance.CrGain;
                WhiteBalanceCRLabel.Text = _models[CurrentCamera].Camera.ImagingSettings.WhiteBalance.CrGain.ToString(CultureInfo.InvariantCulture);

                TrackBarWhiteBalanceCB.Minimum = (int)_models[CurrentCamera].Camera.ImagingSettings.WhiteBalanceYbGainInterval.Min;
                TrackBarWhiteBalanceCB.Maximum = (int)_models[CurrentCamera].Camera.ImagingSettings.WhiteBalanceYbGainInterval.Max;
                TrackBarWhiteBalanceCB.Value = (int)_models[CurrentCamera].Camera.ImagingSettings.WhiteBalance.CbGain;
                WhiteBalanceCBLabel.Text = _models[CurrentCamera].Camera.ImagingSettings.WhiteBalance.CbGain.ToString(CultureInfo.InvariantCulture);

                TrackBarFrameRate.Value = _models[CurrentCamera].Camera.CurrentStream.VideoEncoding.FrameRate;
                FrameRateLabel.Text = _models[CurrentCamera].Camera.CurrentStream.VideoEncoding.FrameRate.ToString(CultureInfo.InvariantCulture);
            });
        }

        #endregion

        private void InvokeGuiThread(Action action)
        {
            BeginInvoke(action);
        }

        private void Flip(object sender, EventArgs e)
        {
            var flippedX = HorizontalFlipCheck.Checked;
            var flippedY = VerticalFlipCheck.Checked;

            if (flippedX && flippedY)
            {
                videoViewerWFs[CurrentCamera].FlipMode = FlipMode.FlipXY;
                return;
            }

            if (flippedX)
            {
                videoViewerWFs[CurrentCamera].FlipMode = FlipMode.FlipX;
                return;
            }

            if (flippedY)
            {
                videoViewerWFs[CurrentCamera].FlipMode = FlipMode.FlipY;
                return;
            }

            videoViewerWFs[CurrentCamera].FlipMode = FlipMode.None;
        }

        private void MouseDownMove(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            if (button != null) _models[CurrentCamera].Move(button.Text);
        }

        private void MouseUpMove(object sender, MouseEventArgs e)
        {
            if (_models[CurrentCamera].Camera == null) return;
            _models[CurrentCamera].Camera.CameraMovement.StopMovement();
        }

        private void button_Home_Click(object sender, EventArgs e)
        {
            if (_models[CurrentCamera].Camera == null) return;
            _models[CurrentCamera].Camera.CameraMovement.GoToHome();
        }

        private void button_SetHome_Click(object sender, EventArgs e)
        {
            if (_models[CurrentCamera].Camera == null) return;
            _models[CurrentCamera].Camera.CameraMovement.SetHome();
        }

        private void button_AddPreset_Click(object sender, EventArgs e)
        {
            if (_models[CurrentCamera].Camera == null) return;
            _models[CurrentCamera].Camera.CameraMovement.Preset.Add();
            comboBox_Presets.DataSource = _models[CurrentCamera].Camera.CameraMovement.Preset.GetPresets();
        }

        private void button_PresetMove_Click(object sender, EventArgs e)
        {
            var preset = (IPCameraPreset)comboBox_Presets.SelectedItem;
            if (preset == null || _models[CurrentCamera].Camera == null) return;
            _models[CurrentCamera].Camera.CameraMovement.Preset.MoveTo(preset.Name);
        }

        private void button_PresetDelete_Click(object sender, EventArgs e)
        {
            var preset = (IPCameraPreset)comboBox_Presets.SelectedItem;
            if (comboBox_Presets.SelectedItem == null) return;
            comboBox_Presets.DataSource = null;
            comboBox_Presets.Items.Remove(preset);
            _models[CurrentCamera].Camera.CameraMovement.Preset.Remove(preset.Name);
            comboBox_Presets.DataSource = _models[CurrentCamera].Camera.CameraMovement.Preset.GetPresets();
            comboBox_Presets.SelectedIndex = -1;
        }

        private void button_ScanStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textBox_Duration.Text)) return;
                var patrol = (PatrolDirection) comboBox_Direction.SelectedItem;
                var duration = double.Parse(textBox_Duration.Text);
                _models[CurrentCamera].Camera.CameraMovement.Patrol(patrol, duration);
            }
            catch (Exception exception)
            {
                Log.Write(exception.Message);
            }
        }

        private void button_ScanStop_Click(object sender, EventArgs e)
        {
            if (_models[CurrentCamera].Camera == null) return;
            _models[CurrentCamera].Camera.CameraMovement.StopMovement();
        }

        private void btn_compose_Click(object sender, EventArgs e)
        {
            var result = _myCameraUrlBuilder.ShowDialog();

            if (result != DialogResult.OK) return;

            //tb_cameraUrl.Text = _myCameraUrlBuilder.CameraURL;

            button_Connect.Enabled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _models[CurrentCamera].AudioOff();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            _models[CurrentCamera].AudioOn();
        }

        private void Button_Right_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton1_Click(object sender, EventArgs e)
        {
            CurrentCamera = 0;
        }

        private void RadioButton2_Click(object sender, EventArgs e)
        
            {
                CurrentCamera = 1;
            }

        private void RadioButton3_Click(object sender, EventArgs e)
        {
            CurrentCamera = 2;
         }

        private void VideoViewerWF2_DoubleClick(object sender, EventArgs e)
        {
            CurrentCamera = 1;
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            CurrentCamera = 3;
        }
    }
}
