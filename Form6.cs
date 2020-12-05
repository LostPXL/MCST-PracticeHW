using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScintillaNET;
using System.IO;

namespace Mabahs.Test_project_1
{
    public partial class Form6 : Form
    {
        public Form6(int TamrinNum)
        {
            InitializeComponent();
            setScintilla(TamrinNum);

        }
        public static Color IntToColor(int rgb)
        {
            return Color.FromArgb(255, (byte)(rgb >> 16), (byte)(rgb >> 8), (byte)rgb);
        }
        private void setScintilla(int Tamrinnum)
        {

            scintilla1.SetSelectionBackColor(true, IntToColor(0x114D9C));

			// Configure the default style
			scintilla1.StyleResetDefault();
			scintilla1.Styles[Style.Default].Font = "Consolas";
			scintilla1.Styles[Style.Default].Size = 10;
			scintilla1.Styles[Style.Default].BackColor = IntToColor(0x212121);
			scintilla1.Styles[Style.Default].ForeColor = IntToColor(0xFFFFFF);
			scintilla1.StyleClearAll();

			// Configure the CPP (C#) lexer styles
			scintilla1.Styles[Style.Cpp.Identifier].ForeColor = IntToColor(0xD0DAE2);
			scintilla1.Styles[Style.Cpp.Comment].ForeColor = IntToColor(0xBD758B);
			scintilla1.Styles[Style.Cpp.CommentLine].ForeColor = IntToColor(0x40BF57);
			scintilla1.Styles[Style.Cpp.CommentDoc].ForeColor = IntToColor(0x2FAE35);
			scintilla1.Styles[Style.Cpp.Number].ForeColor = IntToColor(0xFFFF00);
			scintilla1.Styles[Style.Cpp.String].ForeColor = IntToColor(0xFFFF00);
			scintilla1.Styles[Style.Cpp.Character].ForeColor = IntToColor(0xE95454);
			scintilla1.Styles[Style.Cpp.Preprocessor].ForeColor = IntToColor(0x8AAFEE);
			scintilla1.Styles[Style.Cpp.Operator].ForeColor = IntToColor(0xE0E0E0);
			scintilla1.Styles[Style.Cpp.Regex].ForeColor = IntToColor(0xff00ff);
			scintilla1.Styles[Style.Cpp.CommentLineDoc].ForeColor = IntToColor(0x77A7DB);
			scintilla1.Styles[Style.Cpp.Word].ForeColor = IntToColor(0x48A8EE);
			scintilla1.Styles[Style.Cpp.Word2].ForeColor = IntToColor(0xF98906);
			scintilla1.Styles[Style.Cpp.Operator].ForeColor = Color.DeepPink;
			//scintilla1.Styles[Style.Cpp.Word3].ForeColor = Color.Pink;
			scintilla1.Styles[Style.Cpp.CommentDocKeyword].ForeColor = IntToColor(0xB3D991);
			scintilla1.Styles[Style.Cpp.CommentDocKeywordError].ForeColor = IntToColor(0xFF0000);
			scintilla1.Styles[Style.Cpp.GlobalClass].ForeColor = IntToColor(0x48A8EE);

			scintilla1.Lexer = Lexer.Cpp;

			scintilla1.SetKeywords(0, "if else switch case if else switch case class extends implements import interface new do while for in throw get set function var try catch finally while with default break continue delete return each const namespace package include use is as instanceof typeof author copy default deprecated eventType example exampleText exception haxe inheritDoc internal link mtasc mxmlc param private return see serial serialData serialField since throws usage version langversion playerversion productversion dynamic private public partial static intrinsic internal native override protected AS3 final super this arguments null Infinity NaN undefined true false abstract as base bool break by byte catch char checked class const continue decimal default delegate do double descending explicit event extern else enum false finally fixed float for foreach from goto group implicit in int interface internal into is lock long new null namespace object operator out override orderby params private protected public readonly ref return struct sbyte sealed short sizeof stackalloc static string select this throw true try typeof uint ulong unchecked unsafe ushort using var virtual volatile void while where yield");
			scintilla1.SetKeywords(1, "void Null ArgumentError arguments Array Boolean Class Date DefinitionError Error EvalError Function int Math Namespace Number Object RangeError ReferenceError RegExp SecurityError String SyntaxError TypeError uint XML XMLList Boolean Byte Char DateTime Decimal Double Int16 Int32 Int64 IntPtr SByte Single UInt16 UInt32 UInt64 UIntPtr Void Path File System Windows Forms ScintillaNET");
			//scintilla1.SetKeywords(2, "if else switch case if else switch case"); 

			//Show the full code
			switch (Tamrinnum)
			{
				case 1:
					scintilla1.Text = File.ReadAllText("../../Form2.cs");
					break;
				case 2:
					scintilla1.Text = File.ReadAllText("../../Form3.cs");
					break;
				case 3:
					scintilla1.Text = File.ReadAllText("../../Form4.cs");
					break;
				case 4:
					scintilla1.Text = File.ReadAllText("../../Form5.cs");
					break;
				case 5:
					break;
				default:
					break;
            }
				
				

		}
	}
}
