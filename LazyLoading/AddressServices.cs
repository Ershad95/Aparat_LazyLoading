using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoading
{
    public class AddressServices
    {
        public IEnumerable<Address> GetAddressById(int id)
        {
            for (int i = 0; i < id; i++)
                yield return new Address() { City = $"City{i}",Id=i,State=$"State{i}",Street=$"Street{i}" };
        }
    }
}
