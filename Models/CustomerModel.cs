using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal class CustomerModel
    {
        [DisplayName("Customer Id")]
        public int Id { get; set; }

        [DisplayName("Document Number")]
        [Required(ErrorMessage = "Document number is required")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Document number must be between 5 and 20 characters")]
        public string DocumentNumber { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "First name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "First name must be between 2 and 50 characters")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Last name must be between 2 and 50 characters")]
        public string LastName { get; set; }

        [DisplayName("Address")]
        [Required(ErrorMessage = "Address is required")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Address must be between 5 and 100 characters")]
        public string Address { get; set; }

        [DisplayName("Birthday")]
        [Required(ErrorMessage = "Birthday is required")]
        public DateTime? Birthday { get; set; }

        [DisplayName("Phone Number")]
        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string PhoneNumber { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
    }
}
