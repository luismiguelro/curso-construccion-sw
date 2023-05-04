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

        #region EVENTS
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            OpenContacDetail();

        }
        #endregion

        #region PRIVATE METHODS
        // metodo abrur detail contact
        private void OpenContacDetail()
        {
            // llamar segundo formulario
            ContactDetails contact = new ContactDetails();
            contact.ShowDialog();
        }
        #endregion

        // cargar los contactos una vez se ejecute el programa
        private void Main_Load(object sender, EventArgs e)
        {
            PopulateContacts();
        }
        // funcion de cargar los contactos
        private void PopulateContacts()
        {
            List<Contact> contacts = _bussinesLogicLayer.GetContacts();
            gridContacts.DataSource = contacts;
        }
    }
}