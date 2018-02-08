using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class ClientRepository : IClientRepository
    {
        private readonly AppDbContext _appDbContext;

        public ClientRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public void Add(Cliente cliente)
        {
            //_appDbContext.Personas.Add(cliente);
            Save();
        }

        public IEnumerable<Empleado> GetAllClients()
        {
            //return _appDbContext.Personas.OfType<Cliente>();

            return _appDbContext.Users.OfType<Empleado>();
        }

        public Empleado GetClienteById(string id)
        {
            //return _appDbContext.Personas.OfType<Cliente>().FirstOrDefault(c => c.Id==id);
            // return (Cliente) _appDbContext.Personas.Find(id);
            return (Empleado) _appDbContext.Users.Find(id);
        }

        public void Save()
        {
            _appDbContext.SaveChanges();
        }
    }
}
