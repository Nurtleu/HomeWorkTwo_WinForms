using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsHW2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void Form1_Mouse_pressing(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (e.X<30||e.Y<30||e.X>this.Width-30||e.Y<this.Height-30)
                {
                    MessageBox.Show(Text = "Вы вне зоны");
                    return;
                }
                else if(e.X < 30 || e.Y < 30 || e.X > this.Width - 30 || e.Y > this.Height - 30)
                {
                    MessageBox.Show(Text = "Вы в зоне!");
                    return;
                }
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                Form1.ActiveForm.Text = String.Format("Ширина окна :" + Size.Width + "Высота окна :" + Size.Height);
                return;
            }
        }
        private void Form1_Mouse_move(object sender, MouseEventArgs e)
        {
            if (e.X < 30 || e.Y < 30 || e.X > this.Width - 30 || e.Y > this.Height - 30)
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
