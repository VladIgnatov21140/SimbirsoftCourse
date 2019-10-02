using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models
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
