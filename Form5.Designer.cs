namespace Mabahs.Test_project_1
{
    partial class Form5
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
            this.panelRadioColor = new System.Windows.Forms.Panel();
            this.checkBoxMessageBox = new System.Windows.Forms.CheckBox();
            this.buttonShwChoice = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelShwRadioChoice = new System.Windows.Forms.Label();
            this.radioButtonBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.panelRadioColor.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRadioColor
            // 
            this.panelRadioColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelRadioColor.Controls.Add(this.checkBoxMessageBox);
            this.panelRadioColor.Controls.Add(this.buttonShwChoice);
            this.panelRadioColor.Controls.Add(this.panel4);
            this.panelRadioColor.Controls.Add(this.radioButtonBlue);
            this.panelRadioColor.Controls.Add(this.radioButtonGreen);
            this.panelRadioColor.Controls.Add(this.radioButtonRed);
            this.panelRadioColor.Location = new System.Drawing.Point(267, 93);
            this.panelRadioColor.Name = "panelRadioColor";
            this.panelRadioColor.Size = new System.Drawing.Size(296, 220);
            this.panelRadioColor.TabIndex = 10;
            // 
            // checkBoxMessageBox
            // 
            this.checkBoxMessageBox.AutoSize = true;
            this.checkBoxMessageBox.Location = new System.Drawing.Point(160, 23);
            this.checkBoxMessageBox.Name = "checkBoxMessageBox";
            this.checkBoxMessageBox.Size = new System.Drawing.Size(117, 21);
            this.checkBoxMessageBox.TabIndex = 7;
            this.checkBoxMessageBox.Text = "MessageBoxs";
            this.checkBoxMessageBox.UseVisualStyleBackColor = true;
            // 
            // buttonShwChoice
            // 
            this.buttonShwChoice.Location = new System.Drawing.Point(172, 74);
            this.buttonShwChoice.Name = "buttonShwChoice";
            this.buttonShwChoice.Size = new System.Drawing.Size(105, 44);
            this.buttonShwChoice.TabIndex = 7;
            this.buttonShwChoice.Text = "Show my Choice ";
            this.buttonShwChoice.UseVisualStyleBackColor = true;
            this.buttonShwChoice.Click += new System.EventHandler(this.buttonShwChoice_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel4.Controls.Add(this.labelShwRadioChoice);
            this.panel4.Location = new System.Drawing.Point(172, 126);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(105, 80);
            this.panel4.TabIndex = 7;
            // 
            // labelShwRadioChoice
            // 
            this.labelShwRadioChoice.AutoSize = true;
            this.labelShwRadioChoice.Location = new System.Drawing.Point(16, 14);
            this.labelShwRadioChoice.Name = "labelShwRadioChoice";
            this.labelShwRadioChoice.Size = new System.Drawing.Size(0, 17);
            this.labelShwRadioChoice.TabIndex = 5;
            this.labelShwRadioChoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonBlue
            // 
            this.radioButtonBlue.AutoSize = true;
            this.radioButtonBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBlue.ForeColor = System.Drawing.Color.Blue;
            this.radioButtonBlue.Location = new System.Drawing.Point(27, 143);
            this.radioButtonBlue.Name = "radioButtonBlue";
            this.radioButtonBlue.Size = new System.Drawing.Size(98, 36);
            this.radioButtonBlue.TabIndex = 7;
            this.radioButtonBlue.TabStop = true;
            this.radioButtonBlue.Text = "Blue";
            this.radioButtonBlue.UseVisualStyleBackColor = true;
            this.radioButtonBlue.CheckedChanged += new System.EventHandler(this.radioButtonBlue_CheckedChanged);
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.AutoSize = true;
            this.radioButtonGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonGreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radioButtonGreen.Location = new System.Drawing.Point(27, 85);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(120, 36);
            this.radioButtonGreen.TabIndex = 2;
            this.radioButtonGreen.TabStop = true;
            this.radioButtonGreen.Text = "Green";
            this.radioButtonGreen.UseVisualStyleBackColor = true;
            this.radioButtonGreen.CheckedChanged += new System.EventHandler(this.radioButtonGreen_CheckedChanged);
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRed.ForeColor = System.Drawing.Color.Red;
            this.radioButtonRed.Location = new System.Drawing.Point(27, 29);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(98, 36);
            this.radioButtonRed.TabIndex = 1;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "RED";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            this.radioButtonRed.CheckedChanged += new System.EventHandler(this.radioButtonRed_CheckedChanged);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(2)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelRadioColor);
            this.Name = "Form5";
            this.Text = "Form5";
            this.panelRadioColor.ResumeLayout(false);
            this.panelRadioColor.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelRadioColor;
        private System.Windows.Forms.CheckBox checkBoxMessageBox;
        private System.Windows.Forms.Button buttonShwChoice;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelShwRadioChoice;
        private System.Windows.Forms.RadioButton radioButtonBlue;
        private System.Windows.Forms.RadioButton radioButtonGreen;
        private System.Windows.Forms.RadioButton radioButtonRed;
    }
}