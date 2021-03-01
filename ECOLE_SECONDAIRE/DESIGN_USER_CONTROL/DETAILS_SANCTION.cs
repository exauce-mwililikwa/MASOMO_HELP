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
    public partial class DETAILS_SANCTION : UserControl
    {
        CLASS_DATA_BASE.CLS_GLOSSIERE A = new CLASS_DATA_BASE.CLS_GLOSSIERE();
        CLASS_DATA_BASE.AJOUT B = new CLASS_DATA_BASE.AJOUT();
        CLASS_DESIGN.DESIGN a = new CLASS_DESIGN.DESIGN();
        string CHARGEMENT_NIVEAU = "SELECT NIVEAU_ETUDE FROM SALLE_DE_CLASS GROUP BY NIVEAU_ETUDE";
        public DETAILS_SANCTION()
        {
            InitializeComponent();  A.CHARGE_COMBO(NIVEAU, "" + CHARGEMENT_NIVEAU);
        }

        private void NIVEAU_SelectedIndexChanged(object sender, EventArgs e)
        {
            ABREVIATION.Enabled = true;
            ABREVIATION.Items.Clear();
            string SESSION = "SELECT ABREVIATION FROM SALLE_DE_CLASS WHERE NIVEAU_ETUDE=" + NIVEAU.SelectedItem.ToString() + " GROUP BY ABREVIATION";
            A.CHARGE_COMBO(ABREVIATION, "" + SESSION);
            dataGridView2.DataSource = A.TABLEAU("SELECT MATRICULE,NOM,POSTNOM,PRENOM,CLASSE,ABREVIATION,LETTRE FROM LISTE_INSCRIT_JOURNALIER WHERE NIVEAU_ETUDE=" + NIVEAU.SelectedItem.ToString() + "");
       
        }

        private void ABREVIATION_SelectedIndexChanged(object sender, EventArgs e)
        {
            DESIGNATION.Enabled = true;
            DESIGNATION.Items.Clear();
            string SESSION = "SELECT LETTRE FROM SALLE_DE_CLASS WHERE NIVEAU_ETUDE=" + NIVEAU.SelectedItem.ToString() + " AND ABREVIATION='" + ABREVIATION.SelectedItem.ToString() + "'";
            A.CHARGE_COMBO(DESIGNATION, "" + SESSION);
            dataGridView2.DataSource = A.TABLEAU("SELECT MATRICULE,NOM,POSTNOM,PRENOM,LETTRE,CLASSE FROM LISTE_INSCRIT_JOURNALIER WHERE NIVEAU_ETUDE=" + NIVEAU.SelectedItem.ToString() + " AND ABREVIATION='" + ABREVIATION.SelectedItem.ToString() + "'");
       
        }

        private void DESIGNATION_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = A.TABLEAU("SELECT MATRICULE,NOM,POSTNOM,PRENOM,CLASSE FROM LISTE_INSCRIT_JOURNALIER WHERE NIVEAU_ETUDE=" + NIVEAU.SelectedItem.ToString() + " AND ABREVIATION='" + ABREVIATION.SelectedItem.ToString() + "' AND LETTRE='" + DESIGNATION.SelectedItem.ToString() + "'");
       
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView3.DataSource = A.TABLEAU("SELECT DETAILS_SANCTION.DATE,DETAILS_SANCTION.HEURE,LISTE_DE_SANCTION.DESIGNATION,LISTE_DE_SANCTION.PONDERATION FROM DETAILS_SANCTION INNER JOIN SANCTION ON SANCTION.ID=DETAILS_SANCTION.ID INNER JOIN LISTE_DE_SANCTION ON LISTE_DE_SANCTION.ID=SANCTION.MOTIF INNER JOIN LISTE_INSCRIT_JOURNALIER ON LISTE_INSCRIT_JOURNALIER.MATRICULE=SANCTION.MATRICULE_ELEVE WHERE DETAILS_SANCTION.PERIODE=(SELECT MAX(ID) FROM periode) AND LISTE_INSCRIT_JOURNALIER.MATRICULE LIKE '%"+dataGridView2.CurrentRow.Cells[0].Value.ToString() +"%'");
            A.LABEL(MENTION, "EXEC AFFICHER_DETAILS_FAUTE '" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "'", 1);
            A.LABEL(POURCENTAGE, "EXEC AFFICHER_DETAILS_FAUTE '" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "'", 0);
            NOM.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            POSTNOM.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            PRENOM.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            A.GET_PHOTO("ELEVE", "MATRICULE", "" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "", pictureBox2);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            dataGridView3.DataSource = A.TABLEAU("SELECT DETAILS_SANCTION.DATE,DETAILS_SANCTION.HEURE,LISTE_INSCRIT_JOURNALIER.NOM,LISTE_INSCRIT_JOURNALIER.POSTNOM,LISTE_INSCRIT_JOURNALIER.PRENOM, LISTE_DE_SANCTION.DESIGNATION,LISTE_DE_SANCTION.PONDERATION FROM DETAILS_SANCTION INNER JOIN SANCTION ON SANCTION.ID=DETAILS_SANCTION.ID INNER JOIN LISTE_DE_SANCTION ON LISTE_DE_SANCTION.ID=SANCTION.MOTIF	INNER JOIN LISTE_INSCRIT_JOURNALIER ON LISTE_INSCRIT_JOURNALIER.MATRICULE=SANCTION.MATRICULE_ELEVE WHERE DETAILS_SANCTION.PERIODE=(SELECT MAX(ID) FROM periode)	AND CONCAT(NOM,' ',PRENOM,' ',PRENOM) LIKE '%" + textBox3 .Text+ "%'");
          
        }
    }
}
