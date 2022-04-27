using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }
        [Column(TypeName = "nvarchar(25)")]
        [RegularExpression(@"[A-Z]{1,1}[a-z]+", ErrorMessage = "Start typing doctor's name with large letter and continue using small ones")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Length of field Name can't be less 2 and more 25")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(35)")]
        [RegularExpression(@"[A-Z]{1,1}[a-z]+", ErrorMessage = "Start typing doctor's speciality with large letter and continue using small ones")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Length of field Speciality can't be less 2 and more 25")]
        public string Speciality { get; set; }
    }
}
