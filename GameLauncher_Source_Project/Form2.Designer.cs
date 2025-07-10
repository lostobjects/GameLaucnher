namespace GameLauncher
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            txtboxPlayTime = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtboxGamePath = new TextBox();
            txtboxGameVer = new TextBox();
            txtboxGameName = new TextBox();
            btnSelectedGamePath = new Button();
            openFileDialog1 = new OpenFileDialog();
            btnAddGame = new Button();
            button1 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 10.2F);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(49, 46);
            label1.Name = "label1";
            label1.Size = new Size(150, 22);
            label1.TabIndex = 0;
            label1.Text = "Название игры:";
            // 
            // txtboxPlayTime
            // 
            txtboxPlayTime.BackColor = Color.FromArgb(44, 44, 46);
            txtboxPlayTime.BorderStyle = BorderStyle.FixedSingle;
            txtboxPlayTime.Font = new Font("Cascadia Code", 10.2F);
            txtboxPlayTime.ForeColor = Color.WhiteSmoke;
            txtboxPlayTime.Location = new Point(205, 153);
            txtboxPlayTime.Name = "txtboxPlayTime";
            txtboxPlayTime.Size = new Size(246, 27);
            txtboxPlayTime.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(59, 116);
            label2.Name = "label2";
            label2.Size = new Size(140, 22);
            label2.TabIndex = 2;
            label2.Text = "Путь к файлу:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 10.2F);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(69, 79);
            label3.Name = "label3";
            label3.Size = new Size(130, 22);
            label3.TabIndex = 3;
            label3.Text = "Версия игры:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(9, 153);
            label4.Name = "label4";
            label4.Size = new Size(190, 22);
            label4.TabIndex = 4;
            label4.Text = "Игровое время (ч):";
            // 
            // txtboxGamePath
            // 
            txtboxGamePath.BackColor = Color.FromArgb(44, 44, 46);
            txtboxGamePath.BorderStyle = BorderStyle.FixedSingle;
            txtboxGamePath.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtboxGamePath.ForeColor = Color.WhiteSmoke;
            txtboxGamePath.Location = new Point(205, 116);
            txtboxGamePath.Name = "txtboxGamePath";
            txtboxGamePath.Size = new Size(246, 27);
            txtboxGamePath.TabIndex = 5;
            txtboxGamePath.TextChanged += textBox2_TextChanged;
            // 
            // txtboxGameVer
            // 
            txtboxGameVer.BackColor = Color.FromArgb(44, 44, 46);
            txtboxGameVer.BorderStyle = BorderStyle.FixedSingle;
            txtboxGameVer.Font = new Font("Cascadia Code", 10.2F);
            txtboxGameVer.ForeColor = Color.WhiteSmoke;
            txtboxGameVer.Location = new Point(205, 79);
            txtboxGameVer.Name = "txtboxGameVer";
            txtboxGameVer.Size = new Size(246, 27);
            txtboxGameVer.TabIndex = 6;
            // 
            // txtboxGameName
            // 
            txtboxGameName.BackColor = Color.FromArgb(44, 44, 46);
            txtboxGameName.BorderStyle = BorderStyle.FixedSingle;
            txtboxGameName.Font = new Font("Cascadia Code", 10.2F);
            txtboxGameName.ForeColor = Color.WhiteSmoke;
            txtboxGameName.Location = new Point(205, 46);
            txtboxGameName.Name = "txtboxGameName";
            txtboxGameName.Size = new Size(246, 27);
            txtboxGameName.TabIndex = 7;
            // 
            // btnSelectedGamePath
            // 
            btnSelectedGamePath.BackColor = Color.FromArgb(58, 58, 61);
            btnSelectedGamePath.FlatAppearance.BorderSize = 0;
            btnSelectedGamePath.FlatStyle = FlatStyle.Flat;
            btnSelectedGamePath.Font = new Font("Cascadia Code", 10.2F);
            btnSelectedGamePath.ForeColor = Color.Gainsboro;
            btnSelectedGamePath.Location = new Point(9, 205);
            btnSelectedGamePath.Name = "btnSelectedGamePath";
            btnSelectedGamePath.Size = new Size(442, 35);
            btnSelectedGamePath.TabIndex = 8;
            btnSelectedGamePath.Text = "Выбрать путь";
            btnSelectedGamePath.UseVisualStyleBackColor = false;
            btnSelectedGamePath.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAddGame
            // 
            btnAddGame.BackColor = Color.FromArgb(58, 58, 61);
            btnAddGame.FlatAppearance.BorderSize = 0;
            btnAddGame.FlatStyle = FlatStyle.Flat;
            btnAddGame.Font = new Font("Cascadia Code", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAddGame.ForeColor = Color.White;
            btnAddGame.Location = new Point(9, 259);
            btnAddGame.Name = "btnAddGame";
            btnAddGame.Size = new Size(442, 52);
            btnAddGame.TabIndex = 9;
            btnAddGame.Text = "Добавить игру";
            btnAddGame.UseVisualStyleBackColor = false;
            btnAddGame.Click += btnAddGame_Click;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(431, 0);
            button1.Name = "button1";
            button1.Size = new Size(32, 50);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 45, 48);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-1, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 42);
            panel1.TabIndex = 10;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 30);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(463, 319);
            Controls.Add(panel1);
            Controls.Add(btnAddGame);
            Controls.Add(btnSelectedGamePath);
            Controls.Add(txtboxGameName);
            Controls.Add(txtboxGameVer);
            Controls.Add(txtboxGamePath);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtboxPlayTime);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление игры";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtboxPlayTime;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtboxGamePath;
        private TextBox txtboxGameVer;
        private TextBox txtboxGameName;
        private Button btnSelectedGamePath;
        private OpenFileDialog openFileDialog1;
        private Button btnAddGame;
        private Button button1;
        private Panel panel1;
    }
}