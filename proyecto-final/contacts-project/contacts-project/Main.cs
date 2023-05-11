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
            ContactDetails contactDetails = new ContactDetails();
            contactDetails.ShowDialog(this);
        }


        // funcion de cargar los contactos

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateContacts();
        }
        public void PopulateContacts()
        {
            List<Contact> contacts = _bussinesLogicLayer.GetContacts();
            dataGridView1.DataSource = contacts;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtener celda que se ha clickeado
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

            // validar que sea null
            if (cell.Value.ToString() == "Edit")
            {
                ContactDetails contactDetails = new ContactDetails();
                // crear un contacto nuevo y setear propiedades
                contactDetails.LoadContact(new Contact
                {
                    Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    FirstName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    LastName = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    Phone = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    Address = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(),

                });
                contactDetails.ShowDialog(this);
            } else if(cell.Value.ToString() == "Delete") {

                DeleteContact(int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
                PopulateContacts();
            }
        }
        private void DeleteContact(int id)
        {
            _bussinesLogicLayer.DeleteContact(id);
        }
    }
}
