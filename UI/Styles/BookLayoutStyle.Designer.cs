
namespace UI.Styles
{
    partial class BookLayoutStyle
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ptbImage = new System.Windows.Forms.PictureBox();
            this.chbBorrow = new System.Windows.Forms.CheckBox();
            this.lblBookName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbImage
            // 
            this.ptbImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptbImage.Location = new System.Drawing.Point(10, 10);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(180, 180);
            this.ptbImage.TabIndex = 0;
            this.ptbImage.TabStop = false;
            // 
            // chbBorrow
            // 
            this.chbBorrow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chbBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbBorrow.Location = new System.Drawing.Point(10, 260);
            this.chbBorrow.Name = "chbBorrow";
            this.chbBorrow.Size = new System.Drawing.Size(180, 30);
            this.chbBorrow.TabIndex = 4;
            this.chbBorrow.Text = "Đặt mượn";
            this.chbBorrow.UseVisualStyleBackColor = true;
            // 
            // lblBookName
            // 
            this.lblBookName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBookName.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Location = new System.Drawing.Point(10, 190);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(180, 70);
            this.lblBookName.TabIndex = 5;
            this.lblBookName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BookLayoutStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.chbBorrow);
            this.Controls.Add(this.ptbImage);
            this.Name = "BookLayoutStyle";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(200, 300);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox ptbImage;
        public System.Windows.Forms.CheckBox chbBorrow;
        public System.Windows.Forms.Label lblBookName;
    }
}
