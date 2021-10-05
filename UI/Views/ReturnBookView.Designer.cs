
namespace UI.Views
{
    partial class ReturnBookView
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlDocGia = new System.Windows.Forms.Panel();
            this.cbbTenDG = new System.Windows.Forms.ComboBox();
            this.cbbMaThe = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSach = new System.Windows.Forms.Panel();
            this.pnlDocGia.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Image = global::UI.Properties.Resources.icons8_tick_box_50;
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturn.Location = new System.Drawing.Point(709, 43);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(148, 44);
            this.btnReturn.TabIndex = 22;
            this.btnReturn.Text = "Trả sách";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // pnlDocGia
            // 
            this.pnlDocGia.Controls.Add(this.cbbTenDG);
            this.pnlDocGia.Controls.Add(this.cbbMaThe);
            this.pnlDocGia.Controls.Add(this.btnReturn);
            this.pnlDocGia.Controls.Add(this.label4);
            this.pnlDocGia.Controls.Add(this.label1);
            this.pnlDocGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDocGia.Location = new System.Drawing.Point(20, 20);
            this.pnlDocGia.Name = "pnlDocGia";
            this.pnlDocGia.Size = new System.Drawing.Size(885, 115);
            this.pnlDocGia.TabIndex = 2;
            // 
            // cbbTenDG
            // 
            this.cbbTenDG.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbTenDG.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbTenDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenDG.FormattingEnabled = true;
            this.cbbTenDG.Location = new System.Drawing.Point(177, 70);
            this.cbbTenDG.Name = "cbbTenDG";
            this.cbbTenDG.Size = new System.Drawing.Size(450, 28);
            this.cbbTenDG.TabIndex = 24;
            // 
            // cbbMaThe
            // 
            this.cbbMaThe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbMaThe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbMaThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaThe.FormattingEnabled = true;
            this.cbbMaThe.Location = new System.Drawing.Point(177, 30);
            this.cbbMaThe.Name = "cbbMaThe";
            this.cbbMaThe.Size = new System.Drawing.Size(450, 28);
            this.cbbMaThe.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tên độc giả:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã thẻ";
            // 
            // pnlSach
            // 
            this.pnlSach.AutoScroll = true;
            this.pnlSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSach.Location = new System.Drawing.Point(20, 135);
            this.pnlSach.Name = "pnlSach";
            this.pnlSach.Padding = new System.Windows.Forms.Padding(20);
            this.pnlSach.Size = new System.Drawing.Size(885, 490);
            this.pnlSach.TabIndex = 4;
            // 
            // ReturnBookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlSach);
            this.Controls.Add(this.pnlDocGia);
            this.Name = "ReturnBookView";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(925, 645);
            this.pnlDocGia.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlDocGia;
        private System.Windows.Forms.ComboBox cbbTenDG;
        private System.Windows.Forms.ComboBox cbbMaThe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSach;
    }
}
