using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contacts_project
{
    public class BussinesLogicLayer
    {
        private DataAccessLayer _dataAccessLayer;

        public BussinesLogicLayer()
        {
            _dataAccessLayer = new DataAccessLayer();
        }


        public Contact SaveContact(Contact contact)
        {
            if (contact.Id == 0)

                _dataAccessLayer.InsertContact(contact);


            else
                _dataAccessLayer.UpdateContact(contact); 

           
            return contact;


        }

        // traer los contactos
        public List<Contact> GetContacts()
        {
            return _dataAccessLayer.GetContacts();
        }

        public void DeleteContact(int id)
        {
            _dataAccessLayer.DeleteContact(id);
        }
    }
}
