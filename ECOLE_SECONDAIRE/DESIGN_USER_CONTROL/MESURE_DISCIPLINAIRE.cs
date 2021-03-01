using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ECOLE_SECONDAIRE.DESIGN_BOXES;

namespace ECOLE_SECONDAIRE.DESIGN_USER_CONTROL
{
    public partial class MESURE_DISCIPLINAIRE : UserControl
    {
        CLASS_DATA_BASE.CLS_GLOSSIERE A = new CLASS_DATA_BASE.CLS_GLOSSIERE();
        CLASS_DATA_BASE.AJOUT B = new CLASS_DATA_BASE.AJOUT();
        CLASS_DESIGN.DESIGN a = new CLASS_DESIGN.DESIGN();
        string CHARGEMENT_NIVEAU = "SELECT NIVEAU_ETUDE FROM SALLE_DE_CLASS GROUP BY NIVEAU_ETUDE";
        public MESURE_DISCIPLINAIRE()
        {
            InitializeComponent();
            A.CHARGE_COMBO(NIVEAU, "" + CHARGEMENT_NIVEAU);
            dataGridView3.DataSource = A.TABLEAU("select * from LISTE_DE_SANCTION");
       
      
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void picture_Click(object sender, EventArgs e)
        {

        }

        private void table_commande_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void MESURE_DISCIPLINAIRE_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FAUTE().Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            A.GET_PHOTO("ELEVE", "MATRICULE", "" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "", pictureBox2);
            guna2Button1.Enabled = true;
            NOM.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            POSTNOM.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            PRENOM.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            A.EXEC_UNIVERSEL("SANCTIONNER", "'" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView3.CurrentRow.Cells[1].Value.ToString() + "'", "SANCTION");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            a.APPEL_PANEL(new DESIGN_USER_CONTROL.DETAILS_SANCTION(), DASHBOARD.c);
            
        }
    }
}
