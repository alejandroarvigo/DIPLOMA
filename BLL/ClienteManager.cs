using DAL;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClienteManager
    {
        ClienteRepository reservaRepository = new ClienteRepository();

        public List<Cliente> GetAllClientes()
        {
            return reservaRepository.GetAllClientes();
        }



    }
}
