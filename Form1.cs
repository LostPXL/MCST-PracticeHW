using System;
using System.Drawing;
using System.Windows.Forms;
using ScintillaNET;
using System.IO;





namespace Mabahs.Test_project_1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            customizeDesign();

            setScintilla();
                        
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            scintillaSubPanel.Visible = true;
            buttonShwAnswrFS.Visible = true;

        }

        private void hideGroupBox(GroupBox groupBox)
        {
            groupBox.Visible = false;
        }

        private void Do_Checked()
        {

        }

        #region making form moveable and resizable

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();



        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                const int resizeArea = 10;
                Point cursorPosition = PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                if (cursorPosition.X >= ClientSize.Width - resizeArea && cursorPosition.Y >= ClientSize.Height - resizeArea)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }

            base.WndProc(ref m);
        }


        #endregion


        #region Form Design
        public int TamrinCase = 0;

        private void customizeDesign()
        {
            panelTamrinatSubMenu.Visible = false;
            subPanel.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelTamrinatSubMenu.Visible == true)
                panelTamrinatSubMenu.Visible = false;
            
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
                subPanel.Visible = true;
            }
            else { 
                subMenu.Visible = false;
                subPanel.Visible = false;
            }
        }


        private void btnTamrinat_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTamrinatSubMenu);
            if (activeForm != null)
                activeForm.Close();
            scintillaSubPanel.Visible = false;
            buttonShwAnswrFS.Visible = false;
        }

        private void btnTamrin1_Click(object sender, EventArgs e)
        {
            scintillaSubPanel.ReadOnly = false;
            openChildForm(new Form2());
            LoadDataFromFile("../../T1Answer.cs");
            buttonShwAnswrFS.Text = "Show Tamrin 1's Full Code";
            TamrinCase = 1;
            scintillaSubPanel.Visible = true;
            buttonShwAnswrFS.Visible = true;
        }

        private void btnTamrin2_Click(object sender, EventArgs e)
        {
            scintillaSubPanel.ReadOnly = false;
            openChildForm(new Form3());
            LoadDataFromFile("../../T2Answer.cs");
            buttonShwAnswrFS.Text = "Show Tamrin 2's Full Code";
            TamrinCase = 2;
            scintillaSubPanel.Visible = true;
            buttonShwAnswrFS.Visible = true;
        }

        private void btnTamrin3_Click(object sender, EventArgs e)
        {
            scintillaSubPanel.ReadOnly = false;
            openChildForm(new Form4());
        }

        private void btnTamrin4_Click(object sender, EventArgs e)
        {
            scintillaSubPanel.ReadOnly = false;
            openChildForm(new Form5());
        }



        #endregion

        #region Maximize,Minimize and close button
        private void buttonClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;

        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        #endregion


        #region Setting Scintilla Up

        public static Color IntToColor(int rgb)
        {
            return Color.FromArgb(255, (byte)(rgb >> 16), (byte)(rgb >> 8), (byte)rgb);
        }
        private void LoadDataFromFile(string path)
        {
            //scintillaSubPanel.Text = File.ReadAllText(Properties.Resources.Tamrin1);
            if (File.Exists(path))
            {
                //FileName.Text = Path.GetFileName(path);
                scintillaSubPanel.Text = File.ReadAllText(path);
                //scintillaSubPanel.Text = Properties.Resources.Tamrin1;
            }
            scintillaSubPanel.ReadOnly = true;
        }
        private void setScintilla()
        {

            scintillaSubPanel.SetSelectionBackColor(true, IntToColor(0x114D9C));

            // Configure the default style
            scintillaSubPanel.StyleResetDefault();
            scintillaSubPanel.Styles[Style.Default].Font = "Consolas";
            scintillaSubPanel.Styles[Style.Default].Size = 10;
            scintillaSubPanel.Styles[Style.Default].BackColor = IntToColor(0x212121);
            scintillaSubPanel.Styles[Style.Default].ForeColor = IntToColor(0xFFFFFF);
            scintillaSubPanel.StyleClearAll();

            // Configure the CPP (C#) lexer styles
            scintillaSubPanel.Styles[Style.Cpp.Identifier].ForeColor = IntToColor(0xD0DAE2);
            scintillaSubPanel.Styles[Style.Cpp.Comment].ForeColor = IntToColor(0xBD758B);
            scintillaSubPanel.Styles[Style.Cpp.CommentLine].ForeColor = IntToColor(0x40BF57);
            scintillaSubPanel.Styles[Style.Cpp.CommentDoc].ForeColor = IntToColor(0x2FAE35);
            scintillaSubPanel.Styles[Style.Cpp.Number].ForeColor = IntToColor(0xFFFF00);
            scintillaSubPanel.Styles[Style.Cpp.String].ForeColor = IntToColor(0xFFFF00);
            scintillaSubPanel.Styles[Style.Cpp.Character].ForeColor = IntToColor(0xE95454);
            scintillaSubPanel.Styles[Style.Cpp.Preprocessor].ForeColor = IntToColor(0x8AAFEE);
            scintillaSubPanel.Styles[Style.Cpp.Operator].ForeColor = IntToColor(0xE0E0E0);
            scintillaSubPanel.Styles[Style.Cpp.Regex].ForeColor = IntToColor(0xff00ff);
            scintillaSubPanel.Styles[Style.Cpp.CommentLineDoc].ForeColor = IntToColor(0x77A7DB);
            scintillaSubPanel.Styles[Style.Cpp.Word].ForeColor = IntToColor(0x48A8EE);
            scintillaSubPanel.Styles[Style.Cpp.Word2].ForeColor = IntToColor(0xF98906);
            scintillaSubPanel.Styles[Style.Cpp.Operator].ForeColor = Color.DeepPink;
            //scintillaSubPanel.Styles[Style.Cpp.Word3].ForeColor = Color.Pink;
            scintillaSubPanel.Styles[Style.Cpp.CommentDocKeyword].ForeColor = IntToColor(0xB3D991);
            scintillaSubPanel.Styles[Style.Cpp.CommentDocKeywordError].ForeColor = IntToColor(0xFF0000);
            scintillaSubPanel.Styles[Style.Cpp.GlobalClass].ForeColor = IntToColor(0x48A8EE);

            scintillaSubPanel.Lexer = Lexer.Cpp;

            scintillaSubPanel.SetKeywords(0, "if else switch case if else switch case class extends implements import interface new do while for in throw get set function var try catch finally while with default break continue delete return each const namespace package include use is as instanceof typeof author copy default deprecated eventType example exampleText exception haxe inheritDoc internal link mtasc mxmlc param private return see serial serialData serialField since throws usage version langversion playerversion productversion dynamic private public partial static intrinsic internal native override protected AS3 final super this arguments null Infinity NaN undefined true false abstract as base bool break by byte catch char checked class const continue decimal default delegate do double descending explicit event extern else enum false finally fixed float for foreach from goto group implicit in int interface internal into is lock long new null namespace object operator out override orderby params private protected public readonly ref return struct sbyte sealed short sizeof stackalloc static string select this throw true try typeof uint ulong unchecked unsafe ushort using var virtual volatile void while where yield");
            scintillaSubPanel.SetKeywords(1, "void Null ArgumentError arguments Array Boolean Class Date DefinitionError Error EvalError Function int Math Namespace Number Object RangeError ReferenceError RegExp SecurityError String SyntaxError TypeError uint XML XMLList Boolean Byte Char DateTime Decimal Double Int16 Int32 Int64 IntPtr SByte Single UInt16 UInt32 UInt64 UIntPtr Void Path File System Windows Forms ScintillaNET");
            //scintillaSubPanel.SetKeywords(2, "if else switch case if else switch case");
        }
        #endregion


        private void buttonExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonShwAnswrFS_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(TamrinCase);
            form6.Show();
            /*
            switch (TamrinCase)
            {
                case 1:
                    Form6 form6 = new Form6(TamrinCase);
                    form6.Show();
                    break;
                case 2:
                    Form6 form6 = new Form6(TamrinCase);
                    form6.Show();
                default:
                    break;
            }
            */

        }

    }
}
