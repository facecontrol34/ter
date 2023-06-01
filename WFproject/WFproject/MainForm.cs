using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFproject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void mainExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainExitButton_MouseEnter(object sender, EventArgs e)
        {
            mainExitButton.ForeColor = Color.Black;
        }

        private void mainExitButton_MouseLeave(object sender, EventArgs e)
        {
            mainExitButton.ForeColor = Color.White;
        }

        //движение окна
        Point lastPoint;
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RubBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void DollarBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EuroBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void convisionButton_Click(object sender, EventArgs e)
        {
            ConversionForm conversionForm = new ConversionForm();
            conversionForm.ShowDialog();
        }
    }
}

