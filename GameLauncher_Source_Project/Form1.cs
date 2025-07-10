using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Text.Json;
using System.Runtime.InteropServices;

namespace GameLauncher
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private List<GameInfo> games = new List<GameInfo>();
        private const string saveFile = "games.json";
        private GameInfo selectedGame;
        public Form1()
        {
            InitializeComponent();
            listBox1.BackColor = Color.FromArgb(28, 28, 30);
            listBox1.ForeColor = Color.Gainsboro;
            listBox1.BorderStyle = BorderStyle.FixedSingle;

            listBox1.DrawMode = DrawMode.OwnerDrawFixed;
            listBox1.DrawItem += listBox1_DrawItem;
        }
        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            bool selected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            Color backgroundColor = selected ? Color.FromArgb(48, 105, 215) : listBox1.BackColor;
            Color textColor = selected ? Color.White : listBox1.ForeColor;

            e.Graphics.FillRectangle(new SolidBrush(backgroundColor), e.Bounds);
            e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, new SolidBrush(textColor), e.Bounds, StringFormat.GenericDefault);

            e.DrawFocusRectangle();
        }
        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form4 form4 = new Form4();
            this.Hide();
            form4.FormClosed += (s, args) => this.Show();
            form4.Show();
        }

        private void GameName_Load(object sender, EventArgs e)
        {
            LoadGames();
            UpdateList();
            ClearGameDetails();
        }
        private void LoadGames()
        {
            if (File.Exists(saveFile))
            {
                var json = File.ReadAllText(saveFile);
                games = JsonSerializer.Deserialize<List<GameInfo>>(json) ?? new List<GameInfo>();
            }
        }
        private void SaveGames()
        {
            var json = JsonSerializer.Serialize(games);
            File.WriteAllText(saveFile, json);
        }
        private void UpdateList()
        {
            listBox1.Items.Clear();
            foreach (var game in games)
                listBox1.Items.Add(game.Name);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ShowGameDetails(GameInfo game)
        {
            lblGameName.Text = $"{game.Name}";
            lblGameVer.Text = $"{game.Version}";
            lblPlayTime.Text = $"{game.PlayTime:F2} �";
            lblLastPlay.Text = game.LastPlayed != DateTime.MinValue ? $"{game.LastPlayed:d.MM.y t}" : "";
            btnPlay.Enabled = true;
        }
        private void ClearGameDetails()
        {
            lblGameName.Text = "";
            lblGameVer.Text = "";
            lblPlayTime.Text = "";
            btnPlay.Enabled = false;
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (selectedGame == null || !File.Exists(selectedGame.ExePath))
            {
                MessageBox.Show("���� �� ������.");
                return;
            }

            this.Hide();  // ����������� �����

            DateTime startTime = DateTime.Now;

            Process p = new Process();
            p.StartInfo.FileName = selectedGame.ExePath;
            p.StartInfo.WorkingDirectory = Path.GetDirectoryName(selectedGame.ExePath);
            p.EnableRaisingEvents = true;

            p.Exited += (s, ev) =>
            {
                DateTime endTime = DateTime.Now;
                TimeSpan session = endTime - startTime;

                selectedGame.PlayTime += session.TotalHours;
                selectedGame.LastPlayed = endTime;
                SaveGames();

                this.Invoke((Action)(() =>
                {
                    int sessionMinutes = (int)session.TotalMinutes;
                    int sessionHours = sessionMinutes / 60;
                    int sessionRemainMin = sessionMinutes % 60;

                    MessageBox.Show($"�� ������� {sessionHours} � {sessionRemainMin} ��� � ��� ������.",
                                    "������ ���������",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    ShowGameDetails(selectedGame); // ��������� �����������
                    this.WindowState = FormWindowState.Normal;
                    this.Show();
                }));
            };

            try
            {
                p.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("������ ������� ����: " + ex.Message);
                this.WindowState = FormWindowState.Normal;
                this.Show();
            }
        }
        public void ReloadGameList()
        {
            LoadGames();
            UpdateList();
            ClearGameDetails();
        }
        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            this.Hide();
            form2.FormClosed += (s, args) => this.Show();
            form2.Show();
        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� ������, � ��� �� ��������, ��� ������ ��� �����������. ���-�� ����� ����, �� ��� ������");
            //Form3 form3 = new Form3();
            //this.Hide();//
            //form3.FormClosed += (s, args) => this.Show();//
            //form3.Show();//
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index < 0 || index >= games.Count)
            {
                selectedGame = null;
                ClearGameDetails();
                return;
            }

            selectedGame = games[index];
            ShowGameDetails(selectedGame);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblGameName_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index < 0 || index >= games.Count)
            {
                MessageBox.Show("�������� ���� ��� ��������.");
                return;
            }

            // ������� ���� �� ������
            games.RemoveAt(index);

            // ��������� ��������� � ����
            SaveGames();

            // ��������� ListBox
            UpdateList();

            // ������� ������
            ClearGameDetails();
        }

        private void button4_Click(object sender, EventArgs e)
       {
    int index = listBox1.SelectedIndex;
    if (index< 0 || index >= games.Count)
    {
        MessageBox.Show("�������� ���� ��� ��������������.");
        return;
    }

    var gameToEdit = games[index];
        Form2 form2 = new Form2(this, gameToEdit, index);
    this.Hide();
        form2.FormClosed += (s, args) => this.Show();
        form2.Show();
        }
    }

}
