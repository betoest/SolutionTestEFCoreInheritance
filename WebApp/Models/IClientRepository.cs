using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public interface IClientRepository
    {
        IEnumerable<Empleado> GetAllClients();
        Empleado GetClienteById(string id);
        void Add(Cliente cliente);
        void Save();
    }
}
