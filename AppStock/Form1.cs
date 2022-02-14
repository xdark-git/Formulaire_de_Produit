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

namespace AppStock
{
    public partial class Form1 : Form
    {  
        bdStockEntities db = new bdStockEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgProduit.DataSource = db.Produit.ToList();
        }

        private void Effacer()
        {
            txtDescription.Text = "";
            txtLibelle.Text = "";
            txtPU.Text = "";
            txtQte.Text = "";
            dgProduit.DataSource = db.Produit.ToList();
            txtLibelle.Focus();
        }

        

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Produit p = new Produit();
            p.LibelleProduit = txtLibelle.Text;
            p.DescriptionProduit = txtDescription.Text;
            p.PUProduit = double.Parse(txtPU.Text);
            p.QteProduit = double.Parse(txtQte.Text);
            db.Produit.Add(p);
            db.SaveChanges();

            Effacer();

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            Produit p = db.Produit.Find(id);
            p.LibelleProduit = txtLibelle.Text;
            p.DescriptionProduit = txtDescription.Text;
            p.PUProduit = double.Parse(txtPU.Text);
            p.QteProduit = double.Parse(txtQte.Text);
            
            db.SaveChanges();
            Effacer();
        }

        private void txtQte_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            Produit p = db.Produit.Find(id);
            db.Produit.Remove(p);

            db.SaveChanges();
            Effacer();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            txtDescription.Text = dgProduit.CurrentRow.Cells[2].Value.ToString();
            txtLibelle.Text = dgProduit.CurrentRow.Cells[1].Value.ToString();
            txtPU.Text = dgProduit.CurrentRow.Cells[4].Value.ToString();
            txtQte.Text = dgProduit.CurrentRow.Cells[3].Value.ToString();
            
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            var liste = db.Produit.ToList();
            if(!string.IsNullOrEmpty(txtRLibelle.Text))
            {
                liste = liste.Where(a => a.LibelleProduit.ToUpper().Contains(txtRLibelle.Text.ToUpper())).ToList();
            }

            if (!string.IsNullOrEmpty(txtRDescription.Text))
            {
                liste = liste.Where(a => a.DescriptionProduit.ToUpper().Contains(txtRDescription.Text.ToUpper())).ToList();
            }

            if (!string.IsNullOrEmpty(txtRQteStockInf.Text))
            {
                double qte = double.Parse(txtRQteStockInf.Text);
                liste = liste.Where(a => a.QteProduit <= qte).ToList();
            }

            if (!string.IsNullOrEmpty(txtRQteStockSup.Text))
            {
                double qte = double.Parse(txtRQteStockSup.Text);
                liste = liste.Where(a => a.QteProduit >= qte).ToList();
            }
            dgProduit.DataSource = liste;
        }

        private void textRLibelle_TextChanged(object sender, EventArgs e)
        {

        }

        private void textQteStockSup_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
