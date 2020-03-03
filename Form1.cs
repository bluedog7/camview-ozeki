using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ozeki.Media;
using Ozeki.Camera;
using System.Configuration;
namespace newcam
{
    public partial class Form1 : Form
    {
        private IIPCamera _camera, _camera2;
        private DrawingImageProvider[] _imageProvider;// = new DrawingImageProvider();
        private MediaConnector[] _connector;//= new MediaConnector();
       private Speaker _speaker;
        private int CurrentCamera = 0;
        private IIPCamera[] Cameras, CamPTZ;
        private RadioButton[] Ctlchecked;
        private VideoViewerWF[] videoViewerWFs;
        private String[] connectStr, PTZStr;
        AppSettingsReader ar;
        public Form1()
        {
            InitializeComponent();
            // Create video viewer UI control
            ar = new AppSettingsReader();
            _speaker = Speaker.GetDefaultDevice();
            Ctlchecked = new RadioButton[24];
            connectStr = new String[24];
            PTZStr = new String[24];
            _connector = new MediaConnector[24];
            // Bind the camera image to the UI control
           // videoViewerWF1.SetImageProvider(_imageProvider);
            _speaker =  Speaker.GetDefaultDevice();

            Cameras = new IIPCamera[24];
            CamPTZ = new IIPCamera[24];
            videoViewerWFs = new VideoViewerWF[24];
            _imageProvider = new DrawingImageProvider[24];
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)

            {
                Cameras[i] = IPCameraFactory.GetCamera(connectStr[i], "admin", (String)ar.GetValue("password" + (i + 1).ToString(), typeof(String)));
                CamPTZ[i] = new IPCamera(PTZStr[i], "admin", (String)ar.GetValue("password" + (i + 1).ToString(), typeof(String)));
                //CamPTZ[i] = new IPCamera("165.246.112.35", "admin","ibst0552997730");
                _connector[i].Connect(Cameras[i].VideoChannel, _imageProvider[i]);
                _connector[i].Connect(Cameras[i].AudioChannel, _speaker);
                Cameras[i].Start();
                CamPTZ[i].Start();
                videoViewerWFs[i].Start();
            }
            _speaker.Start();
        }

        private void Button1_MouseDown(object sender, MouseEventArgs e)
        {
            CamPTZ[CurrentCamera].CameraMovement.ContinuousMove(MoveDirection.Down);
        }

        private void Button1_MouseUp(object sender, MouseEventArgs e)
        {
            CamPTZ[CurrentCamera].CameraMovement.StopMovement();
        }

        private void Button2_MouseDown(object sender, MouseEventArgs e)
        {
            CamPTZ[CurrentCamera].CameraMovement.ContinuousMove(MoveDirection.Up);
        }

        private void Button2_MouseUp(object sender, MouseEventArgs e)
        {
            CamPTZ[CurrentCamera].CameraMovement.StopMovement();
        }

        private void Button3_MouseDown(object sender, MouseEventArgs e)
        {
            CamPTZ[CurrentCamera].CameraMovement.ContinuousMove(MoveDirection.Left);
        }

        private void Button3_MouseUp(object sender, MouseEventArgs e)
        {
            CamPTZ[CurrentCamera].CameraMovement.StopMovement();
        }

        private void Button4_MouseDown(object sender, MouseEventArgs e)
        {
            CamPTZ[CurrentCamera].CameraMovement.ContinuousMove(MoveDirection.Right);
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton_Click(object sender, EventArgs e)
        {
            RadioButton button = sender as RadioButton;
            String StrNum;

            StrNum = button.Name.Substring(11 , button.Name.Length-11);

            CurrentCamera = Int32.Parse(StrNum) - 1;
           }

        private void VideoViewerWF_Click(object sender, EventArgs e)
        {
            VideoViewerWF vv = sender as VideoViewerWF;
            String StrNum;

            StrNum = vv.Name.Substring(13, vv.Name.Length - 13);

            CurrentCamera = Int32.Parse(StrNum) - 1;
            Ctlchecked[CurrentCamera].Checked = true;
        }

        private void Button4_MouseUp(object sender, MouseEventArgs e)
        {
            CamPTZ[CurrentCamera].CameraMovement.StopMovement();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                videoViewerWFs[i] = (VideoViewerWF)this.Controls["videoViewerWF" + (i + 1).ToString()];
                videoViewerWFs[i].Click += VideoViewerWF_Click;
                _imageProvider[i] = new DrawingImageProvider();
                _connector[i] = new MediaConnector();
                videoViewerWFs[i].SetImageProvider(_imageProvider[i]);
                Ctlchecked[i] = (RadioButton)this.Controls["radioButton" + (i + 1).ToString()];
                Ctlchecked[i].Checked = false;
                Ctlchecked[i].Click += RadioButton_Click;
                Ctlchecked[i].Text = (String)ar.GetValue("group" + (i + 1).ToString(), typeof(String));
                connectStr[i] = "rtsp://" + (String)ar.GetValue("cam" + (i + 1).ToString(), typeof(String)) + ":554/cam/media.smp";
                PTZStr[i] =  (String)ar.GetValue("cam" + (i + 1).ToString(), typeof(String));
                //       + (String)ar.GetValue("password" + (i + 1).ToString(), typeof(String)) + ";Transport=TCP;";
                

            }
        }



        private void Button1_Click(object sender, EventArgs e)
        {

 
        }
    }
}
