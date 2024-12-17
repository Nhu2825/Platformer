using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platformer
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void SubjectSelection(object sender, EventArgs e)
        {
            if (cmb_Subject.Items.Count <= 0)
            {
                List<SubjectBus> list = SubjectBus.listSubjects();
                foreach (SubjectBus item in list)
                {
                    cmb_Subject.Items.Add(item);
                }
            }
        }

        private void PressStart(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_Name.Text) || string.IsNullOrEmpty(cmb_Subject.Text))
            {
                MessageBox.Show("Please input name and subject.");
                    return;
            }   

            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
        }

        private void Menu_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources._1006406251_1_, 0,0);    
        }
    }
}
