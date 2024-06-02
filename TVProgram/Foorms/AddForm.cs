using System;
using System.IO;
using System.Text.Json;
using System.Threading.Channels;
using System.Windows.Forms;
using System.Xml.Linq;
using TVProgram.Metods;
using TVProgram.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace TVProgram.Foorms
{
    public partial class AddForm : Form
    {
        private DataHandler _data;

        public AddForm()
        {
            InitializeComponent();
            _data = new DataHandler(); 
            _data.LoadExistingData(); 
        }

        private void addElButton_Click(object sender, EventArgs e)
        {
            
            _data.AddShows(id2Box, nameBox, genre2Box, typeBox, time2Box, author2Box, day2Box, channel2Box, favoriteCheckBox);
            
        }

        private void backlButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

