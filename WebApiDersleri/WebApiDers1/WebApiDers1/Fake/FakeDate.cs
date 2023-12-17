using Bogus;
using System.Collections.Generic;
using System.Diagnostics;
using WebApiDers1.Models;

namespace WebApiDers1.Fake
{
    public class FakeDate
    {/*BU CLASS Bogus KÜTÜPHANESİYLE BERABER FAKE DATA OLUŞTURMAYA YARAR.*/
        private static List<User> _users;//Kullandığımız class'i liste sınıfı yapıyoruz
        
        public static List<User> GetUsers(int numbers)
        {//Fake data oluşturuyoruz.
            if (_users==null)
            {
                _users = new Faker<User>()
                .RuleFor(u => u.Id, f => f.IndexFaker + 1)
                .RuleFor(u => u.Name, f => f.Name.FirstName())
                .RuleFor(u => u.Lastname, f => f.Name.LastName())
                .RuleFor(u => u.Address, f => f.Address.FullAddress())
                .Generate(numbers);
            }
           

            return _users;

        }
    }
}
