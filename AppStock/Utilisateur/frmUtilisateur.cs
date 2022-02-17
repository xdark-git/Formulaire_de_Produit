using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppStock.App_Code;
using AppStock.Model;

namespace AppStock.Utilisateur
{
    public partial class frmUtilisateur : Form
    {
        bdStockEntities db = new bdStockEntities();
        public frmUtilisateur()
        {
            InitializeComponent();
        }

       

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
          using (MD5 md5Hash = MD5.Create())
            {
                Model.Utilisateur u = new Model.Utilisateur();
                u.Identifiant = txtIdentifiant.Text;
                u.Email = txtEmail.Text;
                u.MotDePasse = Helper.GetMd5Hash(md5Hash,"P@sser321");
                u.Status = "O";
                db.Utilisateur.Add(u);
                db.SaveChanges();
                Effacer();

            }
        }

        public void Effacer()
        {
            txtEmail.Text = "";
            txtIdentifiant.Text = "";
            txtIdentifiant.Focus();
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            Effacer();
        }
    }
}
