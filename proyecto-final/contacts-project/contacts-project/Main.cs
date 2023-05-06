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
    public partial class Main : Form
    {
        private BussinesLogicLayer _bussinesLogicLayer;
        public Main()
        {
            InitializeComponent();
            _bussinesLogicLayer = new BussinesLogicLayer();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenContacDetail();
        }
        private void OpenContacDetail()
        {
            // llamar segundo formulario
            ContactDetails contact = new ContactDetails();
            contact.ShowDialog();
        }


        // funcion de cargar los contactos
       
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateContacts();
        }
        private void PopulateContacts()
        {
            List<Contact> contacts = _bussinesLogicLayer.GetContacts();
            dataGridView1.DataSource = contacts;
        }
    }
}
