namespace Kanali
{
    partial class SettingsGUI
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.checkBoxMediaScrolling = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSaveAndExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(16, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(462, 36);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Downloads Directory";
            // 
            // checkBoxMediaScrolling
            // 
            this.checkBoxMediaScrolling.ForeColor = System.Drawing.Color.White;
            this.checkBoxMediaScrolling.Location = new System.Drawing.Point(16, 140);
            this.checkBoxMediaScrolling.Name = "checkBoxMediaScrolling";
            this.checkBoxMediaScrolling.Size = new System.Drawing.Size(88, 20);
            this.checkBoxMediaScrolling.TabIndex = 0;
            this.checkBoxMediaScrolling.Text = "True";
            this.checkBoxMediaScrolling.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(466, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enable media scrolling on title screen";
            // 
            // buttonSaveAndExit
            // 
            this.buttonSaveAndExit.ForeColor = System.Drawing.Color.Black;
            this.buttonSaveAndExit.Location = new System.Drawing.Point(13, 10);
            this.buttonSaveAndExit.Name = "buttonSaveAndExit";
            this.buttonSaveAndExit.Size = new System.Drawing.Size(108, 23);
            this.buttonSaveAndExit.TabIndex = 5;
            this.buttonSaveAndExit.Text = "Save and Exit";
            this.buttonSaveAndExit.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(139)))), ((int)(((byte)(210)))));
            this.panel1.Controls.Add(this.buttonSaveAndExit);
            this.panel1.Location = new System.Drawing.Point(-2, 403);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 42);
            this.panel1.TabIndex = 6;
            // 
            // SettingsGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(596, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBoxMediaScrolling);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "SettingsGUI";
            this.Text = "SettingsGUI";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox checkBoxMediaScrolling;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSaveAndExit;
        private System.Windows.Forms.Panel panel1;
    }
}