using cours_dwesign_time.RPT_REPORT;
using DevExpress.XtraReports.UI;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ECOLE_SECONDAIRE.DESIGN_USER_CONTROL
{
    public partial class ADMINISTRATION_BULLETIN : UserControl
    {

        CLASS_DATA_BASE.CLS_GLOSSIERE A = new CLASS_DATA_BASE.CLS_GLOSSIERE();
        string CHARGEMENT_NIVEAU = "SELECT NIVEAU_ETUDE FROM SALLE_DE_CLASS GROUP BY NIVEAU_ETUDE";
      
        public ADMINISTRATION_BULLETIN()
        {
            InitializeComponent();
            A.CHARGE_COMBO(NIVEAU, "" + CHARGEMENT_NIVEAU);
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = A.TABLEAU("SELECT MATRICULE,NOM,POSTNOM,PRENOM FROM LISTE_INSCRIT_JOURNALIER WHERE NIVEAU_ETUDE="+NIVEAU.SelectedItem+" AND ABREVIATION='"+ABREVIATION.SelectedItem+"' AND LETTRE='"+DESIGNATION.SelectedItem+"'");
       
      
        }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }

        private void ADMINISTRATION_BULLETIN_Load(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            REPORT.BULLETIN rpt = new REPORT.BULLETIN();
            rpt.DataSource = A.get_Report_Z("BULLETIN_PRINT", " WHERE MATRICULE='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' AND ANNE=(SELECT MAX(ID) FROM ANNE_SCOLAIRE) ", "MATRICULE,   NOM,POSTNOM,PRENOM,PHOTO,NIVEAU_ETUDE, ABREVIATION,LETTRE,PROVINCE,VILLE,M1,M2,M3,M4,M5,M6,M7,M8,M9,M10,DESIGNATION,P1,P2,EX1,SM1,P3,P4,EX2,SM2,TOTAL,PONDERATION,ANNE,(select SUBSTRING(convert(varchar(34), (sum(point)*100.0/sum(ponderation))),1,5) from PERIODE1 where anne=(select max(id) from ANNE_SCOLAIRE) and MATRICULE='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "') as pourcentage_p_1,(select SUBSTRING(convert(varchar(34), (sum(point)*100.0/sum(ponderation))),1,5) from PERIODE2 where anne=(select max(id) from ANNE_SCOLAIRE) and MATRICULE='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "') as pourcentage_p_2,(select SUBSTRING(convert(varchar(34), (sum(point)*100.0/sum(ponderation))),1,5) from EXAMEN1 where anne=(select max(id) from ANNE_SCOLAIRE) and MATRICULE='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "') as pourcentage_E_1,(select SUBSTRING(convert(varchar(34), (sum(point)*100.0/sum(ponderation))),1,5) from PERIODE3 where anne=(select max(id) from ANNE_SCOLAIRE) and MATRICULE='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "') as pourcentage_p_3,(select SUBSTRING(convert(varchar(34), (sum(point)*100.0/sum(ponderation))),1,5) from PERIODE4 where anne=(select max(id) from ANNE_SCOLAIRE) and MATRICULE='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "') as pourcentage_p_4,(select SUBSTRING(convert(varchar(34), (sum(point)*100.0/(sum(ponderation)*2))),1,5) from EXAMEN2 where anne=(select max(id) from ANNE_SCOLAIRE) and MATRICULE='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "') as pourcentage_EX_2,(SELECT SUBSTRING(convert(varchar(34), (SUM(SM1)*100.0/(SUM(PONDERATION)*4))),1,5) FROM BULLETIN_PRINT WHERE ANNE=(SELECT MAX(ID) FROM ANNE_SCOLAIRE) AND MATRICULE='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "') AS pourcentage_SM_1,(SELECT SUBSTRING(convert(varchar(34), (SUM(SM2)*100.0/(SUM(PONDERATION)*4))),1,5) FROM BULLETIN_PRINT	 WHERE ANNE=(SELECT MAX(ID) FROM ANNE_SCOLAIRE) AND MATRICULE='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "') AS pourcentage_SM_2");
            using (ReportPrintTool printTool = new ReportPrintTool(rpt))
            {
                printTool.ShowPreviewDialog();
            }
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
            dataGridView1.DataSource = A.TABLEAU("SELECT MATRICULE,NOM,POSTNOM,PRENOM,CLASSE FROM LISTE_INSCRIT_JOURNALIER WHERE NIVEAU_ETUDE=" + NIVEAU.SelectedItem.ToString() + " AND ABREVIATION='" + ABREVIATION.SelectedItem.ToString() + "' AND LETTRE='" + DESIGNATION.SelectedItem.ToString() + "'");
       
     
        }
    }
}
