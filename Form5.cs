using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mabahs.Test_project_1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

            noRadioBtn();
        }

        private void noRadioBtn()
        {
            //First Way to do it
            buttonShwChoice.TabIndex = 0;

            //Second Way to do it 
            /*
            radioButtonRed.AutoCheck = false;
            radioButtonGreen.AutoCheck = false;
            radioButtonBlue.AutoCheck = false;
            */
        }

        public int radioBtnCase = 0;

        /* private void radioButtonRed_CheckedChanged(object sender, EventArgs e)
         {
             if (radioButtonRed.Checked == true)
             {
                 if (checkBoxMessageBox.Checked == true)
                 {
                     MessageBox.Show("You selcted Red");
                 }
                 radioBtnCase = 1;
                 panelRadioColor.BackColor = Color.Red;
                 radioButtonGreen.ForeColor = Color.Green;
                 radioButtonBlue.ForeColor = Color.Blue;
             }

             if (panelRadioColor.BackColor == Color.Red)
             {
                 radioButtonRed.ForeColor = Color.White;
                 checkBoxMessageBox.ForeColor = Color.White;
             }
         } */

        /* private void radioButtonGreen_CheckedChanged(object sender, EventArgs e)
         {
             if (radioButtonGreen.Checked == true)
             {
                 if (checkBoxMessageBox.Checked == true)
                 {
                     MessageBox.Show("You selcted Green");
                 }
                 radioBtnCase = 2;
                 panelRadioColor.BackColor = Color.Green;
                 radioButtonBlue.ForeColor = Color.Blue;
                 radioButtonRed.ForeColor = Color.Red;
             }

             if (panelRadioColor.BackColor == Color.Green)
             {
                 radioButtonGreen.ForeColor = Color.White;
                 checkBoxMessageBox.ForeColor = Color.White;
             }
         } */

        /* private void radioButtonBlue_CheckedChanged(object sender, EventArgs e)
         {
             if (radioButtonBlue.Checked == true)
             {
                 if (checkBoxMessageBox.Checked == true)
                 {
                     MessageBox.Show("You selcted Blue");
                 }
                 radioBtnCase = 3;
                 panelRadioColor.BackColor = Color.Blue;
                 radioButtonGreen.ForeColor = Color.Green;
                 radioButtonRed.ForeColor = Color.Red;
             }

             if (panelRadioColor.BackColor == Color.Blue)
             {
                 radioButtonBlue.ForeColor = Color.White;
                 checkBoxMessageBox.ForeColor = Color.White;
             }
         } */


        private void radioButtonRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRed.Checked == true)
            {
                if (checkBoxMessageBox.Checked == true)
                {
                    MessageBox.Show("You selcted Red");
                }
                radioBtnCase = 1;
                panelRadioColor.BackColor = Color.Red;
                radioButtonGreen.ForeColor = Color.Green;
                radioButtonBlue.ForeColor = Color.Blue;
            }

            if (panelRadioColor.BackColor == Color.Red)
            {
                radioButtonRed.ForeColor = Color.White;
                checkBoxMessageBox.ForeColor = Color.White;
            }
        }

        private void radioButtonGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGreen.Checked == true)
            {
                if (checkBoxMessageBox.Checked == true)
                {
                    MessageBox.Show("You selcted Green");
                }
                radioBtnCase = 2;
                panelRadioColor.BackColor = Color.Green;
                radioButtonBlue.ForeColor = Color.Blue;
                radioButtonRed.ForeColor = Color.Red;
            }

            if (panelRadioColor.BackColor == Color.Green)
            {
                radioButtonGreen.ForeColor = Color.White;
                checkBoxMessageBox.ForeColor = Color.White;
            }
        }

        private void radioButtonBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBlue.Checked == true)
            {
                if (checkBoxMessageBox.Checked == true)
                {
                    MessageBox.Show("You selcted Blue");
                }
                radioBtnCase = 3;
                panelRadioColor.BackColor = Color.Blue;
                radioButtonGreen.ForeColor = Color.Green;
                radioButtonRed.ForeColor = Color.Red;
            }

            if (panelRadioColor.BackColor == Color.Blue)
            {
                radioButtonBlue.ForeColor = Color.White;
                checkBoxMessageBox.ForeColor = Color.White;
            }
        }

        private void buttonShwChoice_Click(object sender, EventArgs e)
        {
            switch (radioBtnCase)
            {
                case 1:
                    labelShwRadioChoice.ForeColor = Color.Red;
                    labelShwRadioChoice.Text = "You Have\n chosen\n Red";
                    break;
                case 2:
                    labelShwRadioChoice.ForeColor = Color.Green;
                    labelShwRadioChoice.Text = "You Have\n chosen\n Green";
                    break;
                case 3:
                    labelShwRadioChoice.ForeColor = Color.Blue;
                    labelShwRadioChoice.Text = "You Have\n chosen\n Blue";
                    break;

            }
        }
    }
}
