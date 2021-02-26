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
    public partial class AJOUT_AGENT : UserControl
    {
          public static string TABLEAU_AGENT = "SELECT INSCRIPTION_AGENT.MATRICULE,AGENT.NOM,AGENT.POSTNOM,AGENT.PRENOM,DEPARTEMENT.DESIGNATION FROM INSCRIPTION_AGENT INNER JOIN AGENT ON INSCRIPTION_AGENT.MATRICULE=AGENT.MATRICULE INNER JOIN DEPARTEMENT ON DEPARTEMENT.ID=INSCRIPTION_AGENT.DEPARTEMENT INNER JOIN DETAIL_INSCRIPTION_AGENT ON DETAIL_INSCRIPTION_AGENT.ID_INSCRIPTION_AGENT=INSCRIPTION_AGENT.ID";

        CLASS_DATA_BASE.CLS_GLOSSIERE A = new CLASS_DATA_BASE.CLS_GLOSSIERE();
        CLASS_DATA_BASE.AJOUT B = new CLASS_DATA_BASE.AJOUT();


        public string DEPARTEMENT_AGENT = "select DESIGNATION from DEPARTEMENT";
        public AJOUT_AGENT()
        {
            InitializeComponent();
            A.CHARGE_COMBO(DEPARTEMENT, DEPARTEMENT_AGENT);
            A.MIN_DATE(DATE);
            A.MAX_DATE(DATE);
            AGENT_TABLE.DataSource = A.TABLEAU(TABLEAU_AGENT);

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            B.CHOISIR_IMAGE(pictureBox1);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            B.AGENT(NOM, POSTNOM, PRENOM, TELEPHONE, DATE, DEPARTEMENT, VILLE, QUARTIER, AVENU,NUMERO);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TABLEAU_AGENT = "SELECT INSCRIPTION_AGENT.MATRICULE,AGENT.NOM,AGENT.POSTNOM,AGENT.PRENOM,DEPARTEMENT.DESIGNATION FROM INSCRIPTION_AGENT INNER JOIN AGENT ON INSCRIPTION_AGENT.MATRICULE=AGENT.MATRICULE INNER JOIN DEPARTEMENT ON DEPARTEMENT.ID=INSCRIPTION_AGENT.DEPARTEMENT INNER JOIN DETAIL_INSCRIPTION_AGENT ON DETAIL_INSCRIPTION_AGENT.ID_INSCRIPTION_AGENT=INSCRIPTION_AGENT.ID WHERE CONCAT(NOM,' ',POSTNOM,' ',PRENOM) LIKE '%" + textBox1.Text+ "%'";
            AGENT_TABLE.DataSource = A.TABLEAU(TABLEAU_AGENT);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
