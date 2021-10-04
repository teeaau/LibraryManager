
namespace UI.Views
{
    partial class MainView
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnResize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.pnlTabHeader = new System.Windows.Forms.Panel();
            this.pnlTabView = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.btnResize);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1225, 30);
            this.pnlHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(30, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quản lý thư viện";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::UI.Properties.Resources.icons8_address_book_50;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImage = global::UI.Properties.Resources.icons8_minimize_window_50;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(1135, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            // 
            // btnResize
            // 
            this.btnResize.BackgroundImage = global::UI.Properties.Resources.icons8_maximize_window_50;
            this.btnResize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnResize.FlatAppearance.BorderSize = 0;
            this.btnResize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResize.Location = new System.Drawing.Point(1165, 0);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(30, 30);
            this.btnResize.TabIndex = 1;
            this.btnResize.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::UI.Properties.Resources.icons8_delete_50;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1195, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.pnlNav.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNav.Location = new System.Drawing.Point(0, 30);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(300, 670);
            this.pnlNav.TabIndex = 1;
            // 
            // pnlTabHeader
            // 
            this.pnlTabHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlTabHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTabHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTabHeader.Location = new System.Drawing.Point(300, 30);
            this.pnlTabHeader.Name = "pnlTabHeader";
            this.pnlTabHeader.Size = new System.Drawing.Size(925, 25);
            this.pnlTabHeader.TabIndex = 2;
            // 
            // pnlTabView
            // 
            this.pnlTabView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTabView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTabView.Location = new System.Drawing.Point(300, 55);
            this.pnlTabView.Name = "pnlTabView";
            this.pnlTabView.Size = new System.Drawing.Size(925, 645);
            this.pnlTabView.TabIndex = 3;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1225, 700);
            this.ControlBox = false;
            this.Controls.Add(this.pnlTabView);
            this.Controls.Add(this.pnlTabHeader);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainView";
            this.Text = "MainView";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel pnlTabHeader;
        private System.Windows.Forms.Panel pnlTabView;
    }
}