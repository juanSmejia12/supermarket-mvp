using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class CustomerView : Form, ICustomerView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        public CustomerView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPageCustomerDetail);
        }
        private void AssociateAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        public string CustomerId
        {
            get { return TxtCustomerId.Text; }
            set { TxtCustomerId.Text = value; }
        }

        public string DocumentNumber
        {
            get { return TxtDocumentNumber.Text; }
            set { TxtDocumentNumber.Text = value; }
        }

        public string FirstName
        {
            get { return TxtFirstName.Text; }
            set { TxtFirstName.Text = value; }
        }

        public string LastName
        {
            get { return TxtLastName.Text; }
            set { TxtLastName.Text = value; }
        }

        public string Address
        {
            get { return TxtAddress.Text; }
            set { TxtAddress.Text = value; }
        }

        public DateTime? Birthday
        {
            get { return DtpBirthday.Value; }
            set { DtpBirthday.Value = value ?? DateTime.Now; } // Caso de null
        }

        public string PhoneNumber
        {
            get { return TxtPhoneNumber.Text; }
            set { TxtPhoneNumber.Text = value; }
        }

        public string Email
        {
            get { return TxtEmail.Text; }
            set { TxtEmail.Text = value; }
        }

        public string SearchValue
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }

        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }

        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetCustomerListBindingSource(BindingSource customerList)
        {
            DgCustomer.DataSource = customerList;
        }
    }
}
