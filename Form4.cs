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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();


        }

        public int Bstyle = 0;

        private void doubleFontStyle(Label label, int Bstyle)
        {
            switch (Bstyle)
            {
                case 1:
                    label.Font = new Font(label.Font, FontStyle.Bold | FontStyle.Italic);
                    break;
                case 2:
                    label.Font = new Font(label.Font, FontStyle.Bold);
                    break;
                case 3:
                    label.Font = new Font(label.Font, FontStyle.Italic);
                    break;
                default:
                    labelFontChange.Font = new Font(labelFontChange.Font, FontStyle.Regular);
                    break;

            }
        }

        private void checkBoxBold_CheckedChanged(object sender, EventArgs e)
        {
            Bstyle = 0;
            if (checkBoxItalic.Checked == true && checkBoxBold.Checked == true)
                Bstyle = 1;
            else if (checkBoxItalic.Checked == false && checkBoxBold.Checked == true)
                Bstyle = 2;
            else if (checkBoxItalic.Checked == true && checkBoxBold.Checked == false)
                Bstyle = 3;

            doubleFontStyle(labelFontChange, Bstyle);
        }

        private void checkBoxItalic_CheckedChanged(object sender, EventArgs e)
        {
            Bstyle = 0;
            if (checkBoxItalic.Checked == true && checkBoxBold.Checked == true)
                Bstyle = 1;
            else if (checkBoxItalic.Checked == false && checkBoxBold.Checked == true)
                Bstyle = 2;
            else if (checkBoxItalic.Checked == true && checkBoxBold.Checked == false)
                Bstyle = 3;

            doubleFontStyle(labelFontChange, Bstyle);
        }
    }
}
