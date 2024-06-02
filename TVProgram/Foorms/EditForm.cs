using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using TVProgram.Metods;
using TVProgram.Models;

namespace TVProgram.Foorms
{
    public partial class EditForm : Form
    {
        readonly Shows showe = new Shows();
        public string PATH_DATA = ".\\programa.json";
        Programa library = new Programa();
        private ProgramDataManager _dataManager;

        public EditForm(Shows showe)
        {
            InitializeComponent();
            _dataManager = new ProgramDataManager(".\\programa.json");
            var library = _dataManager.LoadDataFromJSON();
            this.showe = showe;
            idsBox.Text = showe.Id.ToString();
            nameBox.Text = showe.Name.ToString();
            timesBox.Text = showe.Time.ToString();
            genreBox.Text = showe.Genre;
            typeBox.Text = showe.Type;
            channelBox.Text = showe.Channel;
            authorsBox.Text = showe.Authors;
            dayBox.Text = showe.Day;
        }

        

        private void okButton_Click(object sender, EventArgs e)
        {
            LoadExistingData();

            if (!int.TryParse(idsBox.Text, out int id))
            {
                MessageBox.Show("Invalid ID format.");
                return;
            }
            if (string.IsNullOrWhiteSpace(genreBox.Text) ||
                string.IsNullOrWhiteSpace(nameBox.Text) ||
                string.IsNullOrWhiteSpace(timesBox.Text) |
                string.IsNullOrWhiteSpace(typeBox.Text) ||
                string.IsNullOrWhiteSpace(authorsBox.Text) ||
                string.IsNullOrWhiteSpace(dayBox.Text) ||
                string.IsNullOrWhiteSpace(channelBox.Text))
            {
                MessageBox.Show("Invalid data! Please ensure all fields are filled.");
                return;
            }

            string enteredTime = timesBox.Text.Trim();
            if (!DateTime.TryParseExact(enteredTime, "HH:mm", null, System.Globalization.DateTimeStyles.None, out _))
            {
                MessageBox.Show("Будь ласка введіть час у форматі HH:mm наприклад 13:20.", "Invalid Time Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Shows newShow = new Shows()
            {
                Id = id,
                Name = nameBox.Text,
                Genre = genreBox.Text,
                Type = typeBox.Text,
                Time = timesBox.Text,
                Authors = authorsBox.Text,
                Day = dayBox.Text,
                Channel = channelBox.Text
            };

            Shows existingShow = library.Showss.FirstOrDefault(s => s.Id == id);

            if (existingShow != null)
            {
                library.Showss.Remove(existingShow);
            }
            library.Showss.Add(newShow);

            _dataManager.SaveData(library);

            MessageBox.Show("Шоу було успішно оновлене!");
            this.Close();
        }

        private void LoadExistingData()
        {
            if (File.Exists(PATH_DATA))
            {
                var jsonString = File.ReadAllText(PATH_DATA);
                library = JsonSerializer.Deserialize<Programa>(jsonString);
                if (library == null)
                {
                    library = new Programa();  // Створіть новий екземпляр, якщо десеріалізація не вдалася
                }
            }
            else
            {
                library = new Programa();
            }
        }

        

        //private void timesBox_Validating(object sender, CancelEventArgs e)
        //{
        //    string enteredTime = timesBox.Text.Trim();
        //    if (!DateTime.TryParseExact(enteredTime, "HH:mm", null, System.Globalization.DateTimeStyles.None, out _))
        //    {
        //        MessageBox.Show("Будь ласка введіть час у форматі HH:mm, наприклад, 13:20.", "Invalid Time Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        e.Cancel = true;
        //    }
        //    else
        //    {
        //        e.Cancel = false;
        //    }
        //}
    }

}
