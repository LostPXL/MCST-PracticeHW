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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void clearLabel(Label label)
        {
            label.Text = "";
        }

        private void hideGroupBox(GroupBox groupBox)
        {
            groupBox.Visible = false;
        }
        private void showGroupBox(GroupBox groupBox)
        {
            groupBox.Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (label2 != null)
            {
                clearLabel(label2);
            }

            if (checkBox1.Checked == true)
                showGroupBox(groupBoxHiBye);
            else if (checkBox1.Checked == false)
                hideGroupBox(groupBoxHiBye);
        }

        private void btnHi_Click(object sender, EventArgs e)
        {
            clearLabel(label2);
            label2.Text = "Hi";
        }

        private void btnBye_Click(object sender, EventArgs e)
        {
            clearLabel(label2);
            label2.Text = "Bye";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (label2 != null)
            {
                clearLabel(label2);
            }

            if (checkBox2.Checked == true)
                showGroupBox(groupBoxLeftRight);
            else if (checkBox2.Checked == false)
                hideGroupBox(groupBoxLeftRight);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            clearLabel(label2);
            label2.Text = "Left";
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            clearLabel(label2);
            label2.Text = "Right";
        }
    }
}
