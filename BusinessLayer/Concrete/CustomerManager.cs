using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
       

        public void AddCustomer(Customer customer)
        {
            _customerDal.Add(customer);
        }

        public void DeleteCustomer(Customer customer)
        {
            _customerDal.Delete(customer);
        }

        public Customer GetCustomerById(int id)
        {
            return _customerDal.Get(x => x.CustomerID == id);
        }

        public List<Customer> GetCustomerList()
        {
            return _customerDal.List();
        }

        public void UpdateCustomer(Customer customer)
        {
            _customerDal.Update(customer);
        }
    }
}
