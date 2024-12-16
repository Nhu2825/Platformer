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
            //Platformer.x = new User(Convert.ToInt32(cmb_Name.Text), Convert.ToInt32(cmb_Subject.Text));

            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
