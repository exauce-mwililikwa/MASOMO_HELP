using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace ECOLE_SECONDAIRE.DESIGN_BOXES
{
    partial class NOVEAU_TRAVAIL : Form
    {

        CLASS_DATA_BASE.CLS_GLOSSIERE A = new CLASS_DATA_BASE.CLS_GLOSSIERE();
        CLASS_DATA_BASE.AJOUT B = new CLASS_DATA_BASE.AJOUT();
        public int niveau =0;
        public string section = "";
        public string lettre = "";
        public string prof = "";
        public string cours = "";
        public NOVEAU_TRAVAIL(int niveau,string section,string lettre,string prof,string cours )
        {
            InitializeComponent();
            this.niveau = niveau;
            this.section = section;
            this.lettre = lettre;
            this.prof = prof;
            this.cours = cours;

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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            A.EXEC_UNIVERSEL("NOUVEAU_TRAVAIL", ""+niveau+","+section+","+lettre+","+prof+",'"+DESIGNATION.Text+"',"+MAXIMUM.Text+","+cours+"", "travail");
        }
    }
}
