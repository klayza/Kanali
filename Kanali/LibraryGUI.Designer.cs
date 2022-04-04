namespace Kanali
{
    partial class LibraryGUI
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
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonFill = new System.Windows.Forms.Button();
            this.buttonForwardImage = new System.Windows.Forms.Button();
            this.buttonBackImage = new System.Windows.Forms.Button();
            this.labelImageIndex = new System.Windows.Forms.Label();
            this.buttonZoomToFit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(12, 43);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(783, 417);
            this.pictureBoxImage.TabIndex = 0;
            this.pictureBoxImage.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonZoomToFit);
            this.panel1.Controls.Add(this.labelImageIndex);
            this.panel1.Controls.Add(this.buttonFill);
            this.panel1.Controls.Add(this.buttonForwardImage);
            this.panel1.Controls.Add(this.buttonBackImage);
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 33);
            this.panel1.TabIndex = 1;
            // 
            // buttonFill
            // 
            this.buttonFill.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFill.Location = new System.Drawing.Point(169, 5);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(75, 23);
            this.buttonFill.TabIndex = 2;
            this.buttonFill.Text = "Stretch";
            this.buttonFill.UseVisualStyleBackColor = true;
            this.buttonFill.Click += new System.EventHandler(this.buttonFill_Click);
            // 
            // buttonForwardImage
            // 
            this.buttonForwardImage.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForwardImage.Location = new System.Drawing.Point(88, 5);
            this.buttonForwardImage.Name = "buttonForwardImage";
            this.buttonForwardImage.Size = new System.Drawing.Size(75, 23);
            this.buttonForwardImage.TabIndex = 1;
            this.buttonForwardImage.Text = "-->";
            this.buttonForwardImage.UseVisualStyleBackColor = true;
            this.buttonForwardImage.Click += new System.EventHandler(this.buttonForwardImage_Click);
            // 
            // buttonBackImage
            // 
            this.buttonBackImage.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackImage.Location = new System.Drawing.Point(7, 5);
            this.buttonBackImage.Name = "buttonBackImage";
            this.buttonBackImage.Size = new System.Drawing.Size(75, 23);
            this.buttonBackImage.TabIndex = 0;
            this.buttonBackImage.Text = "<--";
            this.buttonBackImage.UseVisualStyleBackColor = true;
            this.buttonBackImage.Click += new System.EventHandler(this.buttonBackImage_Click);
            // 
            // labelImageIndex
            // 
            this.labelImageIndex.AutoSize = true;
            this.labelImageIndex.Location = new System.Drawing.Point(736, 10);
            this.labelImageIndex.Name = "labelImageIndex";
            this.labelImageIndex.Size = new System.Drawing.Size(0, 13);
            this.labelImageIndex.TabIndex = 4;
            // 
            // buttonZoomToFit
            // 
            this.buttonZoomToFit.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZoomToFit.Location = new System.Drawing.Point(250, 5);
            this.buttonZoomToFit.Name = "buttonZoomToFit";
            this.buttonZoomToFit.Size = new System.Drawing.Size(75, 23);
            this.buttonZoomToFit.TabIndex = 5;
            this.buttonZoomToFit.Text = "Fit";
            this.buttonZoomToFit.UseVisualStyleBackColor = true;
            this.buttonZoomToFit.Click += new System.EventHandler(this.buttonZoomToFit_Click);
            // 
            // LibraryGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 472);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxImage);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LibraryGUI";
            this.Text = "LibraryGUI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonForwardImage;
        private System.Windows.Forms.Button buttonBackImage;
        private System.Windows.Forms.Button buttonFill;
        private System.Windows.Forms.Label labelImageIndex;
        private System.Windows.Forms.Button buttonZoomToFit;
    }
}