using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ECOLE_SECONDAIRE.CLASS_DATA_BASE
{
    class CLS_GLOSSIERE
    {
        public static SqlConnection con = MYCONNECTION.con;
        public static SqlCommand cmd = new SqlCommand("", con);//manipuler et envoie les requete dans la bese de donnes

        public static SqlDataAdapter dt = null;//de lire de donnes donnes en entierete dans la bd
        public static SqlDataReader dr = null;//permet de lire de donne ligne par ligne
        public static DataSet ds = null;
        ////////////////////////////////////////CHARGEMENT LABEL UNIQUE 

        public  void LABEL(Label prix, string rqt,int column)
        {
            con.Open();
            cmd.CommandText = rqt;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                prix.Text = dr[column].ToString();
            }
            con.Close();
        }
        public void TEXT(Guna2TextBox prix, string rqt, int column)
        {
            con.Open();
            cmd.CommandText = rqt;
           dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                prix.Text = dr[column].ToString();
            }
            con.Close();
        }

        //////////////////////////////CHARGEMENT COMBO

        public  void CHARGE_COMBO(Guna2ComboBox COMBO, string RQT)
        {

            con.Open();

            cmd.CommandText = ""+RQT;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                COMBO.Items.Add(dr[0]);
            }
            con.Close();
        }

           public void GET_PHOTO(string table, string colonne_ref, string reference, PictureBox picemp)
        {
            con.Open();
            try
            {

                cmd.CommandText = "select  PHOTO from "+table+" where "+colonne_ref+"='" + reference + "'";
                Console.WriteLine("select  PHOTO from " + table + " where " + colonne_ref + "='" + reference + "'");
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

        public void CHARGE_LIST(ListBox LIST, string RQT)
        {

            con.Open();

            cmd.CommandText = "" + RQT;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                LIST.Items.Add(dr[0]);
            }
            con.Close();
        }

        public void MIN_DATE (Guna2DateTimePicker DATE)
        {

            con.Open();
            cmd.CommandText = "EXEC MIN_DATE";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DATE.MinDate =Convert.ToDateTime(dr[0]);
            }
            con.Close();
        }
        public void AJOUT_UNIVERSELLE(string table, string column, string valeurs, string objets)
        {

            con.Open();
            try
            {
                cmd.CommandText = ("INSERT INTO " + table + " (" + column + ") VALUES (" + valeurs + ")");
                cmd.ExecuteNonQuery();
                MessageBox.Show(objets + " ajouter avec success", "ENREGISTRER", MessageBoxButtons.OK, MessageBoxIcon.None);
                Console.WriteLine("INSERT INTO " + table + " (" + column + ") VALUES (" + valeurs + ")");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("" + ex);
            }
            con.Close();

        }

        public void EXEC_UNIVERSEL(string FUNCTION,string PARAMS,string objets)
        {

            con.Open();
            try
            {
                //  MessageBox.Show("insert into ANNE_SCOLAIRE (DESIGNATION)values('" + anne + "')");
                cmd.CommandText = ("EXEC "+FUNCTION+" "+PARAMS+"");
                cmd.ExecuteNonQuery();
                MessageBox.Show(objets + " Effectuer", "SAUVEGARDER", MessageBoxButtons.OK, MessageBoxIcon.None);
                Console.WriteLine("EXEC " + FUNCTION + " " + PARAMS + "");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("" + ex);
                 Console.WriteLine("EXEC " + FUNCTION + " " + PARAMS + "");
            }
            con.Close();
        }

        public void MAX_DATE(Guna2DateTimePicker DATE)
        {

            con.Open();
            cmd.CommandText = "EXEC MAX_DATE";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DATE.MaxDate = Convert.ToDateTime(dr[0]);
            }
            con.Close();
        }
        public  DataTable TABLEAU(String rqte)
        {
            try
            {

                con.Open();
                cmd = new SqlCommand(rqte, con);
                dt = null;
                dt = new SqlDataAdapter(cmd);
                ds = new DataSet();
                Console.WriteLine(rqte);
                dt.Fill(ds);
                con.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("erreur de login " + ex);
            }
            return ds.Tables[0];
        }
        public  DataSet get_Report_Z(string nomTable, string refh, string colonnes)
        {
            DataSet dst;
            try
            {
                //    innitialiseConnect();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new SqlCommand("SELECT  " + colonnes + " FROM " + nomTable + "" + refh, con);
                //  cmd.Parameters.AddWithValue("@valchamp", valchamp);
                dt = new SqlDataAdapter(cmd);
                dst = new DataSet();
                dt.Fill(dst, nomTable);
                //  MessageBox.Show("SELECT * FROM " + nomTable + ""+refh);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose(); con.Close();
            }
            return dst;
        }

       
    }
}
