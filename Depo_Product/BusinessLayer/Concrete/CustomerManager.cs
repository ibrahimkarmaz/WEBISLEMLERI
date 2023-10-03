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
        ICustomerDAL _customerDAL;

        public CustomerManager(ICustomerDAL customerDAL)
        {
            _customerDAL = customerDAL;
        }

        public Customer GetById(int id)
        {
            return _customerDAL.GetById(id);
        }

        public List<Customer> GetCustomerAndJob()
        {
            return _customerDAL.GetCustomerListWithJob();
        }

        public void TAdd(Customer t)
        {
            _customerDAL.Insert(t);
        }

        public void TDelete(Customer t)
        {
            _customerDAL.Delete(t);
        }

        public List<Customer> TGetList()
        {
            return _customerDAL.getList();
        }

        public void TUpdate(Customer t)
        {
            _customerDAL.Update(t);
        }
    }
}
