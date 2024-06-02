using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVProgram.Models;
using TVProgram.Metods;
using static System.Net.Mime.MediaTypeNames;
using System.Xml;
using System.Xml.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using System.Net;
using static ProgramDataManager;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TVProgram.Foorms
{

    public partial class MainFoorm : Form
    {
        private DataGridViewHelper _DataGrid;
        private ProgramDataManager _dataManager;
        private Programa _library;
        readonly Shows showe = new Shows();
        Programa library = new Programa();
        private const string passwordFilePath = "userPassword.txt";
        public MainFoorm()
        {

            InitializeComponent();
            _dataManager = new ProgramDataManager(".\\programa.json");
            var library = _dataManager.LoadDataFromJSON();
            dataGridView1.SelectionChanged += DataGridView_SelectionChanged;
            dataGridView2.SelectionChanged += DataGridView_SelectionChanged;
            dataGridView3.SelectionChanged += DataGridView_SelectionChanged;
            dataGridView4.SelectionChanged += DataGridView_SelectionChanged;
            dataGridView5.SelectionChanged += DataGridView_SelectionChanged;
            var userYearsHelper = new UserYearsHelper();
            Uses();


        }
        public void Uses()
        {
            var userYearsHelper = new UserYearsHelper();
            userYearsHelper.UserYears(
                passwordFilePath,
                LoadingParents,
                LoadingKids,
                children2Button,
                childButton,
                searchButton,
                openButton,
                childLabel,
                searchTVShowButton,
                button1,
                planButton,
                planChildButton,
                changePasswordToolStripMenuItem
            //ref x
            );
        }
        //?
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var dataGridViews = new[] { dataGridView1, dataGridView2, dataGridView3, dataGridView4, dataGridView5 };
            DataGridViewHelper.HandleSelectionChanged(sender, dataGridViews);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            LoadingParents();
        }
        private void childButton_Click(object sender, EventArgs e)
        {
            LoadingKids();
        }
        private void children2Button_Click(object sender, EventArgs e)
        {
            LoadingKids();
        }


        public void LoadingParents()
        {

            _dataManager.Loading(dataGridView1, dataGridView2, dataGridView3, dataGridView4, dataGridView5);

            HideClass.HideAllPictureBoxes(this);

            ViasatPictureBox.Visible = true;
            bbcPictureBox.Visible = true;
            pictureBox1.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            changePasswordToolStripMenuItem.Visible = true;
            planButton.Visible = true;
            planChildButton.Visible = false;
            y = 1;



        }
        public void LoadingKids()
        {
            _dataManager.LoadingKid(dataGridView1, dataGridView2, dataGridView3, dataGridView4, dataGridView5);

            HideClass.HideAllPictureBoxes(this);

            pictureBox2.Visible = true;
            nickelodeonPicture.Visible = true;
            disneyPictureBox.Visible = true;
            plusPictureBox.Visible = true;
            dreamPictureBox.Visible = true;
            planChildButton.Visible = true;
            y = 2;
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutUsForm = new AboutForm();
            aboutUsForm.ShowDialog();
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dataManager.LoadDataFromJSON();
            MessageBox.Show("Data loaded");
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var library = new Programa();
            _dataManager.SaveData(library);
            MessageBox.Show("Data saved");
        }

        private void searchTVShowButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm(0);
            searchForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var library = new Programa();  // Необхідно отримати актуальні дані для збереження
            _dataManager.LoadDataFromJSON();
            MessageBox.Show("Data load");
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            _dataManager.DeleteShow(dataGridView1, dataGridView2, dataGridView3, dataGridView4, dataGridView5);
            if (y == 1)
            {
                LoadingParents();
            }
            if (y == 2)
            {
                LoadingKids();
            }

        }


        private void editSelectElementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dataManager.EditElement(dataGridView1, dataGridView2, dataGridView3, dataGridView4, dataGridView5);
            if (y == 1)
            {
                LoadingParents();
            }
            if (y == 2)
            {
                LoadingKids();
            }

        }
        private void addNewElementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Show();
        }

        private void favoritesButton_Click(object sender, EventArgs e)
        {
            _dataManager.LikeShow(dataGridView1, dataGridView2, dataGridView3, dataGridView4, dataGridView5);
            if (y == 1)
            {
                LoadingParents();
            }
            if (y == 2)
            {
                LoadingKids();
            }
        }

        private void deleteFavoriteButton_Click(object sender, EventArgs e)
        {

            _dataManager.DeleteLikedShows(dataGridView1, dataGridView2, dataGridView3, dataGridView4, dataGridView5);
            if (y == 1)
            {
                LoadingParents();
            }
            if (y == 2)
            {
                LoadingKids();
            }
        }


        private void planButton_Click(object sender, EventArgs e)
        {
            PlanForm planForm = new PlanForm(3);
            planForm.Show();
        }

        private void updateFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var library = _dataManager.LoadDataFromJSON();
            MessageBox.Show("Data loaded");
        }


        private void openButton_Click(object sender, EventArgs e)
        {
            Uses();
        }

        private void змінитиПарольToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var changePasswordForm = new changePasswordForm())
            {
                if (changePasswordForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Пароль успішно змінено!");
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm(1);
            searchForm.Show();
        }

        private void planChildButton_Click(object sender, EventArgs e)
        {
            PlanForm planForm = new PlanForm(1);
            planForm.Show();
        }

        public int y = 0;
        private string who;

        private void dataGridView3_DoubleClick(object sender, EventArgs e)
        {
            if (y == 2)
            {
                HideClass.Url("https://tv.kyivstar.ua/ua/live-channels/56bd8815e4b0cc78202b7627-nickelodeon");
            }
            if (y == 1)
            {
                HideClass.Url("https://tv.kyivstar.ua/ua/live-channels/55efdb75e4b0781039bc0ac3-viasat-kino-action-hd");
            }

        }

        private void dataGridView4_DoubleClick(object sender, EventArgs e)
        {
            if (y == 2)
            {
                HideClass.Url("https://sweet.tv/tv/86-cartoon-network");
            }
            if (y == 1)
            {
                HideClass.Url("https://www.bbc.co.uk/bbcone");
            }
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            if (y == 2)
            {
                HideClass.Url("https://www.preview.disneyplus.com/unavailable");
            }
            if (y == 1)
            {
                HideClass.Url("https://tv.kyivstar.ua/ua/live-channels/55f2bcefe4b0781039beb055-1-1-marafon-hd");
            }
        }

        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            if (y == 2)
            {
                HideClass.Url("https://sweet.tv/collections/6102-multfilmi-dreamworks");
            }
            if (y == 1)
            {
                HideClass.Url("https://tv.kyivstar.ua/ua/live-channels/5ac5ef8560b20c61c1f9c8bc-mtv-hits");
            }
        }

        private void dataGridView5_DoubleClick(object sender, EventArgs e)
        {

            if (y == 2)
            {
                HideClass.Url("https://tv.kyivstar.ua/ua/live-channels/55efdb73e4b0781039bc04a2-plyusplyus-hd");
            }
            if (y == 1)
            {
                HideClass.Url("https://tv.kyivstar.ua/ua/live-channels/58c24f0830d48b494be7c3e8-eurosport");
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutAppForm aboutAppForm = new AboutAppForm();
            aboutAppForm.ShowDialog();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedDataGridView = DataGridViewHelper.GetSelectedDataGridView(dataGridView1, dataGridView2, dataGridView3, dataGridView4, dataGridView5);

            if (selectedDataGridView != null && selectedDataGridView.SelectedRows.Count == selectedDataGridView.Rows.Count)
            {
                // If all rows are selected, copy all shows
                StringBuilder sb = new StringBuilder();
                foreach (DataGridViewRow row in selectedDataGridView.Rows)
                {
                    Shows show = row.DataBoundItem as Shows;
                    if (show != null)
                    {
                        sb.AppendLine($"Назва: {show.Name}, Канал: {show.Channel}, Час: {show.Time}, День: {show.Day}");
                    }
                }

                if (sb.Length > 0)
                {
                    Clipboard.SetText(sb.ToString());
                }
            }
            else
            {
                var selectedShow = DataGridViewHelper.GetSelectedShow(selectedDataGridView);
                if (selectedShow != null)
                {
                    var selectedText = $"Назва: {selectedShow.Name}, Канал: {selectedShow.Channel}, Час: {selectedShow.Time}, День: {selectedShow.Day}";
                    if (!string.IsNullOrEmpty(selectedText))
                    {
                        Clipboard.SetText(selectedText);
                    }
                }
            }
        }

        private void daySearchButton_Click(object sender, EventArgs e)
        {
            Programa programa = _dataManager.LoadDataFromJSON();
            if (programa != null)
            {
                string selectedDay = null;

                if (domainUpDown2.SelectedItem == null)
                {
                    MessageBox.Show("Ви не обрали день");
                }
                else
                {
                    selectedDay = domainUpDown2.SelectedItem.ToString();
                }

                var filteredShows = programa.Showss.Where(show =>
                    show.Day.Equals(selectedDay, StringComparison.OrdinalIgnoreCase)).ToList();

                if (y == 1)
                {
                    dataGridView1.DataSource = filteredShows.Where(show => show.Channel.Equals("MTV Hits", StringComparison.OrdinalIgnoreCase)).ToList();
                    dataGridView2.DataSource = filteredShows.Where(show => show.Channel.Equals("1+1", StringComparison.OrdinalIgnoreCase)).ToList();
                    dataGridView3.DataSource = filteredShows.Where(show => show.Channel.Equals("VIASAT KINO", StringComparison.OrdinalIgnoreCase)).ToList();
                    dataGridView4.DataSource = filteredShows.Where(show => show.Channel.Equals("BBC News", StringComparison.OrdinalIgnoreCase)).ToList();
                    dataGridView5.DataSource = filteredShows.Where(show => show.Channel.Equals("Eurosport", StringComparison.OrdinalIgnoreCase)).ToList();
                }
                if (y == 2)
                {
                    dataGridView1.DataSource = filteredShows.Where(show => show.Channel.Equals("Dream Works", StringComparison.OrdinalIgnoreCase)).ToList();
                    dataGridView2.DataSource = filteredShows.Where(show => show.Channel.Equals("Disney", StringComparison.OrdinalIgnoreCase)).ToList();
                    dataGridView3.DataSource = filteredShows.Where(show => show.Channel.Equals("nickelodeon", StringComparison.OrdinalIgnoreCase)).ToList();
                    dataGridView4.DataSource = filteredShows.Where(show => show.Channel.Equals("Cartoon Network", StringComparison.OrdinalIgnoreCase)).ToList();
                    dataGridView5.DataSource = filteredShows.Where(show => show.Channel.Equals("Plus Plus", StringComparison.OrdinalIgnoreCase)).ToList();
                }

            }
        }
    }
}