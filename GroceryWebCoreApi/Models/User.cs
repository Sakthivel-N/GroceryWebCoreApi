﻿using System.ComponentModel.DataAnnotations;

namespace GroceryWebCoreApi.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required,MaxLength(20)]
        public string UserName { get; set; }  
        
        [DataType(DataType.EmailAddress)]
        [Required,MaxLength(20)]
        public string EmailId { get; set; }
        [Required,MaxLength(13)]
        public string PhoneNumber { get; set; }
        [Required,MaxLength(60)]
        public string Address { get; set; }
        
        [Required]
        public int Wallet { get; set; }

        [DataType(DataType.Password)]
        [Required,MaxLength(20)]
        public string Password { get; set; }

        
    }
}
