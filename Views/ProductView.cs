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
    public partial class ProductView: Form, IProductView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        public ProductView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPageProductDetail);
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

        public string ProductId
        {
            get { return TxtProductId.Text; }
            set { TxtProductId.Text = value; }
        }

        public string ProductName
        {
            get { return TxtProductName.Text; }
            set { TxtProductName.Text = value; }
        }

        public string ProductPrice
        {
            get { return TxtProductPrice.Text; }
            set { TxtProductPrice.Text = value; }
        }

        public string ProductStock
        {
            get { return TxtProductStock.Text; }
            set { TxtProductStock.Text = value; }
        }

        public string ProductCategoryId
        {
            get { return TxtProductCategoryId.Text; }
            set { TxtProductCategoryId.Text = value; }
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

        public void SetProductListBindingSource(BindingSource productList)
        {
            DgProduct.DataSource = productList;
        }
    }
}
