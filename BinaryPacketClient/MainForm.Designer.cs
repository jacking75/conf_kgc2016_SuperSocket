namespace BinaryPacketClient
{
    partial class MainForm
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxLocalHostIP = new System.Windows.Forms.CheckBox();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxRecvEcho = new System.Windows.Forms.TextBox();
            this.labelSendEcho = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxSendEcho = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.labelConnState = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxPort);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.checkBoxLocalHostIP);
            this.groupBox5.Controls.Add(this.textBoxIP);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(466, 52);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Socket 더미 클라이언트 설정";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(243, 20);
            this.textBoxPort.MaxLength = 6;
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(103, 21);
            this.textBoxPort.TabIndex = 18;
            this.textBoxPort.Text = "18732";
            this.textBoxPort.WordWrap = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(181, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 12);
            this.label10.TabIndex = 17;
            this.label10.Text = "포트 번호";
            // 
            // checkBoxLocalHostIP
            // 
            this.checkBoxLocalHostIP.AutoSize = true;
            this.checkBoxLocalHostIP.Checked = true;
            this.checkBoxLocalHostIP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLocalHostIP.Location = new System.Drawing.Point(355, 23);
            this.checkBoxLocalHostIP.Name = "checkBoxLocalHostIP";
            this.checkBoxLocalHostIP.Size = new System.Drawing.Size(103, 16);
            this.checkBoxLocalHostIP.TabIndex = 15;
            this.checkBoxLocalHostIP.Text = "localhost 사용";
            this.checkBoxLocalHostIP.UseVisualStyleBackColor = true;
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(68, 19);
            this.textBoxIP.MaxLength = 6;
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(103, 21);
            this.textBoxIP.TabIndex = 11;
            this.textBoxIP.Text = "172.20.60.220";
            this.textBoxIP.WordWrap = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "서버 주소";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxRecvEcho);
            this.groupBox1.Controls.Add(this.labelSendEcho);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxSendEcho);
            this.groupBox1.Location = new System.Drawing.Point(10, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 102);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Echo";
            // 
            // textBoxRecvEcho
            // 
            this.textBoxRecvEcho.Location = new System.Drawing.Point(8, 72);
            this.textBoxRecvEcho.Name = "textBoxRecvEcho";
            this.textBoxRecvEcho.Size = new System.Drawing.Size(450, 21);
            this.textBoxRecvEcho.TabIndex = 3;
            // 
            // labelSendEcho
            // 
            this.labelSendEcho.AutoSize = true;
            this.labelSendEcho.Location = new System.Drawing.Point(101, 51);
            this.labelSendEcho.Name = "labelSendEcho";
            this.labelSendEcho.Size = new System.Drawing.Size(83, 12);
            this.labelSendEcho.TabIndex = 2;
            this.labelSendEcho.Text = "에코 정보: ???";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 19);
            this.button1.TabIndex = 1;
            this.button1.Text = "에코 보내기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxSendEcho
            // 
            this.textBoxSendEcho.Location = new System.Drawing.Point(8, 20);
            this.textBoxSendEcho.Name = "textBoxSendEcho";
            this.textBoxSendEcho.Size = new System.Drawing.Size(450, 21);
            this.textBoxSendEcho.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 19);
            this.button2.TabIndex = 19;
            this.button2.Text = "서버에 접속";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelConnState
            // 
            this.labelConnState.AutoSize = true;
            this.labelConnState.Location = new System.Drawing.Point(234, 73);
            this.labelConnState.Name = "labelConnState";
            this.labelConnState.Size = new System.Drawing.Size(111, 12);
            this.labelConnState.TabIndex = 20;
            this.labelConnState.Text = "서버 접속 상태: ???";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(123, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 19);
            this.button3.TabIndex = 21;
            this.button3.Text = "서버와 접속 끊기";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 261);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.labelConnState);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "메인 폼";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBoxLocalHostIP;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxRecvEcho;
        private System.Windows.Forms.Label labelSendEcho;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxSendEcho;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelConnState;
        private System.Windows.Forms.Button button3;
    }
}

