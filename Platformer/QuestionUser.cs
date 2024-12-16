using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platformer
{
    public partial class QuestionUser : Form
    {
        int i;
        List<QuestionsBus> list = QuestionsBus.listQuestion(1);
        public QuestionUser()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void QuestionUsers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QuestionUsers_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            i = rnd.Next(0, list.Count);
            QuestionHere.Text = list[i].Question;
            rad_A.Text = list[i].DA1;
            rad_B.Text = list[i].DA2;
            rad_C.Text = list[i].DA3;
            rad_D.Text = list[i].DA4;
        }
        /*private void button1_Click(object sender, EventArgs e)
        {
            if ((rad_A.Checked & list[i].DA == "A") ||
                (rad_B.Checked & list[i].DA == "B") ||
                (rad_C.Checked & list[i].DA == "C") ||
                (rad_D.Checked & list[i].DA == "D"))
            {
                Mario.x.Score++;
                
            }
            else
            {
                Mario.x.Lives--;
            }
            this.Close();
        }*/
    }
}
