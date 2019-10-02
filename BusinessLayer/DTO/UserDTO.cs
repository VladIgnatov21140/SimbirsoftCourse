using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.DTO
{
    public class UserDTO
    {
        /// <summary>
        /// Users account identificator
        /// </summary>
        [Required]
        public int Id { get; set; }
        /// <summary>
        /// Users name
        /// </summary>
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        /// <summary>
        /// Users surname
        /// </summary>
        [Required]
        [Display(Name = "Surname")]
        public string Surname { get; set; }
        /// <summary>
        /// Users date of birth
        /// </summary>
        [Display(Name = "Date of birth")]
        public DateTime DateOfBirth { get; set; }
        /// <summary>
        /// Login user uses to login on site
        /// </summary>
        [Required]
        [Display(Name = "Login")]
        public string Login { get; set; }
        /// <summary>
        /// Password user uses to login on site
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        /// <summary>
        /// Users account Email
        /// </summary>
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

    }
}
