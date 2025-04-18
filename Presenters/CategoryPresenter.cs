using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;

namespace Supermarket_mvp.Presenters
{
    internal class CategoryPresenter
    {
        private ICategoryView view;
        private ICategoryRepository repository;
        private BindingSource categoryBindingSource;
        private IEnumerable<CategoryModel> categoryList;

        public CategoryPresenter(ICategoryView view, ICategoryRepository repository)
        {
            this.categoryBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCategory;
            this.view.AddNewEvent += AddNewCategory;
            this.view.EditEvent += LoadSelectedCategoryToEdit;
            this.view.DeleteEvent += DeleteSelectedCategory;
            this.view.SaveEvent += SaveCategory;
            this.view.CancelEvent += CancelAction;

            this.view.SetCategoryListBindingSource(categoryBindingSource);

            LoadAllCategoryList();

            this.view.Show();
        }

        private void LoadAllCategoryList()
        {
            categoryList = repository.GetAll();
            categoryBindingSource.DataSource = categoryList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveCategory(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedCategory(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectedCategoryToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewCategory(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchCategory(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                categoryList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                categoryList = repository.GetAll();
            }
            categoryBindingSource.DataSource = categoryList;
        }
    }
}
