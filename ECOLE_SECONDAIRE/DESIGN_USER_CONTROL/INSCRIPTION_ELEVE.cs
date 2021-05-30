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
    public partial class INSCRIPTION_ELEVE : UserControl
    {
        CLASS_DATA_BASE.CLS_GLOSSIERE A = new CLASS_DATA_BASE.CLS_GLOSSIERE();
        CLASS_DATA_BASE.AJOUT B= new CLASS_DATA_BASE.AJOUT();
        private Boolean rio;
        string CHARGEMENT_NIVEAU = "SELECT NIVEAU_ETUDE FROM SALLE_DE_CLASS GROUP BY NIVEAU_ETUDE";
        public INSCRIPTION_ELEVE()
        {
            InitializeComponent();

            A.CHARGE_COMBO(NIVEAU, "" + CHARGEMENT_NIVEAU);
            A.LABEL(ANNE, "SELECT DESIGNATION FROM ANNE_SCOLAIRE WHERE ID=(SELECT MAX(ID) FROM ANNE_SCOLAIRE)", 0);
            dataGridView1.DataSource = A.TABLEAU("SELECT MATRICULE,NOM,POSTNOM,PRENOM,CLASSE,HEURE FROM LISTE_INSCRIT_JOURNALIER WHERE DATE=FORMAT(GETDATE(),'yyyy-MM-dd')");
            colapsarusurio.Start();
        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            guna2Button4.Enabled = true;
          
           
                A.LABEL(NOMBRE_PLACE, "EXEC SITUATION_TITULARISATIO " + NIVEAU.SelectedItem.ToString() + ",'" + ABREVIATION.SelectedItem.ToString() + "','" + DESIGNATION.SelectedItem.ToString() + "'", 1);
                A.LABEL(TITULAIRE, "EXEC SITUATION_TITULARISATIO " + NIVEAU.SelectedItem.ToString() + ",'" + ABREVIATION.SelectedItem.ToString() + "','" + DESIGNATION.SelectedItem.ToString() + "'", 0);
                A.LABEL(PLACE_LIBRE, "EXEC SITUATION_TITULARISATIO " + NIVEAU.SelectedItem.ToString() + ",'" + ABREVIATION.SelectedItem.ToString() + "','" + DESIGNATION.SelectedItem.ToString() + "'", 2);
       
            
         
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void NIVEAU_SelectedIndexChanged(object sender, EventArgs e)
        {
            ABREVIATION.Enabled = true;
            ABREVIATION.Items.Clear();
            string SESSION = "SELECT ABREVIATION FROM SALLE_DE_CLASS WHERE NIVEAU_ETUDE=" + NIVEAU.SelectedItem.ToString() + " GROUP BY ABREVIATION";
            A.CHARGE_COMBO(ABREVIATION, "" + SESSION);
           
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DESIGNATION.Enabled = true;
            DESIGNATION.Items.Clear();
            string SESSION = "SELECT LETTRE FROM SALLE_DE_CLASS WHERE NIVEAU_ETUDE=" + NIVEAU.SelectedItem.ToString() + " AND ABREVIATION='" + ABREVIATION.SelectedItem.ToString() + "'";
            A.CHARGE_COMBO(DESIGNATION, "" + SESSION);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (guna2Button4.Enabled == false)
            {
                MessageBox.Show("Selectionner la salle a affecter");
            }
            else
            {


                A.LABEL(PLACE_LIBRE, "EXEC SITUATION_TITULARISATIO " + NIVEAU.SelectedItem.ToString() + ",'" + ABREVIATION.SelectedItem.ToString() + "','" + DESIGNATION.SelectedItem.ToString() + "'", 2);
                NOM.BorderColor = System.Drawing.Color.Black;
                POSTNOM.BorderColor = System.Drawing.Color.Black;
                PRENOM.BorderColor = System.Drawing.Color.Black;
                PAYS.BorderColor = System.Drawing.Color.Black;
                PROVINCE.BorderColor = System.Drawing.Color.Black;
                VILLE.BorderColor = System.Drawing.Color.Black;
                QUARTIER.BorderColor = System.Drawing.Color.Black;
                NUMERO.BorderColor = System.Drawing.Color.Black;
                CELLULAIRE.BorderColor = System.Drawing.Color.Black;
                NOM_T.BorderColor = System.Drawing.Color.Black;
                POSTNOM_T.BorderColor = System.Drawing.Color.Black;
                PRENOM_T.BorderColor = System.Drawing.Color.Black;
                CELLULAIRE_T.BorderColor = System.Drawing.Color.Black;
                if (NOM.Text == "")
                {
                    NOM.BorderColor = System.Drawing.Color.Red;
                }
                else if (POSTNOM.Text == "")
                {
                    POSTNOM.BorderColor = System.Drawing.Color.Red;
                }
                else if (PRENOM.Text == "")
                {
                    PRENOM.BorderColor = System.Drawing.Color.Red;
                }
                else if (PAYS.Text == "")
                {
                    PAYS.BorderColor = System.Drawing.Color.Red;
                }
                else if (PROVINCE.Text == "")
                {
                    PROVINCE.BorderColor = System.Drawing.Color.Red;
                }
                else if (VILLE.Text == "")
                {
                    VILLE.BorderColor = System.Drawing.Color.Red;
                }

                else if (QUARTIER.Text == "")
                {
                    QUARTIER.BorderColor = System.Drawing.Color.Red;
                }
                else if (NUMERO.Text == "")
                {
                    NUMERO.BorderColor = System.Drawing.Color.Red;
                }
                else if (CELLULAIRE.Text == "")
                {
                    CELLULAIRE.BorderColor = System.Drawing.Color.Red;
                }

                else if (NOM_T.Text == "")
                {
                    NOM_T.BorderColor = System.Drawing.Color.Red;
                }
                else if (POSTNOM_T.Text == "")
                {
                    POSTNOM_T.BorderColor = System.Drawing.Color.Red;
                }
                else if (PRENOM_T.Text == "")
                {
                    PRENOM_T.BorderColor = System.Drawing.Color.Red;
                }
                else if (CELLULAIRE_T.Text == "")
                {
                    CELLULAIRE_T.BorderColor = System.Drawing.Color.Red;
                }
                else if (int.Parse(PLACE_LIBRE.Text) <= 0)
                {
                    MessageBox.Show("Place insufissant", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    B.ELEVE(NOM, POSTNOM, PRENOM, PAYS, PROVINCE, VILLE, QUARTIER, AVENU, NUMERO, EMAIL, CELLULAIRE, NOM_T, POSTNOM_T, PRENOM_T, EMAIL_T, CELLULAIRE_T, NIVEAU, ABREVIATION, DESIGNATION);
               
                }
                A.LABEL(PLACE_LIBRE, "EXEC SITUATION_TITULARISATIO " + NIVEAU.SelectedItem.ToString() + ",'" + ABREVIATION.SelectedItem.ToString() + "','" + DESIGNATION.SelectedItem.ToString() + "'", 2);
                dataGridView1.DataSource = A.TABLEAU("SELECT MATRICULE,NOM,POSTNOM,PRENOM,CLASSE,HEURE FROM LISTE_INSCRIT_JOURNALIER WHERE DATE=FORMAT(GETDATE(),'yyyy-MM-dd')");
           
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            B.CHOISIR_IMAGE(pictureBox1);
        }

        private void PRENOM_TextChanged(object sender, EventArgs e)
        {
            NOM_ALERT.Text = "ID";
            A.LABEL(NOM_ALERT, "SELECT * from LISTE_INSCRIT_JOURNALIER WHERE NOM='" + NOM.Text + "' AND POSTNOM='" + POSTNOM.Text + "' AND PRENOM='" + PRENOM.Text + "'", 1);
            A.LABEL(POSTNOM_ALERT, "SELECT * from LISTE_INSCRIT_JOURNALIER WHERE NOM='" + NOM.Text + "' AND POSTNOM='" + POSTNOM.Text + "' AND PRENOM='" + PRENOM.Text + "'", 2);
            A.LABEL(PRENOM_ALERT, "SELECT * from LISTE_INSCRIT_JOURNALIER WHERE NOM='" + NOM.Text + "' AND POSTNOM='" + POSTNOM.Text + "' AND PRENOM='" + PRENOM.Text + "'", 3);
            A.LABEL(MATRICULE, "SELECT * from LISTE_INSCRIT_JOURNALIER WHERE NOM='" + NOM.Text + "' AND POSTNOM='" + POSTNOM.Text + "' AND PRENOM='" + PRENOM.Text + "'", 0);
            A.GET_PHOTO("ELEVE", "NOM='" + NOM.Text + "' AND POSTNOM='" + POSTNOM.Text + "' AND PRENOM", "" + PRENOM.Text + "", pictureBox2);
            if (NOM_ALERT.Text != "ID")
            {
                colapsarusurio.Start();
                guna2Button4.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
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

      

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            colapsarusurio.Start();

            guna2Button4.Enabled = true;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            new DESIGN_BOXES.INFORMATION_ELEVE(""+MATRICULE.Text+"").Show();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = A.TABLEAU("SELECT MATRICULE,NOM,POSTNOM,PRENOM,CLASSE,HEURE FROM LISTE_INSCRIT_JOURNALIER WHERE CONCAT (NOM,' ',POSTNOM,' ',PRENOM) LIKE '%"+textBox1.Text+"%' AND DATE=FORMAT(GETDATE(),'yyyy-MM-dd')");
         
        }//
    }
}
