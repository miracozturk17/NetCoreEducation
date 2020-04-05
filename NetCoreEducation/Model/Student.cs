using System.ComponentModel.DataAnnotations;

namespace NetCoreEducation.Model
{
    public class Student
    {
        [Required(ErrorMessage = "Lütfen adınızı giriniz.")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyadınızı giriniz.")]
        [DataType(DataType.Text)]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Lütfen mail adresinizi giriniz.")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen telefon bilginizi giriniz.")]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Lütfen bir seçim yapınız.")]
        public bool? Confirm { get; set; }
    }
}