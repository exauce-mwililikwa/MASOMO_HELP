using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace ECOLE_SECONDAIRE.DESIGN_BOXES
{
    partial class INFORMATION_ELEVE : Form
    {
        new CLASS_DATA_BASE.CLS_GLOSSIERE A = new CLASS_DATA_BASE.CLS_GLOSSIERE();
        new CLASS_DATA_BASE.AJOUT B = new CLASS_DATA_BASE.AJOUT();
        public INFORMATION_ELEVE(string matricule)
        {
            InitializeComponent();
            A.GET_PHOTO("ELEVE", "MATRICULE", matricule , pictureBox1);

            MATRICULE_LABEL.Text = "" + matricule; 
            A.TEXT(NOM, "SELECT NOM FROM LISTE_INSCRIT_JOURNALIER WHERE MATRICULE='" +matricule + "'", 0);
            A.TEXT(POSTNOM, "SELECT POSTNOM FROM LISTE_INSCRIT_JOURNALIER WHERE MATRICULE='" + matricule + "'", 0);
            A.TEXT(PRENOM, "SELECT PRENOM FROM LISTE_INSCRIT_JOURNALIER WHERE MATRICULE='" + matricule + "'", 0);
            A.LABEL(CLASSE, "SELECT CLASSE FROM LISTE_INSCRIT_JOURNALIER WHERE MATRICULE='" + matricule + "'", 0);
            A.TEXT(PAYS, "SELECT PAYS FROM LISTE_INSCRIT_JOURNALIER WHERE MATRICULE='" + matricule + "'", 0);
            A.TEXT(PROVINCE, "SELECT PROVINCE FROM LISTE_INSCRIT_JOURNALIER WHERE MATRICULE='" + matricule + "'", 0);
            A.TEXT(QUARTIER, "SELECT QUARTIER FROM LISTE_INSCRIT_JOURNALIER WHERE MATRICULE='" + matricule + "'", 0);
            A.TEXT(VILLE, "SELECT VILLE FROM LISTE_INSCRIT_JOURNALIER WHERE MATRICULE='" + matricule + "'", 0);
            A.TEXT(NOM_T, "SELECT NOM_TUTEUR FROM LISTE_INSCRIT_JOURNALIER WHERE MATRICULE='" + matricule + "'", 0);
            A.TEXT(POSTNOM_T, "SELECT TUTEUR_POSTNOM FROM LISTE_INSCRIT_JOURNALIER WHERE MATRICULE='" + matricule + "'", 0);
            A.TEXT(PRENOM, "SELECT TUTEUR_PRENOM FROM LISTE_INSCRIT_JOURNALIER WHERE MATRICULE='" + matricule + "'", 0);
            A.TEXT(CELLULAIRE_T, "SELECT CELULAIRE FROM LISTE_INSCRIT_JOURNALIER WHERE MATRICULE='" + matricule + "'", 0);
            A.TEXT(EMAIL_T, "SELECT EMAIL FROM LISTE_INSCRIT_JOURNALIER WHERE MATRICULE='" + matricule + "'", 0);
            A.LABEL(DATE, "SELECT DATE FROM LISTE_INSCRIT_JOURNALIER WHERE MATRICULE='" + matricule + "'", 0);
            A.LABEL(HEURE, "SELECT HEURE FROM LISTE_INSCRIT_JOURNALIER WHERE MATRICULE='" + matricule + "'", 0);
            A.TEXT(EMAIL, "SELECT EMAIL_ELEVE FROM LISTE_INSCRIT_JOURNALIER WHERE MATRICULE='" + matricule + "'", 0);
            A.TEXT(CELLULAIRE, "SELECT CELLULAIRE_ELEVE FROM LISTE_INSCRIT_JOURNALIER WHERE MATRICULE='" + matricule + "'", 0);
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            B.CHOISIR_IMAGE(pictureBox1);
        }
    }
}
