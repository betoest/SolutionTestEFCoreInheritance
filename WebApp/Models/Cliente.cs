using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Cliente:Persona
    {
        public DateTime RegisterDate { get; set; }
        public string Address { get; set; }

    }
}
