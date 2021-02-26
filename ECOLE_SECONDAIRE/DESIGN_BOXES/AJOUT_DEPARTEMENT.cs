using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace ECOLE_SECONDAIRE.DESIGN_BOXES
{
    partial class AJOUT_DEPARTEMENT : Form
    {
        //////////////////////////////////////REQUETE D'ACTUALISATION
        string NOMBRE_DEPARTEMENT = "select COUNT(*) from DEPARTEMENT";
        CLASS_DATA_BASE.AJOUT a = new CLASS_DATA_BASE.AJOUT();
        CLASS_DATA_BASE.CLS_GLOSSIERE ag = new CLASS_DATA_BASE.CLS_GLOSSIERE();
        public AJOUT_DEPARTEMENT()
        {
            InitializeComponent();
            ag.LABEL(NOMBRE_DEPARTEMENT_LABEL,NOMBRE_DEPARTEMENT,0);
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void AJOUT_DEPARTEMENT_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (DESIGNATION.Text == "")
            {
                DESIGNATION.BorderColor = System.Drawing.Color.Red;
               // DESIGNATION.PlaceholderText = "Entrer la designation du departement";
            }
            else if (SALAIRE.Text == "")
            {

                SALAIRE.BorderColor = System.Drawing.Color.Red;
            //    SALAIRE.PlaceholderText = "Entrer le salaire";
            }
            else
            {
                a.DEPARTEMENT("" + DESIGNATION.Text.ToString(), int.Parse(SALAIRE.Text));
            }
        }

        private void DESIGNATION_Click(object sender, EventArgs e)
        {

        }

        private void DESIGNATION_TextChanged(object sender, EventArgs e)
        {

            DESIGNATION.BorderColor = System.Drawing.Color.Black;
        }

     
    }
}
