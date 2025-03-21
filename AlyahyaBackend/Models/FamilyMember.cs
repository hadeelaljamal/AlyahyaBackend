using System.ComponentModel.DataAnnotations;

namespace AlyahyaBackend.Models
{
    public class FamilyMember
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string SecondName { get; set; }

        [Required]
        [MaxLength(50)]
        public string ThirdName { get; set; }

        [Required]
        [MaxLength(50)]
        public string FourthName { get; set; }

        [Required]
        [MaxLength(50)]
        public string FifthName { get; set; }

        [Required]
        [MaxLength(100)]
        public string CityOfResidence { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [Range(1900, 2100)]
        public int YearOfBirth { get; set; }

        public string ProfilePhoto { get; set; } // URL 

        [MaxLength(500)]
        public string Suggestions { get; set; } // ملاحظات إضافية
    }
}
