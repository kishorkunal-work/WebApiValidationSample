using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiValidation.Models
{
	public class User
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "The client name can not be empty")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Client Name field must have minimum 5 and maximum 15 character!")]
        public string ClientName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "ClientPassword  cannot be empty!")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "ClientPassword must have minimum 5 and maximum 15 character!")]
        public string ClientPassword { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Confirm ClientPassword cannot be empty!")]
        public string ConfirmClientPassword { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "EmailID address  cannot be empty!")]
        public string EmailID { get; set; }
    }
}