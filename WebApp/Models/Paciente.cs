using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Paciente: AppUser
    {
        public DateTime RegisterDate { get; set; }
        public virtual Paciente PadreoTutor { get; set; }
    }
}
