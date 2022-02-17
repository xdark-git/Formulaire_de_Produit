using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppStock.Model;
using AppStock.App_Code;
using System.Security.Cryptography;

namespace AppStock
{
    public partial class frmConnexion : Form
    {
         bdStockEntities db = new bdStockEntities(); 
        public frmConnexion()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            Boolean rep = false;
            var leUser = db.Utilisateur.Where(a => a.Identifiant == txtIdentifiant.Text).FirstOrDefault();
            if (leUser != null)
            {
                using (MD5 md5Hash = MD5.Create())
                {
                    rep = Helper.VerifyMd5Hash(md5Hash, txtMotDePasse.Text, leUser.MotDePasse);
                }
            }
            if(rep)
            {
                frmMDI f = new frmMDI();
                f.Show();
                this.Hide();
            }
            else
            {
                lblMessage.Text = "Identifiant ou mot de passe incorrect";
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
