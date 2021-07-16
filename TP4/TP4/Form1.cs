/** logiciel d'enregistrement de contacts.
 * Permet d'enregistrer des contacts dans un répertoire
 * Date : 28/02/2020
 * Author : Romain
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Collection qui contient les contacts
        List<Contact> lesContacts = new List<Contact>();
        // Nom du fichier qui contient les contacts
        string save = "Sauvegarde";

        /**
         * Module qui permet de mettre à jour la listbox avec la collection de contact
         */
        private void majList(int indice)
        {
            lstContact.Items.Clear();
            foreach (Contact unContact in lesContacts)
            {
                lstContact.Items.Add(unContact.infosContact());
            }
            try
            {
                lstContact.SelectedIndex = indice;
            }
            catch (Exception ex)
            {
                lstContact.SelectedIndex = -1;
                imgPhoto.Image = Properties.Resources.vide;
            }
            lstContact.Focus();
            Serialise.Sauve(save, lesContacts);
        }
        /**
         * Module mise à jour des composants graphiques
         * Active ou désactive certains composants graphiques par rapport au radio button sélectionné
         */
        private void majVisible(bool visible)
        {
            lblPhoto.Visible = visible;
            txtPrenom.Enabled = visible;
            txtNom.Enabled = visible;
            txtNum.Enabled = visible;
            btnAdd.Enabled = visible;
            btnAnnuler.Enabled = visible;
            lstContact.Enabled = !visible;
            btnEdit.Enabled = !visible;
            btnDelete.Enabled = !visible;
            grpRecherche.Enabled = !visible;
            txtNumRecherche.Clear();
            if (visible)
            {
                txtPrenom.Visible = rdbParticulier.Checked;
                lblPrenom.Visible = rdbParticulier.Checked;
                if (rdbParticulier.Checked)
                {
                    imgPhoto.Image = Properties.Resources.particulier;
                }
                else
                {
                    imgPhoto.Image = Properties.Resources.professionnel;
                }
            }
            else
            {
                rdbPro.Checked = false;
                rdbParticulier.Checked = false;
                txtPrenom.Clear();
                txtNom.Clear();
                txtNum.Clear();
                imgPhoto.Image = Properties.Resources.vide;
            }
            lstContact.SelectedIndex = -1;
        }
        /**
         * Module qui permet de supprimer un contact dans la collection
         */
        private void supprContact(int indice)
        {
            Contact unContact = trouveContactParTel(extraireNum(lstContact.Items[indice].ToString()));
            lesContacts.Remove(unContact);
            majList(indice);
        }
        /**
         * Module qui recherche l'indice dans la collection du contact sélectionné
         */
        private Contact trouveContactParTel(string num)
        {
            Contact leContact = null;
            foreach(Contact unContact in lesContacts)
            {
                if (unContact.getTel().Equals(num))
                {
                    leContact = unContact;
                }
            }
            return leContact;
        }
        /**
         * Module qui extrait le numéro du contact
         */
        private string extraireNum(string contact)
        {
            int pos = contact.IndexOf('(');
            string tel = contact.Substring(pos + 1);
            return tel.Substring(0, tel.Length - 1);
        }
        /**
         * Module qui retourne l'indice du contact sélectionné
         */
        private int rechercheIndice(string num)
        {
            int indice = 0;
            while (indice < lstContact.Items.Count - 1 && !extraireNum(lstContact.Items[indice].ToString()).Equals(num))
            {
                indice++;
            }
            if (extraireNum(lstContact.Items[indice].ToString()).Equals(num))
            {
                return indice;
            }
            else
            {
                return -1;
            }
        }
        /**
         * Evenement clic sur le label choix de la photo
         * Affiche une boite de dialogue pour sélectionner une image
         */
        private void lblPhoto_Click(object sender, EventArgs e)
        {
            // Boite de dialogue pour sélectionner un fichier
            OpenFileDialog rechercheFichier;
            rechercheFichier = new System.Windows.Forms.OpenFileDialog();
            DialogResult choix = rechercheFichier.ShowDialog();
            if (choix == DialogResult.OK)
            {
                // Récupération du fichier
                string nomFichier = rechercheFichier.FileName;
                try
                {
                    // Si un fichier est sélectionné
                    imgPhoto.Image = Image.FromFile(nomFichier);
                }
                catch (Exception ex)
                {
                    // Si le fichier n'est pas une image
                    MessageBox.Show("Le fichier sélectionné n'est pas une image.");
                }
            }
        }
        /**
         * Evenement clic sur le bouton ajouter un contact
         * Ajoute le contact à la list
         */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Controle des zones de saisie
            if (txtNom.TextLength > 0 && txtNum.TextLength > 0 && (rdbParticulier.Checked && txtPrenom.TextLength > 0) || rdbPro.Checked)
            {
                string num = txtNum.Text;
                // Création d'un contact
                Contact unContact;
                // Controle si c'est un particulier ou un professionnel
                if (rdbParticulier.Checked)
                {
                    // Ajoute le contact à la collection
                    unContact = new Particulier(txtNom.Text, txtPrenom.Text, num, imgPhoto.Image);
                }
                else
                {
                    // Ajoute le contact à la collection
                    unContact = new Professionnel(txtNom.Text, num, imgPhoto.Image);
                }
                lesContacts.Add(unContact);
                majList(-1);
                majVisible(false);
                lstContact.SelectedIndex = rechercheIndice(num);
            }
            else
            {
                // Affiche un message d'erreur si les zones de texte ne sont pas remplis
                MessageBox.Show("Les champs ne sont pas remplis");
            }
        }
        /**
         * Bouton "Particulier" sélectionné
         * Mise à jour des éléments graphiques
         */
        private void rdbParticulier_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbParticulier.Checked == true && rdbPro.Checked == false)
            {
                majVisible(true);
            }
        }
        /**
         * Bouton "Professionnel" sélectionné
         * Mise à jour des éléments graphiques
         */
        private void rdbPro_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbParticulier.Checked == false && rdbPro.Checked == true)
            {
                majVisible(true);
            }
        }
        /**
         * Evenement clic sur le bouton modifier
         * Modifier un contact
         */
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Controle si un contact est sélectionné
            if (lstContact.SelectedIndex != -1)
            {
                // Indice du contact sélectionné dans la collection
                Contact unContact = trouveContactParTel(extraireNum(lstContact.Items[lstContact.SelectedIndex].ToString()));
                // Suppression du contact dans la collection
                supprContact(lstContact.SelectedIndex);
                // Passage en mode "ajout" de l'application
                // Mise à jour de l'interface si le contact est un particulier ou un professionnel
                if (unContact is Particulier)
                {
                    rdbParticulier.Checked = true;
                    txtPrenom.Text = ((Particulier)unContact).getPrenom();
                }
                else
                {
                    rdbPro.Checked = true;
                }
                txtNom.Text = unContact.getNom();
                txtNum.Text = unContact.getTel();
                imgPhoto.Image = unContact.getPhoto();
            }
        }
        /**
         * Evenement changement d'index dans la listbox
         * Affiche l'image du contact sélectionné
         */
        private void lstContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstContact.SelectedIndex != -1)
            {
                Contact unContact = trouveContactParTel(extraireNum(lstContact.Items[lstContact.SelectedIndex].ToString()));
                imgPhoto.Image = unContact.getPhoto();
            }
        }
        /**
         * Evenement suppression d'un contact 
         */
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstContact.SelectedIndex != -1)
            {
                int indice = lstContact.SelectedIndex;
                // Suppression du contact dans la collection et mise à jour de la listbox
                supprContact(indice);
                txtNumRecherche.Text = "";
            }
        }
        /**
        * Evenement clic sur le bouton annuler
        * Annule la saisie d'un contact
        */
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            majVisible(false);
            try
            {
                lstContact.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                lstContact.SelectedIndex = -1;
            }
        }
        /**
         * Actualise la listbox si une saisie est effectuée dans la zone de recherche
         */
        private void txtNumRecherche_TextChanged(object sender, EventArgs e)
        {
            lstContact.Items.Clear();
            // Si la zone de saisie est vide : actualisation de la listbox avec la collection de contact
            if (txtNumRecherche.Text.Equals(""))
            {
                majList(0);
            }
            else
            {
                foreach (Contact unContact in lesContacts)
                {
                    if (unContact.getTel().IndexOf(txtNumRecherche.Text) != -1)
                    {
                        lstContact.Items.Add(unContact.infosContact());
                    }
                }
                imgPhoto.Image = Properties.Resources.vide;
            }
        }
        /**
         * Chargement de l'interface au lancement du programme
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            majVisible(false);
            Object sauvegarde = Serialise.Recup(save);
            if(sauvegarde != null)
            {
                lesContacts = ((List<Contact>)sauvegarde);
            }
            majList(-1);
        }
        /**
         * Gestion des couleurs dans la listbox
         */
        private void lstContact_DrawItem(object sender, DrawItemEventArgs e)
        {
            if(e.Index != -1)
            {
                string ligne = lstContact.Items[e.Index].ToString();
                e.DrawBackground();
                Brush myBrush;
                if (trouveContactParTel(extraireNum(ligne)) is Particulier)
                {
                    myBrush = new SolidBrush(rdbParticulier.ForeColor);
                }
                else
                {
                    myBrush = new SolidBrush(rdbPro.ForeColor);
                }
                e.Graphics.DrawString(ligne, e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
                e.DrawFocusRectangle();
            }
        }
        /**
         * Annule la recherche d'un contact
         */
        private void btnAnnulerRecherche_Click(object sender, EventArgs e)
        {
            majList(-1);
            txtNumRecherche.Clear();
        }
    }
}
