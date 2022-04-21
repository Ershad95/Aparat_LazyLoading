using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoading
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public Customer(int? id=null)
        {
            Id = id ?? Id;
            //Addresses = new Lazy<IEnumerable<Address>>(()=>new AddressServices().GetAddressById(this.Id));            
            Addresses = new AddressServices().GetAddressById(this.Id);
        }
        //public Lazy<IEnumerable<Address>> Addresses { get; set; }
        public IEnumerable<Address> Addresses { get; set; }
    }
}
