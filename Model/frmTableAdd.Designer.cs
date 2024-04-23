namespace PointofSale.Model
{
    partial class frmTableAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTableAdd));
            this.label2 = new System.Windows.Forms.Label();
            this.TextName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ShadowPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(120, 21);
            this.label1.Size = new System.Drawing.Size(217, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "TABLE DETAILS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // TextName
            // 
            this.TextName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextName.BorderRadius = 10;
            this.TextName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextName.DefaultText = "";
            this.TextName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextName.IconLeft = ((System.Drawing.Image)(resources.GetObject("TextName.IconLeft")));
            this.TextName.Location = new System.Drawing.Point(48, 148);
            this.TextName.Name = "TextName";
            this.TextName.PasswordChar = '\0';
            this.TextName.PlaceholderText = "Name";
            this.TextName.SelectedText = "";
            this.TextName.Size = new System.Drawing.Size(329, 50);
            this.TextName.TabIndex = 0;
            // 
            // frmTableAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 317);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextName);
            this.Name = "frmTableAdd";
            this.Text = "frmTableAdd";
            this.Controls.SetChildIndex(this.guna2ShadowPanel2, 0);
            this.Controls.SetChildIndex(this.TextName, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2TextBox TextName;
    }
}