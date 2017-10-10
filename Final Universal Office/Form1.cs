using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Ribbonpad
{
    public partial class Form1 : DevComponents.DotNetBar.Office2007Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();

            try
            {
                File.Delete(saveFileDialog1.FileName + ".csv"); ;
            }
            catch (Exception ex) { }
            string suText = "";
            
            for (int i = 0; i < archonDataGridView1.RowCount; i++)
            {
                suText = "";
                for (int colCount = 0; colCount < archonDataGridView1.ColumnCount; colCount++)
                {
                    suText += archonDataGridView1.Rows[i].Cells[colCount].Value+",";
                }
                File.AppendAllText(saveFileDialog1.FileName + ".csv", suText + "\n");
            }
        }
        
        public void addColumn()
        {
            archonDataGridView1.Columns.Add("a", "C" + archonDataGridView1.Columns.Count);
        }

        public void removeColumn()
        {
            archonDataGridView1.Columns.RemoveAt(archonDataGridView1.Columns.Count - 1);
        }
        public void addRow()
        {
            archonDataGridView1.Rows.Add();
        }

        public void removeRow()
        {
            archonDataGridView1.Rows.RemoveAt(archonDataGridView1.SelectedRows[0].Index);
        }
    }
}
