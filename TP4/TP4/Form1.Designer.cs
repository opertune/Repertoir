namespace TP4
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.imgPhoto = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.rdbPro = new System.Windows.Forms.RadioButton();
            this.rdbParticulier = new System.Windows.Forms.RadioButton();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpRecherche = new System.Windows.Forms.GroupBox();
            this.txtNumRecherche = new System.Windows.Forms.TextBox();
            this.lblRechercheNum = new System.Windows.Forms.Label();
            this.btnAnnulerRecherche = new System.Windows.Forms.Button();
            this.lstContact = new System.Windows.Forms.ListBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblPhoto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpRecherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgPhoto
            // 
            this.imgPhoto.Image = global::TP4.Properties.Resources.vide;
            this.imgPhoto.Location = new System.Drawing.Point(11, 10);
            this.imgPhoto.Name = "imgPhoto";
            this.imgPhoto.Size = new System.Drawing.Size(163, 188);
            this.imgPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPhoto.TabIndex = 0;
            this.imgPhoto.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNum);
            this.groupBox1.Controls.Add(this.txtPrenom);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.lblNum);
            this.groupBox1.Controls.Add(this.lblPrenom);
            this.groupBox1.Controls.Add(this.lblNom);
            this.groupBox1.Controls.Add(this.rdbPro);
            this.groupBox1.Controls.Add(this.rdbParticulier);
            this.groupBox1.Controls.Add(this.btnAnnuler);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(11, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 125);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ajout contact";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(57, 96);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(130, 20);
            this.txtNum.TabIndex = 9;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(57, 70);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(130, 20);
            this.txtPrenom.TabIndex = 8;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(57, 42);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(130, 20);
            this.txtNom.TabIndex = 7;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(6, 99);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(24, 13);
            this.lblNum.TabIndex = 6;
            this.lblNum.Text = "tel :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(6, 73);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(48, 13);
            this.lblPrenom.TabIndex = 5;
            this.lblPrenom.Text = "prénom :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(6, 45);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(33, 13);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "nom :";
            // 
            // rdbPro
            // 
            this.rdbPro.AutoSize = true;
            this.rdbPro.ForeColor = System.Drawing.Color.Green;
            this.rdbPro.Location = new System.Drawing.Point(75, 19);
            this.rdbPro.Name = "rdbPro";
            this.rdbPro.Size = new System.Drawing.Size(87, 17);
            this.rdbPro.TabIndex = 3;
            this.rdbPro.Text = "professionnel";
            this.rdbPro.UseVisualStyleBackColor = true;
            this.rdbPro.CheckedChanged += new System.EventHandler(this.rdbPro_CheckedChanged);
            // 
            // rdbParticulier
            // 
            this.rdbParticulier.AutoSize = true;
            this.rdbParticulier.BackColor = System.Drawing.SystemColors.Control;
            this.rdbParticulier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rdbParticulier.Location = new System.Drawing.Point(6, 19);
            this.rdbParticulier.Name = "rdbParticulier";
            this.rdbParticulier.Size = new System.Drawing.Size(70, 17);
            this.rdbParticulier.TabIndex = 2;
            this.rdbParticulier.Text = "particulier";
            this.rdbParticulier.UseVisualStyleBackColor = false;
            this.rdbParticulier.CheckedChanged += new System.EventHandler(this.rdbParticulier_CheckedChanged);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Image = global::TP4.Properties.Resources.annuler;
            this.btnAnnuler.Location = new System.Drawing.Point(193, 68);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(48, 48);
            this.btnAnnuler.TabIndex = 1;
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::TP4.Properties.Resources.ajouter;
            this.btnAdd.Location = new System.Drawing.Point(193, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(48, 48);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpRecherche
            // 
            this.grpRecherche.Controls.Add(this.txtNumRecherche);
            this.grpRecherche.Controls.Add(this.lblRechercheNum);
            this.grpRecherche.Controls.Add(this.btnAnnulerRecherche);
            this.grpRecherche.Location = new System.Drawing.Point(11, 335);
            this.grpRecherche.Name = "grpRecherche";
            this.grpRecherche.Size = new System.Drawing.Size(249, 69);
            this.grpRecherche.TabIndex = 2;
            this.grpRecherche.TabStop = false;
            this.grpRecherche.Text = "recherche";
            // 
            // txtNumRecherche
            // 
            this.txtNumRecherche.Location = new System.Drawing.Point(57, 16);
            this.txtNumRecherche.Name = "txtNumRecherche";
            this.txtNumRecherche.Size = new System.Drawing.Size(130, 20);
            this.txtNumRecherche.TabIndex = 2;
            this.txtNumRecherche.TextChanged += new System.EventHandler(this.txtNumRecherche_TextChanged);
            // 
            // lblRechercheNum
            // 
            this.lblRechercheNum.AutoSize = true;
            this.lblRechercheNum.Location = new System.Drawing.Point(6, 16);
            this.lblRechercheNum.Name = "lblRechercheNum";
            this.lblRechercheNum.Size = new System.Drawing.Size(24, 13);
            this.lblRechercheNum.TabIndex = 1;
            this.lblRechercheNum.Text = "tel :";
            // 
            // btnAnnulerRecherche
            // 
            this.btnAnnulerRecherche.Image = global::TP4.Properties.Resources.playagain;
            this.btnAnnulerRecherche.Location = new System.Drawing.Point(193, 16);
            this.btnAnnulerRecherche.Name = "btnAnnulerRecherche";
            this.btnAnnulerRecherche.Size = new System.Drawing.Size(48, 48);
            this.btnAnnulerRecherche.TabIndex = 0;
            this.btnAnnulerRecherche.UseVisualStyleBackColor = true;
            this.btnAnnulerRecherche.Click += new System.EventHandler(this.btnAnnulerRecherche_Click);
            // 
            // lstContact
            // 
            this.lstContact.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstContact.FormattingEnabled = true;
            this.lstContact.Location = new System.Drawing.Point(266, 10);
            this.lstContact.Name = "lstContact";
            this.lstContact.Size = new System.Drawing.Size(288, 394);
            this.lstContact.Sorted = true;
            this.lstContact.TabIndex = 3;
            this.lstContact.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstContact_DrawItem);
            this.lstContact.SelectedIndexChanged += new System.EventHandler(this.lstContact_SelectedIndexChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::TP4.Properties.Resources.modifier;
            this.btnEdit.Location = new System.Drawing.Point(180, 10);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(48, 48);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::TP4.Properties.Resources.supprimer;
            this.btnDelete.Location = new System.Drawing.Point(180, 64);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(48, 48);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Location = new System.Drawing.Point(33, 161);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(123, 26);
            this.lblPhoto.TabIndex = 6;
            this.lblPhoto.Text = "Cliquer pour sélectionner\r\nune photo\r\n";
            this.lblPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPhoto.Click += new System.EventHandler(this.lblPhoto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 411);
            this.Controls.Add(this.lblPhoto);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lstContact);
            this.Controls.Add(this.grpRecherche);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imgPhoto);
            this.Name = "Form1";
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpRecherche.ResumeLayout(false);
            this.grpRecherche.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPhoto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.RadioButton rdbPro;
        private System.Windows.Forms.RadioButton rdbParticulier;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpRecherche;
        private System.Windows.Forms.Label lblRechercheNum;
        private System.Windows.Forms.Button btnAnnulerRecherche;
        private System.Windows.Forms.ListBox lstContact;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtNumRecherche;
        private System.Windows.Forms.Label lblPhoto;
    }
}

