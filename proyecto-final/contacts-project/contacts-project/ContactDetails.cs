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

        }
        private void SaveContact()
        {

            Contact contact = new Contact();

            //obtener lo que hay en el txt del formulario
            contact.FirstName = txtFirstName.Text;
            contact.LastName = txtLastName.Text;
            contact.Phone = txtPhone.Text;
            contact.Address = txtAddress.Text;

            // lamar capa negocios
            _bussinesLogicLayer.SaveContact(contact);
        }
    }
}
