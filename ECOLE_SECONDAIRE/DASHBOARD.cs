using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ECOLE_SECONDAIRE
{
    public partial class DASHBOARD : Form
    {
        public static Panel c;
        CLASS_DESIGN.DESIGN a = new CLASS_DESIGN.DESIGN();
        public DASHBOARD()
        {
           InitializeComponent();
            c = panel4;
        }
        
        
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void eEJFEJFToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void administratioN_SALLE1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
            
        {
            a.APPEL_PANEL(new DESIGN_USER_CONTROL.INSCRIPTION_ELEVE(),panel4);
            
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            a.APPEL_PANEL(new DESIGN_USER_CONTROL.MESURE_DISCIPLINAIRE(), panel4);
            
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            a.APPEL_PANEL(new DESIGN_USER_CONTROL.COTATION_TRAVAIL(), panel4);
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            a.APPEL_PANEL(new DESIGN_USER_CONTROL.AFFECTATION_RESULTAT(), panel4);
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            a.APPEL_PANEL(new DESIGN_USER_CONTROL.AJOUT_AGENT(), panel4);
            
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            a.APPEL_PANEL(new DESIGN_USER_CONTROL.ADMINISTRATION_BULLETIN(), panel4);
            

            
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            a.APPEL_PANEL(new DESIGN_USER_CONTROL.PAIEMENT_ELEVE(), panel4);
            
           
        }

        private void aJOTERToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void aNNEEACADEMIQUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DESIGN_BOXES.ANNE_SCOLAIRE().Show();
        }

        private void dEPARTEMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DESIGN_BOXES.AJOUT_DEPARTEMENT().Show();
        }

        private void sECTIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DESIGN_BOXES.SECTION().Show();
        }

        private void sALLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a.APPEL_PANEL(new DESIGN_USER_CONTROL.SALLE_DE_CLASSE(), panel4);
        }

        private void cOURSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a.APPEL_PANEL(new DESIGN_USER_CONTROL.ADMINISTRATION_COURS(), panel4);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            a.APPEL_PANEL(new DESIGN_USER_CONTROL.LISTE_ELEVE(), panel4);
        }

        private void hORAIRESEMESTRIELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a.APPEL_PANEL(new DESIGN_USER_CONTROL.HORAIRE_HEBDOMADAIRE(), panel4);
        }
    }
}
