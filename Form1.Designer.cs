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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.videoViewerWF8 = new Ozeki.Media.VideoViewerWF();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.videoViewerWF9 = new Ozeki.Media.VideoViewerWF();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.micpic1 = new System.Windows.Forms.PictureBox();
            this.micpic2 = new System.Windows.Forms.PictureBox();
            this.micpic3 = new System.Windows.Forms.PictureBox();
            this.micpic4 = new System.Windows.Forms.PictureBox();
            this.micpic5 = new System.Windows.Forms.PictureBox();
            this.micpic6 = new System.Windows.Forms.PictureBox();
            this.micpic7 = new System.Windows.Forms.PictureBox();
            this.micpic8 = new System.Windows.Forms.PictureBox();
            this.micpic9 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.micpic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.micpic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.micpic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.micpic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.micpic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.micpic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.micpic7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.micpic8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.micpic9)).BeginInit();
            this.SuspendLayout();
            // 
            // connectBtn
            // 
            this.connectBtn.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.connectBtn.Location = new System.Drawing.Point(1739, 526);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(120, 34);
            this.connectBtn.TabIndex = 0;
            this.connectBtn.Text = "LiveStart";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1775, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button1_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button1_MouseUp);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1775, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button2_MouseDown);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button2_MouseUp);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(1725, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button3_MouseDown);
            this.button3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button3_MouseUp);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(1821, 314);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 5;
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
            this.radioButton4.Location = new System.Drawing.Point(58, 360);
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
            this.videoViewerWF4.Location = new System.Drawing.Point(58, 383);
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
            this.radioButton5.Location = new System.Drawing.Point(589, 360);
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
            this.videoViewerWF5.Location = new System.Drawing.Point(589, 383);
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
            this.radioButton6.Location = new System.Drawing.Point(1108, 361);
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
            this.videoViewerWF6.Location = new System.Drawing.Point(1108, 384);
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
            this.radioButton7.Location = new System.Drawing.Point(58, 688);
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
            this.videoViewerWF7.Location = new System.Drawing.Point(58, 707);
            this.videoViewerWF7.Name = "videoViewerWF7";
            this.videoViewerWF7.RotateAngle = 0;
            this.videoViewerWF7.Size = new System.Drawing.Size(435, 245);
            this.videoViewerWF7.TabIndex = 18;
            this.videoViewerWF7.Text = "videoViewerWF7";
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton8.Location = new System.Drawing.Point(589, 688);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(14, 13);
            this.radioButton8.TabIndex = 21;
            this.radioButton8.TabStop = true;
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // videoViewerWF8
            // 
            this.videoViewerWF8.BackColor = System.Drawing.Color.Black;
            this.videoViewerWF8.ContextMenuEnabled = true;
            this.videoViewerWF8.FlipMode = Ozeki.Media.FlipMode.None;
            this.videoViewerWF8.FrameStretch = Ozeki.Media.FrameStretch.Uniform;
            this.videoViewerWF8.FullScreenEnabled = true;
            this.videoViewerWF8.Location = new System.Drawing.Point(589, 707);
            this.videoViewerWF8.Name = "videoViewerWF8";
            this.videoViewerWF8.RotateAngle = 0;
            this.videoViewerWF8.Size = new System.Drawing.Size(435, 245);
            this.videoViewerWF8.TabIndex = 20;
            this.videoViewerWF8.Text = "videoViewerWF8";
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton9.Location = new System.Drawing.Point(1108, 689);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(14, 13);
            this.radioButton9.TabIndex = 23;
            this.radioButton9.TabStop = true;
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // videoViewerWF9
            // 
            this.videoViewerWF9.BackColor = System.Drawing.Color.Black;
            this.videoViewerWF9.ContextMenuEnabled = true;
            this.videoViewerWF9.FlipMode = Ozeki.Media.FlipMode.None;
            this.videoViewerWF9.FrameStretch = Ozeki.Media.FrameStretch.Uniform;
            this.videoViewerWF9.FullScreenEnabled = true;
            this.videoViewerWF9.Location = new System.Drawing.Point(1108, 708);
            this.videoViewerWF9.Name = "videoViewerWF9";
            this.videoViewerWF9.RotateAngle = 0;
            this.videoViewerWF9.Size = new System.Drawing.Size(435, 245);
            this.videoViewerWF9.TabIndex = 22;
            this.videoViewerWF9.Text = "videoViewerWF9";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1622, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 121);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // micpic1
            // 
            this.micpic1.Image = ((System.Drawing.Image)(resources.GetObject("micpic1.Image")));
            this.micpic1.Location = new System.Drawing.Point(459, 29);
            this.micpic1.Name = "micpic1";
            this.micpic1.Size = new System.Drawing.Size(34, 32);
            this.micpic1.TabIndex = 25;
            this.micpic1.TabStop = false;
            this.micpic1.Visible = false;
            // 
            // micpic2
            // 
            this.micpic2.Image = ((System.Drawing.Image)(resources.GetObject("micpic2.Image")));
            this.micpic2.Location = new System.Drawing.Point(990, 29);
            this.micpic2.Name = "micpic2";
            this.micpic2.Size = new System.Drawing.Size(34, 32);
            this.micpic2.TabIndex = 26;
            this.micpic2.TabStop = false;
            this.micpic2.Visible = false;
            // 
            // micpic3
            // 
            this.micpic3.Image = ((System.Drawing.Image)(resources.GetObject("micpic3.Image")));
            this.micpic3.Location = new System.Drawing.Point(1509, 29);
            this.micpic3.Name = "micpic3";
            this.micpic3.Size = new System.Drawing.Size(34, 32);
            this.micpic3.TabIndex = 27;
            this.micpic3.TabStop = false;
            this.micpic3.Visible = false;
            // 
            // micpic4
            // 
            this.micpic4.Image = ((System.Drawing.Image)(resources.GetObject("micpic4.Image")));
            this.micpic4.Location = new System.Drawing.Point(459, 350);
            this.micpic4.Name = "micpic4";
            this.micpic4.Size = new System.Drawing.Size(34, 32);
            this.micpic4.TabIndex = 28;
            this.micpic4.TabStop = false;
            this.micpic4.Visible = false;
            // 
            // micpic5
            // 
            this.micpic5.Image = ((System.Drawing.Image)(resources.GetObject("micpic5.Image")));
            this.micpic5.Location = new System.Drawing.Point(990, 350);
            this.micpic5.Name = "micpic5";
            this.micpic5.Size = new System.Drawing.Size(34, 32);
            this.micpic5.TabIndex = 29;
            this.micpic5.TabStop = false;
            this.micpic5.Visible = false;
            // 
            // micpic6
            // 
            this.micpic6.Image = ((System.Drawing.Image)(resources.GetObject("micpic6.Image")));
            this.micpic6.Location = new System.Drawing.Point(1509, 350);
            this.micpic6.Name = "micpic6";
            this.micpic6.Size = new System.Drawing.Size(34, 32);
            this.micpic6.TabIndex = 30;
            this.micpic6.TabStop = false;
            this.micpic6.Visible = false;
            // 
            // micpic7
            // 
            this.micpic7.Image = ((System.Drawing.Image)(resources.GetObject("micpic7.Image")));
            this.micpic7.Location = new System.Drawing.Point(459, 673);
            this.micpic7.Name = "micpic7";
            this.micpic7.Size = new System.Drawing.Size(34, 32);
            this.micpic7.TabIndex = 31;
            this.micpic7.TabStop = false;
            this.micpic7.Visible = false;
            // 
            // micpic8
            // 
            this.micpic8.Image = ((System.Drawing.Image)(resources.GetObject("micpic8.Image")));
            this.micpic8.Location = new System.Drawing.Point(990, 673);
            this.micpic8.Name = "micpic8";
            this.micpic8.Size = new System.Drawing.Size(34, 32);
            this.micpic8.TabIndex = 32;
            this.micpic8.TabStop = false;
            this.micpic8.Visible = false;
            // 
            // micpic9
            // 
            this.micpic9.Image = ((System.Drawing.Image)(resources.GetObject("micpic9.Image")));
            this.micpic9.Location = new System.Drawing.Point(1509, 673);
            this.micpic9.Name = "micpic9";
            this.micpic9.Size = new System.Drawing.Size(34, 32);
            this.micpic9.TabIndex = 33;
            this.micpic9.TabStop = false;
            this.micpic9.Visible = false;
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(1775, 383);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 57);
            this.button5.TabIndex = 34;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(1821, 383);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 57);
            this.button6.TabIndex = 35;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button7
            // 
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(1725, 258);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 50);
            this.button7.TabIndex = 36;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button7_MouseDown);
            this.button7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button7_MouseUp);
            // 
            // button8
            // 
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(1821, 258);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 50);
            this.button8.TabIndex = 37;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button8_MouseDown);
            this.button8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button8_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.micpic9);
            this.Controls.Add(this.micpic8);
            this.Controls.Add(this.micpic7);
            this.Controls.Add(this.micpic6);
            this.Controls.Add(this.micpic5);
            this.Controls.Add(this.micpic4);
            this.Controls.Add(this.micpic3);
            this.Controls.Add(this.micpic2);
            this.Controls.Add(this.micpic1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radioButton9);
            this.Controls.Add(this.videoViewerWF9);
            this.Controls.Add(this.radioButton8);
            this.Controls.Add(this.videoViewerWF8);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.micpic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.micpic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.micpic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.micpic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.micpic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.micpic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.micpic7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.micpic8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.micpic9)).EndInit();
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
        private System.Windows.Forms.RadioButton radioButton8;
        private Ozeki.Media.VideoViewerWF videoViewerWF8;
        private System.Windows.Forms.RadioButton radioButton9;
        private Ozeki.Media.VideoViewerWF videoViewerWF9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox micpic1;
        private System.Windows.Forms.PictureBox micpic2;
        private System.Windows.Forms.PictureBox micpic3;
        private System.Windows.Forms.PictureBox micpic4;
        private System.Windows.Forms.PictureBox micpic5;
        private System.Windows.Forms.PictureBox micpic6;
        private System.Windows.Forms.PictureBox micpic7;
        private System.Windows.Forms.PictureBox micpic8;
        private System.Windows.Forms.PictureBox micpic9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

