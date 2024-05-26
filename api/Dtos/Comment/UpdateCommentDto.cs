using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Comment
{
    public class UpdateCommentDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "Title must be 5 over character")]
        [MaxLength(280, ErrorMessage = "Title cannot be over 380 characters")]
        public String Title { get; set; } = string.Empty;
        
        [Required]
        [MinLength(5, ErrorMessage = "Content must be over 5 character")]
        [MaxLength(280, ErrorMessage = "Content cannot be over 380 characters")]
        public string Content { get; set; } = string.Empty;
    }
}