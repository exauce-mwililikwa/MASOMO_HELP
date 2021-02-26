namespace ECOLE_SECONDAIRE.DESIGN_USER_CONTROL
{
    partial class AJOUT_AGENT
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AGENT_TABLE = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DATE = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.PRENOM = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.POSTNOM = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NOM = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DEPARTEMENT = new Guna.UI2.WinForms.Guna2ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.NUMERO = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.AVENU = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.QUARTIER = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.VILLE = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TELEPHONE = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AGENT_TABLE)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.AGENT_TABLE);
            this.panel1.Location = new System.Drawing.Point(768, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 816);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(413, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "ENTRER LE NOM DE L\'AGENT";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AGENT_TABLE
            // 
            this.AGENT_TABLE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AGENT_TABLE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AGENT_TABLE.Location = new System.Drawing.Point(16, 48);
            this.AGENT_TABLE.Name = "AGENT_TABLE";
            this.AGENT_TABLE.Size = new System.Drawing.Size(596, 599);
            this.AGENT_TABLE.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.DATE);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.PRENOM);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.POSTNOM);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NOM);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 234);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IDENTITE";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(647, 173);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(49, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Parcourir";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ECOLE_SECONDAIRE.Properties.Resources.avtar_7;
            this.pictureBox1.Location = new System.Drawing.Point(597, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // DATE
            // 
            this.DATE.AutoRoundedCorners = true;
            this.DATE.BorderRadius = 17;
            this.DATE.BorderThickness = 1;
            this.DATE.CheckedState.Parent = this.DATE;
            this.DATE.FillColor = System.Drawing.Color.White;
            this.DATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DATE.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DATE.HoverState.Parent = this.DATE;
            this.DATE.Location = new System.Drawing.Point(10, 150);
            this.DATE.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DATE.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DATE.Name = "DATE";
            this.DATE.ShadowDecoration.Parent = this.DATE;
            this.DATE.Size = new System.Drawing.Size(200, 36);
            this.DATE.TabIndex = 7;
            this.DATE.Value = new System.DateTime(2021, 1, 12, 21, 58, 26, 413);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "DATE DE NAISSANCE";
            // 
            // PRENOM
            // 
            this.PRENOM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.PRENOM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PRENOM.DefaultText = "";
            this.PRENOM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PRENOM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PRENOM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PRENOM.DisabledState.Parent = this.PRENOM;
            this.PRENOM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PRENOM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PRENOM.FocusedState.Parent = this.PRENOM;
            this.PRENOM.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PRENOM.HoverState.Parent = this.PRENOM;
            this.PRENOM.Location = new System.Drawing.Point(314, 149);
            this.PRENOM.Name = "PRENOM";
            this.PRENOM.PasswordChar = '\0';
            this.PRENOM.PlaceholderText = "";
            this.PRENOM.SelectedText = "";
            this.PRENOM.ShadowDecoration.Parent = this.PRENOM;
            this.PRENOM.Size = new System.Drawing.Size(200, 36);
            this.PRENOM.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "PRENOM";
            // 
            // POSTNOM
            // 
            this.POSTNOM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.POSTNOM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.POSTNOM.DefaultText = "";
            this.POSTNOM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.POSTNOM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.POSTNOM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.POSTNOM.DisabledState.Parent = this.POSTNOM;
            this.POSTNOM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.POSTNOM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.POSTNOM.FocusedState.Parent = this.POSTNOM;
            this.POSTNOM.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.POSTNOM.HoverState.Parent = this.POSTNOM;
            this.POSTNOM.Location = new System.Drawing.Point(314, 63);
            this.POSTNOM.Name = "POSTNOM";
            this.POSTNOM.PasswordChar = '\0';
            this.POSTNOM.PlaceholderText = "";
            this.POSTNOM.SelectedText = "";
            this.POSTNOM.ShadowDecoration.Parent = this.POSTNOM;
            this.POSTNOM.Size = new System.Drawing.Size(200, 36);
            this.POSTNOM.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "POSTNOM";
            // 
            // NOM
            // 
            this.NOM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NOM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NOM.DefaultText = "";
            this.NOM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NOM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NOM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NOM.DisabledState.Parent = this.NOM;
            this.NOM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NOM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NOM.FocusedState.Parent = this.NOM;
            this.NOM.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NOM.HoverState.Parent = this.NOM;
            this.NOM.Location = new System.Drawing.Point(7, 54);
            this.NOM.Name = "NOM";
            this.NOM.PasswordChar = '\0';
            this.NOM.PlaceholderText = "";
            this.NOM.SelectedText = "";
            this.NOM.ShadowDecoration.Parent = this.NOM;
            this.NOM.Size = new System.Drawing.Size(200, 36);
            this.NOM.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOM";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.DEPARTEMENT);
            this.groupBox2.Location = new System.Drawing.Point(394, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 114);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AFFECTATION";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "NOMBRE ENREGISTRER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "DEPARTEMENT";
            // 
            // DEPARTEMENT
            // 
            this.DEPARTEMENT.AutoRoundedCorners = true;
            this.DEPARTEMENT.BackColor = System.Drawing.Color.Transparent;
            this.DEPARTEMENT.BorderRadius = 17;
            this.DEPARTEMENT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DEPARTEMENT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DEPARTEMENT.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DEPARTEMENT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DEPARTEMENT.FocusedState.Parent = this.DEPARTEMENT;
            this.DEPARTEMENT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DEPARTEMENT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.DEPARTEMENT.HoverState.Parent = this.DEPARTEMENT;
            this.DEPARTEMENT.ItemHeight = 30;
            this.DEPARTEMENT.ItemsAppearance.Parent = this.DEPARTEMENT;
            this.DEPARTEMENT.Location = new System.Drawing.Point(6, 60);
            this.DEPARTEMENT.Name = "DEPARTEMENT";
            this.DEPARTEMENT.ShadowDecoration.Parent = this.DEPARTEMENT;
            this.DEPARTEMENT.Size = new System.Drawing.Size(140, 36);
            this.DEPARTEMENT.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.guna2Button1);
            this.groupBox3.Controls.Add(this.NUMERO);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.AVENU);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.QUARTIER);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.VILLE);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TELEPHONE);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(3, 363);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(759, 208);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ADDRESSE";
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
            this.guna2Button1.Location = new System.Drawing.Point(528, 140);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(200, 45);
            this.guna2Button1.TabIndex = 12;
            this.guna2Button1.Text = "ENREGISTRER";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // NUMERO
            // 
            this.NUMERO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NUMERO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NUMERO.DefaultText = "";
            this.NUMERO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NUMERO.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NUMERO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NUMERO.DisabledState.Parent = this.NUMERO;
            this.NUMERO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NUMERO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NUMERO.FocusedState.Parent = this.NUMERO;
            this.NUMERO.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NUMERO.HoverState.Parent = this.NUMERO;
            this.NUMERO.Location = new System.Drawing.Point(277, 150);
            this.NUMERO.Name = "NUMERO";
            this.NUMERO.PasswordChar = '\0';
            this.NUMERO.PlaceholderText = "";
            this.NUMERO.SelectedText = "";
            this.NUMERO.ShadowDecoration.Parent = this.NUMERO;
            this.NUMERO.Size = new System.Drawing.Size(200, 36);
            this.NUMERO.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(274, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "NUMERO";
            // 
            // AVENU
            // 
            this.AVENU.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.AVENU.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AVENU.DefaultText = "";
            this.AVENU.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AVENU.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AVENU.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AVENU.DisabledState.Parent = this.AVENU;
            this.AVENU.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AVENU.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AVENU.FocusedState.Parent = this.AVENU;
            this.AVENU.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AVENU.HoverState.Parent = this.AVENU;
            this.AVENU.Location = new System.Drawing.Point(10, 150);
            this.AVENU.Name = "AVENU";
            this.AVENU.PasswordChar = '\0';
            this.AVENU.PlaceholderText = "";
            this.AVENU.SelectedText = "";
            this.AVENU.ShadowDecoration.Parent = this.AVENU;
            this.AVENU.Size = new System.Drawing.Size(200, 36);
            this.AVENU.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "AVENU";
            // 
            // QUARTIER
            // 
            this.QUARTIER.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.QUARTIER.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QUARTIER.DefaultText = "";
            this.QUARTIER.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.QUARTIER.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.QUARTIER.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QUARTIER.DisabledState.Parent = this.QUARTIER;
            this.QUARTIER.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QUARTIER.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QUARTIER.FocusedState.Parent = this.QUARTIER;
            this.QUARTIER.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QUARTIER.HoverState.Parent = this.QUARTIER;
            this.QUARTIER.Location = new System.Drawing.Point(528, 56);
            this.QUARTIER.Name = "QUARTIER";
            this.QUARTIER.PasswordChar = '\0';
            this.QUARTIER.PlaceholderText = "";
            this.QUARTIER.SelectedText = "";
            this.QUARTIER.ShadowDecoration.Parent = this.QUARTIER;
            this.QUARTIER.Size = new System.Drawing.Size(200, 36);
            this.QUARTIER.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(525, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "QUARTIER";
            // 
            // VILLE
            // 
            this.VILLE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.VILLE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.VILLE.DefaultText = "";
            this.VILLE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.VILLE.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.VILLE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.VILLE.DisabledState.Parent = this.VILLE;
            this.VILLE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.VILLE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.VILLE.FocusedState.Parent = this.VILLE;
            this.VILLE.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.VILLE.HoverState.Parent = this.VILLE;
            this.VILLE.Location = new System.Drawing.Point(277, 56);
            this.VILLE.Name = "VILLE";
            this.VILLE.PasswordChar = '\0';
            this.VILLE.PlaceholderText = "";
            this.VILLE.SelectedText = "";
            this.VILLE.ShadowDecoration.Parent = this.VILLE;
            this.VILLE.Size = new System.Drawing.Size(200, 36);
            this.VILLE.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(274, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "VILLE";
            // 
            // TELEPHONE
            // 
            this.TELEPHONE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TELEPHONE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TELEPHONE.DefaultText = "";
            this.TELEPHONE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TELEPHONE.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TELEPHONE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TELEPHONE.DisabledState.Parent = this.TELEPHONE;
            this.TELEPHONE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TELEPHONE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TELEPHONE.FocusedState.Parent = this.TELEPHONE;
            this.TELEPHONE.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TELEPHONE.HoverState.Parent = this.TELEPHONE;
            this.TELEPHONE.Location = new System.Drawing.Point(10, 56);
            this.TELEPHONE.Name = "TELEPHONE";
            this.TELEPHONE.PasswordChar = '\0';
            this.TELEPHONE.PlaceholderText = "";
            this.TELEPHONE.SelectedText = "";
            this.TELEPHONE.ShadowDecoration.Parent = this.TELEPHONE;
            this.TELEPHONE.Size = new System.Drawing.Size(200, 36);
            this.TELEPHONE.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "TELEPHONE";
            // 
            // AJOUT_AGENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "AJOUT_AGENT";
            this.Size = new System.Drawing.Size(1398, 819);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AGENT_TABLE)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox PRENOM;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox POSTNOM;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox NOM;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker DATE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView AGENT_TABLE;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox DEPARTEMENT;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI2.WinForms.Guna2TextBox NUMERO;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox AVENU;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox QUARTIER;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox VILLE;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox TELEPHONE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;





    }
}
