namespace ECOLE_SECONDAIRE.DESIGN_USER_CONTROL
{
    partial class HORAIRE_HEBDOMADAIRE
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DESIGNATION = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ABREVIATION = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NIVEAU = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NOMBRE_COURS = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TITULAIRE = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.NOMBRE_PLACE = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NOMBRE_ELEVE = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DESIGNATION_SALLE = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.DEJA_PROGRAMMER = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.NOMBRE_HEURE = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.COURS = new System.Windows.Forms.Label();
            this.SALLE = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.HEURE = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.JOUR = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.MATRICULE = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.PRENOM = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.POSTNOM = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.NOM = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DESIGNATION);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ABREVIATION);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NIVEAU);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SALLE";
            // 
            // DESIGNATION
            // 
            this.DESIGNATION.AutoRoundedCorners = true;
            this.DESIGNATION.BackColor = System.Drawing.Color.Transparent;
            this.DESIGNATION.BorderRadius = 17;
            this.DESIGNATION.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DESIGNATION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DESIGNATION.Enabled = false;
            this.DESIGNATION.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DESIGNATION.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DESIGNATION.FocusedState.Parent = this.DESIGNATION;
            this.DESIGNATION.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DESIGNATION.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.DESIGNATION.HoverState.Parent = this.DESIGNATION;
            this.DESIGNATION.ItemHeight = 30;
            this.DESIGNATION.ItemsAppearance.Parent = this.DESIGNATION;
            this.DESIGNATION.Location = new System.Drawing.Point(202, 150);
            this.DESIGNATION.Name = "DESIGNATION";
            this.DESIGNATION.ShadowDecoration.Parent = this.DESIGNATION;
            this.DESIGNATION.Size = new System.Drawing.Size(140, 36);
            this.DESIGNATION.TabIndex = 5;
            this.DESIGNATION.SelectedIndexChanged += new System.EventHandler(this.ABREVIATION_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "SECTION";
            // 
            // ABREVIATION
            // 
            this.ABREVIATION.AutoRoundedCorners = true;
            this.ABREVIATION.BackColor = System.Drawing.Color.Transparent;
            this.ABREVIATION.BorderRadius = 17;
            this.ABREVIATION.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ABREVIATION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ABREVIATION.Enabled = false;
            this.ABREVIATION.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ABREVIATION.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ABREVIATION.FocusedState.Parent = this.ABREVIATION;
            this.ABREVIATION.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ABREVIATION.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ABREVIATION.HoverState.Parent = this.ABREVIATION;
            this.ABREVIATION.ItemHeight = 30;
            this.ABREVIATION.ItemsAppearance.Parent = this.ABREVIATION;
            this.ABREVIATION.Location = new System.Drawing.Point(202, 86);
            this.ABREVIATION.Name = "ABREVIATION";
            this.ABREVIATION.ShadowDecoration.Parent = this.ABREVIATION;
            this.ABREVIATION.Size = new System.Drawing.Size(140, 36);
            this.ABREVIATION.TabIndex = 3;
            this.ABREVIATION.SelectedIndexChanged += new System.EventHandler(this.DESIGNATION_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SECTION";
            // 
            // NIVEAU
            // 
            this.NIVEAU.AutoRoundedCorners = true;
            this.NIVEAU.BackColor = System.Drawing.Color.Transparent;
            this.NIVEAU.BorderRadius = 17;
            this.NIVEAU.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.NIVEAU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NIVEAU.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NIVEAU.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NIVEAU.FocusedState.Parent = this.NIVEAU;
            this.NIVEAU.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.NIVEAU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.NIVEAU.HoverState.Parent = this.NIVEAU;
            this.NIVEAU.ItemHeight = 30;
            this.NIVEAU.ItemsAppearance.Parent = this.NIVEAU;
            this.NIVEAU.Location = new System.Drawing.Point(202, 18);
            this.NIVEAU.Name = "NIVEAU";
            this.NIVEAU.ShadowDecoration.Parent = this.NIVEAU;
            this.NIVEAU.Size = new System.Drawing.Size(140, 36);
            this.NIVEAU.TabIndex = 1;
            this.NIVEAU.SelectedIndexChanged += new System.EventHandler(this.NIVEAU_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIVEAU";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NOMBRE_COURS);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.TITULAIRE);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.NOMBRE_PLACE);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.NOMBRE_ELEVE);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.DESIGNATION_SALLE);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(395, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1000, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INFORMATION SALLE";
            // 
            // NOMBRE_COURS
            // 
            this.NOMBRE_COURS.AutoSize = true;
            this.NOMBRE_COURS.Location = new System.Drawing.Point(786, 74);
            this.NOMBRE_COURS.Name = "NOMBRE_COURS";
            this.NOMBRE_COURS.Size = new System.Drawing.Size(15, 17);
            this.NOMBRE_COURS.TabIndex = 9;
            this.NOMBRE_COURS.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(786, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 17);
            this.label13.TabIndex = 8;
            this.label13.Text = "NOMBRE DE COURS";
            // 
            // TITULAIRE
            // 
            this.TITULAIRE.AutoSize = true;
            this.TITULAIRE.Location = new System.Drawing.Point(606, 74);
            this.TITULAIRE.Name = "TITULAIRE";
            this.TITULAIRE.Size = new System.Drawing.Size(15, 17);
            this.TITULAIRE.TabIndex = 7;
            this.TITULAIRE.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(606, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "TITULAIRE";
            // 
            // NOMBRE_PLACE
            // 
            this.NOMBRE_PLACE.AutoSize = true;
            this.NOMBRE_PLACE.Location = new System.Drawing.Point(371, 74);
            this.NOMBRE_PLACE.Name = "NOMBRE_PLACE";
            this.NOMBRE_PLACE.Size = new System.Drawing.Size(15, 17);
            this.NOMBRE_PLACE.TabIndex = 5;
            this.NOMBRE_PLACE.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(371, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "NOMBRE DE PLACE";
            // 
            // NOMBRE_ELEVE
            // 
            this.NOMBRE_ELEVE.AutoSize = true;
            this.NOMBRE_ELEVE.Location = new System.Drawing.Point(176, 74);
            this.NOMBRE_ELEVE.Name = "NOMBRE_ELEVE";
            this.NOMBRE_ELEVE.Size = new System.Drawing.Size(15, 17);
            this.NOMBRE_ELEVE.TabIndex = 3;
            this.NOMBRE_ELEVE.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "NOMBRE D\'ELEVE";
            // 
            // DESIGNATION_SALLE
            // 
            this.DESIGNATION_SALLE.AutoSize = true;
            this.DESIGNATION_SALLE.Location = new System.Drawing.Point(6, 74);
            this.DESIGNATION_SALLE.Name = "DESIGNATION_SALLE";
            this.DESIGNATION_SALLE.Size = new System.Drawing.Size(88, 17);
            this.DESIGNATION_SALLE.TabIndex = 1;
            this.DESIGNATION_SALLE.Text = "DESIGNATION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "DESIGNATION";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 287);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(520, 303);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TABLE DE COURS";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(359, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Entrer le cours";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(498, 236);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.DEJA_PROGRAMMER);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.NOMBRE_HEURE);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.HEURE);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.JOUR);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(538, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 698);
            this.panel1.TabIndex = 3;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(74, 66);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(44, 13);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Modifier";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
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
            this.guna2Button1.Location = new System.Drawing.Point(699, 16);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(141, 45);
            this.guna2Button1.TabIndex = 13;
            this.guna2Button1.Text = "AJOUTER";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // DEJA_PROGRAMMER
            // 
            this.DEJA_PROGRAMMER.AutoSize = true;
            this.DEJA_PROGRAMMER.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEJA_PROGRAMMER.Location = new System.Drawing.Point(666, 32);
            this.DEJA_PROGRAMMER.Name = "DEJA_PROGRAMMER";
            this.DEJA_PROGRAMMER.Size = new System.Drawing.Size(15, 17);
            this.DEJA_PROGRAMMER.TabIndex = 12;
            this.DEJA_PROGRAMMER.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(516, 32);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(131, 17);
            this.label19.TabIndex = 11;
            this.label19.Text = "HEURE PROGRAMMER";
            // 
            // NOMBRE_HEURE
            // 
            this.NOMBRE_HEURE.AutoSize = true;
            this.NOMBRE_HEURE.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOMBRE_HEURE.Location = new System.Drawing.Point(482, 32);
            this.NOMBRE_HEURE.Name = "NOMBRE_HEURE";
            this.NOMBRE_HEURE.Size = new System.Drawing.Size(15, 17);
            this.NOMBRE_HEURE.TabIndex = 10;
            this.NOMBRE_HEURE.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(356, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 17);
            this.label16.TabIndex = 9;
            this.label16.Text = "NOMBRE D\'HEURE";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(15, 128);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(825, 556);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "PROGRAMME";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.COURS);
            this.groupBox6.Controls.Add(this.SALLE);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Location = new System.Drawing.Point(344, 421);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(480, 135);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "DISPONIBITITE DU PROFFESSEUR";
            // 
            // COURS
            // 
            this.COURS.AutoSize = true;
            this.COURS.Location = new System.Drawing.Point(123, 98);
            this.COURS.Name = "COURS";
            this.COURS.Size = new System.Drawing.Size(17, 13);
            this.COURS.TabIndex = 3;
            this.COURS.Text = "\"\"";
            // 
            // SALLE
            // 
            this.SALLE.AutoSize = true;
            this.SALLE.Location = new System.Drawing.Point(124, 39);
            this.SALLE.Name = "SALLE";
            this.SALLE.Size = new System.Drawing.Size(17, 13);
            this.SALLE.TabIndex = 2;
            this.SALLE.Text = "\"\"";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "COURS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "SALLE";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(658, 18);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Entrer le cours";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(22, 50);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(786, 292);
            this.dataGridView2.TabIndex = 0;
            // 
            // HEURE
            // 
            this.HEURE.BackColor = System.Drawing.Color.Transparent;
            this.HEURE.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.HEURE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HEURE.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HEURE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HEURE.FocusedState.Parent = this.HEURE;
            this.HEURE.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.HEURE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.HEURE.HoverState.Parent = this.HEURE;
            this.HEURE.ItemHeight = 30;
            this.HEURE.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.HEURE.ItemsAppearance.Parent = this.HEURE;
            this.HEURE.Location = new System.Drawing.Point(272, 16);
            this.HEURE.Name = "HEURE";
            this.HEURE.ShadowDecoration.Parent = this.HEURE;
            this.HEURE.Size = new System.Drawing.Size(65, 36);
            this.HEURE.TabIndex = 7;
            this.HEURE.SelectedIndexChanged += new System.EventHandler(this.HEURE_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(210, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 17);
            this.label15.TabIndex = 6;
            this.label15.Text = "HEURE";
            // 
            // JOUR
            // 
            this.JOUR.BackColor = System.Drawing.Color.Transparent;
            this.JOUR.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.JOUR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JOUR.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.JOUR.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.JOUR.FocusedState.Parent = this.JOUR;
            this.JOUR.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.JOUR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.JOUR.HoverState.Parent = this.JOUR;
            this.JOUR.ItemHeight = 30;
            this.JOUR.ItemsAppearance.Parent = this.JOUR;
            this.JOUR.Location = new System.Drawing.Point(77, 16);
            this.JOUR.Name = "JOUR";
            this.JOUR.ShadowDecoration.Parent = this.JOUR;
            this.JOUR.Size = new System.Drawing.Size(114, 36);
            this.JOUR.TabIndex = 5;
            this.JOUR.SelectedIndexChanged += new System.EventHandler(this.JOUR_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 17);
            this.label14.TabIndex = 4;
            this.label14.Text = "JOURS";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.MATRICULE);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.PRENOM);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.POSTNOM);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.NOM);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(12, 596);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(520, 209);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PROF";
            // 
            // MATRICULE
            // 
            this.MATRICULE.AutoSize = true;
            this.MATRICULE.Location = new System.Drawing.Point(12, 192);
            this.MATRICULE.Name = "MATRICULE";
            this.MATRICULE.Size = new System.Drawing.Size(69, 13);
            this.MATRICULE.TabIndex = 7;
            this.MATRICULE.Text = "MATRICULE";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 146);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(69, 13);
            this.label22.TabIndex = 6;
            this.label22.Text = "MATRICULE";
            // 
            // PRENOM
            // 
            this.PRENOM.AutoSize = true;
            this.PRENOM.Location = new System.Drawing.Point(380, 89);
            this.PRENOM.Name = "PRENOM";
            this.PRENOM.Size = new System.Drawing.Size(54, 13);
            this.PRENOM.TabIndex = 5;
            this.PRENOM.Text = "PRENOM";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(380, 43);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 13);
            this.label20.TabIndex = 4;
            this.label20.Text = "POSTNOM";
            // 
            // POSTNOM
            // 
            this.POSTNOM.AutoSize = true;
            this.POSTNOM.Location = new System.Drawing.Point(190, 89);
            this.POSTNOM.Name = "POSTNOM";
            this.POSTNOM.Size = new System.Drawing.Size(61, 13);
            this.POSTNOM.TabIndex = 3;
            this.POSTNOM.Text = "POSTNOM";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(190, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "POSTNOM";
            // 
            // NOM
            // 
            this.NOM.AutoSize = true;
            this.NOM.Location = new System.Drawing.Point(12, 89);
            this.NOM.Name = "NOM";
            this.NOM.Size = new System.Drawing.Size(32, 13);
            this.NOM.TabIndex = 1;
            this.NOM.Text = "NOM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "NOM";
            // 
            // HORAIRE_HEBDOMADAIRE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(1398, 819);
            this.MinimumSize = new System.Drawing.Size(1398, 819);
            this.Name = "HORAIRE_HEBDOMADAIRE";
            this.Size = new System.Drawing.Size(1398, 819);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox DESIGNATION;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox ABREVIATION;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox NIVEAU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label NOMBRE_ELEVE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label DESIGNATION_SALLE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TITULAIRE;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label NOMBRE_PLACE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label NOMBRE_COURS;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label DEJA_PROGRAMMER;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label NOMBRE_HEURE;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Guna.UI2.WinForms.Guna2ComboBox HEURE;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2ComboBox JOUR;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label MATRICULE;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label PRENOM;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label POSTNOM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label NOM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label COURS;
        private System.Windows.Forms.Label SALLE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}
