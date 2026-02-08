using System.ComponentModel.DataAnnotations;

namespace CollegeWebApplication.Models
{
    public class StudentInfo
    {
        [Key]
        public int StudentId { get; set; }


        [Required(ErrorMessage = " Student First Name is required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "First Name must be between 3 and 30 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = " Student Last Name is required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Last Name must be between 3 and 30 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [Required(ErrorMessage = " Date of Birth is required")]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateOfBirth { get; set; }


        [Required(ErrorMessage = "Gender is Required"), StringLength(6)]
        public string Gender { get; set; }


        [Required(ErrorMessage = "Please Enter Student Address")]
        public string Address { get; set; }


        [Required(ErrorMessage = "Please Enter Student City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please Enter Student Email")]
        [Display(Name = " Student Email")]
        public string Email { get; set; }


        [Required(ErrorMessage = " Phone Number is required")]
        [StringLength(13, MinimumLength = 10, ErrorMessage = "Phone Number Should be between 10 to 13 digits")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        public string? Stream { get; set; }

        public string? YearOfStudy { get; set; }
    }

}
