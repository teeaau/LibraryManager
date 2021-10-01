
namespace UI.Styles
{
    partial class TabStyle
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
            this.btnTabClose = new System.Windows.Forms.Button();
            this.btnTabTitle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTabClose
            // 
            this.btnTabClose.BackColor = System.Drawing.Color.Transparent;
            this.btnTabClose.BackgroundImage = global::UI.Properties.Resources.icons8_cancel_50;
            this.btnTabClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTabClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTabClose.FlatAppearance.BorderSize = 0;
            this.btnTabClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTabClose.Location = new System.Drawing.Point(125, 0);
            this.btnTabClose.Name = "btnTabClose";
            this.btnTabClose.Size = new System.Drawing.Size(25, 25);
            this.btnTabClose.TabIndex = 0;
            this.btnTabClose.UseVisualStyleBackColor = false;
            // 
            // btnTabTitle
            // 
            this.btnTabTitle.BackColor = System.Drawing.Color.Transparent;
            this.btnTabTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTabTitle.FlatAppearance.BorderSize = 0;
            this.btnTabTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            this.btnTabTitle.Location = new System.Drawing.Point(0, 0);
            this.btnTabTitle.Name = "btnTabTitle";
            this.btnTabTitle.Size = new System.Drawing.Size(125, 25);
            this.btnTabTitle.TabIndex = 1;
            this.btnTabTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTabTitle.UseVisualStyleBackColor = false;
            // 
            // TabStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.Controls.Add(this.btnTabTitle);
            this.Controls.Add(this.btnTabClose);
            this.Name = "TabStyle";
            this.Size = new System.Drawing.Size(150, 25);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTabClose;
        private System.Windows.Forms.Button btnTabTitle;
    }
}
