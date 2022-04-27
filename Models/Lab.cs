using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Lab
    {
        [Key]
        public int LabId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [RegularExpression(@"[A-Z]{1,1}[a-z]+", ErrorMessage = "Start typing lab's name with large letter and continue using small ones")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Length of field Name can't be less 2 and more 50")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [RegularExpression(@"[A-Z]{1,1}[a-z]+\s[0-9]{1,3}[a-z]{0,1}", ErrorMessage = "Incorrect hospital's adress")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Length of field Address can't be less 5 and more 50")]
        public string Address { get; set; }
        [Column(TypeName = "nvarchar(12)")]
        [Phone(ErrorMessage = "Incorrect Phone number")]
        public string Phone { get; set; }
    }
}
