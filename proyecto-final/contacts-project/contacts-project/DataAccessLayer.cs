using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contacts_project
{
    public class DataAccessLayer
    {
        // conexion
        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ContactsProject;Data Source=LAPTOP-813IJ0E5");

        // metodos
        public void InsertContact(Contact contact)
        {
            // acceso bd
            try
            {
                // Abrir la conexion
                conn.Open();

                // ejecutar consulta
                string query = "INSERT INTO Contacts (FirstName, LastName, Phone, Address) VALUES (@FirstName, @LastName, @Phone, @Address)";

                // obtener y enviar valores
                SqlParameter firstName = new SqlParameter();
                firstName.ParameterName = "@FirstName";
                firstName.Value = contact.FirstName;
                firstName.DbType = System.Data.DbType.String;


                SqlParameter lastName = new SqlParameter("@LastName", contact.LastName);
                SqlParameter phone = new SqlParameter("@Phone", contact.Phone);
                SqlParameter address = new SqlParameter("@Address", contact.Address);

                // consulta y conexion
                SqlCommand command = new SqlCommand(query,conn);

                // agregar parametro
                command.Parameters.Add(firstName);
                command.Parameters.Add(lastName);
                command.Parameters.Add(phone);
                command.Parameters.Add(address);

                // devolver cantidad de filas afectadas 
                command.ExecuteNonQuery();


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Contact> GetContacts()
        {
            List<Contact> contacts = new List<Contact>();
            try
            {
                conn.Open();

                string query = "SELECT FirstName, LastName, Phone, Address  FROM Contacts";

                SqlCommand command = new SqlCommand(query, conn);

                // devolver todad las filas
                SqlDataReader reader = command.ExecuteReader();

                // iterar el read, leer adelante, no se devuelve
                while (reader.Read())
                {
                    contacts.Add(new Contact
                    {
                        // setear propiedades
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        Address = reader["Address"].ToString()

                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            return contacts;
        }
    }
}
