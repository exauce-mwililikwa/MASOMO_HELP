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
    public partial class HORAIRE_HEBDOMADAIRE : UserControl
    {
        CLASS_DATA_BASE.CLS_GLOSSIERE A = new CLASS_DATA_BASE.CLS_GLOSSIERE();
        CLASS_DATA_BASE.AJOUT B = new CLASS_DATA_BASE.AJOUT();

        string CHARGEMENT_NIVEAU = "SELECT NIVEAU_ETUDE FROM SALLE_DE_CLASS GROUP BY NIVEAU_ETUDE";
        public HORAIRE_HEBDOMADAIRE()
        {
            InitializeComponent();
            A.CHARGE_COMBO(NIVEAU, "" + CHARGEMENT_NIVEAU);
            A.CHARGE_COMBO(JOUR, "SELECT JOUR FROM PROGRAMME_JOURNE");
            A.CHARGE_COMBO(HEURE, "EXEC NOMBRE_HEURE 'MERCREDI'");
        }

        private void NIVEAU_SelectedIndexChanged(object sender, EventArgs e)
        {
            ABREVIATION.Enabled = true;
            ABREVIATION.Items.Clear();
            string SESSION = "SELECT ABREVIATION FROM SALLE_DE_CLASS WHERE NIVEAU_ETUDE=" + NIVEAU.SelectedItem.ToString() + " GROUP BY ABREVIATION";
            A.CHARGE_COMBO(ABREVIATION, "" + SESSION);
           
        }

        private void DESIGNATION_SelectedIndexChanged(object sender, EventArgs e)
        {

            DESIGNATION.Enabled = true;
            DESIGNATION.Items.Clear();
            string SESSION = "SELECT LETTRE FROM SALLE_DE_CLASS WHERE NIVEAU_ETUDE=" + NIVEAU.SelectedItem.ToString() + " AND ABREVIATION='" + ABREVIATION.SelectedItem.ToString() + "'";
            A.CHARGE_COMBO(DESIGNATION, "" + SESSION);
        }

        private void ABREVIATION_SelectedIndexChanged(object sender, EventArgs e)
        {
            A.LABEL(TITULAIRE, "EXEC SITUATION_TITULARISATIO " + NIVEAU.SelectedItem.ToString() + ",'" + ABREVIATION.SelectedItem.ToString() + "','" + DESIGNATION.SelectedItem.ToString() + "'", 0);
          A.LABEL(NOMBRE_PLACE, "EXEC SITUATION_TITULARISATIO " + NIVEAU.SelectedItem.ToString() + ",'" + ABREVIATION.SelectedItem.ToString() + "','" + DESIGNATION.SelectedItem.ToString() + "'",1);
          A.LABEL(DESIGNATION_SALLE, "EXEC SITUATION_TITULARISATIO " + NIVEAU.SelectedItem.ToString() + ",'" + ABREVIATION.SelectedItem.ToString() + "','" + DESIGNATION.SelectedItem.ToString() + "'", 7);
          A.LABEL(NOMBRE_COURS, "EXEC SITUATION_TITULARISATIO " + NIVEAU.SelectedItem.ToString() + ",'" + ABREVIATION.SelectedItem.ToString() + "','" + DESIGNATION.SelectedItem.ToString() + "'", 6);
          A.LABEL(NOMBRE_ELEVE, "EXEC SITUATION_TITULARISATIO " + NIVEAU.SelectedItem.ToString() + ",'" + ABREVIATION.SelectedItem.ToString() + "','" + DESIGNATION.SelectedItem.ToString() + "'", 8);
          dataGridView1.DataSource = A.TABLEAU("SELECT DESIGNATION,PONDERATION, NOMBRE_JOURNALIER ,MATRICULE FROM COURS_SALLE WHERE NIVEAU_ETUDE=" + NIVEAU.SelectedItem.ToString() + " AND ABREVIATION='" + ABREVIATION.SelectedItem.ToString() + "' AND LETTRE='" + DESIGNATION.SelectedItem.ToString() + "'");
          dataGridView2.DataSource = A.TABLEAU(" SELECT HEURE,LUNDI,MARDI,MERCREDI,JEUDI,VENDREDI,SAMEDI FROM PROGRAMME_GENERAL WHERE NIVEAU_ETUDE=" + NIVEAU.SelectedItem.ToString() + " AND ABREVIATION='" + ABREVIATION.SelectedItem.ToString() + "' AND LETTRE='" + DESIGNATION.SelectedItem.ToString() + "'");
         
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new DESIGN_BOXES.PARAMETRE_JOUR().Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            A.LABEL(NOM, " SELECT * FROM COURS_SALLE WHERE MATRICULE='" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "'", 4);
            A.LABEL(POSTNOM, " SELECT * FROM COURS_SALLE WHERE MATRICULE='" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "'", 5);
            A.LABEL(PRENOM, " SELECT * FROM COURS_SALLE WHERE MATRICULE='" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "'", 6);
            A.LABEL(MATRICULE, " SELECT * FROM COURS_SALLE WHERE MATRICULE='" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "'", 3);
            A.LABEL(NOMBRE_HEURE, "SELECT * FROM COURS_SALLE WHERE DESIGNATION='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' AND NIVEAU_ETUDE=" + NIVEAU.SelectedItem.ToString() + " AND ABREVIATION='" + ABREVIATION.SelectedItem.ToString() + "' AND LETTRE='" + DESIGNATION.SelectedItem.ToString() + "'", 10);
            A.LABEL(DEJA_PROGRAMMER, "EXEC DEJA_PROGRAMMER_COURS '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "',"+NIVEAU.SelectedItem.ToString()+",'"+ABREVIATION.SelectedItem.ToString()+"','"+DESIGNATION.SelectedItem.ToString()+"'", 0);

            if (int.Parse(NOMBRE_HEURE.Text) == int.Parse(DEJA_PROGRAMMER.Text))
            {
                guna2Button1.Enabled = false;
            }
            else
            {
                guna2Button1.Enabled = true;
            }
        }

        private void JOUR_SelectedIndexChanged(object sender, EventArgs e)
        {
            A.CHARGE_COMBO(HEURE, "EXEC NOMBRE_HEURE 'MERCREDI'");
            Console.WriteLine("EXEC NOMBRE_HEURE '" + JOUR.SelectedItem.ToString() + "'");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            A.EXEC_UNIVERSEL("PROGRAMMER_COURS_HORAIRE", "" + NIVEAU.SelectedItem.ToString() + ",'" + ABREVIATION.SelectedItem.ToString() + "','" + DESIGNATION.SelectedItem.ToString() + "','" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','"+JOUR.SelectedItem.ToString()+"',"+HEURE.SelectedItem.ToString()+"", "PROGRAMME");
            dataGridView2.DataSource = A.TABLEAU(" SELECT HEURE,LUNDI,MARDI,MERCREDI,JEUDI,VENDREDI,SAMEDI FROM PROGRAMME_GENERAL WHERE NIVEAU_ETUDE=" + NIVEAU.SelectedItem.ToString() + " AND ABREVIATION='" + ABREVIATION.SelectedItem.ToString() + "' AND LETTRE='" + DESIGNATION.SelectedItem.ToString() + "'");
            A.LABEL(NOMBRE_HEURE, "SELECT * FROM COURS_SALLE WHERE DESIGNATION='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' AND NIVEAU_ETUDE=" + NIVEAU.SelectedItem.ToString() + " AND ABREVIATION='" + ABREVIATION.SelectedItem.ToString() + "' AND LETTRE='" + DESIGNATION.SelectedItem.ToString() + "'", 10);
            A.LABEL(DEJA_PROGRAMMER, "EXEC DEJA_PROGRAMMER_COURS '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'," + NIVEAU.SelectedItem.ToString() + ",'" + ABREVIATION.SelectedItem.ToString() + "','" + DESIGNATION.SelectedItem.ToString() + "'", 0);
       
        }

        private void HEURE_SelectedIndexChanged(object sender, EventArgs e)
        {
            COURS.Text = "LIBRE";
            SALLE.Text = "LIBRE";
            A.LABEL(COURS, " EXEC SELECTIONNER_RESSEMBLANCE_HORAIRE '" + JOUR.SelectedItem.ToString() + "','" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "'," + HEURE.SelectedItem.ToString() + "", 0);
            A.LABEL(SALLE, " EXEC SELECTIONNER_RESSEMBLANCE_HORAIRE '" + JOUR.SelectedItem.ToString() + "','" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "'," + HEURE.SelectedItem.ToString() + "", 1);
            if (COURS.Text != "LIBRE")
            {
                guna2Button1.Enabled = false;
            }
            else
            {
                guna2Button1.Enabled = true;
            }
        }
    }
}
