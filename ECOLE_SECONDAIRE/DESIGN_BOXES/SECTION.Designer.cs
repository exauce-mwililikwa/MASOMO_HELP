namespace ECOLE_SECONDAIRE.DESIGN_BOXES
{
    partial class SECTION
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
            this.label2 = new System.Windows.Forms.Label();
            this.DESIGNATION = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SIGLE = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ENTRER LE NOM DE LA SECTION";
            // 
            // DESIGNATION
            // 
            this.DESIGNATION.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.DESIGNATION.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DESIGNATION.DefaultText = "";
            this.DESIGNATION.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DESIGNATION.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DESIGNATION.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DESIGNATION.DisabledState.Parent = this.DESIGNATION;
            this.DESIGNATION.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DESIGNATION.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DESIGNATION.FocusedState.Parent = this.DESIGNATION;
            this.DESIGNATION.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DESIGNATION.HoverState.Parent = this.DESIGNATION;
            this.DESIGNATION.Location = new System.Drawing.Point(12, 38);
            this.DESIGNATION.Name = "DESIGNATION";
            this.DESIGNATION.PasswordChar = '\0';
            this.DESIGNATION.PlaceholderText = "";
            this.DESIGNATION.SelectedText = "";
            this.DESIGNATION.ShadowDecoration.Parent = this.DESIGNATION;
            this.DESIGNATION.Size = new System.Drawing.Size(200, 36);
            this.DESIGNATION.TabIndex = 3;
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 21;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::ECOLE_SECONDAIRE.Properties.Resources.Save_48px;
            this.guna2Button1.Location = new System.Drawing.Point(12, 154);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(200, 45);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "SAUVEGARDER";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // SIGLE
            // 
            this.SIGLE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SIGLE.DefaultText = "";
            this.SIGLE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SIGLE.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SIGLE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SIGLE.DisabledState.Parent = this.SIGLE;
            this.SIGLE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SIGLE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SIGLE.FocusedState.Parent = this.SIGLE;
            this.SIGLE.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SIGLE.HoverState.Parent = this.SIGLE;
            this.SIGLE.Location = new System.Drawing.Point(12, 112);
            this.SIGLE.MaxLength = 5;
            this.SIGLE.Name = "SIGLE";
            this.SIGLE.PasswordChar = '\0';
            this.SIGLE.PlaceholderText = "";
            this.SIGLE.SelectedText = "";
            this.SIGLE.ShadowDecoration.Parent = this.SIGLE;
            this.SIGLE.Size = new System.Drawing.Size(200, 36);
            this.SIGLE.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ENTRER LE SIGLE DE LA SECTION";
            // 
            // SECTION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(226, 211);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SIGLE);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.DESIGNATION);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SECTION";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SECTION";
            this.Load += new System.EventHandler(this.SECTION_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox DESIGNATION;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox SIGLE;
        private System.Windows.Forms.Label label1;

    }
}
