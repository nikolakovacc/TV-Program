using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using TVProgram.Models;

namespace TVProgram.Metods
{
    public class DataHandler
    {
        private Programa library;
        private string path = ".\\programa.json";
        private ProgramDataManager _dataManager;

        public DataHandler()
        {
            _dataManager = new ProgramDataManager(path);
        }

        public void AddShows(TextBox ids, TextBox name, TextBox genre, TextBox type, TextBox time, TextBox author, TextBox day, TextBox channel, CheckBox isFavorite)
        {
            int id;
            if (!int.TryParse(ids.Text, out id))
            {
                MessageBox.Show("Невірний id формат");
                return;
            }

            string[] validChannels = { "Eurosport", "Nickelodeon", "1+1", "MTV Hits", "Plus Plus", "Cartoon Network", "Disney", "Viasat Kino", "BBC News", "bbc news", "viasat kino", "dreamworks", "dream works" };
            string enteredChannel = channel.Text.Trim();
            string enteredTime = time.Text.Trim();
            bool isValidChannel = false;
            foreach (string validChannel in validChannels)
            {
                if (enteredChannel.Equals(validChannel, StringComparison.OrdinalIgnoreCase))
                {
                    isValidChannel = true;
                    break;
                }
            }
            if (!isValidChannel)
            {
                MessageBox.Show("Будь ласка введіть канал який є в програмі.(1+1, Euronews, BBC News, Viasat Kino, MTV Hits, Dreamworks, Nickelodeon, Cartoon Network, Plus Plus, Disney)", "Invalid Channel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!DateTime.TryParseExact(enteredTime, "HH:mm", null, System.Globalization.DateTimeStyles.None, out _))
            {
                MessageBox.Show("Будь ласка введіть час у форматі HH:mm наприклад 13:20.", "Invalid Time Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Check if a show with the same time and channel already exists
            foreach (var show in library.Showss)
            {
                if (show.Channel.Equals(enteredChannel, StringComparison.OrdinalIgnoreCase) && show.Time == enteredTime)
                {
                    MessageBox.Show($"Шоу на каналі {enteredChannel} вже існує на {enteredTime}.", "Duplicate Show", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(genre.Text) ||
                string.IsNullOrWhiteSpace(name.Text) ||
                string.IsNullOrWhiteSpace(time.Text) ||
                string.IsNullOrWhiteSpace(author.Text) ||
                string.IsNullOrWhiteSpace(day.Text) ||
                string.IsNullOrWhiteSpace(channel.Text))
            {
                MessageBox.Show("Невірні дані! Переконайтеся, що всі поля заповнені.");
                return;
            }

            AddShow(id, name.Text, genre.Text, enteredTime, author.Text, day.Text, type.Text, enteredChannel, isFavorite.Checked);
            MessageBox.Show("Нове шоу успішно додане!");
            ClearFormFields(ids, name, genre, time, author, day, channel, isFavorite);
        }

        public void AddShow(int id, string name, string genre, string time, string authors, string day, string type, string channel, bool isFavorite)
        {
            if ((isFavorite == true))
            {
                name = name + " ❤";
            }
            Shows newShow = new Shows()
            {
                Id = id,
                Name = name,
                Genre = genre,
                Type = type,
                Time = time,
                Authors = authors,
                Day = day,
                Channel = channel,
                IsFavorite = isFavorite
            };

            var existingData = _dataManager.LoadDataFromJSON();
            existingData.Showss.Add(newShow);
            _dataManager.SaveData(existingData);
        }

        public void ClearFormFields(TextBox id, TextBox name, TextBox genre, TextBox time, TextBox author, TextBox day, TextBox channel, CheckBox isFavorite)
        {
            id.Clear();
            name.Clear();
            genre.Clear();
            time.Clear();
            author.Clear();
            day.Clear();
            channel.Clear();
            isFavorite.Checked = false;
        }

        public void LoadExistingData()
        {
            if (File.Exists(path))
            {
                var jsonString = File.ReadAllText(path);
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
    }
}