using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVProgram.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace TVProgram.Foorms
{

    public partial class SearchForm : Form
    {
        Programa library = new Programa();
        public string path = ".\\programa.json";
        public SearchForm(int xValue)
        {
            x = xValue;
            InitializeComponent();
            library = library.LoadData(path);
        }

        public int x = 2;

        private void searchButton_Click(object sender, EventArgs e)
        {
            var onlyFavorites = favoriteCheckBox.Checked;
            var result = library.Search(idBox.Text, nameBox.Text, genreBox.Text, typeBox.Text, timeBox.Text, authorBox.Text, dayBox.Text, channelBox.Text, onlyFavorites);

            if (TimeSpan.TryParse(startTimeTextBox.Text, out TimeSpan startTime) && TimeSpan.TryParse(endTimeTextBox.Text, out TimeSpan endTime))
            {
                result = result.Where(show => TimeSpan.TryParse(show.Time, out TimeSpan showTime) && showTime >= startTime && showTime <= endTime).ToList();
            }

            if (x == 1)
            {
                var filteredResult = result.Where(s => s.Channel == "Nickelodeon" || s.Channel == "Cartoon Network" || s.Channel == "Dreamworks" || s.Channel == "Disney" || s.Channel == "Plus Plus");
                showsBindingSource.DataSource = filteredResult.ToList();
            }
            else if (x == 0)
            {
                showsBindingSource.DataSource = result;
            }
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                if (selectedRow.DataBoundItem is Shows show)
                {
                    var showEditForm = new EditForm(show);
                    if (showEditForm.ShowDialog() == DialogResult.OK)
                    {
                        searchButton_Click(null, null);
                        library = library.LoadData(path);
                    }
                }
            }
        }
        
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
