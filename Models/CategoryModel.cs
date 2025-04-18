using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal class CategoryModel
    {
        [DisplayName("Category Id")]
        public int Id { get; set; }

        [DisplayName("Category Name")]
        [Required(ErrorMessage = "Category name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Category name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [DisplayName("Description")]
        [Required(ErrorMessage = "Category description is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Description must be between 3 and 200 characters")]
        public string Description { get; set; }
    }
}
