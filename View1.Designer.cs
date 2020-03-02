namespace Camview
{
    partial class View1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.VideoInfoText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AudioInfoText = new System.Windows.Forms.TextBox();
            this.StreamCombo = new System.Windows.Forms.ComboBox();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.WhiteBalanceCRLabel = new System.Windows.Forms.Label();
            this.TrackBarWhiteBalanceCR = new System.Windows.Forms.TrackBar();
            this.label17 = new System.Windows.Forms.Label();
            this.FrameRateLabel = new System.Windows.Forms.Label();
            this.WhiteBalanceCBLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.TrackBarFrameRate = new System.Windows.Forms.TrackBar();
            this.TrackBarWhiteBalanceCB = new System.Windows.Forms.TrackBar();
            this.label15 = new System.Windows.Forms.Label();
            this.BackLightLabel = new System.Windows.Forms.Label();
            this.SharpnessLabel = new System.Windows.Forms.Label();
            this.TrackBarBackLight = new System.Windows.Forms.TrackBar();
            this.TrackBarSharpness = new System.Windows.Forms.TrackBar();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SaturationLabel = new System.Windows.Forms.Label();
            this.ContrastLabel = new System.Windows.Forms.Label();
            this.brightnessLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TrackBarSaturation = new System.Windows.Forms.TrackBar();
            this.LabelImage = new System.Windows.Forms.Label();
            this.TrackBarContrast = new System.Windows.Forms.TrackBar();
            this.TrackBarBrightness = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.VerticalFlipCheck = new System.Windows.Forms.CheckBox();
            this.HorizontalFlipCheck = new System.Windows.Forms.CheckBox();
            this.LabelSaturation = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LabelContrast = new System.Windows.Forms.Label();
            this.videoViewerWF1 = new Ozeki.Media.VideoViewerWF();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarWhiteBalanceCR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarFrameRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarWhiteBalanceCB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBackLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarSharpness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBrightness)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.settingsTab);
            this.TabControl.Location = new System.Drawing.Point(912, 150);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(531, 332);
            this.TabControl.TabIndex = 5;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.StreamCombo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(523, 306);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Streams";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 12);
            this.label11.TabIndex = 3;
            this.label11.Text = "Available";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Location = new System.Drawing.Point(7, 30);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(507, 272);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Details";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.VideoInfoText);
            this.groupBox7.Location = new System.Drawing.Point(255, 17);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(245, 249);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Video";
            // 
            // VideoInfoText
            // 
            this.VideoInfoText.Location = new System.Drawing.Point(7, 18);
            this.VideoInfoText.Multiline = true;
            this.VideoInfoText.Name = "VideoInfoText";
            this.VideoInfoText.ReadOnly = true;
            this.VideoInfoText.Size = new System.Drawing.Size(230, 226);
            this.VideoInfoText.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AudioInfoText);
            this.groupBox2.Location = new System.Drawing.Point(7, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 249);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Audio";
            // 
            // AudioInfoText
            // 
            this.AudioInfoText.Location = new System.Drawing.Point(7, 18);
            this.AudioInfoText.Multiline = true;
            this.AudioInfoText.Name = "AudioInfoText";
            this.AudioInfoText.ReadOnly = true;
            this.AudioInfoText.Size = new System.Drawing.Size(230, 226);
            this.AudioInfoText.TabIndex = 1;
            // 
            // StreamCombo
            // 
            this.StreamCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StreamCombo.FormattingEnabled = true;
            this.StreamCombo.Location = new System.Drawing.Point(76, 6);
            this.StreamCombo.Name = "StreamCombo";
            this.StreamCombo.Size = new System.Drawing.Size(431, 20);
            this.StreamCombo.TabIndex = 0;
            // 
            // settingsTab
            // 
            this.settingsTab.Controls.Add(this.groupBox8);
            this.settingsTab.Controls.Add(this.groupBox6);
            this.settingsTab.Controls.Add(this.LabelSaturation);
            this.settingsTab.Controls.Add(this.label7);
            this.settingsTab.Controls.Add(this.LabelContrast);
            this.settingsTab.Location = new System.Drawing.Point(4, 22);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTab.Size = new System.Drawing.Size(523, 306);
            this.settingsTab.TabIndex = 2;
            this.settingsTab.Text = "Settings";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.WhiteBalanceCRLabel);
            this.groupBox8.Controls.Add(this.TrackBarWhiteBalanceCR);
            this.groupBox8.Controls.Add(this.label17);
            this.groupBox8.Controls.Add(this.FrameRateLabel);
            this.groupBox8.Controls.Add(this.WhiteBalanceCBLabel);
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.Controls.Add(this.TrackBarFrameRate);
            this.groupBox8.Controls.Add(this.TrackBarWhiteBalanceCB);
            this.groupBox8.Controls.Add(this.label15);
            this.groupBox8.Controls.Add(this.BackLightLabel);
            this.groupBox8.Controls.Add(this.SharpnessLabel);
            this.groupBox8.Controls.Add(this.TrackBarBackLight);
            this.groupBox8.Controls.Add(this.TrackBarSharpness);
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.Controls.Add(this.SaturationLabel);
            this.groupBox8.Controls.Add(this.ContrastLabel);
            this.groupBox8.Controls.Add(this.brightnessLabel);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Controls.Add(this.TrackBarSaturation);
            this.groupBox8.Controls.Add(this.LabelImage);
            this.groupBox8.Controls.Add(this.TrackBarContrast);
            this.groupBox8.Controls.Add(this.TrackBarBrightness);
            this.groupBox8.Controls.Add(this.label6);
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Location = new System.Drawing.Point(7, 50);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(511, 253);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Image adjustment";
            // 
            // WhiteBalanceCRLabel
            // 
            this.WhiteBalanceCRLabel.AutoSize = true;
            this.WhiteBalanceCRLabel.Location = new System.Drawing.Point(467, 189);
            this.WhiteBalanceCRLabel.Name = "WhiteBalanceCRLabel";
            this.WhiteBalanceCRLabel.Size = new System.Drawing.Size(25, 12);
            this.WhiteBalanceCRLabel.TabIndex = 32;
            this.WhiteBalanceCRLabel.Text = "     ";
            // 
            // TrackBarWhiteBalanceCR
            // 
            this.TrackBarWhiteBalanceCR.AutoSize = false;
            this.TrackBarWhiteBalanceCR.Location = new System.Drawing.Point(124, 189);
            this.TrackBarWhiteBalanceCR.Maximum = 1;
            this.TrackBarWhiteBalanceCR.Name = "TrackBarWhiteBalanceCR";
            this.TrackBarWhiteBalanceCR.Size = new System.Drawing.Size(338, 23);
            this.TrackBarWhiteBalanceCR.TabIndex = 31;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 189);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 12);
            this.label17.TabIndex = 30;
            this.label17.Text = "White balance CR";
            // 
            // FrameRateLabel
            // 
            this.FrameRateLabel.AutoSize = true;
            this.FrameRateLabel.Location = new System.Drawing.Point(468, 215);
            this.FrameRateLabel.Name = "FrameRateLabel";
            this.FrameRateLabel.Size = new System.Drawing.Size(25, 12);
            this.FrameRateLabel.TabIndex = 29;
            this.FrameRateLabel.Text = "     ";
            // 
            // WhiteBalanceCBLabel
            // 
            this.WhiteBalanceCBLabel.AutoSize = true;
            this.WhiteBalanceCBLabel.Location = new System.Drawing.Point(467, 161);
            this.WhiteBalanceCBLabel.Name = "WhiteBalanceCBLabel";
            this.WhiteBalanceCBLabel.Size = new System.Drawing.Size(25, 12);
            this.WhiteBalanceCBLabel.TabIndex = 28;
            this.WhiteBalanceCBLabel.Text = "     ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(34, 215);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 12);
            this.label16.TabIndex = 27;
            this.label16.Text = "Frame rate";
            // 
            // TrackBarFrameRate
            // 
            this.TrackBarFrameRate.AutoSize = false;
            this.TrackBarFrameRate.Location = new System.Drawing.Point(124, 215);
            this.TrackBarFrameRate.Maximum = 100;
            this.TrackBarFrameRate.Name = "TrackBarFrameRate";
            this.TrackBarFrameRate.Size = new System.Drawing.Size(338, 23);
            this.TrackBarFrameRate.TabIndex = 26;
            // 
            // TrackBarWhiteBalanceCB
            // 
            this.TrackBarWhiteBalanceCB.AutoSize = false;
            this.TrackBarWhiteBalanceCB.Location = new System.Drawing.Point(124, 161);
            this.TrackBarWhiteBalanceCB.Maximum = 1;
            this.TrackBarWhiteBalanceCB.Name = "TrackBarWhiteBalanceCB";
            this.TrackBarWhiteBalanceCB.Size = new System.Drawing.Size(338, 23);
            this.TrackBarWhiteBalanceCB.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 161);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 12);
            this.label15.TabIndex = 24;
            this.label15.Text = "White balance CB";
            // 
            // BackLightLabel
            // 
            this.BackLightLabel.AutoSize = true;
            this.BackLightLabel.Location = new System.Drawing.Point(467, 132);
            this.BackLightLabel.Name = "BackLightLabel";
            this.BackLightLabel.Size = new System.Drawing.Size(25, 12);
            this.BackLightLabel.TabIndex = 23;
            this.BackLightLabel.Text = "     ";
            // 
            // SharpnessLabel
            // 
            this.SharpnessLabel.AutoSize = true;
            this.SharpnessLabel.Location = new System.Drawing.Point(467, 103);
            this.SharpnessLabel.Name = "SharpnessLabel";
            this.SharpnessLabel.Size = new System.Drawing.Size(25, 12);
            this.SharpnessLabel.TabIndex = 22;
            this.SharpnessLabel.Text = "     ";
            // 
            // TrackBarBackLight
            // 
            this.TrackBarBackLight.AutoSize = false;
            this.TrackBarBackLight.Location = new System.Drawing.Point(124, 132);
            this.TrackBarBackLight.Maximum = 1;
            this.TrackBarBackLight.Name = "TrackBarBackLight";
            this.TrackBarBackLight.Size = new System.Drawing.Size(338, 23);
            this.TrackBarBackLight.TabIndex = 21;
            // 
            // TrackBarSharpness
            // 
            this.TrackBarSharpness.AutoSize = false;
            this.TrackBarSharpness.Location = new System.Drawing.Point(124, 103);
            this.TrackBarSharpness.Maximum = 1;
            this.TrackBarSharpness.Name = "TrackBarSharpness";
            this.TrackBarSharpness.Size = new System.Drawing.Size(338, 23);
            this.TrackBarSharpness.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 12);
            this.label14.TabIndex = 19;
            this.label14.Text = "Sharpness";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 12);
            this.label13.TabIndex = 16;
            this.label13.Text = "Backlight";
            // 
            // SaturationLabel
            // 
            this.SaturationLabel.AutoSize = true;
            this.SaturationLabel.Location = new System.Drawing.Point(467, 79);
            this.SaturationLabel.Name = "SaturationLabel";
            this.SaturationLabel.Size = new System.Drawing.Size(25, 12);
            this.SaturationLabel.TabIndex = 15;
            this.SaturationLabel.Text = "     ";
            // 
            // ContrastLabel
            // 
            this.ContrastLabel.AutoSize = true;
            this.ContrastLabel.Location = new System.Drawing.Point(468, 53);
            this.ContrastLabel.Name = "ContrastLabel";
            this.ContrastLabel.Size = new System.Drawing.Size(25, 12);
            this.ContrastLabel.TabIndex = 14;
            this.ContrastLabel.Text = "     ";
            // 
            // brightnessLabel
            // 
            this.brightnessLabel.AutoSize = true;
            this.brightnessLabel.Location = new System.Drawing.Point(467, 24);
            this.brightnessLabel.Name = "brightnessLabel";
            this.brightnessLabel.Size = new System.Drawing.Size(25, 12);
            this.brightnessLabel.TabIndex = 13;
            this.brightnessLabel.Text = "     ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 12);
            this.label12.TabIndex = 12;
            this.label12.Text = "Saturation";
            // 
            // TrackBarSaturation
            // 
            this.TrackBarSaturation.AutoSize = false;
            this.TrackBarSaturation.Location = new System.Drawing.Point(124, 75);
            this.TrackBarSaturation.Maximum = 1;
            this.TrackBarSaturation.Name = "TrackBarSaturation";
            this.TrackBarSaturation.Size = new System.Drawing.Size(338, 23);
            this.TrackBarSaturation.TabIndex = 7;
            // 
            // LabelImage
            // 
            this.LabelImage.Location = new System.Drawing.Point(0, 0);
            this.LabelImage.Name = "LabelImage";
            this.LabelImage.Size = new System.Drawing.Size(117, 21);
            this.LabelImage.TabIndex = 11;
            // 
            // TrackBarContrast
            // 
            this.TrackBarContrast.AutoSize = false;
            this.TrackBarContrast.Location = new System.Drawing.Point(124, 46);
            this.TrackBarContrast.Maximum = 1;
            this.TrackBarContrast.Name = "TrackBarContrast";
            this.TrackBarContrast.Size = new System.Drawing.Size(338, 23);
            this.TrackBarContrast.TabIndex = 3;
            // 
            // TrackBarBrightness
            // 
            this.TrackBarBrightness.AutoSize = false;
            this.TrackBarBrightness.Location = new System.Drawing.Point(124, 18);
            this.TrackBarBrightness.Maximum = 1;
            this.TrackBarBrightness.Name = "TrackBarBrightness";
            this.TrackBarBrightness.Size = new System.Drawing.Size(338, 23);
            this.TrackBarBrightness.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "Contrast";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "Brightness";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.VerticalFlipCheck);
            this.groupBox6.Controls.Add(this.HorizontalFlipCheck);
            this.groupBox6.Location = new System.Drawing.Point(7, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(241, 48);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Flip";
            // 
            // VerticalFlipCheck
            // 
            this.VerticalFlipCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.VerticalFlipCheck.AutoSize = true;
            this.VerticalFlipCheck.Location = new System.Drawing.Point(148, 18);
            this.VerticalFlipCheck.Name = "VerticalFlipCheck";
            this.VerticalFlipCheck.Size = new System.Drawing.Size(57, 22);
            this.VerticalFlipCheck.TabIndex = 12;
            this.VerticalFlipCheck.Text = "Vertical";
            this.VerticalFlipCheck.UseVisualStyleBackColor = true;
            // 
            // HorizontalFlipCheck
            // 
            this.HorizontalFlipCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.HorizontalFlipCheck.AutoSize = true;
            this.HorizontalFlipCheck.Location = new System.Drawing.Point(22, 18);
            this.HorizontalFlipCheck.Name = "HorizontalFlipCheck";
            this.HorizontalFlipCheck.Size = new System.Drawing.Size(71, 22);
            this.HorizontalFlipCheck.TabIndex = 11;
            this.HorizontalFlipCheck.Text = "Horizontal";
            this.HorizontalFlipCheck.UseVisualStyleBackColor = true;
            // 
            // LabelSaturation
            // 
            this.LabelSaturation.Location = new System.Drawing.Point(21, 86);
            this.LabelSaturation.Name = "LabelSaturation";
            this.LabelSaturation.Size = new System.Drawing.Size(117, 21);
            this.LabelSaturation.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(112, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 21);
            this.label7.TabIndex = 9;
            // 
            // LabelContrast
            // 
            this.LabelContrast.Location = new System.Drawing.Point(112, 107);
            this.LabelContrast.Name = "LabelContrast";
            this.LabelContrast.Size = new System.Drawing.Size(117, 21);
            this.LabelContrast.TabIndex = 10;
            // 
            // videoViewerWF1
            // 
            this.videoViewerWF1.BackColor = System.Drawing.Color.Black;
            this.videoViewerWF1.ContextMenuEnabled = true;
            this.videoViewerWF1.FlipMode = Ozeki.Media.FlipMode.None;
            this.videoViewerWF1.FrameStretch = Ozeki.Media.FrameStretch.Uniform;
            this.videoViewerWF1.FullScreenEnabled = true;
            this.videoViewerWF1.Location = new System.Drawing.Point(36, 51);
            this.videoViewerWF1.Name = "videoViewerWF1";
            this.videoViewerWF1.RotateAngle = 0;
            this.videoViewerWF1.Size = new System.Drawing.Size(813, 431);
            this.videoViewerWF1.TabIndex = 6;
            this.videoViewerWF1.Text = "videoViewerWF1";
            // 
            // View1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 569);
            this.Controls.Add(this.videoViewerWF1);
            this.Controls.Add(this.TabControl);
            this.Name = "View1";
            this.Text = "View1";
            this.Load += new System.EventHandler(this.View1_Load);
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.settingsTab.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarWhiteBalanceCR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarFrameRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarWhiteBalanceCB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBackLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarSharpness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBrightness)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox VideoInfoText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox AudioInfoText;
        private System.Windows.Forms.ComboBox StreamCombo;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label WhiteBalanceCRLabel;
        private System.Windows.Forms.TrackBar TrackBarWhiteBalanceCR;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label FrameRateLabel;
        private System.Windows.Forms.Label WhiteBalanceCBLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TrackBar TrackBarFrameRate;
        private System.Windows.Forms.TrackBar TrackBarWhiteBalanceCB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label BackLightLabel;
        private System.Windows.Forms.Label SharpnessLabel;
        private System.Windows.Forms.TrackBar TrackBarBackLight;
        private System.Windows.Forms.TrackBar TrackBarSharpness;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label SaturationLabel;
        private System.Windows.Forms.Label ContrastLabel;
        private System.Windows.Forms.Label brightnessLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar TrackBarSaturation;
        private System.Windows.Forms.Label LabelImage;
        private System.Windows.Forms.TrackBar TrackBarContrast;
        private System.Windows.Forms.TrackBar TrackBarBrightness;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox VerticalFlipCheck;
        private System.Windows.Forms.CheckBox HorizontalFlipCheck;
        private System.Windows.Forms.Label LabelSaturation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LabelContrast;
        private Ozeki.Media.VideoViewerWF videoViewerWF1;
    }
}