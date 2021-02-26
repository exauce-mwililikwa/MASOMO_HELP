namespace ECOLE_SECONDAIRE.DESIGN_BOXES
{
    partial class NOVEAU_TRAVAIL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.DESIGNATION = new Guna.UI2.WinForms.Guna2TextBox();
            this.MAXIMUM = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // DESIGNATION
            // 
            this.DESIGNATION.Animated = true;
            this.DESIGNATION.BorderColor = System.Drawing.Color.Black;
            this.DESIGNATION.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DESIGNATION.DefaultText = "";
            this.DESIGNATION.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DESIGNATION.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DESIGNATION.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DESIGNATION.DisabledState.Parent = this.DESIGNATION;
            this.DESIGNATION.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DESIGNATION.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DESIGNATION.FocusedState.Parent = this.DESIGNATION;
            this.DESIGNATION.ForeColor = System.Drawing.Color.Black;
            this.DESIGNATION.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DESIGNATION.HoverState.Parent = this.DESIGNATION;
            this.DESIGNATION.Location = new System.Drawing.Point(36, 26);
            this.DESIGNATION.Name = "DESIGNATION";
            this.DESIGNATION.PasswordChar = '\0';
            this.DESIGNATION.PlaceholderForeColor = System.Drawing.Color.Black;
            this.DESIGNATION.PlaceholderText = "Entrer le motif du travail";
            this.DESIGNATION.SelectedText = "";
            this.DESIGNATION.ShadowDecoration.Parent = this.DESIGNATION;
            this.DESIGNATION.Size = new System.Drawing.Size(304, 36);
            this.DESIGNATION.TabIndex = 0;
            // 
            // MAXIMUM
            // 
            this.MAXIMUM.Animated = true;
            this.MAXIMUM.BorderColor = System.Drawing.Color.Black;
            this.MAXIMUM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MAXIMUM.DefaultText = "";
            this.MAXIMUM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MAXIMUM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MAXIMUM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MAXIMUM.DisabledState.Parent = this.MAXIMUM;
            this.MAXIMUM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MAXIMUM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MAXIMUM.FocusedState.Parent = this.MAXIMUM;
            this.MAXIMUM.ForeColor = System.Drawing.Color.Black;
            this.MAXIMUM.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MAXIMUM.HoverState.Parent = this.MAXIMUM;
            this.MAXIMUM.Location = new System.Drawing.Point(36, 86);
            this.MAXIMUM.Name = "MAXIMUM";
            this.MAXIMUM.PasswordChar = '\0';
            this.MAXIMUM.PlaceholderForeColor = System.Drawing.Color.Black;
            this.MAXIMUM.PlaceholderText = "Entrer le maximun";
            this.MAXIMUM.SelectedText = "";
            this.MAXIMUM.ShadowDecoration.Parent = this.MAXIMUM;
            this.MAXIMUM.Size = new System.Drawing.Size(304, 36);
            this.MAXIMUM.TabIndex = 1;
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(36, 140);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(303, 45);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "SAUVEGARDER";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // NOVEAU_TRAVAIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 197);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.MAXIMUM);
            this.Controls.Add(this.DESIGNATION);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NOVEAU_TRAVAIL";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NOVEAU_TRAVAIL";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox DESIGNATION;
        private Guna.UI2.WinForms.Guna2TextBox MAXIMUM;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;

    }
}
