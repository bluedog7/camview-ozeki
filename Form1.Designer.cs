namespace newcam
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.connectBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.videoViewerWF1 = new Ozeki.Media.VideoViewerWF();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.videoViewerWF2 = new Ozeki.Media.VideoViewerWF();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.videoViewerWF3 = new Ozeki.Media.VideoViewerWF();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.videoViewerWF4 = new Ozeki.Media.VideoViewerWF();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.videoViewerWF5 = new Ozeki.Media.VideoViewerWF();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.videoViewerWF6 = new Ozeki.Media.VideoViewerWF();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.videoViewerWF7 = new Ozeki.Media.VideoViewerWF();
            this.SuspendLayout();
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(1679, 41);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(75, 23);
            this.connectBtn.TabIndex = 0;
            this.connectBtn.Text = "connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1718, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "down";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button1_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button1_MouseUp);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1718, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "up";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button2_MouseDown);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button2_MouseUp);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1648, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "left";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button3_MouseDown);
            this.button3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button3_MouseUp);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1807, 156);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "right";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button4_MouseDown);
            this.button4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button4_MouseUp);
            // 
            // videoViewerWF1
            // 
            this.videoViewerWF1.BackColor = System.Drawing.Color.Black;
            this.videoViewerWF1.ContextMenuEnabled = true;
            this.videoViewerWF1.FlipMode = Ozeki.Media.FlipMode.None;
            this.videoViewerWF1.FrameStretch = Ozeki.Media.FrameStretch.Uniform;
            this.videoViewerWF1.FullScreenEnabled = true;
            this.videoViewerWF1.Location = new System.Drawing.Point(58, 60);
            this.videoViewerWF1.Name = "videoViewerWF1";
            this.videoViewerWF1.RotateAngle = 0;
            this.videoViewerWF1.Size = new System.Drawing.Size(435, 245);
            this.videoViewerWF1.TabIndex = 6;
            this.videoViewerWF1.Text = "videoViewerWF1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton1.Location = new System.Drawing.Point(58, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // videoViewerWF2
            // 
            this.videoViewerWF2.BackColor = System.Drawing.Color.Black;
            this.videoViewerWF2.ContextMenuEnabled = true;
            this.videoViewerWF2.FlipMode = Ozeki.Media.FlipMode.None;
            this.videoViewerWF2.FrameStretch = Ozeki.Media.FrameStretch.Uniform;
            this.videoViewerWF2.FullScreenEnabled = true;
            this.videoViewerWF2.Location = new System.Drawing.Point(589, 60);
            this.videoViewerWF2.Name = "videoViewerWF2";
            this.videoViewerWF2.RotateAngle = 0;
            this.videoViewerWF2.Size = new System.Drawing.Size(435, 245);
            this.videoViewerWF2.TabIndex = 8;
            this.videoViewerWF2.Text = "videoViewerWF2";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton2.Location = new System.Drawing.Point(589, 29);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton3.Location = new System.Drawing.Point(1108, 29);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(14, 13);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // videoViewerWF3
            // 
            this.videoViewerWF3.BackColor = System.Drawing.Color.Black;
            this.videoViewerWF3.ContextMenuEnabled = true;
            this.videoViewerWF3.FlipMode = Ozeki.Media.FlipMode.None;
            this.videoViewerWF3.FrameStretch = Ozeki.Media.FrameStretch.Uniform;
            this.videoViewerWF3.FullScreenEnabled = true;
            this.videoViewerWF3.Location = new System.Drawing.Point(1108, 60);
            this.videoViewerWF3.Name = "videoViewerWF3";
            this.videoViewerWF3.RotateAngle = 0;
            this.videoViewerWF3.Size = new System.Drawing.Size(435, 245);
            this.videoViewerWF3.TabIndex = 10;
            this.videoViewerWF3.Text = "videoViewerWF3";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton4.Location = new System.Drawing.Point(58, 367);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(14, 13);
            this.radioButton4.TabIndex = 13;
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // videoViewerWF4
            // 
            this.videoViewerWF4.BackColor = System.Drawing.Color.Black;
            this.videoViewerWF4.ContextMenuEnabled = true;
            this.videoViewerWF4.FlipMode = Ozeki.Media.FlipMode.None;
            this.videoViewerWF4.FrameStretch = Ozeki.Media.FrameStretch.Uniform;
            this.videoViewerWF4.FullScreenEnabled = true;
            this.videoViewerWF4.Location = new System.Drawing.Point(58, 390);
            this.videoViewerWF4.Name = "videoViewerWF4";
            this.videoViewerWF4.RotateAngle = 0;
            this.videoViewerWF4.Size = new System.Drawing.Size(435, 245);
            this.videoViewerWF4.TabIndex = 12;
            this.videoViewerWF4.Text = "videoViewerWF4";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton5.Location = new System.Drawing.Point(589, 367);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(14, 13);
            this.radioButton5.TabIndex = 15;
            this.radioButton5.TabStop = true;
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // videoViewerWF5
            // 
            this.videoViewerWF5.BackColor = System.Drawing.Color.Black;
            this.videoViewerWF5.ContextMenuEnabled = true;
            this.videoViewerWF5.FlipMode = Ozeki.Media.FlipMode.None;
            this.videoViewerWF5.FrameStretch = Ozeki.Media.FrameStretch.Uniform;
            this.videoViewerWF5.FullScreenEnabled = true;
            this.videoViewerWF5.Location = new System.Drawing.Point(589, 390);
            this.videoViewerWF5.Name = "videoViewerWF5";
            this.videoViewerWF5.RotateAngle = 0;
            this.videoViewerWF5.Size = new System.Drawing.Size(435, 245);
            this.videoViewerWF5.TabIndex = 14;
            this.videoViewerWF5.Text = "videoViewerWF5";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton6.Location = new System.Drawing.Point(1108, 382);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(14, 13);
            this.radioButton6.TabIndex = 17;
            this.radioButton6.TabStop = true;
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // videoViewerWF6
            // 
            this.videoViewerWF6.BackColor = System.Drawing.Color.Black;
            this.videoViewerWF6.ContextMenuEnabled = true;
            this.videoViewerWF6.FlipMode = Ozeki.Media.FlipMode.None;
            this.videoViewerWF6.FrameStretch = Ozeki.Media.FrameStretch.Uniform;
            this.videoViewerWF6.FullScreenEnabled = true;
            this.videoViewerWF6.Location = new System.Drawing.Point(1108, 405);
            this.videoViewerWF6.Name = "videoViewerWF6";
            this.videoViewerWF6.RotateAngle = 0;
            this.videoViewerWF6.Size = new System.Drawing.Size(435, 245);
            this.videoViewerWF6.TabIndex = 16;
            this.videoViewerWF6.Text = "videoViewerWF6";
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton7.Location = new System.Drawing.Point(58, 695);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(14, 13);
            this.radioButton7.TabIndex = 19;
            this.radioButton7.TabStop = true;
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // videoViewerWF7
            // 
            this.videoViewerWF7.BackColor = System.Drawing.Color.Black;
            this.videoViewerWF7.ContextMenuEnabled = true;
            this.videoViewerWF7.FlipMode = Ozeki.Media.FlipMode.None;
            this.videoViewerWF7.FrameStretch = Ozeki.Media.FrameStretch.Uniform;
            this.videoViewerWF7.FullScreenEnabled = true;
            this.videoViewerWF7.Location = new System.Drawing.Point(58, 714);
            this.videoViewerWF7.Name = "videoViewerWF7";
            this.videoViewerWF7.RotateAngle = 0;
            this.videoViewerWF7.Size = new System.Drawing.Size(435, 245);
            this.videoViewerWF7.TabIndex = 18;
            this.videoViewerWF7.Text = "videoViewerWF7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.videoViewerWF7);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.videoViewerWF6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.videoViewerWF5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.videoViewerWF4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.videoViewerWF3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.videoViewerWF2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.videoViewerWF1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.connectBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private Ozeki.Media.VideoViewerWF videoViewerWF1;
        private System.Windows.Forms.RadioButton radioButton1;
        private Ozeki.Media.VideoViewerWF videoViewerWF2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private Ozeki.Media.VideoViewerWF videoViewerWF3;
        private System.Windows.Forms.RadioButton radioButton4;
        private Ozeki.Media.VideoViewerWF videoViewerWF4;
        private System.Windows.Forms.RadioButton radioButton5;
        private Ozeki.Media.VideoViewerWF videoViewerWF5;
        private System.Windows.Forms.RadioButton radioButton6;
        private Ozeki.Media.VideoViewerWF videoViewerWF6;
        private System.Windows.Forms.RadioButton radioButton7;
        private Ozeki.Media.VideoViewerWF videoViewerWF7;
    }
}

