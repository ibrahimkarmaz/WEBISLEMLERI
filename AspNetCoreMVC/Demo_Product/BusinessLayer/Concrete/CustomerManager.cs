using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDAL _CustomerDAL;

        public CustomerManager(ICustomerDAL customerDAL)
        {
            _CustomerDAL = customerDAL;
        }

        public List<Customer> GetCustomersListWithJob()
        {
            return _CustomerDAL.GetCustomerListWithJob();
        }

        public void TDelete(Customer t)
        {
            _CustomerDAL.Delete(t);
        }

        public Customer TGetById(int id)
        {
            return _CustomerDAL.GetById(id);
        }

        public List<Customer> TGetList()
        {
            return _CustomerDAL.GetAll();
        }

        public void TInsert(Customer t)
        {
             _CustomerDAL.Insert(t);
        }

        public void TUpdate(Customer t)
        {
            _CustomerDAL.Update(t);
        }
    }
}
