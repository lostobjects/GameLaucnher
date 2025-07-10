namespace GameLauncher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listBox1 = new ListBox();
            lblGameName = new Label();
            btnPlay = new Button();
            lblGameVer = new Label();
            label2 = new Label();
            label3 = new Label();
            lblLastPlay = new Label();
            lblPlayTime = new Label();
            label6 = new Label();
            panel1 = new Panel();
            txt = new Label();
            label7 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(45, 45, 48);
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.Cursor = Cursors.Hand;
            listBox1.ForeColor = Color.Gainsboro;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(699, 46);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(182, 502);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // lblGameName
            // 
            lblGameName.AutoSize = true;
            lblGameName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblGameName.ForeColor = Color.Gainsboro;
            lblGameName.Location = new Point(3, 0);
            lblGameName.Name = "lblGameName";
            lblGameName.Size = new Size(239, 41);
            lblGameName.TabIndex = 1;
            lblGameName.Text = "Название игры";
            lblGameName.Click += lblGameName_Click;
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.SeaGreen;
            btnPlay.FlatAppearance.BorderSize = 0;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.Font = new Font("Cascadia Code", 12F, FontStyle.Bold);
            btnPlay.ForeColor = Color.White;
            btnPlay.Location = new Point(12, 104);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(234, 63);
            btnPlay.TabIndex = 2;
            btnPlay.Text = "Играть";
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += btnPlay_Click;
            // 
            // lblGameVer
            // 
            lblGameVer.AutoSize = true;
            lblGameVer.Font = new Font("Cascadia Code", 10.8F, FontStyle.Italic);
            lblGameVer.ForeColor = Color.Gainsboro;
            lblGameVer.Location = new Point(9, 140);
            lblGameVer.Name = "lblGameVer";
            lblGameVer.Size = new Size(32, 24);
            lblGameVer.TabIndex = 3;
            lblGameVer.Text = "0v";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(9, 15);
            label2.Name = "label2";
            label2.Size = new Size(204, 27);
            label2.TabIndex = 4;
            label2.Text = "Последний запуск";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(301, 15);
            label3.Name = "label3";
            label3.Size = new Size(120, 27);
            label3.TabIndex = 5;
            label3.Text = "Вы играли";
            // 
            // lblLastPlay
            // 
            lblLastPlay.AutoSize = true;
            lblLastPlay.Font = new Font("Cascadia Code", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblLastPlay.ForeColor = Color.Gainsboro;
            lblLastPlay.Location = new Point(9, 54);
            lblLastPlay.Name = "lblLastPlay";
            lblLastPlay.Size = new Size(76, 24);
            lblLastPlay.TabIndex = 6;
            lblLastPlay.Text = "label4";
            // 
            // lblPlayTime
            // 
            lblPlayTime.AutoSize = true;
            lblPlayTime.Font = new Font("Cascadia Code", 10.8F, FontStyle.Italic);
            lblPlayTime.ForeColor = Color.Gainsboro;
            lblPlayTime.Location = new Point(301, 54);
            lblPlayTime.Name = "lblPlayTime";
            lblPlayTime.Size = new Size(76, 24);
            lblPlayTime.TabIndex = 7;
            lblPlayTime.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 12F, FontStyle.Bold);
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(9, 104);
            label6.Name = "label6";
            label6.Size = new Size(144, 27);
            label6.TabIndex = 9;
            label6.Text = "Версия игры";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 45, 48);
            panel1.Controls.Add(txt);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.ForeColor = Color.FromArgb(45, 45, 48);
            panel1.Location = new Point(-1, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 42);
            panel1.TabIndex = 10;
            panel1.MouseDown += panelTitleBar_MouseDown;
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.Font = new Font("Cascadia Code", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            txt.ForeColor = Color.Gainsboro;
            txt.Location = new Point(3, 9);
            txt.Name = "txt";
            txt.Size = new Size(156, 27);
            txt.TabIndex = 13;
            txt.Text = "GameLauncher";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Code", 10.2F, FontStyle.Bold);
            label7.ForeColor = Color.Gainsboro;
            label7.Location = new Point(262, 13);
            label7.Name = "label7";
            label7.Size = new Size(140, 22);
            label7.TabIndex = 7;
            label7.Text = "Добавить игру";
            label7.Click += добавитьИгруToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(408, 13);
            label1.Name = "label1";
            label1.Size = new Size(80, 22);
            label1.TabIndex = 5;
            label1.Text = "Справка";
            label1.Click += справкаToolStripMenuItem_Click;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(813, 0);
            button2.Name = "button2";
            button2.Size = new Size(35, 50);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(854, 0);
            button1.Name = "button1";
            button1.Size = new Size(32, 50);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(45, 45, 48);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lblPlayTime);
            panel2.Controls.Add(lblGameVer);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(lblLastPlay);
            panel2.Location = new Point(252, 104);
            panel2.Name = "panel2";
            panel2.Size = new Size(431, 180);
            panel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(45, 45, 48);
            panel3.Controls.Add(lblGameName);
            panel3.Location = new Point(12, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(358, 48);
            panel3.TabIndex = 12;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Cascadia Code", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.ForeColor = Color.Gainsboro;
            button3.Location = new Point(471, 290);
            button3.Name = "button3";
            button3.Size = new Size(212, 30);
            button3.TabIndex = 13;
            button3.Text = "Удалить игру";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkGoldenrod;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Cascadia Code", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button4.ForeColor = Color.Gainsboro;
            button4.Location = new Point(253, 290);
            button4.Name = "button4";
            button4.Size = new Size(212, 30);
            button4.TabIndex = 14;
            button4.Text = "Редактировать";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 30);
            ClientSize = new Size(886, 556);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(btnPlay);
            Controls.Add(listBox1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += GameName_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Label lblGameName;
        private Button btnPlay;
        private Label lblGameVer;
        private Label label2;
        private Label label3;
        private Label lblLastPlay;
        private Label lblPlayTime;
        private Label label6;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label7;
        private Panel panel2;
        private Panel panel3;
        private Label txt;
        private Button button3;
        private Button button4;
    }
}
