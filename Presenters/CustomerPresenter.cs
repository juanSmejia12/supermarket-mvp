using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;

namespace Supermarket_mvp.Presenters
{
    internal class CustomerPresenter
    {
        private ICustomerView view;
        private ICustomerRepository repository;
        private BindingSource customerBindingSource;
        private IEnumerable<CustomerModel> customerList;

        public CustomerPresenter(ICustomerView view, ICustomerRepository repository)
        {
            this.customerBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCustomer;
            this.view.AddNewEvent += AddNewCustomer;
            this.view.EditEvent += LoadSelectedCustomerToEdit;
            this.view.DeleteEvent += DeleteSelectedCustomer;
            this.view.SaveEvent += SaveCustomer;
            this.view.CancelEvent += CancelAction;

            this.view.SetCustomerListBindingSource(customerBindingSource);

            LoadAllCustomerList();

            this.view.Show();
        }

        private void LoadAllCustomerList()
        {
            customerList = repository.GetAll();
            customerBindingSource.DataSource = customerList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveCustomer(object? sender, EventArgs e)
        {
            var customer = new CustomerModel
            {
                Id = Convert.ToInt32(view.CustomerId), 
                DocumentNumber = view.DocumentNumber,    
                FirstName = view.FirstName,  
                LastName = view.LastName,  
                Address = view.Address,  
                Birthday = (DateTime)view.Birthday,
                PhoneNumber = view.PhoneNumber, 
                Email = view.Email
            };

            try
            {
                new Common.ModelDataValidation().Validate(customer);

                if (view.IsEdit)
                {
                    repository.Edit(customer);
                    view.Message = "Customer edited successfully";
                }
                else
                {
                    repository.Add(customer);
                    view.Message = "Customer added successfully";
                }

                view.IsSuccessful = true;
                LoadAllCustomerList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }
        private void CleanViewFields()
        {
            view.CustomerId = "0";
            view.DocumentNumber = "";
            view.FirstName = "";
            view.LastName = "";
            view.Address = "";
            view.Birthday = null; 
            view.PhoneNumber = "";
            view.Email = "";
        }

        private void DeleteSelectedCustomer(object? sender, EventArgs e)
        {
            try
            {
                var customer = (CustomerModel)customerBindingSource.Current;

                repository.Delete(customer.Id);
                view.IsSuccessful = true;
                view.Message = "Customer deleted successfully";
                LoadAllCustomerList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error occurred, could not delete customer";
            }
        }

        private void LoadSelectedCustomerToEdit(object? sender, EventArgs e)
        {
            var customer = (CustomerModel)customerBindingSource.Current;

            view.CustomerId = customer.Id.ToString();
            view.DocumentNumber = customer.DocumentNumber;
            view.FirstName = customer.FirstName;
            view.LastName = customer.LastName;
            view.Address = customer.Address;
            view.Birthday = customer.Birthday;
            view.PhoneNumber = customer.PhoneNumber;
            view.Email = customer.Email;              

            view.IsEdit = true;
        }

        private void AddNewCustomer(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchCustomer(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                customerList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                customerList = repository.GetAll();
            }
            customerBindingSource.DataSource = customerList;
        }
    }
}
