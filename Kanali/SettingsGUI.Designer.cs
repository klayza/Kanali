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
            this.textBoxDownloadDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxMediaScrolling = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSaveAndExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonChooseFolder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDownloadDirectory
            // 
            this.textBoxDownloadDirectory.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDownloadDirectory.Location = new System.Drawing.Point(21, 63);
            this.textBoxDownloadDirectory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDownloadDirectory.Name = "textBoxDownloadDirectory";
            this.textBoxDownloadDirectory.Size = new System.Drawing.Size(615, 43);
            this.textBoxDownloadDirectory.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Downloads Directory";
            // 
            // checkBoxMediaScrolling
            // 
            this.checkBoxMediaScrolling.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F);
            this.checkBoxMediaScrolling.ForeColor = System.Drawing.Color.White;
            this.checkBoxMediaScrolling.Location = new System.Drawing.Point(21, 172);
            this.checkBoxMediaScrolling.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxMediaScrolling.Name = "checkBoxMediaScrolling";
            this.checkBoxMediaScrolling.Size = new System.Drawing.Size(137, 37);
            this.checkBoxMediaScrolling.TabIndex = 0;
            this.checkBoxMediaScrolling.Text = "True";
            this.checkBoxMediaScrolling.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(494, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Media scrolling on title screen:";
            // 
            // buttonSaveAndExit
            // 
            this.buttonSaveAndExit.ForeColor = System.Drawing.Color.Black;
            this.buttonSaveAndExit.Location = new System.Drawing.Point(17, 12);
            this.buttonSaveAndExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSaveAndExit.Name = "buttonSaveAndExit";
            this.buttonSaveAndExit.Size = new System.Drawing.Size(144, 28);
            this.buttonSaveAndExit.TabIndex = 5;
            this.buttonSaveAndExit.Text = "Save and Exit";
            this.buttonSaveAndExit.UseVisualStyleBackColor = true;
            this.buttonSaveAndExit.Click += new System.EventHandler(this.buttonSaveAndExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(139)))), ((int)(((byte)(210)))));
            this.panel1.Controls.Add(this.buttonSaveAndExit);
            this.panel1.Location = new System.Drawing.Point(-3, 496);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 52);
            this.panel1.TabIndex = 6;
            // 
            // buttonChooseFolder
            // 
            this.buttonChooseFolder.Location = new System.Drawing.Point(341, 27);
            this.buttonChooseFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonChooseFolder.Name = "buttonChooseFolder";
            this.buttonChooseFolder.Size = new System.Drawing.Size(100, 28);
            this.buttonChooseFolder.TabIndex = 7;
            this.buttonChooseFolder.Text = "Browse";
            this.buttonChooseFolder.UseVisualStyleBackColor = true;
            this.buttonChooseFolder.Click += new System.EventHandler(this.buttonChooseFolder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(103, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "(Must have at least one favorited)";
            // 
            // SettingsGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(795, 546);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonChooseFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDownloadDirectory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBoxMediaScrolling);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(813, 593);
            this.MinimumSize = new System.Drawing.Size(813, 593);
            this.Name = "SettingsGUI";
            this.Text = "SettingsGUI";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDownloadDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxMediaScrolling;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSaveAndExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonChooseFolder;
        private System.Windows.Forms.Label label3;
    }
}