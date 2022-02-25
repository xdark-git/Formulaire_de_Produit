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
using AppStock.Utilisateur;
using AppStock.App_Code;
using System.Security.Cryptography;

namespace AppStock.Utilisateur
{
    public partial class frmChangerMDP : Form
    {
        bdStockEntities db = new bdStockEntities();

        private string identifiant;
        public frmChangerMDP(string txtidentifiant)
        {
            InitializeComponent();
            this.identifiant = txtidentifiant;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            var leUser = db.Utilisateur.Where(a => a.Identifiant == identifiant).FirstOrDefault();
            leUser.SetPassword(txtNouveauMotDePasse.Text);
            db.SaveChanges();
            frmMDI f = new frmMDI();
            f.Show();
            this.Hide();
            //MessageBox.Show("Bonjour votre identifiant est : "+ identifiant);
        }

        private void frmChangerMDP_Load(object sender, EventArgs e)
        {

        }
    }
}
