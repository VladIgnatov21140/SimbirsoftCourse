using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimbirsoftCourses.Models
{
    public class User
    {
        /// <summary>
        /// Users account identificator
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Users name
        /// </summary>
        [Display(Name = "Name")]
        public string Name { get; set; }
        /// <summary>
        /// Users surname
        /// </summary>
        [Display(Name = "Surname")]
        public string Surname { get; set; }
    }
}
