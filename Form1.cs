using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assesment
{
    public partial class Form1 : Form
    {
        bool jumping = false;
        int pipeSpeed = 5;
        int gravity = 5;
        int Inscore = 0;
        public Form1()
        {
            InitializeComponent();
            endText1.Text = "Game Over!";
            endText2.Text = "Your Final Score Is: + Inscore";
            gameDesigner.Text = "Game Designed By Big Nuts";
            endText1.Visible = false;
            endText2.Visible = false;
            gameDesigner.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GameKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void GameKeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
