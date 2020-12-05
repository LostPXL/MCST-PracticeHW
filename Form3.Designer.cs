namespace Mabahs.Test_project_1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxLeftRight = new System.Windows.Forms.GroupBox();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.groupBoxHiBye = new System.Windows.Forms.GroupBox();
            this.btnBye = new System.Windows.Forms.Button();
            this.btnHi = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.groupBoxLeftRight.SuspendLayout();
            this.groupBoxHiBye.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.groupBoxLeftRight);
            this.panel2.Controls.Add(this.groupBoxHiBye);
            this.panel2.Location = new System.Drawing.Point(249, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 255);
            this.panel2.TabIndex = 5;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(221, 191);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(91, 21);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Left/Right";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(221, 29);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 21);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Hi/Bye";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Wozcott", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(221, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 31);
            this.label2.TabIndex = 2;
            // 
            // groupBoxLeftRight
            // 
            this.groupBoxLeftRight.Controls.Add(this.btnRight);
            this.groupBoxLeftRight.Controls.Add(this.btnLeft);
            this.groupBoxLeftRight.Location = new System.Drawing.Point(15, 134);
            this.groupBoxLeftRight.Name = "groupBoxLeftRight";
            this.groupBoxLeftRight.Size = new System.Drawing.Size(200, 100);
            this.groupBoxLeftRight.TabIndex = 1;
            this.groupBoxLeftRight.TabStop = false;
            this.groupBoxLeftRight.Text = "Left/Right";
            this.groupBoxLeftRight.Visible = false;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(96, 31);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(77, 47);
            this.btnRight.TabIndex = 3;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(13, 31);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(77, 47);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // groupBoxHiBye
            // 
            this.groupBoxHiBye.Controls.Add(this.btnBye);
            this.groupBoxHiBye.Controls.Add(this.btnHi);
            this.groupBoxHiBye.Location = new System.Drawing.Point(15, 14);
            this.groupBoxHiBye.Name = "groupBoxHiBye";
            this.groupBoxHiBye.Size = new System.Drawing.Size(200, 92);
            this.groupBoxHiBye.TabIndex = 0;
            this.groupBoxHiBye.TabStop = false;
            this.groupBoxHiBye.Text = "Hi/Bye";
            this.groupBoxHiBye.Visible = false;
            // 
            // btnBye
            // 
            this.btnBye.Location = new System.Drawing.Point(96, 28);
            this.btnBye.Name = "btnBye";
            this.btnBye.Size = new System.Drawing.Size(77, 47);
            this.btnBye.TabIndex = 1;
            this.btnBye.Text = "Bye";
            this.btnBye.UseVisualStyleBackColor = true;
            this.btnBye.Click += new System.EventHandler(this.btnBye_Click);
            // 
            // btnHi
            // 
            this.btnHi.Location = new System.Drawing.Point(13, 28);
            this.btnHi.Name = "btnHi";
            this.btnHi.Size = new System.Drawing.Size(77, 47);
            this.btnHi.TabIndex = 0;
            this.btnHi.Text = "Hi";
            this.btnHi.UseVisualStyleBackColor = true;
            this.btnHi.Click += new System.EventHandler(this.btnHi_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(2)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBoxLeftRight.ResumeLayout(false);
            this.groupBoxHiBye.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxLeftRight;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.GroupBox groupBoxHiBye;
        private System.Windows.Forms.Button btnBye;
        private System.Windows.Forms.Button btnHi;
    }
}