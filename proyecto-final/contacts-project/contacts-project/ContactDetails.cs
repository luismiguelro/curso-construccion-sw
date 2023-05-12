using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contacts_project
{
    public partial class ContactDetails : Form
    {
        // variable global
        private BussinesLogicLayer _bussinesLogicLayer;
        private Contact _contact;
        public ContactDetails()
        {
            InitializeComponent();
            _bussinesLogicLayer = new BussinesLogicLayer();
        }

        // Cerrar dialogo
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            SaveContact();
            // cerrar form
            this.Close();

            // actualizar contactos en la grilla
            ((Main)this.Owner).PopulateContacts();

        }
        private void SaveContact()
        {

            Contact contact = new Contact();

            //obtener lo que hay en el txt del formulario
            contact.FirstName = txtFirstName.Text;
            contact.LastName = txtLastName.Text;
            contact.Phone = txtPhone.Text;
            contact.Address = txtAddress.Text;

            // escenario para el edit
            contact.Id = _contact != null ? _contact.Id : 0;

            // lamar capa negocios
            _bussinesLogicLayer.SaveContact(contact);
        }
        public void LoadContact(Contact contact)
        {
            _contact = contact;
            if (contact != null)
            {
                ClearForm();
                // cargar el contacto a editar
                txtFirstName.Text = contact.FirstName;
                txtLastName.Text = contact.LastName;
                txtPhone.Text = contact.Phone;
                txtAddress.Text = contact.Address;
            }
        }

        // limpiar camps
        private void ClearForm()
        {

            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtAddress.Text = string.Empty;
        }
    }
}
