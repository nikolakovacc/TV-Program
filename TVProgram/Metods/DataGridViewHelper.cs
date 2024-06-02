using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVProgram.Models;

namespace TVProgram.Metods
{
    internal class DataGridViewHelper
    {
        public static DataGridView GetSelectedDataGridView(params DataGridView[] dataGridViews)
        {
            foreach (var dgv in dataGridViews)
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    return dgv;
                }
            }
            return null;
        }

        public static Shows GetSelectedShow(DataGridView dgv)
        {
            if (dgv != null && dgv.SelectedRows.Count > 0)
            {
                var selectedRow = dgv.SelectedRows[0];
                if (selectedRow.DataBoundItem is Shows show)
                {
                    return show;
                }
            }
            return null;
        }


        public static void HandleSelectionChanged(object sender, DataGridView[] dataGridViews)
        {
            var currentDataGridView = sender as DataGridView;

            foreach (var dgv in dataGridViews)
            {
                if (dgv != currentDataGridView)
                {
                    dgv.ClearSelection();
                }
            }
            /*Очищає виділення в усіх DataGridView, крім того, який викликав подію, 
             * щоб уникнути одночасного вибору рядків в декількох DataGridView.*/
        }

    }
}
