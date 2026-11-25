using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{
    public class EmployeeManager
    {
        private EmployeeManager _repo;

        public EmployeeManager(IEmployeeManager repo)
        {
            _repo = repo;
        }

        public void AddEmployee(Employee e)
        {
            _repo.Save(e);
        }

        public Employee getEmployeeByID(int id)
        {
            return _repo.GetById(id);
        }

        public List<Employee> getEmployees()
        {
            return _repo.GetEmployeeList();
        }
    }
}
