using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace GameLauncher
{

    public partial class Form2 : Form
    {
        private Form1 mainForm;
        private const string saveFile = "games.json";
        private List<GameInfo> games = new List<GameInfo>();
        private int? editingIndex = null; // null — добавление, число — редактирование
        public Form2(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
            LoadGames();
        }

        public Form2(Form1 form, GameInfo gameToEdit, int index)
        {
            InitializeComponent();
            mainForm = form;
            LoadGames();

            // Заполняем поля для редактирования
            txtboxGameName.Text = gameToEdit.Name;
            txtboxGameVer.Text = gameToEdit.Version;
            txtboxGamePath.Text = gameToEdit.ExePath;
            txtboxPlayTime.Text = gameToEdit.PlayTime.ToString("F2");

            editingIndex = index;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Файлы приложений (*.exe)|*.exe|Все файлы (*.*)|*.*";
                ofd.Title = "Выберите файл игры";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtboxGamePath.Text = ofd.FileName;

                }
            }
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtboxGameName.Text) ||
                string.IsNullOrWhiteSpace(txtboxGameVer.Text) ||
                string.IsNullOrWhiteSpace(txtboxGamePath.Text) ||
                !double.TryParse(txtboxPlayTime.Text, out double time))
            {
                MessageBox.Show("Заполни все поля корректно.");
                return;
            }

            var newGame = new GameInfo
            {
                Name = txtboxGameName.Text.Trim(),
                Version = txtboxGameVer.Text.Trim(),
                ExePath = txtboxGamePath.Text.Trim(),
                PlayTime = time
            };

            if (editingIndex.HasValue)
            {
                games[editingIndex.Value] = newGame; // режим редактирования
            }
            else
            {
                games.Add(newGame); // режим добавления
            }
            SaveGames();

            // Переключение на Form1
            mainForm.ReloadGameList();
            mainForm.Show();
            this.Close();
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
            var options = new JsonSerializerOptions { WriteIndented = true };
            var json = JsonSerializer.Serialize(games, options);
            File.WriteAllText(saveFile, json);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }
    }

}
