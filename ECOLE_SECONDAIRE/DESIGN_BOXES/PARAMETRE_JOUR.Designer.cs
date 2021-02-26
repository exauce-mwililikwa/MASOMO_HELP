namespace ECOLE_SECONDAIRE.DESIGN_BOXES
{
    partial class PARAMETRE_JOUR
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
            this.label1 = new System.Windows.Forms.Label();
            this.JOURS = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NOMBRE_HEURE = new Guna.UI2.WinForms.Guna2TextBox();
            this.DUREE = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "JOUR";
            // 
            // JOURS
            // 
            this.JOURS.BackColor = System.Drawing.Color.Transparent;
            this.JOURS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.JOURS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JOURS.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.JOURS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.JOURS.FocusedState.Parent = this.JOURS;
            this.JOURS.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.JOURS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.JOURS.HoverState.Parent = this.JOURS;
            this.JOURS.ItemHeight = 30;
            this.JOURS.Items.AddRange(new object[] {
            "LUNDI",
            "MARDI",
            "MERCREDI",
            "JEUDI",
            "VENDREDI",
            "SAMEDI"});
            this.JOURS.ItemsAppearance.Parent = this.JOURS;
            this.JOURS.Location = new System.Drawing.Point(68, 20);
            this.JOURS.Name = "JOURS";
            this.JOURS.ShadowDecoration.Parent = this.JOURS;
            this.JOURS.Size = new System.Drawing.Size(148, 36);
            this.JOURS.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOMBRE D\'HEURE";
            // 
            // NOMBRE_HEURE
            // 
            this.NOMBRE_HEURE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NOMBRE_HEURE.DefaultText = "";
            this.NOMBRE_HEURE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NOMBRE_HEURE.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NOMBRE_HEURE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NOMBRE_HEURE.DisabledState.Parent = this.NOMBRE_HEURE;
            this.NOMBRE_HEURE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NOMBRE_HEURE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NOMBRE_HEURE.FocusedState.Parent = this.NOMBRE_HEURE;
            this.NOMBRE_HEURE.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NOMBRE_HEURE.HoverState.Parent = this.NOMBRE_HEURE;
            this.NOMBRE_HEURE.Location = new System.Drawing.Point(367, 20);
            this.NOMBRE_HEURE.Name = "NOMBRE_HEURE";
            this.NOMBRE_HEURE.PasswordChar = '\0';
            this.NOMBRE_HEURE.PlaceholderText = "";
            this.NOMBRE_HEURE.SelectedText = "";
            this.NOMBRE_HEURE.ShadowDecoration.Parent = this.NOMBRE_HEURE;
            this.NOMBRE_HEURE.Size = new System.Drawing.Size(57, 36);
            this.NOMBRE_HEURE.TabIndex = 3;
            // 
            // DUREE
            // 
            this.DUREE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DUREE.DefaultText = "";
            this.DUREE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DUREE.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DUREE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DUREE.DisabledState.Parent = this.DUREE;
            this.DUREE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DUREE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DUREE.FocusedState.Parent = this.DUREE;
            this.DUREE.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DUREE.HoverState.Parent = this.DUREE;
            this.DUREE.Location = new System.Drawing.Point(68, 78);
            this.DUREE.Name = "DUREE";
            this.DUREE.PasswordChar = '\0';
            this.DUREE.PlaceholderText = "";
            this.DUREE.SelectedText = "";
            this.DUREE.ShadowDecoration.Parent = this.DUREE;
            this.DUREE.Size = new System.Drawing.Size(101, 36);
            this.DUREE.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DUREE";
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.Parent = this.guna2TextBox3;
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.FocusedState.Parent = this.guna2TextBox3;
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.HoverState.Parent = this.guna2TextBox3;
            this.guna2TextBox3.Location = new System.Drawing.Point(367, 78);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PasswordChar = '\0';
            this.guna2TextBox3.PlaceholderText = "";
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.ShadowDecoration.Parent = this.guna2TextBox3;
            this.guna2TextBox3.Size = new System.Drawing.Size(57, 36);
            this.guna2TextBox3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "DUREE";
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(244, 145);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 8;
            this.guna2Button1.Text = "MODIFIER";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // PARAMETRE_JOUR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 215);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2TextBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DUREE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NOMBRE_HEURE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.JOURS);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PARAMETRE_JOUR";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PARAMETRE_JOUR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox JOURS;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox NOMBRE_HEURE;
        private Guna.UI2.WinForms.Guna2TextBox DUREE;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;

    }
}
