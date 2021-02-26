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
    public partial class SALLE_DE_CLASSE : UserControl
    {
        string NIVEAU_P = "select * from NIVEAU_ETUDE";
        string SECTION_P = "select SECTION.ABREVIATION from SECTION";
        string nom_prof = "SELECT CONCAT(NOM,' ',POSTNOM ,' ',PRENOM) FROM AGENT LEFT JOIN TITULARISATION_SALLE ON TITULARISATION_SALLE.AGENT=AGENT.MATRICULE AND TITULARISATION_SALLE.ANNE=(SELECT MAX(ID) FROM ANNE_SCOLAIRE) WHERE  ISNULL(TITULARISATION_SALLE.SALLE,0)=0";
        string TABLEAU_SALLE = "SELECT SALLE.NIVEAU_ETUDE,SECTION.DESIGNATION,ABREVIATION,DESIGNATION_SALLE.LETTRE,DESIGNATION_SALLE.NOMBRE_PLACE,CONCAT(AGENT.NOM,' ',AGENT.POSTNOM,' ',PRENOM) AS TITULAIRE FROM SALLE INNER JOIN DESIGNATION_SALLE on SALLE.ID=DESIGNATION_SALLE.ID_SALLE INNER JOIN SECTION ON  SALLE.SECTION=SECTION.ID INNER JOIN TITULARISATION_SALLE ON TITULARISATION_SALLE.SALLE=DESIGNATION_SALLE.ID INNER JOIN  AGENT ON AGENT.MATRICULE=TITULARISATION_SALLE.AGENT";
        CLASS_DATA_BASE.CLS_GLOSSIERE A = new CLASS_DATA_BASE.CLS_GLOSSIERE();
        CLASS_DATA_BASE.AJOUT B = new CLASS_DATA_BASE.AJOUT();
        public SALLE_DE_CLASSE()
        {
            InitializeComponent();
            A.CHARGE_COMBO(SECTION,SECTION_P);
            A.CHARGE_COMBO(NIVEAU, NIVEAU_P);
            A.CHARGE_LIST(PROF, ""+nom_prof);
            SALLE.DataSource = A.TABLEAU(TABLEAU_SALLE);
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            new DESIGN_BOXES.AJOUT_NIVEAU().Show();
        }

        private void SALLE_DE_CLASSE_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            PROF.Items.Clear();
            nom_prof = "SELECT TOP 12 CONCAT(NOM,' ',POSTNOM,' ',PRENOM) FROM AGENT WHERE CONCAT(NOM,' ',POSTNOM,' ',PRENOM) LIKE '%" + guna2TextBox3.Text+ "%'";
            A.CHARGE_LIST(PROF, "" + nom_prof);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            B.GET_PHOTO("AGENT", "CONCAT(NOM,' ',POSTNOM,' ',PRENOM)", "" + PROF.SelectedItem.ToString(), pictureBox2);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            B.SALLE(NIVEAU, SECTION, DESIGNATION, PLACE, PROF);
            PROF.Items.Clear();
            A.CHARGE_LIST(PROF, "" + nom_prof);

           
        }

        private void DESIGNATION_TextChanged(object sender, EventArgs e)
        {
            B.CONTRAINT_DESIGNATION_SALLE(int.Parse(NIVEAU.SelectedItem.ToString()), "" + SECTION.SelectedItem.ToString(), DESIGNATION, guna2Button4);
        }

        private void SALLE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NIVEAU_LABEL.Text = SALLE.CurrentRow.Cells[0].Value.ToString();
            SECTION_LABEL.Text = SALLE.CurrentRow.Cells[2].Value.ToString();
            DESIGNATION_LABEL.Text = SALLE.CurrentRow.Cells[3].Value.ToString();
            NOMBRE.Text = SALLE.CurrentRow.Cells[4].Value.ToString();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            new DESIGN_BOXES.SECTION().Show();
        }
    }
}
