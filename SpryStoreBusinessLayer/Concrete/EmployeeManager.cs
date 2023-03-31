using SpryStoreBusinessLayer.Abstract;
using SpryStoreDataAccessLayer.Abstract;
using SpryStoreEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryStoreBusinessLayer.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private readonly IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public void TDelete(Employee t)
        {
            _employeeDal.Delete(t);
        }

        public Employee TGetByID(int id)
        {
            return _employeeDal.GetByID(id);
        }

        public List<Employee> TGetList()
        {
            return _employeeDal.GetList();
        }

        public void TInsert(Employee t)
        {
            if (t.Name != "" && t.Name.Length >= 3 && t.Name.Length <= 20)
            {
                _employeeDal.Insert(t);
            }
            else
            {
                //hata mesajı
            }
        }

        public void TUpdate(Employee t)
        {
            _employeeDal.Update(t);
        }
    }
}
