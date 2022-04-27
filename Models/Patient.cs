using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        [Column(TypeName = "nvarchar(25)")]
        [RegularExpression(@"[A-Z]{1,1}[a-z]+", ErrorMessage = "Start typing patient's name with large letter and continue using small ones")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Length of field Name can't be less 2 and more 20")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [RegularExpression(@"[A-Z]{1,1}[a-z]+", ErrorMessage = "Start typing patient's disease with large letter and continue using small ones")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Length of field Disease can't be less 2 and more 25")]
        public string Disease { get; set; }
    }
}
