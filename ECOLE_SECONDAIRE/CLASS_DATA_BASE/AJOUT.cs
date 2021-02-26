//using DevExpress.XtraReports.UI;
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

namespace ECOLE_SECONDAIRE.CLASS_DATA_BASE
{
    class AJOUT
    {
        public static SqlConnection con = MYCONNECTION.con;
            public static SqlCommand cmd = new SqlCommand("", con);//manipuler et envoie les requete dans la bese de donnes

        public static SqlDataAdapter dt = null;//de lire de donnes donnes en entierete dans la bd
        public static SqlDataReader dr = null;//permet de lire de donne ligne par ligne
        public static DataSet ds = null;
        public static string imgLon = ""; 
        public void CHOISIR_IMAGE(PictureBox picture)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|GIF Files(*.gif)|*.gif|All Files(*.*)|*.*";
            dlg.Title = "Selectionner une image";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgLon = dlg.FileName.ToString();
                picture.ImageLocation = imgLon;
            }
        }

        ///////////////////////////////////////////AJOUT ANNE ACADEMIQUE
        public void ANNEE_ACADEMIQUE(string anne)
        {
            con.Open();
            try {
              //  MessageBox.Show("insert into ANNE_SCOLAIRE (DESIGNATION)values('" + anne + "')");
                cmd.CommandText = ("insert into ANNE_SCOLAIRE (DESIGNATION)values('" + anne + "')");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Annee modifier avec success");
            }
            catch(SqlException ex){
                MessageBox.Show("insert into ANNE_SCOLAIRE (DESIGNATION)values('" + anne + "')"+ex);
            }
            con.Close();
        }
        /////////////////////////////////////////AJOUT DEPARTEMENT
        public void DEPARTEMENT(string DESIGNATION,int MONTANT)
        {
          
            con.Open();
            try
            {
                //  MessageBox.Show("insert into ANNE_SCOLAIRE (DESIGNATION)values('" + anne + "')");
                cmd.CommandText = ("EXEC AJOUTER_DEPARTEMENT_SALAIRE '"+DESIGNATION+"',"+MONTANT+"");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Departement ajouter avec success");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("" + ex);
            }
            con.Close();
        }

        //////////////////////////////////////////AJOUT SECTION///////////////////////////////////////////////////////////////////////////////////////////////

        public void SECTION(Guna2TextBox DESIGNATION, Guna2TextBox ABREVIATION)
        {
            if (ABREVIATION.Text == "")
            {
                ABREVIATION.BorderColor = System.Drawing.Color.Red;
                ABREVIATION.PlaceholderText = "Entrer la designation de la section";
            }
            else
            {
                con.Open();
                try
                {
                    cmd.CommandText = ("INSERT INTO SECTION (DESIGNATION,ABREVIATION) VALUES ('"+DESIGNATION.Text+"','" + ABREVIATION.Text + "')");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Section ajouter avec success", "ENREGISTRER", MessageBoxButtons.OK, MessageBoxIcon.None);

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("" + ex);
                }
                con.Close();
            }
        }

      

        public void AGENT(Guna2TextBox NOM, Guna2TextBox POSTNOM, Guna2TextBox PRENOM,Guna2TextBox TELEPHONE, Guna2DateTimePicker DATE,
            Guna2ComboBox DEPARTEMENT, Guna2TextBox VILLE, Guna2TextBox QUARTIER, Guna2TextBox AVENU, Guna2TextBox NUMERO)
        {
            NOM.BorderColor = System.Drawing.Color.Black;
            POSTNOM.BorderColor = System.Drawing.Color.Black;
            PRENOM.BorderColor = System.Drawing.Color.Black;
            VILLE.BorderColor = System.Drawing.Color.Black;
            QUARTIER.BorderColor = System.Drawing.Color.Black;
            AVENU.BorderColor = System.Drawing.Color.Black;
            NUMERO.BorderColor = System.Drawing.Color.Black;
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
            else if (VILLE.Text == "")
            {
                VILLE.BorderColor = System.Drawing.Color.Red;
            }
            else if (QUARTIER.Text == "")
            {
                QUARTIER.BorderColor = System.Drawing.Color.Red;
            }
            else if (AVENU.Text == "")
            {
                AVENU.BorderColor = System.Drawing.Color.Red;
            }
            else if (NUMERO.Text == "")
            {
                NUMERO.BorderColor = System.Drawing.Color.Red;
            }
            else
            {
                con.Open();
                try {
                    byte[] img = null;
                   
                    cmd.Parameters.Clear();
                    FileStream fs = new FileStream(imgLon, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    cmd.CommandText = ("EXEC AJOUT_AGENT '" + NOM.Text + "','" + POSTNOM.Text + "','" + PRENOM.Text + "',NULL,@IMAGE,'" + DEPARTEMENT.SelectedItem.ToString() + "','" + TELEPHONE.Text + "','" + VILLE.Text + "','" + QUARTIER.Text + "','" + AVENU.Text + "'," + NUMERO.Text + "");
                   cmd.Parameters.Add(new SqlParameter("@IMAGE", img));
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("L'agent a ete bien ajouter", "AJOUTER", MessageBoxButtons.OK, MessageBoxIcon.None);
                    img = null;
                    
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(""+ex);
                }
                con.Close();

            }
        }

        public void ELEVE(Guna2TextBox NOM, Guna2TextBox POSTNOM, Guna2TextBox PRENOM, Guna2TextBox PAYS, Guna2TextBox PROVINCE,
            Guna2TextBox VILLE, Guna2TextBox QUARTIER, Guna2TextBox AVENU, Guna2TextBox NUMERO, Guna2TextBox EMAIL, Guna2TextBox CELLULAIRE,
            Guna2TextBox NOM_T, Guna2TextBox POSTNOM_T, Guna2TextBox PRENOM_T, Guna2TextBox EMAIL_T, Guna2TextBox CELLULAIRE_T,
            Guna2ComboBox NIVEAU,Guna2ComboBox ABREVIATION,Guna2ComboBox LETTRE)
        {
           
                con.Open();
                try
                {
                    byte[] img = null;

                    cmd.Parameters.Clear();
                    FileStream fs = new FileStream(imgLon, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    cmd.CommandText = ("EXEC INSCRIPTION_ETUDIANT '" + NOM.Text + "','" + POSTNOM.Text + "','" + PRENOM.Text + "',@IMAGE," + NIVEAU.SelectedItem.ToString() + ",'" + ABREVIATION.SelectedItem.ToString() + "','" + LETTRE.SelectedItem.ToString() + "','" + EMAIL.Text + "','" + CELLULAIRE.Text + "','" + PAYS.Text + "','" + PROVINCE.Text + "','" + VILLE.Text + "','" + QUARTIER.Text + "','" + AVENU.Text + "','" + NUMERO.Text + "','" + NOM_T.Text + "','" + POSTNOM_T.Text + "','" + PRENOM_T.Text + "','" + EMAIL_T.Text + "','" + CELLULAIRE_T.Text + "'");
                    cmd.Parameters.Add(new SqlParameter("@IMAGE", img));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("L'etudiant a ete bien ajouter", "AJOUTER", MessageBoxButtons.OK, MessageBoxIcon.None);
                    img = null;

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("" + ex);
                }
                con.Close();

         
        }

        public void NIVEAU(Guna2NumericUpDown IEME)
        {
          
                con.Open();
                try
                {
                    cmd.CommandText = ("INSERT INTO NIVEAU_ETUDE(NIVEAU) VALUES("+IEME.Value.ToString()+")");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Niveau ajouter avec success", "ENREGISTRER", MessageBoxButtons.OK, MessageBoxIcon.None);

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("" + ex);
                }
                con.Close();
            }

        public void SALLE(Guna2ComboBox IEME,Guna2ComboBox section, Guna2TextBox designation,Guna2TextBox place,ListBox prof)
        {

            con.Open();
            try
            {
                cmd.CommandText = ("EXEC NOUVEAU_SALLE "+IEME.SelectedItem.ToString()+",'"+section.SelectedItem.ToString()+"','"+designation.Text+"',"+place.Text+",'"+prof.SelectedItem.ToString()+"'");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Salle ajouter avec succes", "ENREGISTRER", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("" + ex);
            }
            con.Close();
        }

        public void GET_PHOTO(string table, string colonne_ref, string reference, PictureBox picemp)
        {
            con.Open();
            try
            {

                cmd.CommandText = "select  PHOTO from AGENT where concat(nom,' ',postnom,' ',prenom)='" + reference + "'";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    byte[] img = (byte[])(dr[0]);
                    if (img == null)
                        picemp.Image = null;
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        picemp.Image = System.Drawing.Image.FromStream(ms);
                    }

                }
                
              //  Console.WriteLine("select PHOTO from " + table + " where " + colonne_ref + "='" + reference + "'");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("" + ex);
            }
            con.Close();
        }

        public void CONTRAINT_DESIGNATION_SALLE(int NIVEAU,string session,Guna2TextBox designation,Guna2Button valide)
        {
            valide.Enabled = true;
            
            try
            {
                con.Open();

                cmd.CommandText = "SELECT COUNT(*) FROM SALLE INNER JOIN DESIGNATION_SALLE on SALLE.ID=DESIGNATION_SALLE.ID_SALLE INNER JOIN SECTION ON SALLE.SECTION=SECTION.ID where LETTRE='"+designation.Text+"' AND NIVEAU_ETUDE="+NIVEAU+" AND SECTION.ABREVIATION='"+session+"'";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    
                    if (int.Parse(dr[0].ToString()) == 1) {
                        //  designation.Text = "";
                        MessageBox.Show("Cette salle existe deja, choisir une autres", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        valide.Enabled = false;
                    }
                    else
                    {
                    }  

                }

                con.Close();//  Console.WriteLine("select PHOTO from " + table + " where " + colonne_ref + "='" + reference + "'");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("" + ex);
            }
        
        }

        }
      

    }

