using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.ViewModels
{
    public class RegistroViewModel
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        [DataType(DataType.Password)]
        public string Passwd { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        [DataType(DataType.Date)]
        public DateTime  BirthDate { get; set; }
        public string Address { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime HireDate { get; set; }
        public Job Job { get; set; }
        public decimal Salary { get; set; }
        public string Titulo { get; set; }
        public string CedulaProfesional { get; set; }


    }
}
