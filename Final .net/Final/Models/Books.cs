using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class Books
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Image of book is Required")]
        public string Book_image { get; set; }

        [Required(ErrorMessage = "Type of book is Required")]
        public string Book_type { get; set; }

        [Required(ErrorMessage = "Book name is Required")]
        [StringLength(50, MinimumLength = 3)]
        public string Book_name { get; set; }

        [Required(ErrorMessage = "Please Enter the cost")]
        public decimal Cost { get; set; }

        [Required(ErrorMessage = "Author name is Required")]
        [StringLength(50, MinimumLength = 3)]
        public string Author { get; set; }
    }
}
