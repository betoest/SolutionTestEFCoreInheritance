using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Doctor:AppUser
    {
        public string Titulo { get; set; }
        public string CedulaProfesional { get; set; }
    }
}
