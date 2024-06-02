using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using TVProgram.Models;



namespace TVProgram.Foorms
{
    public partial class PlanForm : Form
    {
        private string _scheduleFilePath = "mySchedules.json";
        private string _programaFilePath = "programa.json";
        private List<ViewingSchedule> schedules = new List<ViewingSchedule>();

        public PlanForm(int xValue)
        {
            x = xValue;
            InitializeComponent();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            LoadSchedulesFromFile();
            if(x == 1)
            {
                domainUpDown1.Visible = false;
                domainUpDown2.Visible = true;
            }
            if(x == 3)
            {
                domainUpDown2.Visible = false;
                domainUpDown1.Visible = true;
            }
        }

        private void PlanForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSchedulesToFile();
        }
        public int x = 2;

        public class ViewingSchedule
        {
            public int ShowId { get; set; }
            public string ShowName { get; set; }
            public string ShowDay { get; set; }
            public string ShowTime { get; set; }
            public string ShowChannel { get; set; }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //if (dataGridView1.SelectedRows.Count > 0)
            //{
            //    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            //    if (selectedRow.DataBoundItem is Shows selectedShow)
            //    {
            //        if (!DateTime.TryParseExact(selectedShow.Time, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime showTime))
            //        {
            //            MessageBox.Show("Невірний формат часу.");
            //        }
            //    }
            //}
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                if (selectedRow.DataBoundItem is Shows selectedShow)
                {
                    var schedule = new ViewingSchedule()
                    {
                        ShowId = selectedShow.Id,
                        ShowName = selectedShow.Name,
                        ShowDay = selectedShow.Day,
                        ShowTime = selectedShow.Time,
                        ShowChannel = selectedShow.Channel
                    };

                    schedules.Add(schedule);
                    UpdateScheduleList();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть шоу, щоб додати до розкладу.");
            }
            SaveSchedulesToFile();
        }

        private void UpdateScheduleList()
        {
            planListBox.Items.Clear();
            foreach (var schedule in schedules)
            {
                planListBox.Items.Add($"Назва: {schedule.ShowName}, Час: {schedule.ShowTime}, День: {schedule.ShowDay}, Канал: {schedule.ShowChannel} ");
            }
        }

        private void SaveSchedulesToFile()
        {
            var json = JsonSerializer.Serialize(schedules);
            File.WriteAllText(_scheduleFilePath, json);
        }

        private void LoadSchedulesFromFile()
        {
            if (File.Exists(_scheduleFilePath))
            {
                var json = File.ReadAllText(_scheduleFilePath);
                schedules = JsonSerializer.Deserialize<List<ViewingSchedule>>(json);
                UpdateScheduleList();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Programa programa = LoadDataFromJson();
            if (programa != null)
            {
                if (x == 1)
                {
                    var filteredShows = programa.Showss.Where(show =>
                        show.Channel.Equals("Nickelodeon", StringComparison.OrdinalIgnoreCase) ||
                        show.Channel.Equals("Disney", StringComparison.OrdinalIgnoreCase) ||
                        show.Channel.Equals("Plus Plus", StringComparison.OrdinalIgnoreCase) ||
                        show.Channel.Equals("Cartoon Network", StringComparison.OrdinalIgnoreCase) ||
                        show.Channel.Equals("Dreamworks", StringComparison.OrdinalIgnoreCase)).ToList();
                    
                    dataGridView1.DataSource = filteredShows;
                }
                else
                {
                    dataGridView1.DataSource = programa.Showss;
                   
                }
            }
            else
            {
                MessageBox.Show("Помилка завантаження шоу з JSON.");
            }
        }

        private Programa LoadDataFromJson()
        {
            string path = ".\\programa.json";
            if (File.Exists(path))
            {
                string jsonString = File.ReadAllText(_programaFilePath);
                Programa programa = JsonSerializer.Deserialize<Programa>(jsonString);
                return programa;
            }
            else
            {
                MessageBox.Show("JSON не був знайдений.");
                return null;
            }
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (planListBox.SelectedIndex != -1)
            {
                schedules.RemoveAt(planListBox.SelectedIndex);
                UpdateScheduleList();
                SaveSchedulesToFile();
            }
        }

        private void saveAsButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                Title = "Save your text file"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        foreach (var item in planListBox.Items)
                        {
                            writer.WriteLine(item.ToString());
                        }
                    }

                    MessageBox.Show("Файл успішно збережено!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при збереженні файлу: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Programa programa = LoadDataFromJson();
            if (programa != null)
            {
                if (x == 3)
                {
                    string selectedChannel = null;
                    if(domainUpDown1.SelectedItem == null)
                    {
                        MessageBox.Show("Ви не обрали канал!");
                    }
                    else
                    {
                        selectedChannel = domainUpDown1.SelectedItem.ToString();
                    }
                    var filteredShows = programa.Showss.Where(show =>
                        show.Channel.Equals(selectedChannel, StringComparison.OrdinalIgnoreCase)).ToList();
                    dataGridView1.DataSource = filteredShows;
                }
                else
                {
                    string selectedChannel = null;
                    if (domainUpDown2.SelectedItem == null)
                    {
                        MessageBox.Show("Ви не обрали канал!");
                    }
                    else
                    {
                        selectedChannel = domainUpDown2.SelectedItem.ToString();
                    }
                    var filteredShows = programa.Showss.Where(show =>
                        show.Channel.Equals(selectedChannel, StringComparison.OrdinalIgnoreCase)).ToList();
                    dataGridView1.DataSource = filteredShows;
                }
            }
        }

    }
}
