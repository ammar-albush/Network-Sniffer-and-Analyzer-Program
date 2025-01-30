namespace NetworkScannerAndSniffer
{
    partial class NetworkScanner
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetworkScanner));
            groupBox5 = new GroupBox();
            label14 = new Label();
            auto_timeout_btn = new Button();
            panel3 = new Panel();
            devices_listView = new ListView();
            imageList2 = new ImageList(components);
            found_ip_treeView = new TreeView();
            imageList1 = new ImageList(components);
            label6 = new Label();
            Start_button = new Button();
            label4 = new Label();
            timeout_numericUpDown = new NumericUpDown();
            groupBox4 = new GroupBox();
            progressBar = new ProgressBar();
            log_textBox = new TextBox();
            groupBox1 = new GroupBox();
            Broadcast_tb = new TextBox();
            label1 = new Label();
            label13 = new Label();
            ip_class_textBox = new TextBox();
            recommend = new Label();
            start_ip_textBox = new TextBox();
            label9 = new Label();
            end_ip_textBox = new TextBox();
            label10 = new Label();
            label11 = new Label();
            net_id_textBox = new TextBox();
            label8 = new Label();
            net_id_count_textBox = new TextBox();
            label7 = new Label();
            max_host_textBox = new TextBox();
            mask_bits_trackBar = new TrackBar();
            mask_bits_richTextBox = new RichTextBox();
            label3 = new Label();
            label5 = new Label();
            mask_textBox = new TextBox();
            Ip_comboBox = new ComboBox();
            label2 = new Label();
            Ip_textBox = new TextBox();
            choose_ip_radioButton = new RadioButton();
            Enter_ip_radioButton = new RadioButton();
            label12 = new Label();
            ping_devices_bgw = new System.ComponentModel.BackgroundWorker();
            groupBox5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)timeout_numericUpDown).BeginInit();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mask_bits_trackBar).BeginInit();
            SuspendLayout();
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label14);
            groupBox5.Controls.Add(auto_timeout_btn);
            groupBox5.Controls.Add(panel3);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(Start_button);
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(timeout_numericUpDown);
            groupBox5.Location = new Point(19, 486);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(807, 224);
            groupBox5.TabIndex = 20;
            groupBox5.TabStop = false;
            groupBox5.Text = "Process";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(580, 99);
            label14.Name = "label14";
            label14.Size = new Size(103, 20);
            label14.TabIndex = 19;
            label14.Text = "Auto Timeout:";
            // 
            // auto_timeout_btn
            // 
            auto_timeout_btn.FlatAppearance.BorderSize = 0;
            auto_timeout_btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            auto_timeout_btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            auto_timeout_btn.FlatStyle = FlatStyle.Flat;
            auto_timeout_btn.Image = Properties.Resources.icons8_schalter_an_40;
            auto_timeout_btn.Location = new Point(689, 93);
            auto_timeout_btn.Name = "auto_timeout_btn";
            auto_timeout_btn.Size = new Size(88, 34);
            auto_timeout_btn.TabIndex = 18;
            auto_timeout_btn.Tag = true;
            auto_timeout_btn.UseVisualStyleBackColor = true;
            auto_timeout_btn.Click += auto_timeout_btn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(devices_listView);
            panel3.Controls.Add(found_ip_treeView);
            panel3.Location = new Point(28, 42);
            panel3.Name = "panel3";
            panel3.Size = new Size(546, 163);
            panel3.TabIndex = 17;
            // 
            // devices_listView
            // 
            devices_listView.BorderStyle = BorderStyle.None;
            devices_listView.LargeImageList = imageList2;
            devices_listView.Location = new Point(329, 20);
            devices_listView.Name = "devices_listView";
            devices_listView.Size = new Size(203, 125);
            devices_listView.TabIndex = 2;
            devices_listView.UseCompatibleStateImageBehavior = false;
            devices_listView.MouseDoubleClick += devices_listView_MouseDoubleClick;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth8Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "icons8-wired-netzwerkverbindung-50.png");
            imageList2.Images.SetKeyName(1, "icons8-wired-netzwerkverbindung-50(1).png");
            // 
            // found_ip_treeView
            // 
            found_ip_treeView.BorderStyle = BorderStyle.None;
            found_ip_treeView.ImageIndex = 0;
            found_ip_treeView.ImageList = imageList1;
            found_ip_treeView.Location = new Point(14, 20);
            found_ip_treeView.Name = "found_ip_treeView";
            found_ip_treeView.SelectedImageIndex = 0;
            found_ip_treeView.Size = new Size(296, 125);
            found_ip_treeView.TabIndex = 0;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth16Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-wired-netzwerkverbindung-50.png");
            imageList1.Images.SetKeyName(1, "icons8-mein-computer-50.png");
            imageList1.Images.SetKeyName(2, "icons8-mac-desktop-50.png");
            imageList1.Images.SetKeyName(3, "icons8-ipv6-50.png");
            imageList1.Images.SetKeyName(4, "icons8-hostname-50.png");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(28, 19);
            label6.Name = "label6";
            label6.Size = new Size(112, 20);
            label6.TabIndex = 16;
            label6.Text = "Found Devices :";
            // 
            // Start_button
            // 
            Start_button.BackColor = Color.LightGreen;
            Start_button.FlatAppearance.BorderSize = 0;
            Start_button.Location = new Point(657, 161);
            Start_button.Name = "Start_button";
            Start_button.Size = new Size(129, 44);
            Start_button.TabIndex = 15;
            Start_button.Text = "Start";
            Start_button.UseVisualStyleBackColor = false;
            Start_button.Click += Start_button_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(580, 42);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 14;
            label4.Text = "Timeout :";
            // 
            // timeout_numericUpDown
            // 
            timeout_numericUpDown.Enabled = false;
            timeout_numericUpDown.Increment = new decimal(new int[] { 500, 0, 0, 0 });
            timeout_numericUpDown.Location = new Point(657, 42);
            timeout_numericUpDown.Maximum = new decimal(new int[] { 30000, 0, 0, 0 });
            timeout_numericUpDown.Minimum = new decimal(new int[] { 10000, 0, 0, 0 });
            timeout_numericUpDown.Name = "timeout_numericUpDown";
            timeout_numericUpDown.Size = new Size(120, 23);
            timeout_numericUpDown.TabIndex = 0;
            timeout_numericUpDown.Value = new decimal(new int[] { 15000, 0, 0, 0 });
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(progressBar);
            groupBox4.Controls.Add(log_textBox);
            groupBox4.Location = new Point(19, 727);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(807, 211);
            groupBox4.TabIndex = 21;
            groupBox4.TabStop = false;
            groupBox4.Text = "Log";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(28, 31);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(742, 41);
            progressBar.TabIndex = 1;
            // 
            // log_textBox
            // 
            log_textBox.Location = new Point(28, 79);
            log_textBox.Multiline = true;
            log_textBox.Name = "log_textBox";
            log_textBox.ScrollBars = ScrollBars.Both;
            log_textBox.Size = new Size(742, 122);
            log_textBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Broadcast_tb);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(ip_class_textBox);
            groupBox1.Controls.Add(recommend);
            groupBox1.Controls.Add(start_ip_textBox);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(end_ip_textBox);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(net_id_textBox);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(net_id_count_textBox);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(max_host_textBox);
            groupBox1.Controls.Add(mask_bits_trackBar);
            groupBox1.Controls.Add(mask_bits_richTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(mask_textBox);
            groupBox1.Controls.Add(Ip_comboBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Ip_textBox);
            groupBox1.Controls.Add(choose_ip_radioButton);
            groupBox1.Controls.Add(Enter_ip_radioButton);
            groupBox1.Controls.Add(label12);
            groupBox1.Location = new Point(19, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(807, 468);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Net ID :";
            // 
            // Broadcast_tb
            // 
            Broadcast_tb.BorderStyle = BorderStyle.FixedSingle;
            Broadcast_tb.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Broadcast_tb.Location = new Point(538, 363);
            Broadcast_tb.Name = "Broadcast_tb";
            Broadcast_tb.ReadOnly = true;
            Broadcast_tb.Size = new Size(232, 27);
            Broadcast_tb.TabIndex = 42;
            Broadcast_tb.Text = "0.0.0.0";
            Broadcast_tb.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(400, 362);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 41;
            label1.Text = "Braodcast  :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(14, 363);
            label13.Name = "label13";
            label13.Size = new Size(68, 20);
            label13.TabIndex = 39;
            label13.Text = "IP CLass :";
            // 
            // ip_class_textBox
            // 
            ip_class_textBox.BorderStyle = BorderStyle.FixedSingle;
            ip_class_textBox.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ip_class_textBox.Location = new Point(152, 362);
            ip_class_textBox.Name = "ip_class_textBox";
            ip_class_textBox.ReadOnly = true;
            ip_class_textBox.Size = new Size(232, 27);
            ip_class_textBox.TabIndex = 38;
            ip_class_textBox.TextAlign = HorizontalAlignment.Center;
            // 
            // recommend
            // 
            recommend.AutoSize = true;
            recommend.BackColor = Color.White;
            recommend.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            recommend.ForeColor = Color.White;
            recommend.Location = new Point(400, 429);
            recommend.Name = "recommend";
            recommend.Size = new Size(0, 20);
            recommend.TabIndex = 37;
            // 
            // start_ip_textBox
            // 
            start_ip_textBox.BorderStyle = BorderStyle.FixedSingle;
            start_ip_textBox.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            start_ip_textBox.Location = new Point(538, 268);
            start_ip_textBox.Name = "start_ip_textBox";
            start_ip_textBox.ReadOnly = true;
            start_ip_textBox.Size = new Size(232, 27);
            start_ip_textBox.TabIndex = 36;
            start_ip_textBox.Text = "0.0.0.0";
            start_ip_textBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(400, 318);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 35;
            label9.Text = "Last IP : ";
            // 
            // end_ip_textBox
            // 
            end_ip_textBox.BorderStyle = BorderStyle.FixedSingle;
            end_ip_textBox.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            end_ip_textBox.Location = new Point(538, 317);
            end_ip_textBox.Name = "end_ip_textBox";
            end_ip_textBox.ReadOnly = true;
            end_ip_textBox.Size = new Size(232, 27);
            end_ip_textBox.TabIndex = 34;
            end_ip_textBox.Text = "0.0.0.0";
            end_ip_textBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(400, 268);
            label10.Name = "label10";
            label10.Size = new Size(63, 20);
            label10.TabIndex = 33;
            label10.Text = "First IP  :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(400, 222);
            label11.Name = "label11";
            label11.Size = new Size(59, 20);
            label11.TabIndex = 31;
            label11.Text = "Net ID :";
            // 
            // net_id_textBox
            // 
            net_id_textBox.BorderStyle = BorderStyle.FixedSingle;
            net_id_textBox.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            net_id_textBox.Location = new Point(538, 222);
            net_id_textBox.Name = "net_id_textBox";
            net_id_textBox.ReadOnly = true;
            net_id_textBox.Size = new Size(232, 27);
            net_id_textBox.TabIndex = 30;
            net_id_textBox.Text = "0.0.0.0";
            net_id_textBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(14, 315);
            label8.Name = "label8";
            label8.Size = new Size(106, 20);
            label8.TabIndex = 29;
            label8.Text = "Max ID Count :";
            // 
            // net_id_count_textBox
            // 
            net_id_count_textBox.BorderStyle = BorderStyle.FixedSingle;
            net_id_count_textBox.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            net_id_count_textBox.Location = new Point(152, 314);
            net_id_count_textBox.Name = "net_id_count_textBox";
            net_id_count_textBox.ReadOnly = true;
            net_id_count_textBox.Size = new Size(232, 27);
            net_id_count_textBox.TabIndex = 28;
            net_id_count_textBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(14, 265);
            label7.Name = "label7";
            label7.Size = new Size(132, 20);
            label7.TabIndex = 27;
            label7.Text = "Max Hosts Count  :";
            // 
            // max_host_textBox
            // 
            max_host_textBox.BorderStyle = BorderStyle.FixedSingle;
            max_host_textBox.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            max_host_textBox.Location = new Point(152, 264);
            max_host_textBox.Name = "max_host_textBox";
            max_host_textBox.ReadOnly = true;
            max_host_textBox.Size = new Size(232, 27);
            max_host_textBox.TabIndex = 26;
            max_host_textBox.TextAlign = HorizontalAlignment.Center;
            // 
            // mask_bits_trackBar
            // 
            mask_bits_trackBar.Enabled = false;
            mask_bits_trackBar.LargeChange = 1;
            mask_bits_trackBar.Location = new Point(12, 174);
            mask_bits_trackBar.Maximum = 32;
            mask_bits_trackBar.Name = "mask_bits_trackBar";
            mask_bits_trackBar.Size = new Size(636, 45);
            mask_bits_trackBar.TabIndex = 21;
            mask_bits_trackBar.TickStyle = TickStyle.TopLeft;
            mask_bits_trackBar.Scroll += mask_bits_trackBar_Scroll;
            // 
            // mask_bits_richTextBox
            // 
            mask_bits_richTextBox.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            mask_bits_richTextBox.Location = new Point(33, 118);
            mask_bits_richTextBox.Name = "mask_bits_richTextBox";
            mask_bits_richTextBox.ReadOnly = true;
            mask_bits_richTextBox.Size = new Size(615, 50);
            mask_bits_richTextBox.TabIndex = 20;
            mask_bits_richTextBox.Text = "00000000000000000000000000000000";
            mask_bits_richTextBox.TextChanged += mask_bits_richTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 219);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 24;
            label3.Text = "Subnet Mask  :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(664, 174);
            label5.Name = "label5";
            label5.Size = new Size(43, 31);
            label5.TabIndex = 22;
            label5.Text = "/ 0";
            // 
            // mask_textBox
            // 
            mask_textBox.BorderStyle = BorderStyle.FixedSingle;
            mask_textBox.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            mask_textBox.Location = new Point(152, 219);
            mask_textBox.Name = "mask_textBox";
            mask_textBox.ReadOnly = true;
            mask_textBox.Size = new Size(232, 27);
            mask_textBox.TabIndex = 23;
            mask_textBox.Text = "0.0.0.0";
            mask_textBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Ip_comboBox
            // 
            Ip_comboBox.Enabled = false;
            Ip_comboBox.FormattingEnabled = true;
            Ip_comboBox.Location = new Point(214, 63);
            Ip_comboBox.Name = "Ip_comboBox";
            Ip_comboBox.Size = new Size(232, 23);
            Ip_comboBox.TabIndex = 5;
            Ip_comboBox.SelectedIndexChanged += Ip_comboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(140, 31);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 0;
            label2.Text = "IP  :";
            // 
            // Ip_textBox
            // 
            Ip_textBox.BorderStyle = BorderStyle.FixedSingle;
            Ip_textBox.Location = new Point(214, 31);
            Ip_textBox.Name = "Ip_textBox";
            Ip_textBox.Size = new Size(232, 23);
            Ip_textBox.TabIndex = 1;
            Ip_textBox.TextChanged += Ip_textBox_TextChanged;
            // 
            // choose_ip_radioButton
            // 
            choose_ip_radioButton.AutoSize = true;
            choose_ip_radioButton.Location = new Point(12, 65);
            choose_ip_radioButton.Name = "choose_ip_radioButton";
            choose_ip_radioButton.Size = new Size(78, 19);
            choose_ip_radioButton.TabIndex = 2;
            choose_ip_radioButton.TabStop = true;
            choose_ip_radioButton.Text = "Choose IP";
            choose_ip_radioButton.UseVisualStyleBackColor = true;
            // 
            // Enter_ip_radioButton
            // 
            Enter_ip_radioButton.AutoSize = true;
            Enter_ip_radioButton.Checked = true;
            Enter_ip_radioButton.Location = new Point(12, 31);
            Enter_ip_radioButton.Name = "Enter_ip_radioButton";
            Enter_ip_radioButton.Size = new Size(65, 19);
            Enter_ip_radioButton.TabIndex = 3;
            Enter_ip_radioButton.TabStop = true;
            Enter_ip_radioButton.Text = "Enter IP";
            Enter_ip_radioButton.UseVisualStyleBackColor = true;
            Enter_ip_radioButton.CheckedChanged += Enter_ip_radioButton_CheckedChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(140, 63);
            label12.Name = "label12";
            label12.Size = new Size(28, 20);
            label12.TabIndex = 4;
            label12.Text = "IP :";
            // 
            // ping_devices_bgw
            // 
            ping_devices_bgw.DoWork += ping_devices_bgw_DoWork;
            // 
            // NetworkScanner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 950);
            Controls.Add(groupBox1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NetworkScanner";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Network Scanner";
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)timeout_numericUpDown).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mask_bits_trackBar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox5;
        private Panel panel3;
        private TreeView found_ip_treeView;
        private Label label6;
        private Button Start_button;
        private Label label4;
        private NumericUpDown timeout_numericUpDown;
        private GroupBox groupBox4;
        private ProgressBar progressBar;
        private TextBox log_textBox;
        private GroupBox groupBox1;
        private TextBox Broadcast_tb;
        private Label label1;
        private Label label13;
        private TextBox ip_class_textBox;
        private Label recommend;
        private TextBox start_ip_textBox;
        private Label label9;
        private TextBox end_ip_textBox;
        private Label label10;
        private Label label11;
        private TextBox net_id_textBox;
        private Label label8;
        private TextBox net_id_count_textBox;
        private Label label7;
        private TextBox max_host_textBox;
        private TrackBar mask_bits_trackBar;
        private RichTextBox mask_bits_richTextBox;
        private Label label3;
        private Label label5;
        private TextBox mask_textBox;
        private ComboBox Ip_comboBox;
        private Label label2;
        private TextBox Ip_textBox;
        private RadioButton choose_ip_radioButton;
        private RadioButton Enter_ip_radioButton;
        private Label label12;
        private ImageList imageList1;
        private System.ComponentModel.BackgroundWorker ping_devices_bgw;
        private Label label14;
        private Button auto_timeout_btn;
        private ListView devices_listView;
        private ImageList imageList2;
    }
}