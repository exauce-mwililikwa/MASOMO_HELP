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
    public partial class LISTE_ELEVE : UserControl
    {
        CLASS_DESIGN.DESIGN a = new CLASS_DESIGN.DESIGN();
        CLASS_DATA_BASE.CLS_GLOSSIERE A = new CLASS_DATA_BASE.CLS_GLOSSIERE();

        string CHARGEMENT_NIVEAU = "SELECT NIVEAU_ETUDE FROM SALLE_DE_CLASS GROUP BY NIVEAU_ETUDE";
        public LISTE_ELEVE()
        {
            InitializeComponent();
            A.CHARGE_COMBO(NIVEAU, "" + CHARGEMENT_NIVEAU);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            a.APPEL_PANEL(new DESIGN_USER_CONTROL.INSCRIPTION_ELEVE(), DASHBOARD.c);
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ABREVIATION.Enabled = true;
            ABREVIATION.Items.Clear();
            string SESSION = "SELECT ABREVIATION FROM SALLE_DE_CLASS WHERE NIVEAU_ETUDE=" + NIVEAU.SelectedItem.ToString() + " GROUP BY ABREVIATION";
            A.CHARGE_COMBO(ABREVIATION, "" + SESSION);
            dataGridView1.DataSource = A.TABLEAU("SELECT MATRICULE,NOM,POSTNOM,PRENOM,CLASSE,ABREVIATION,LETTRE FROM LISTE_INSCRIT_JOURNALIER WHERE NIVEAU_ETUDE="+NIVEAU.SelectedItem.ToString()+"");
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DESIGNATION.Enabled = true;
            DESIGNATION.Items.Clear();
            string SESSION = "SELECT LETTRE FROM SALLE_DE_CLASS WHERE NIVEAU_ETUDE=" + NIVEAU.SelectedItem.ToString() + " AND ABREVIATION='" + ABREVIATION.SelectedItem.ToString() + "'";
            A.CHARGE_COMBO(DESIGNATION, "" + SESSION);
            dataGridView1.DataSource = A.TABLEAU("SELECT MATRICULE,NOM,POSTNOM,PRENOM,LETTRE,CLASSE FROM LISTE_INSCRIT_JOURNALIER WHERE NIVEAU_ETUDE="+NIVEAU.SelectedItem.ToString()+" AND ABREVIATION='"+ABREVIATION.SelectedItem.ToString()+"'");
       
        }

        private void DESIGNATION_SelectedIndexChanged(object sender, EventArgs e)
        {
            A.LABEL(NOMBRE_PLACE, "EXEC SITUATION_TITULARISATIO " + NIVEAU.SelectedItem.ToString() + ",'" + ABREVIATION.SelectedItem.ToString() + "','" + DESIGNATION.SelectedItem.ToString() + "'", 1);
            A.LABEL(TITULAIRE, "EXEC SITUATION_TITULARISATIO " + NIVEAU.SelectedItem.ToString() + ",'" + ABREVIATION.SelectedItem.ToString() + "','" + DESIGNATION.SelectedItem.ToString() + "'", 0);
            A.LABEL(PLACE_LIBRE, "EXEC SITUATION_TITULARISATIO " + NIVEAU.SelectedItem.ToString() + ",'" + ABREVIATION.SelectedItem.ToString() + "','" + DESIGNATION.SelectedItem.ToString() + "'", 2);
            
            dataGridView1.DataSource = A.TABLEAU("SELECT MATRICULE,NOM,POSTNOM,PRENOM,CLASSE FROM LISTE_INSCRIT_JOURNALIER WHERE NIVEAU_ETUDE="+NIVEAU.SelectedItem.ToString()+" AND ABREVIATION='"+ABREVIATION.SelectedItem.ToString()+"' AND LETTRE='"+DESIGNATION.SelectedItem.ToString()+"'");
       
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NOM.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            POSTNOM.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            PRENOM.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            MATRICULE.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            CLASSE.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
           // ID.Text = dataGridView1.CurrentRow.Cells[0].Value(5, 9);
            A.GET_PHOTO("ELEVE", "MATRICULE", "" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "", pictureBox1);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            new DESIGN_BOXES.INFORMATION_ELEVE(""+MATRICULE.Text+"").Show();
        }
    }
}
