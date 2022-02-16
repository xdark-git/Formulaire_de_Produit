namespace AppStock
{
    partial class frmMDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.seDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seDéconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutCatégorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeCatégorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seDeToolStripMenuItem,
            this.administrationToolStripMenuItem,
            this.codificationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // seDeToolStripMenuItem
            // 
            this.seDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seDéconnecterToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.seDeToolStripMenuItem.Name = "seDeToolStripMenuItem";
            this.seDeToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.seDeToolStripMenuItem.Text = "Action";
            // 
            // seDéconnecterToolStripMenuItem
            // 
            this.seDéconnecterToolStripMenuItem.Name = "seDéconnecterToolStripMenuItem";
            this.seDéconnecterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seDéconnecterToolStripMenuItem.Text = "Se Déconnecter";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilisateurToolStripMenuItem});
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.administrationToolStripMenuItem.Text = "Administration";
            // 
            // utilisateurToolStripMenuItem
            // 
            this.utilisateurToolStripMenuItem.Name = "utilisateurToolStripMenuItem";
            this.utilisateurToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.utilisateurToolStripMenuItem.Text = "Ajout utilisateur";
            this.utilisateurToolStripMenuItem.Click += new System.EventHandler(this.utilisateurToolStripMenuItem_Click);
            // 
            // codificationToolStripMenuItem
            // 
            this.codificationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutCatégorieToolStripMenuItem,
            this.listeCatégorieToolStripMenuItem,
            this.ajoutProduitToolStripMenuItem,
            this.listeProduitToolStripMenuItem});
            this.codificationToolStripMenuItem.Name = "codificationToolStripMenuItem";
            this.codificationToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.codificationToolStripMenuItem.Text = "Codification";
            // 
            // ajoutCatégorieToolStripMenuItem
            // 
            this.ajoutCatégorieToolStripMenuItem.Name = "ajoutCatégorieToolStripMenuItem";
            this.ajoutCatégorieToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.ajoutCatégorieToolStripMenuItem.Text = "Ajout catégorie";
            // 
            // listeCatégorieToolStripMenuItem
            // 
            this.listeCatégorieToolStripMenuItem.Name = "listeCatégorieToolStripMenuItem";
            this.listeCatégorieToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.listeCatégorieToolStripMenuItem.Text = "Liste catégorie";
            // 
            // ajoutProduitToolStripMenuItem
            // 
            this.ajoutProduitToolStripMenuItem.Name = "ajoutProduitToolStripMenuItem";
            this.ajoutProduitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.ajoutProduitToolStripMenuItem.Text = "Ajout produit";
            // 
            // listeProduitToolStripMenuItem
            // 
            this.listeProduitToolStripMenuItem.Name = "listeProduitToolStripMenuItem";
            this.listeProduitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.listeProduitToolStripMenuItem.Text = "Liste produit";
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMDI";
            this.Text = "Gestion Stock ::";
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seDéconnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutCatégorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeCatégorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeProduitToolStripMenuItem;
    }
}