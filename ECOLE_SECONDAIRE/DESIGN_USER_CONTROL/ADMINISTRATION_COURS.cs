using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ECOLE_SECONDAIRE.DESIGN_USER_CONTROL
{
    public partial class ADMINISTRATION_COURS : UserControl
    {
        CLASS_DATA_BASE.CLS_GLOSSIERE A = new CLASS_DATA_BASE.CLS_GLOSSIERE();
        CLASS_DESIGN.DESIGN B= new  CLASS_DESIGN.DESIGN();
        public static string designation_Salle = "";
        string CHARGEMENT_NIVEAU = "SELECT NIVEAU_ETUDE FROM SALLE_DE_CLASS GROUP BY NIVEAU_ETUDE";
        private Boolean rio;
        public ADMINISTRATION_COURS()
        {
            InitializeComponent();
            A.CHARGE_COMBO(NIVEAU,""+CHARGEMENT_NIVEAU);
            dataGridView2.DataSource = A.TABLEAU("SELECT TOP 15 INSCRIPTION_AGENT.MATRICULE,AGENT.NOM,AGENT.POSTNOM,AGENT.PRENOM,DEPARTEMENT.DESIGNATION FROM INSCRIPTION_AGENT   INNER JOIN AGENT ON AGENT.MATRICULE=INSCRIPTION_AGENT.MATRICULE INNER JOIN DEPARTEMENT ON DEPARTEMENT.ID=INSCRIPTION_AGENT.DEPARTEMENT ");
            
        }
       
        private void ADMINISTRATION_COURS_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void NIVEAU_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            LETTRE.Enabled = true;
            LETTRE.Items.Clear();
            string SESSION = "SELECT ABREVIATION FROM SALLE_DE_CLASS WHERE NIVEAU_ETUDE=" + NIVEAU.SelectedItem.ToString() + " GROUP BY ABREVIATION";
            A.CHARGE_COMBO(LETTRE, "" + SESSION);
            dataGridView1.DataSource = A.TABLEAU("SELECT SALLE_DE_CLASS.ABREVIATION, LETTRE,NOMBRE_PLACE,TITULAIRE FROM SALLE_DE_CLASS WHERE NIVEAU_ETUDE="+NIVEAU.SelectedItem.ToString()+"");
        }

        private void PROMOTION_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = A.TABLEAU("SELECT LETTRE,NOMBRE_PLACE,NOMBRE_INSCRIT,TITULAIRE FROM SALLE_DE_CLASS WHERE NIVEAU_ETUDE=" + NIVEAU.SelectedItem.ToString() + " AND ABREVIATION='" + LETTRE.SelectedItem.ToString() + "'");
            dataGridView3.DataSource = A.TABLEAU("SELECT COURS.DESIGNATION,HORAIRE.PONDERATION AS '1P',HORAIRE.PONDERATION AS '2P',HORAIRE.PONDERATION*2 AS 'EXAM',HORAIRE.PONDERATION*4 AS  'SEMESTRE' FROM COURS INNER JOIN HORAIRE ON HORAIRE.COURS=COURS.ID INNER JOIN SALLE ON SALLE.ID=HORAIRE.SALLE INNER   JOIN SECTION ON SECTION.ID=SALLE.SECTION WHERE SECTION.ABREVIATION='"+LETTRE.SelectedItem.ToString()+"' AND SALLE.NIVEAU_ETUDE="+NIVEAU.SelectedItem.ToString()+"  UNION SELECT 'TOTAL' AS 'COURS.DESIGNATION',SUM(HORAIRE.PONDERATION) AS '1P',SUM(HORAIRE.PONDERATION) AS '2P',SUM(HORAIRE.PONDERATION*2) AS 'EXAM',SUM(HORAIRE.PONDERATION*4) AS  'SEMESTRE' FROM COURS INNER JOIN HORAIRE ON HORAIRE.COURS=COURS.ID INNER JOIN SALLE ON SALLE.ID=HORAIRE.SALLE INNER   JOIN SECTION ON SECTION.ID=SALLE.SECTION WHERE SECTION.ABREVIATION='" + LETTRE.SelectedItem.ToString() + "' AND SALLE.NIVEAU_ETUDE=" + NIVEAU.SelectedItem.ToString() + "");
            A.CHARGE_LIST(COURS_LIST, "SELECT COURS.DESIGNATION FROM COURS");
            DESIGNATION.Enabled = true;
            DESIGNATION.Items.Clear();
            string SESSION = "SELECT LETTRE FROM SALLE_DE_CLASS WHERE NIVEAU_ETUDE=" + NIVEAU.SelectedItem.ToString() + " AND ABREVIATION='"+LETTRE.SelectedItem.ToString()+"'";
            A.CHARGE_COMBO(DESIGNATION, "" + SESSION);
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TITULAIRE.Text = "AUCUN";
            NOM.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            POSTNOM.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            PRENOM.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            A.GET_PHOTO("AGENT", "MATRICULE", "" + dataGridView2.CurrentRow.Cells[0].Value.ToString(), pictureBox2);
            A.LABEL(TITULAIRE, "SELECT CONCAT(NIVEAU_ETUDE.NIVEAU,'eme',SECTION.ABREVIATION,'/',DESIGNATION_SALLE.LETTRE)  FROM NIVEAU_ETUDE INNER JOIN SALLE ON NIVEAU_ETUDE.NIVEAU=SALLE.NIVEAU_ETUDE INNER JOIN SECTION ON   SECTION.ID=SALLE.SECTION INNER JOIN DESIGNATION_SALLE ON DESIGNATION_SALLE.ID_SALLE=SALLE.ID INNER JOIN    TITULARISATION_SALLE ON TITULARISATION_SALLE.SALLE=DESIGNATION_SALLE.ID WHERE TITULARISATION_SALLE.AGENT='" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "'",0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = A.TABLEAU("SELECT TOP 15 INSCRIPTION_AGENT.MATRICULE,AGENT.NOM,AGENT.POSTNOM,AGENT.PRENOM,DEPARTEMENT.DESIGNATION FROM INSCRIPTION_AGENT   INNER JOIN AGENT ON AGENT.MATRICULE=INSCRIPTION_AGENT.MATRICULE INNER JOIN DEPARTEMENT ON DEPARTEMENT.ID=INSCRIPTION_AGENT.DEPARTEMENT WHERE CONCAT(NOM,' ',POSTNOM,' ',PRENOM) LIKE '%" + textBox1.Text+ "%'");
      
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            new DESIGN_BOXES.AJOUT_COURS().Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            string ens = null;
            if (radioButton1.Checked)
            {
                ens = "non";
            }
            else
            {
                ens = "tout";
            }
            if (guna2Button5.Text == "AJOUTER" && ens=="non")
            {
                MessageBox.Show("Vous devez ajouter le cours de "+COURS_LIST.SelectedItem.ToString()+" dans toute les promotions de "+NIVEAU.SelectedItem.ToString()+"eme"+LETTRE.SelectedItem.ToString()+" allez cocher la case de l'attribution total ", "Erreur d'ajout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(ponderation.Text==""){
                ponderation.BorderColor = System.Drawing.Color.Red;
            }
            else
            {
                A.EXEC_UNIVERSEL("ADMINISTRER_COURS_PROF", "" + NIVEAU.SelectedItem.ToString() + ",'" + LETTRE.SelectedItem.ToString() + "','" + NIVEAU.SelectedItem.ToString() + "" + LETTRE.SelectedItem.ToString() + "'," + ponderation.Text + ",'" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "','" + COURS_LIST.SelectedItem.ToString() + "','" + designation_Salle + "','" + ens + "',"+NOMBRE.Text+"", "HORAIRE ");
                dataGridView3.DataSource = A.TABLEAU("SELECT COURS.DESIGNATION,HORAIRE.PONDERATION AS '1P',HORAIRE.PONDERATION AS '2P',HORAIRE.PONDERATION*2 AS 'EXAM',HORAIRE.PONDERATION*4 AS  'SEMESTRE' FROM COURS INNER JOIN HORAIRE ON HORAIRE.COURS=COURS.ID INNER JOIN SALLE ON SALLE.ID=HORAIRE.SALLE INNER   JOIN SECTION ON SECTION.ID=SALLE.SECTION WHERE SECTION.ABREVIATION='" + LETTRE.SelectedItem.ToString() + "' AND SALLE.NIVEAU_ETUDE=" + NIVEAU.SelectedItem.ToString() + "  UNION SELECT 'TOTAL' AS 'COURS.DESIGNATION',SUM(HORAIRE.PONDERATION) AS '1P',SUM(HORAIRE.PONDERATION) AS '2P',SUM(HORAIRE.PONDERATION*2) AS 'EXAM',SUM(HORAIRE.PONDERATION*4) AS  'SEMESTRE' FROM COURS INNER JOIN HORAIRE ON HORAIRE.COURS=COURS.ID INNER JOIN SALLE ON SALLE.ID=HORAIRE.SALLE INNER   JOIN SECTION ON SECTION.ID=SALLE.SECTION WHERE SECTION.ABREVIATION='" + LETTRE.SelectedItem.ToString() + "' AND SALLE.NIVEAU_ETUDE=" + NIVEAU.SelectedItem.ToString() + "");
           
            }
            
        }

        private void COURS_LIST_SelectedIndexChanged(object sender, EventArgs e)
        {

            string PLUS_COURS_DONNER = "EXEC DESIGNATION_COURS_AFFECTATION '" + COURS_LIST.SelectedItem.ToString() + "'," + NIVEAU.SelectedItem.ToString() + ",'" + LETTRE.SelectedItem.ToString() + "','" + designation_Salle + "'";
            guna2Button5.Enabled = true;
            NOM_LABEL.Text = null;
            A.LABEL(NOM_LABEL, PLUS_COURS_DONNER,0);
            POSTNOM_LABEL.Text = null;
            A.LABEL(POSTNOM_LABEL, PLUS_COURS_DONNER, 1);
            PRENOM_LABEL.Text = null;
            A.LABEL(PRENOM_LABEL, PLUS_COURS_DONNER, 2);//
            ponderation.Text = null;
            A.TEXT(ponderation, PLUS_COURS_DONNER, 5);
            A.GET_PHOTO("AGENT INNER JOIN AFFECTATION_COURS ON AFFECTATION_COURS.PROF=AGENT.MATRICULE INNER JOIN HORAIRE  ON HORAIRE.ID=AFFECTATION_COURS.HORAIRE INNER JOIN SALLE ON SALLE.ID=HORAIRE.SALLE INNER JOIN SECTION ON SECTION.ID=SALLE.SECTION INNER JOIN DESIGNATION_SALLE  ON DESIGNATION_SALLE.ID_SALLE=SALLE.ID AND DESIGNATION_SALLE.ID=AFFECTATION_COURS.DESIGNATION_SALLE INNER JOIN COURS ON COURS.ID=HORAIRE.COURS AND HORAIRE.SALLE=SALLE.ID ", " NIVEAU_ETUDE =" + NIVEAU.SelectedItem.ToString() + " AND CONCAT(' ',ABREVIATION) ", " " + LETTRE.SelectedItem.ToString() + "' AND LETTRE='" + designation_Salle + "' AND COURS.DESIGNATION= '" + COURS_LIST.SelectedItem.ToString() + " ", pictureBox1);
            if (NOM_LABEL.Text != "")
            {
                label3.Text = "Cours existant";
                guna2Button5.Text = "MODIFIER";
            }
            else{
                label3.Text = "Cours inexistant";
                guna2Button5.Text = "AJOUTER";
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
            colapsarusurio.Start();
           
        }

        private void colapsarusurio_Tick(object sender, EventArgs e)
        {
            if (rio)
            {
                //    this.usuario.Iconimage_right = global::cours_dwesign_time.Properties.Resources.gauche;
                panelusuario.Height += 20;
                if (panelusuario.Size == panelusuario.MaximumSize)
                {
                    colapsarusurio.Stop();
                    rio = false;
                }
            }
            else
            {
                //  this.usuario.Iconimage_right = global::cours_dwesign_time.Properties.Resources.droitre;
                panelusuario.Height -= 20;
                if (panelusuario.Size == panelusuario.MinimumSize)
                {
                    colapsarusurio.Stop();
                    rio = true;
                }
            }
        }

        private void DESIGNATION_SelectedIndexChanged(object sender, EventArgs e)
        {

            designation_Salle = DESIGNATION.SelectedItem.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           B.APPEL_PANEL(new DESIGN_USER_CONTROL.AJOUT_AGENT(), DASHBOARD.c);
        }
    }
}
