using MessagePack;
using Microsoft.Build.Framework;
using Microsoft.VisualBasic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vroom.Utility;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace Vroom.Models
{
    public class EmployeeVM 
    {

        [Key]
        public int? Id { get; set; }

        [Required(ErrorMessage = "First Name is Required")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Last name should be between 3 and 15 characters")]
        [TaskName(ErrorMessage = "The Fisrt letter must be Capital and don't contains any Symbol or Number")]
        public string FirstName { get; set; }

        
        [Required(ErrorMessage = "Last Name is Required")]
        [StringLength(15, MinimumLength = 3,
                  ErrorMessage = "Last name should be between 3 and 15 characters")]
        [TaskName(ErrorMessage = "The Fisrt letter must be Capital and don't contains any Symbol or Number")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Phone Number is Required")]
        [Display(Name = "Contect Number")]
        [StringLength(15 , MinimumLength =15 ,ErrorMessage ="the phone number must be 15 digit only") ]
        [TaskPhone(ErrorMessage = "The number must be start from +966")]
        public string Phone { get; set; }

        [Required (ErrorMessage ="Date of Brith is Required")]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/mm/yyyy}" , ApplyFormatInEditMode =true)]
        //[ValidateDateOfBrith(ErrorMessage = "Invalid Date of Birth")]
        public DateTime DOB { get; set; }

    }
}


