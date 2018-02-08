using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public enum Gender
    {
        Hombre,
        Mujer
    }

    public enum Job
    {
        CEO,
        Manager,
        Senior,
        Junior
    }

    public abstract class Persona
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public Gender Gender { get; set; }

    }//de la clase

}
