using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelExpertsWeb.Models
{
    public partial class Customers
    {
        public int CustomerId { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "Please enter your first name")]
        public string CustFirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Please enter your last name")]
        public string CustLastName { get; set; }

        [DisplayName("Address")]
        [Required(ErrorMessage = "Please enter your living address")]
        public string CustAddress { get; set; }

        [DisplayName("City")]
        [Required(ErrorMessage = "Please enter your living city")]
        public string CustCity { get; set; }

        [DisplayName("Province")]
        [Required(ErrorMessage = "Please enter your living province")]
        public string CustProv { get; set; }

        [DisplayName("PostCode")]
        [Required(ErrorMessage = "Please enter postcode of your living address")]
        public string CustPostal { get; set; }

        [DisplayName("Country")]
        public string CustCountry { get; set; }

        [DisplayName("Home Phone")]
        [RegularExpression("^((\\+1-?)|0)?[0-9]{10}$",
            ErrorMessage = "Please enter a valid phone number")]
        public string CustHomePhone { get; set; }

        [DisplayName("Business Phone")]
        [Required(ErrorMessage = "Please enter your business phone")]
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

        public byte[] PasswordHashed { get; set; }
        public Guid? PasswordSalt { get; set; }

        [DisplayName("User Name")]
        [Required(ErrorMessage = "Please enter your User name")]
        [RegularExpression(@"(\S)+", ErrorMessage = "White space is not allowed")]
        public string CustUserName { get; set; }
        

        //[DisplayName("Confirm Password")]
        //[DataType(DataType.Password)]
        //[NotMapped]
        //[Compare("PasswordNotHashed", ErrorMessage = "Password not match.")]
        //public string ConfirmPassword { get; set; }
    }
}
