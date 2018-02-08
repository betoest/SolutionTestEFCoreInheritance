using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Empleado:AppUser
    {

        public DateTime? HireDate { get; set; }
        public Job Job { get; set; }
        public decimal Salary { get; set; }
    }
}
