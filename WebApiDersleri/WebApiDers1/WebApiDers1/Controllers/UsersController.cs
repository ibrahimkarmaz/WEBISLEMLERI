using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApiDers1.Fake;
using WebApiDers1.Models;

namespace WebApiDers1.Controllers
{
    /*EKLEME SİLME GÜNCELLEMEDE POSTMAN KULLANILDI.*/
    [Route("api/[controller]")] //Bu yönlendirme için kullanılır [controller] controllerin ismini otomatik alır. Apiler genellikle api ile başlar.
    public class UsersController : Controller
    {
        private List<User> _users = FakeDate.GetUsers(200);
        [HttpGet]
        public List<User> Get()
        {
            return _users;
        }
        [HttpGet("{id}")]//Get veri alma isteyenler için geliyor fakat id isteniyor.
        public User Get(int id)
        {
            var user = _users.FirstOrDefault(x => x.Id == id);
            return user;
        }
        [HttpPost]
        public User Post([FromBody]User user) //Gönderilen kısımda body'de user class'i dan veri isteniyor. //Ekleme için
        {
            _users.Add(user);
            return user;
        }

        [HttpPut]
        public User Put([FromBody] User user) //Gönderilen kısımda body'de user class'i dan veri isteniyor. //Güncelleme için
        {
            var editUser = _users.FirstOrDefault(x => x.Id == user.Id);
            editUser.Name = user.Name;
            editUser.Lastname = user.Lastname;
            editUser.Address = user.Address;
            return user;
        }

        [HttpDelete("{id}")]//Delete işlemleri
        public void Delete(int id)
        {
            var deleteUser = _users.FirstOrDefault(x => x.Id == id);
            _users.Remove(deleteUser);
        }
    }
}
//VİDEO KAYNAĞI: https://www.youtube.com/watch?v=xxvcD5fXFuA&list=PLpiXyP9d3U1q251izX5xLHctZEmb8REr_&index=5