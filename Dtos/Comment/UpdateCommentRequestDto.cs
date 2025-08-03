using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Comment
{
    public class UpdateCommentRequestDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "title must be at least five charahters")]
        [MaxLength(20, ErrorMessage = "title lenght must be 20 charahters max")]
        public String Title { get; set; } = String.Empty;

        [Required]
        [MinLength(5, ErrorMessage = "content must be at least five charahters")]
        [MaxLength(80, ErrorMessage = "content lenght must be 80 charahters max")]
        public String Content { get; set; } = String.Empty;
    }
}