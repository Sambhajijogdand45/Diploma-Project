using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Ribbonpad
{
    public partial class CcreatePDF : Form
    {
        public CcreatePDF()
        {
            InitializeComponent();
        }

        private void CcreatePDF_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(new ListViewItem(new string[] { textBox1.Text,textBox2.Text,textBox3.Text}, -1));
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "*.PDF|*.PDF";
            sfd.FilterIndex = 0;
            sfd.AddExtension = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                clsGenratePDF genpdf = new clsGenratePDF();

                ArrayList a1 = new ArrayList();
                a1.Add("COLUMN 1");
                a1.Add("COLUMN 2");
                a1.Add("COLUMN 3");


                genpdf.GenerateUsingText(sfd.FileName, richTextBox1);
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "*.PDF|*.PDF";
                sfd.FilterIndex = 0;
                sfd.AddExtension = true;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    clsGenratePDF genpdf = new clsGenratePDF();

                    ArrayList a1 = new ArrayList();
                    a1.Add("COLUMN 1");
                    a1.Add("COLUMN 2");
                    a1.Add("COLUMN 3");


                    genpdf.GenerateUsingList(sfd.FileName, listView1, a1, 1);
                }
            }
            else
            {
                MessageBox.Show("Please eneter atleast one row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}