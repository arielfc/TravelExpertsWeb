using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelExpertsWebApplication.Models
{
    public partial class Customers
    {
        public Customers()
        {
            Bookings = new HashSet<Bookings>();
            CreditCards = new HashSet<CreditCards>();
            CustomersRewards = new HashSet<CustomersRewards>();
        }

        //public int CustomerId { get; set; }
        //public string CustFirstName { get; set; }
        //public string CustLastName { get; set; }
        //public string CustAddress { get; set; }
        //public string CustCity { get; set; }
        //public string CustProv { get; set; }
        //public string CustPostal { get; set; }
        //public string CustCountry { get; set; }
        //public string CustHomePhone { get; set; }
        //public string CustBusPhone { get; set; }
        //public string CustEmail { get; set; }
        //public int? AgentId { get; set; }
        //public string PasswordNotHashed { get; set; }
        //public byte[] PasswordHashed { get; set; }
        //public Guid? PasswordSalt { get; set; }
        //public string CustUserName { get; set; }

        public int CustomerId { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "Please enter your first name")]
        public string CustFirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Please enter your last name")]
        public string CustLastName { get; set; }

        [DisplayName("Address")]
        [Required(ErrorMessage = "Please enter your address")]
        public string CustAddress { get; set; }

        [DisplayName("City")]
        [Required(ErrorMessage = "Please enter your city")]
        public string CustCity { get; set; }

        [DisplayName("Province")]
        [Required(ErrorMessage = "Please enter your province")]
        public string CustProv { get; set; }

        [DisplayName("PostCode")]
        [Required(ErrorMessage = "Please enter your postal code")]
        public string CustPostal { get; set; }

        [DisplayName("Country")]
        public string CustCountry { get; set; }

        [DisplayName("Home Phone")]
        [Required(ErrorMessage = "Please enter your phone number")]
        [RegularExpression("^((\\+1-?)|0)?[0-9]{10}$",
            ErrorMessage = "Please enter a valid phone number")]
        public string CustHomePhone { get; set; }

        [DisplayName("Business Phone")]
        [RegularExpression("^((\\+1-?)|0)?[0-9]{10}$",
            ErrorMessage = "Please enter a valid phone number")]
        public string CustBusPhone { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Please enter a valid email address")]
        public string CustEmail { get; set; }

        [DisplayName("Agent Id")]
        public int? AgentId { get; set; }

        [DisplayName("Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please enter your password")]
        //[RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{6,20}$",
        //            ErrorMessage = "Password required 6-20 characters, at least 1 Uppercase and 1 Lowercase Alphabet, and 1 Number.")]
        public string PasswordNotHashed { get; set; }

        //[NotMapped] // Does not effect with your database
        //[Required(ErrorMessage = "Passwords do not match")]
        //[Compare("PasswordNotHashed")]
        //public string ConfirmPassword { get; set; }

        public byte[] PasswordHashed { get; set; }
        public Guid? PasswordSalt { get; set; }

        //[DisplayName("User Name")]
        //[Required(ErrorMessage = "Please enter your User name")]
        //[RegularExpression(@"(\S)+", ErrorMessage = "White space is not allowed")]
        public string CustUserName { get; set; }

        public Agents Agent { get; set; }
        public ICollection<Bookings> Bookings { get; set; }
        public ICollection<CreditCards> CreditCards { get; set; }
        public ICollection<CustomersRewards> CustomersRewards { get; set; }
    }
}
