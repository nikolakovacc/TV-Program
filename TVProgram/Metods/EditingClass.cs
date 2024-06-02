using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using TVProgram.Foorms;
using TVProgram.Metods;
using TVProgram.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class UserYearsHelper
{
    public void UserYears(string passwordFilePath, Action loadingAction, Action loadingKidAction,
        Control children2Button, Control childButton, Control searchButton, Control openButton, Control childLabel, Control searchTVShowButton, Control searchTVkidsButton, Control planButton, Control planChildButton, ToolStripMenuItem changePasswordToolStripMenuItem/*, ref int x*/)
    {
        using (var diyaForm = new Diya())
        using (var passwordForm = new changePasswordForm())
        {
            var res = diyaForm.ShowDialog();
            string savedPassword = File.ReadAllText(passwordFilePath);
            if (res == DialogResult.OK)
            {
                if (diyaForm.Password == savedPassword)
                {
                    loadingAction();
                    children2Button.Visible = false;
                    childButton.Visible = true;
                    searchButton.Visible = true;
                    openButton.Visible = false;
                    childLabel.Visible = false;
                    searchTVShowButton.Visible = true;
                    searchTVkidsButton.Visible = false;
                    planButton.Visible = true;
                    planChildButton.Visible = false;
                    changePasswordToolStripMenuItem.Visible = true;
                }
                else
                {
                    loadingKidAction();
                    childButton.Visible = false;
                    children2Button.Visible = true;
                    searchButton.Visible = false;
                    openButton.Visible = true;
                    searchTVShowButton.Visible = false;
                    searchTVkidsButton.Visible = true;
                    planButton.Visible = false;
                    planChildButton.Visible = true;
                    changePasswordToolStripMenuItem.Visible = false;
                }
            }
        }
    }
}
public class ProgramDataManager
{
    private string _filePath;

    public ProgramDataManager(string filePath)
    {
        _filePath = filePath;
    }

    public void LikeShow(DataGridView data1, DataGridView data2, DataGridView data3, DataGridView data4, DataGridView data5)
    {
        var selectedDataGridView = DataGridViewHelper.GetSelectedDataGridView(data1, data2, data3, data4, data5);
        var selectedShow = DataGridViewHelper.GetSelectedShow(selectedDataGridView);

        if (selectedShow != null)
        {
            if (selectedShow.IsFavorite)
            {
                MessageBox.Show("Це шоу вже додано до улюблених");
            }
            else
            {
                var library = new Programa();
                library = LoadDataFromJSON();

                var showToUpdate = library.Showss.FirstOrDefault(show => show.Id == selectedShow.Id);
                if (showToUpdate != null)
                {
                    showToUpdate.IsFavorite = true;
                    showToUpdate.Name += " ❤";
                }

                SaveData(library);

                MessageBox.Show("Шоу додано до улюблених!");
                selectedDataGridView.Refresh();

            }
        }
        else
        {
            MessageBox.Show("Будь ласка оберіть шоу яке ви хотіли б додати до улюблених");
        }
    }
    public void DeleteLikedShows(DataGridView data1, DataGridView data2, DataGridView data3, DataGridView data4, DataGridView data5)
    {
        var selectedDataGridView = DataGridViewHelper.GetSelectedDataGridView(data1, data2, data3, data4, data5);
        var selectedShow = DataGridViewHelper.GetSelectedShow(selectedDataGridView);
        if (selectedShow != null)
        {
            if (selectedShow.IsFavorite)
            {
                var library = LoadDataFromJSON();

                var showToUpdate = library.Showss.FirstOrDefault(show => show.Id == selectedShow.Id);
                if (showToUpdate != null)
                {
                    showToUpdate.IsFavorite = false;
                    if (showToUpdate.Name.EndsWith(" ❤"))
                    {
                        showToUpdate.Name = showToUpdate.Name.Substring(0, showToUpdate.Name.Length - 2);
                    }
                    SaveData(library);
                    MessageBox.Show("Шоу видалено з улюблених!");
                    selectedDataGridView.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Це шоу не є улюбленим!");
            }
        }
        else
        {
            MessageBox.Show("Будь ласка оберіть шоу яке хотіли б видалити з улюблених.");
        }
    }
    public void Loading(DataGridView data1, DataGridView data2, DataGridView data3, DataGridView data4, DataGridView data5)
    {
        Programa programa = LoadDataFromJSON();

        var showsOn1Plus1 = programa.Showss.Where(show => show.Channel == "1+1").ToList();
        var showsViasatKino = programa.Showss.Where(show => show.Channel == "Viasat Kino" || show.Channel == "VIASAT KINO" || show.Channel == "viasat kino").ToList();
        var showsBBCChannel = programa.Showss.Where(show => show.Channel == "BBC News" || show.Channel == "bbc news" || show.Channel == "BBC NEWS").ToList();
        var showsMTVHits = programa.Showss.Where(show => show.Channel == "MTV Hits" || show.Channel == "mtv hits").ToList();
        var showsEurosport = programa.Showss.Where(show => show.Channel == "Eurosport" || show.Channel == "eurosport").ToList();

        data1.DataSource = showsMTVHits;
        data2.DataSource = showsOn1Plus1;
        data3.DataSource = showsViasatKino;
        data4.DataSource = showsBBCChannel;
        data5.DataSource = showsEurosport;
    }
    public void LoadingKid(DataGridView data1, DataGridView data2, DataGridView data3, DataGridView data4, DataGridView data5)
    {
        Programa programa = LoadDataFromJSON();

        var showsOnNickelodeon = programa.Showss.Where(show => show.Channel == "Nickelodeon" || show.Channel == "nickelodeon").ToList();
        var showsOnCartoonNetwork = programa.Showss.Where(show => show.Channel == "Cartoon Network" || show.Channel == "cartoon network").ToList();
        var showsDreamworks = programa.Showss.Where(show => show.Channel == "Dreamworks" || show.Channel == "dreamworks" || show.Channel == "dream works" || show.Channel == "Dream Works" || show.Channel == "DreamWorks").ToList();
        var showsDisney = programa.Showss.Where(show => show.Channel == "Disney" || show.Channel == "disney").ToList();
        var showsPlusPlus = programa.Showss.Where(show => show.Channel == "Plus Plus" || show.Channel == "plus plus").ToList();

        data1.DataSource = showsDreamworks;
        data2.DataSource = showsDisney;
        data3.DataSource = showsOnNickelodeon;
        data4.DataSource = showsOnCartoonNetwork;
        data5.DataSource = showsPlusPlus;

    }
   
    public void EditElement(DataGridView data1, DataGridView data2, DataGridView data3, DataGridView data4, DataGridView data5)
    {
        var selectedDataGridView = DataGridViewHelper.GetSelectedDataGridView(data1, data2, data3, data4, data5);
        var selectedShow = DataGridViewHelper.GetSelectedShow(selectedDataGridView);

        if (selectedShow != null)
        {
            var showsEditForm = new EditForm(selectedShow);
            _ = showsEditForm.ShowDialog() == DialogResult.OK;
        }
        else
        {
            MessageBox.Show("Оберіть шоу");
        }
    }
    public void DeleteShow(DataGridView data1, DataGridView data2, DataGridView data3, DataGridView data4, DataGridView data5)
    {
        var selectedDataGridView = DataGridViewHelper.GetSelectedDataGridView(data1, data2, data3, data4, data5);
        var selectedShow = DataGridViewHelper.GetSelectedShow(selectedDataGridView);

        if (selectedShow != null)
        {
            var library = new Programa();
            library = LoadDataFromJSON();
            var showToUpdate = library.Showss.FirstOrDefault(show => show.Id == selectedShow.Id);
            if (showToUpdate != null)
            {
                if (showToUpdate != null)
                {
                    library.Showss.Remove(showToUpdate);
                    SaveData(library);
                }
            }
            SaveData(library);
            MessageBox.Show("Шоу успішно видалено!");
            selectedDataGridView.Refresh();
        }
        else
        {
            MessageBox.Show("Будь ласка оберіть шоу яке хотіли б видалити!");
        }
    }
    public void SaveData(Programa library)
    {
        string json = JsonSerializer.Serialize(library, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(_filePath, json);
    }
    public Programa LoadDataFromJSON()
    {
        if (File.Exists(_filePath))
        {
            string jsonString = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<Programa>(jsonString) ?? new Programa(); ;
        }
        return new Programa { Showss = new List<Shows>() };
    }

    public class HideClass
    {
        public static void HideAllPictureBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is PictureBox)
                {
                    c.Visible = false;
                }
                if (c.HasChildren)
                {
                    HideAllPictureBoxes(c);
                }
            }
        }
        
        public static void Url(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалося відкрити URL. Помилка: " + ex.Message);
            }
        }
    }
}
