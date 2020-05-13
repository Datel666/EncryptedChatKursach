namespace EncryptedChatKursach
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.portTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.sendMsg = new System.Windows.Forms.Button();
            this.sendTextBox = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.fileNameTextbox = new System.Windows.Forms.TextBox();
            this.chooseFilebtn = new System.Windows.Forms.Button();
            this.sendFilebtn = new System.Windows.Forms.Button();
            this.clearFilesList = new System.Windows.Forms.Button();
            this.filesList = new System.Windows.Forms.ListBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.nickTextbox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.destinationPubKey = new System.Windows.Forms.TextBox();
            this.copyKeyBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.keysgeneratorBtn = new System.Windows.Forms.Button();
            this.rsaRadio = new System.Windows.Forms.RadioButton();
            this.aesRadio = new System.Windows.Forms.RadioButton();
            this.noencryptionRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addressTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.infoTextbox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logTextBox
            // 
            this.logTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.logTextBox.Location = new System.Drawing.Point(20, 83);
            this.logTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.Size = new System.Drawing.Size(743, 296);
            this.logTextBox.TabIndex = 31;
            this.logTextBox.TabStop = false;
            // 
            // portTextbox
            // 
            this.portTextbox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.portTextbox.Location = new System.Drawing.Point(85, 55);
            this.portTextbox.MaxLength = 6;
            this.portTextbox.Name = "portTextbox";
            this.portTextbox.Size = new System.Drawing.Size(132, 29);
            this.portTextbox.TabIndex = 33;
            this.portTextbox.Text = "50201";
            this.portTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Chat log";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1027, 522);
            this.tabControl1.TabIndex = 36;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Controls.Add(this.clearFilesList);
            this.tabPage1.Controls.Add(this.filesList);
            this.tabPage1.Controls.Add(this.connectButton);
            this.tabPage1.Controls.Add(this.nickTextbox);
            this.tabPage1.Controls.Add(this.clearButton);
            this.tabPage1.Controls.Add(this.logTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1019, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main page";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl2.Location = new System.Drawing.Point(20, 386);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(757, 96);
            this.tabControl2.TabIndex = 44;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.sendMsg);
            this.tabPage3.Controls.Add(this.sendTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(749, 69);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Chat";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // sendMsg
            // 
            this.sendMsg.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendMsg.Location = new System.Drawing.Point(564, 39);
            this.sendMsg.Name = "sendMsg";
            this.sendMsg.Size = new System.Drawing.Size(173, 23);
            this.sendMsg.TabIndex = 38;
            this.sendMsg.Text = "Send";
            this.sendMsg.UseVisualStyleBackColor = true;
            this.sendMsg.Click += new System.EventHandler(this.sendMsg_Click);
            // 
            // sendTextBox
            // 
            this.sendTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.sendTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.sendTextBox.Location = new System.Drawing.Point(4, 7);
            this.sendTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sendTextBox.Name = "sendTextBox";
            this.sendTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sendTextBox.Size = new System.Drawing.Size(733, 25);
            this.sendTextBox.TabIndex = 37;
            this.sendTextBox.TabStop = false;
            this.sendTextBox.Click += new System.EventHandler(this.sendTextBox_Click);
            this.sendTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sendTextBox_KeyDown);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.fileNameTextbox);
            this.tabPage4.Controls.Add(this.chooseFilebtn);
            this.tabPage4.Controls.Add(this.sendFilebtn);
            this.tabPage4.Location = new System.Drawing.Point(4, 23);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(749, 69);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "FileManager";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // fileNameTextbox
            // 
            this.fileNameTextbox.Enabled = false;
            this.fileNameTextbox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileNameTextbox.Location = new System.Drawing.Point(6, 38);
            this.fileNameTextbox.Name = "fileNameTextbox";
            this.fileNameTextbox.Size = new System.Drawing.Size(605, 25);
            this.fileNameTextbox.TabIndex = 42;
            // 
            // chooseFilebtn
            // 
            this.chooseFilebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chooseFilebtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseFilebtn.Location = new System.Drawing.Point(6, 6);
            this.chooseFilebtn.Name = "chooseFilebtn";
            this.chooseFilebtn.Size = new System.Drawing.Size(105, 29);
            this.chooseFilebtn.TabIndex = 41;
            this.chooseFilebtn.Text = "Choose file";
            this.chooseFilebtn.UseVisualStyleBackColor = true;
            this.chooseFilebtn.Click += new System.EventHandler(this.chooseFilebtn_Click);
            // 
            // sendFilebtn
            // 
            this.sendFilebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sendFilebtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendFilebtn.Location = new System.Drawing.Point(634, 34);
            this.sendFilebtn.Name = "sendFilebtn";
            this.sendFilebtn.Size = new System.Drawing.Size(105, 29);
            this.sendFilebtn.TabIndex = 40;
            this.sendFilebtn.Text = "Send file";
            this.sendFilebtn.UseVisualStyleBackColor = true;
            this.sendFilebtn.Click += new System.EventHandler(this.sendFile_Click);
            // 
            // clearFilesList
            // 
            this.clearFilesList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearFilesList.Location = new System.Drawing.Point(806, 386);
            this.clearFilesList.Margin = new System.Windows.Forms.Padding(4);
            this.clearFilesList.Name = "clearFilesList";
            this.clearFilesList.Size = new System.Drawing.Size(192, 26);
            this.clearFilesList.TabIndex = 43;
            this.clearFilesList.TabStop = false;
            this.clearFilesList.Text = "Clear";
            this.clearFilesList.UseVisualStyleBackColor = true;
            this.clearFilesList.Click += new System.EventHandler(this.clearFilesList_Click);
            // 
            // filesList
            // 
            this.filesList.FormattingEnabled = true;
            this.filesList.ItemHeight = 21;
            this.filesList.Location = new System.Drawing.Point(806, 60);
            this.filesList.Name = "filesList";
            this.filesList.Size = new System.Drawing.Size(192, 319);
            this.filesList.TabIndex = 42;
            this.filesList.SelectedValueChanged += new System.EventHandler(this.filesList_SelectedValueChanged);
            this.filesList.DoubleClick += new System.EventHandler(this.filesList_DoubleClick);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(20, 13);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(113, 26);
            this.connectButton.TabIndex = 41;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // nickTextbox
            // 
            this.nickTextbox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nickTextbox.Location = new System.Drawing.Point(193, 14);
            this.nickTextbox.Name = "nickTextbox";
            this.nickTextbox.Size = new System.Drawing.Size(134, 26);
            this.nickTextbox.TabIndex = 40;
            this.nickTextbox.Text = "Nickname";
            this.nickTextbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nickTextbox_MouseClick);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(650, 53);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(113, 26);
            this.clearButton.TabIndex = 39;
            this.clearButton.TabStop = false;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1019, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.rsaRadio);
            this.groupBox2.Controls.Add(this.aesRadio);
            this.groupBox2.Controls.Add(this.noencryptionRadio);
            this.groupBox2.Location = new System.Drawing.Point(6, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(572, 321);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Safety";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.infoTextbox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.destinationPubKey);
            this.groupBox3.Controls.Add(this.copyKeyBtn);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.passwordTextbox);
            this.groupBox3.Controls.Add(this.keysgeneratorBtn);
            this.groupBox3.Location = new System.Drawing.Point(6, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(537, 185);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Encryption keys management";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 21);
            this.label5.TabIndex = 36;
            this.label5.Text = "Set destination pubkey";
            // 
            // destinationPubKey
            // 
            this.destinationPubKey.Location = new System.Drawing.Point(6, 128);
            this.destinationPubKey.MaxLength = 0;
            this.destinationPubKey.Name = "destinationPubKey";
            this.destinationPubKey.Size = new System.Drawing.Size(333, 29);
            this.destinationPubKey.TabIndex = 7;
            // 
            // copyKeyBtn
            // 
            this.copyKeyBtn.Enabled = false;
            this.copyKeyBtn.Location = new System.Drawing.Point(4, 66);
            this.copyKeyBtn.Name = "copyKeyBtn";
            this.copyKeyBtn.Size = new System.Drawing.Size(278, 32);
            this.copyKeyBtn.TabIndex = 6;
            this.copyKeyBtn.Text = "Copy your public key to clipboard";
            this.copyKeyBtn.UseVisualStyleBackColor = true;
            this.copyKeyBtn.Visible = false;
            this.copyKeyBtn.Click += new System.EventHandler(this.copyKeyBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enter AES encryption pass";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(6, 59);
            this.passwordTextbox.MaxLength = 0;
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(211, 29);
            this.passwordTextbox.TabIndex = 3;
            this.passwordTextbox.Text = "pepe";
            // 
            // keysgeneratorBtn
            // 
            this.keysgeneratorBtn.Enabled = false;
            this.keysgeneratorBtn.Location = new System.Drawing.Point(4, 31);
            this.keysgeneratorBtn.Name = "keysgeneratorBtn";
            this.keysgeneratorBtn.Size = new System.Drawing.Size(175, 29);
            this.keysgeneratorBtn.TabIndex = 5;
            this.keysgeneratorBtn.Text = "Generate RSA keys";
            this.keysgeneratorBtn.UseVisualStyleBackColor = true;
            this.keysgeneratorBtn.Visible = false;
            this.keysgeneratorBtn.Click += new System.EventHandler(this.keysgeneratorBtn_Click);
            // 
            // rsaRadio
            // 
            this.rsaRadio.AutoSize = true;
            this.rsaRadio.Location = new System.Drawing.Point(10, 99);
            this.rsaRadio.Name = "rsaRadio";
            this.rsaRadio.Size = new System.Drawing.Size(148, 25);
            this.rsaRadio.TabIndex = 2;
            this.rsaRadio.TabStop = true;
            this.rsaRadio.Text = "RSA encryption";
            this.rsaRadio.UseVisualStyleBackColor = true;
            this.rsaRadio.CheckedChanged += new System.EventHandler(this.rsaRadio_CheckedChanged);
            // 
            // aesRadio
            // 
            this.aesRadio.AutoSize = true;
            this.aesRadio.Checked = true;
            this.aesRadio.Location = new System.Drawing.Point(10, 68);
            this.aesRadio.Name = "aesRadio";
            this.aesRadio.Size = new System.Drawing.Size(147, 25);
            this.aesRadio.TabIndex = 1;
            this.aesRadio.TabStop = true;
            this.aesRadio.Text = "AES encryption";
            this.aesRadio.UseVisualStyleBackColor = true;
            this.aesRadio.CheckedChanged += new System.EventHandler(this.aesRadio_CheckedChanged);
            // 
            // noencryptionRadio
            // 
            this.noencryptionRadio.AutoSize = true;
            this.noencryptionRadio.Location = new System.Drawing.Point(10, 37);
            this.noencryptionRadio.Name = "noencryptionRadio";
            this.noencryptionRadio.Size = new System.Drawing.Size(135, 25);
            this.noencryptionRadio.TabIndex = 0;
            this.noencryptionRadio.TabStop = true;
            this.noencryptionRadio.Text = "No encryption";
            this.noencryptionRadio.UseVisualStyleBackColor = true;
            this.noencryptionRadio.CheckedChanged += new System.EventHandler(this.noencryptionRadio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addressTextbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.portTextbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 93);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Socket address";
            // 
            // addressTextbox
            // 
            this.addressTextbox.Location = new System.Drawing.Point(85, 25);
            this.addressTextbox.MaxLength = 16;
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Size = new System.Drawing.Size(132, 29);
            this.addressTextbox.TabIndex = 36;
            this.addressTextbox.Text = "127.000.000.001";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Address";
            // 
            // infoTextbox
            // 
            this.infoTextbox.Enabled = false;
            this.infoTextbox.Location = new System.Drawing.Point(284, 32);
            this.infoTextbox.Name = "infoTextbox";
            this.infoTextbox.Size = new System.Drawing.Size(247, 29);
            this.infoTextbox.TabIndex = 37;
            this.infoTextbox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 540);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.TextBox portTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox sendTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox addressTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sendFilebtn;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox nickTextbox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.RadioButton rsaRadio;
        private System.Windows.Forms.RadioButton aesRadio;
        private System.Windows.Forms.RadioButton noencryptionRadio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Button clearFilesList;
        private System.Windows.Forms.ListBox filesList;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button sendMsg;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox fileNameTextbox;
        private System.Windows.Forms.Button chooseFilebtn;
        private System.Windows.Forms.Button copyKeyBtn;
        private System.Windows.Forms.Button keysgeneratorBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TextBox destinationPubKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox infoTextbox;
    }
}

