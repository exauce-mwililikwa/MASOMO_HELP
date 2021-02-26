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
    public partial class COTATION_TRAVAIL : UserControl
    {
        CLASS_DATA_BASE.CLS_GLOSSIERE A = new CLASS_DATA_BASE.CLS_GLOSSIERE();
        CLASS_DATA_BASE.AJOUT B = new CLASS_DATA_BASE.AJOUT();
  

        string CHARGEMENT_NIVEAU = "SELECT NIVEAU_ETUDE FROM SALLE_DE_CLASS GROUP BY NIVEAU_ETUDE";
        public COTATION_TRAVAIL()
        {
            InitializeComponent();

            A.CHARGE_COMBO(NIVEAU, "" + CHARGEMENT_NIVEAU);
            A.LABEL(ANNE,"SELECT DESIGNATION FROM ANNE_SCOLAIRE WHERE ID=(SELECT MAX(ID) FROM ANNE_SCOLAIRE)",0);
            A.LABEL(PERIODE, "SELECT DESIGNATION FROM PERIODE WHERE ANNE=(SELECT MAX(ID) FROM ANNE_SCOLAIRE)", 0);
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void COTATION_TRAVAIL_Load(object sender, EventArgs e)
        {

        }

        private void NIVEAU_SelectedIndexChanged(object sender, EventArgs e)
        {
            ABREVIATION.Enabled = true;
            ABREVIATION.Items.Clear();
            string SESSION = "SELECT ABREVIATION FROM SALLE_DE_CLASS WHERE NIVEAU_ETUDE=" + NIVEAU.SelectedItem.ToString() + " GROUP BY ABREVIATION";
            A.CHARGE_COMBO(ABREVIATION, "" + SESSION);
        }

        private void ABREVIATION_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            DESIGNATION.Enabled = true;
            DESIGNATION.Items.Clear();
            string SESSION = "SELECT LETTRE FROM SALLE_DE_CLASS WHERE NIVEAU_ETUDE=" + NIVEAU.SelectedItem.ToString() + " AND ABREVIATION='" + ABREVIATION.SelectedItem.ToString() + "'";
            A.CHARGE_COMBO(DESIGNATION, "" + SESSION);
        }

        private void DESIGNATION_SelectedIndexChanged(object sender, EventArgs e)
        {
            COMBO_COURS.Items.Clear();
            A.LABEL(NOMBRE_COURS, "SELECT COUNT(COURS_SALLE.DESIGNATION) FROM COURS_SALLE WHERE NIVEAU_ETUDE=" + NIVEAU.SelectedItem.ToString() + " AND ABREVIATION='" + ABREVIATION.SelectedItem.ToString() + "' AND LETTRE='" + DESIGNATION.SelectedItem.ToString() + "'", 0);
            A.CHARGE_COMBO(COMBO_COURS, "SELECT COURS_SALLE.DESIGNATION FROM COURS_SALLE WHERE NIVEAU_ETUDE=" + NIVEAU.SelectedItem.ToString() + " AND ABREVIATION='" + ABREVIATION.SelectedItem.ToString() + "' AND LETTRE='" + DESIGNATION.SelectedItem.ToString() + "'");
            COMBO_COURS.Enabled = true;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            new DESIGN_BOXES.NOVEAU_TRAVAIL(int.Parse(NIVEAU.SelectedItem.ToString()),"'"+ABREVIATION.SelectedItem.ToString()+"'","'"+DESIGNATION.SelectedItem.ToString()+"'","'"+MATRICULE.Text+"'","'"+COMBO_COURS.SelectedItem.ToString()+"'").Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            new DESIGN_BOXES.PERIODE().Show();
        }

        private void COMBO_COURS_SelectedIndexChanged(object sender, EventArgs e)
        {
            A.LABEL(NOM, " SELECT * FROM COURS_SALLE WHERE NIVEAU_ETUDE='"+NIVEAU.SelectedItem.ToString()+"' AND ABREVIATION='"+ABREVIATION.SelectedItem.ToString()+"' AND LETTRE='"+DESIGNATION.SelectedItem.ToString()+"' AND DESIGNATION='"+COMBO_COURS.SelectedItem.ToString()+"'", 4);
            A.LABEL(POSTNOM, " SELECT * FROM COURS_SALLE WHERE NIVEAU_ETUDE='" + NIVEAU.SelectedItem.ToString() + "' AND ABREVIATION='" + ABREVIATION.SelectedItem.ToString() + "' AND LETTRE='" + DESIGNATION.SelectedItem.ToString() + "' AND DESIGNATION='" + COMBO_COURS.SelectedItem.ToString() + "'", 5);
            A.LABEL(PRENOM, " SELECT * FROM COURS_SALLE WHERE NIVEAU_ETUDE='" + NIVEAU.SelectedItem.ToString() + "' AND ABREVIATION='" + ABREVIATION.SelectedItem.ToString() + "' AND LETTRE='" + DESIGNATION.SelectedItem.ToString() + "' AND DESIGNATION='" + COMBO_COURS.SelectedItem.ToString() + "'", 6);
            A.LABEL(MATRICULE, " SELECT * FROM COURS_SALLE WHERE NIVEAU_ETUDE='" + NIVEAU.SelectedItem.ToString() + "' AND ABREVIATION='" + ABREVIATION.SelectedItem.ToString() + "' AND LETTRE='" + DESIGNATION.SelectedItem.ToString() + "' AND DESIGNATION='" + COMBO_COURS.SelectedItem.ToString() + "'", 3);
            guna2Button5.Enabled =true;
            dataGridView2.DataSource = A.TABLEAU("SELECT TRAVAIL.ID,DATE,HEURE,DENOMINATION,MAXIMUM FROM DETAILS_TRAVAIL INNER JOIN  TRAVAIL ON TRAVAIL.ID=DETAILS_TRAVAIL.ID INNER JOIN COURS on COURS.ID=TRAVAIL.COURS  INNER JOIN DESIGNATION_SALLE ON DESIGNATION_SALLE.ID=TRAVAIL.DESIGNATION_SALLE INNER   JOIN SALLE ON SALLE.ID=DESIGNATION_SALLE.ID_SALLE INNER JOIN SECTION ON SECTION.ID=SALLE.SECTION WHERE SECTION.ABREVIATION='" + ABREVIATION.SelectedItem.ToString() + "' AND COURS.DESIGNATION='" + COMBO_COURS.SelectedItem.ToString() + "' AND SALLE.NIVEAU_ETUDE=" + NIVEAU.SelectedItem.ToString() + " AND DESIGNATION_SALLE.LETTRE='" + DESIGNATION.SelectedItem.ToString() + "' AND DETAILS_TRAVAIL.PERIODE=(SELECT MAX(ID) FROM periode)");
       
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            guna2Button3.Enabled = true;
           dataGridView1.DataSource = A.TABLEAU("SELECT MATRICULE,UPPER(NOM) AS NOM,UPPER(POSTNOM) AS POSTNOM,UPPER(PRENOM) AS PRENOM,POINT FROM COTATION INNER JOIN ELEVE ON ELEVE.MATRICULE=COTATION.MATRICULE_ELEVE WHERE COTATION.ID_TRAVAIL=" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "");
            Console.WriteLine("SELECT MATRICULE,UPPER(NOM),UPPER(POSTNOM),UPPER(PRENOM),POINT FROM COTATION INNER JOIN ELEVE ON ELEVE.MATRICULE=COTATION.MATRICULE_ELEVE WHERE DETAILS_COTATION.ID_COTATION=" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            A.GET_PHOTO("eleve", "matricule", "" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "",PHOTO);
            COTE_.Enabled = true;
            COTE_.Focus();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            if (int.Parse(COTE_.Text) > int.Parse(dataGridView2.CurrentRow.Cells[4].Value.ToString()))
            {
                label9.Text = "MAXIMUM SUPERIEUR";
            }
            else
            {
                label9.Text = "";
                A.EXEC_UNIVERSEL("COTER", "" + COTE_.Text + "," + dataGridView2.CurrentRow.Cells[0].Value.ToString() + ",'" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", "");
                dataGridView1.DataSource = A.TABLEAU("SELECT MATRICULE,UPPER(NOM) AS NOM,UPPER(POSTNOM) AS POSTNOM,UPPER(PRENOM) AS PRENOM,POINT FROM COTATION INNER JOIN ELEVE ON ELEVE.MATRICULE=COTATION.MATRICULE_ELEVE  WHERE COTATION.ID_TRAVAIL=" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "  ORDER BY POINT ASC");
           
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {
            if (int.Parse(COTER_UNIQUE.Text) > int.Parse(dataGridView2.CurrentRow.Cells[4].Value.ToString()))
            {
                label19.Text = "MAXIMUM SUPERIEUR";
            }
            else
            {
                label9.Text = "";
                A.EXEC_UNIVERSEL("COTER_UNIQUE", "" + COTER_UNIQUE.Text + "," + dataGridView2.CurrentRow.Cells[0].Value.ToString() + ",'" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", "");
                dataGridView1.DataSource = A.TABLEAU("SELECT MATRICULE,UPPER(NOM) AS NOM,UPPER(POSTNOM) AS POSTNOM,UPPER(PRENOM) AS PRENOM,POINT FROM COTATION INNER JOIN ELEVE ON ELEVE.MATRICULE=COTATION.MATRICULE_ELEVE  WHERE COTATION.ID_TRAVAIL=" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "  ORDER BY POINT ASC");

            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            A.EXEC_UNIVERSEL("ANNULER_INTERRO", "" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "", "ANNULATION ");
            dataGridView2.DataSource = A.TABLEAU("SELECT TRAVAIL.ID,DATE,HEURE,DENOMINATION,MAXIMUM FROM DETAILS_TRAVAIL INNER JOIN  TRAVAIL ON TRAVAIL.ID=DETAILS_TRAVAIL.ID INNER JOIN COURS on COURS.ID=TRAVAIL.COURS  INNER JOIN DESIGNATION_SALLE ON DESIGNATION_SALLE.ID=TRAVAIL.DESIGNATION_SALLE INNER   JOIN SALLE ON SALLE.ID=DESIGNATION_SALLE.ID_SALLE INNER JOIN SECTION ON SECTION.ID=SALLE.SECTION WHERE SECTION.ABREVIATION='" + ABREVIATION.SelectedItem.ToString() + "' AND COURS.DESIGNATION='" + COMBO_COURS.SelectedItem.ToString() + "' AND SALLE.NIVEAU_ETUDE=" + NIVEAU.SelectedItem.ToString() + " AND DESIGNATION_SALLE.LETTRE='" + DESIGNATION.SelectedItem.ToString() + "' AND DETAILS_TRAVAIL.PERIODE=(SELECT MAX(ID) FROM periode)");
       
        }

       
    }
}
