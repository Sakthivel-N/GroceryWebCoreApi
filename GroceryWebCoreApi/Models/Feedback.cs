﻿using System.ComponentModel.DataAnnotations;
namespace GroceryWebCoreApi.Models
{
    public class Feedback
    {
        [Key]
        public int FeedbackID { get; set; }

        [Required]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [Required,MaxLength(255)]
        public string FeedbackMsg { get; set; }
        [Required,MaxLength(25)]
        public string FeedbackTime { get; set; }
    }
}
