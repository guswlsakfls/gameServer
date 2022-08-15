namespace client_tcp
{
    partial class mainForm
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
            this.btn_close = new System.Windows.Forms.Button();
            this.서버 = new System.Windows.Forms.GroupBox();
            this.local_host_checkBox = new System.Windows.Forms.CheckBox();
            this.portNum = new System.Windows.Forms.TextBox();
            this.label_portNum = new System.Windows.Forms.Label();
            this.ipNum = new System.Windows.Forms.TextBox();
            this.label_ipNum = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.box_textEcho = new System.Windows.Forms.TextBox();
            this.btn_echo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.box_pw = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.box_id = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.netStatus = new System.Windows.Forms.Label();
            this.box_log = new System.Windows.Forms.ListBox();
            this.btn_removeLog = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.GroupBox();
            this.서버.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Log.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Enabled = false;
            this.btn_close.Location = new System.Drawing.Point(379, 53);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(114, 22);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "접속끊기";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_click);
            // 
            // 서버
            // 
            this.서버.Controls.Add(this.local_host_checkBox);
            this.서버.Controls.Add(this.portNum);
            this.서버.Controls.Add(this.label_portNum);
            this.서버.Controls.Add(this.ipNum);
            this.서버.Controls.Add(this.label_ipNum);
            this.서버.Location = new System.Drawing.Point(12, 12);
            this.서버.Name = "서버";
            this.서버.Size = new System.Drawing.Size(361, 70);
            this.서버.TabIndex = 1;
            this.서버.TabStop = false;
            this.서버.Text = "Select 더미 클라이언트 설정";
            this.서버.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // local_host_checkBox
            // 
            this.local_host_checkBox.AutoSize = true;
            this.local_host_checkBox.Checked = true;
            this.local_host_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.local_host_checkBox.Location = new System.Drawing.Point(269, 44);
            this.local_host_checkBox.Name = "local_host_checkBox";
            this.local_host_checkBox.Size = new System.Drawing.Size(81, 16);
            this.local_host_checkBox.TabIndex = 5;
            this.local_host_checkBox.Text = "local_host";
            this.local_host_checkBox.UseVisualStyleBackColor = true;
            this.local_host_checkBox.CheckedChanged += new System.EventHandler(this.local_host_checkBox_CheckedChanged);
            // 
            // portNum
            // 
            this.portNum.Location = new System.Drawing.Point(163, 41);
            this.portNum.Name = "portNum";
            this.portNum.Size = new System.Drawing.Size(81, 21);
            this.portNum.TabIndex = 4;
            this.portNum.Text = "11021";
            this.portNum.TextChanged += new System.EventHandler(this.portNum_TextChanged);
            // 
            // label_portNum
            // 
            this.label_portNum.AutoSize = true;
            this.label_portNum.Location = new System.Drawing.Point(161, 26);
            this.label_portNum.Name = "label_portNum";
            this.label_portNum.Size = new System.Drawing.Size(57, 12);
            this.label_portNum.TabIndex = 3;
            this.label_portNum.Text = "포트 번호";
            this.label_portNum.Click += new System.EventHandler(this.label_port);
            // 
            // ipNum
            // 
            this.ipNum.Location = new System.Drawing.Point(37, 41);
            this.ipNum.Name = "ipNum";
            this.ipNum.Size = new System.Drawing.Size(81, 21);
            this.ipNum.TabIndex = 2;
            this.ipNum.Text = "0.0.0.0";
            this.ipNum.TextChanged += new System.EventHandler(this.textBox_echo);
            // 
            // label_ipNum
            // 
            this.label_ipNum.AutoSize = true;
            this.label_ipNum.Location = new System.Drawing.Point(35, 26);
            this.label_ipNum.Name = "label_ipNum";
            this.label_ipNum.Size = new System.Drawing.Size(57, 12);
            this.label_ipNum.TabIndex = 0;
            this.label_ipNum.Text = "서버 주소";
            this.label_ipNum.Click += new System.EventHandler(this.label_ip);
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(379, 27);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(114, 23);
            this.btn_connect.TabIndex = 1;
            this.btn_connect.Text = "접속하기";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_click);
            // 
            // box_textEcho
            // 
            this.box_textEcho.Location = new System.Drawing.Point(12, 101);
            this.box_textEcho.Name = "box_textEcho";
            this.box_textEcho.Size = new System.Drawing.Size(361, 21);
            this.box_textEcho.TabIndex = 6;
            this.box_textEcho.TextChanged += new System.EventHandler(this.box_text);
            this.box_textEcho.Enter += new System.EventHandler(this.sendEcho_Click);
            // 
            // btn_echo
            // 
            this.btn_echo.Location = new System.Drawing.Point(379, 101);
            this.btn_echo.Name = "btn_echo";
            this.btn_echo.Size = new System.Drawing.Size(114, 21);
            this.btn_echo.TabIndex = 7;
            this.btn_echo.Text = "echo 보내기";
            this.btn_echo.UseVisualStyleBackColor = true;
            this.btn_echo.Click += new System.EventHandler(this.sendEcho_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_login);
            this.groupBox1.Controls.Add(this.box_pw);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.box_id);
            this.groupBox1.Location = new System.Drawing.Point(12, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 137);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(37, 91);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(122, 30);
            this.btn_login.TabIndex = 9;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // box_pw
            // 
            this.box_pw.Location = new System.Drawing.Point(79, 53);
            this.box_pw.Name = "box_pw";
            this.box_pw.Size = new System.Drawing.Size(100, 21);
            this.box_pw.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "PassWD:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "UserID:";
            this.label3.Click += new System.EventHandler(this.sendEcho_Click);
            // 
            // box_id
            // 
            this.box_id.Location = new System.Drawing.Point(79, 26);
            this.box_id.Name = "box_id";
            this.box_id.Size = new System.Drawing.Size(100, 21);
            this.box_id.TabIndex = 6;
            this.box_id.TextChanged += new System.EventHandler(this.box_id_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox4);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(212, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 137);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lobby";
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 12;
            this.listBox4.Location = new System.Drawing.Point(8, 20);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(175, 100);
            this.listBox4.TabIndex = 26;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(189, 92);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(81, 30);
            this.button6.TabIndex = 12;
            this.button6.Text = "Leave";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(189, 56);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 30);
            this.button5.TabIndex = 11;
            this.button5.Text = "Enter";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(189, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 30);
            this.button4.TabIndex = 10;
            this.button4.Text = "List 요청";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox3);
            this.groupBox3.Controls.Add(this.listBox2);
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 308);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(481, 262);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Room";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 12;
            this.listBox3.Location = new System.Drawing.Point(152, 78);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(314, 124);
            this.listBox3.TabIndex = 25;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(8, 78);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(138, 124);
            this.listBox2.TabIndex = 24;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(406, 212);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(60, 30);
            this.button10.TabIndex = 20;
            this.button10.Text = "Chat";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(6, 218);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(394, 21);
            this.textBox8.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "User List:";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(406, 14);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 30);
            this.button9.TabIndex = 16;
            this.button9.Text = "Relay";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(285, 20);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(115, 21);
            this.textBox7.TabIndex = 15;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(208, 14);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 30);
            this.button8.TabIndex = 14;
            this.button8.Text = "Leave";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(142, 14);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 30);
            this.button7.TabIndex = 13;
            this.button7.Text = "Enter";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(103, 20);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(33, 21);
            this.textBox6.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "Room Number:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // netStatus
            // 
            this.netStatus.AutoSize = true;
            this.netStatus.Location = new System.Drawing.Point(10, 775);
            this.netStatus.Name = "netStatus";
            this.netStatus.Size = new System.Drawing.Size(123, 12);
            this.netStatus.TabIndex = 21;
            this.netStatus.Text = "[서버 접속 상태]  ???";
            this.netStatus.Click += new System.EventHandler(this.label7_Click);
            // 
            // box_log
            // 
            this.box_log.FormattingEnabled = true;
            this.box_log.ItemHeight = 12;
            this.box_log.Location = new System.Drawing.Point(6, 20);
            this.box_log.Name = "box_log";
            this.box_log.Size = new System.Drawing.Size(408, 148);
            this.box_log.TabIndex = 23;
            this.box_log.SelectedIndexChanged += new System.EventHandler(this.lbox_name_SelectedIndexChanged);
            // 
            // btn_removeLog
            // 
            this.btn_removeLog.Enabled = false;
            this.btn_removeLog.Location = new System.Drawing.Point(420, 69);
            this.btn_removeLog.Name = "btn_removeLog";
            this.btn_removeLog.Size = new System.Drawing.Size(61, 51);
            this.btn_removeLog.TabIndex = 26;
            this.btn_removeLog.Text = "기록\r\n삭제하기";
            this.btn_removeLog.UseVisualStyleBackColor = true;
            this.btn_removeLog.Click += new System.EventHandler(this.btn_removeLog_Click);
            // 
            // Log
            // 
            this.Log.Controls.Add(this.box_log);
            this.Log.Controls.Add(this.btn_removeLog);
            this.Log.Location = new System.Drawing.Point(12, 581);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(481, 177);
            this.Log.TabIndex = 27;
            this.Log.TabStop = false;
            this.Log.Text = "Log";
            this.Log.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 810);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.netStatus);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_echo);
            this.Controls.Add(this.box_textEcho);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.서버);
            this.Controls.Add(this.btn_close);
            this.Name = "mainForm";
            this.Text = "chatClient";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.서버.ResumeLayout(false);
            this.서버.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Log.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.GroupBox 서버;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox ipNum;
        private System.Windows.Forms.Label label_ipNum;
        private System.Windows.Forms.CheckBox local_host_checkBox;
        private System.Windows.Forms.TextBox portNum;
        private System.Windows.Forms.Label label_portNum;
        private System.Windows.Forms.TextBox box_textEcho;
        private System.Windows.Forms.Button btn_echo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox box_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox box_pw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label netStatus;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox box_log;
        private System.Windows.Forms.Button btn_removeLog;
        private System.Windows.Forms.GroupBox Log;
    }
}

