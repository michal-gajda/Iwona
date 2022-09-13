using SampleWebApi.Interfaces;
using SampleWebApi.Models;

namespace SampleWebApi.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly List<Employee> items = new();

        public EmployeeService()
        {
            this.items.Add(new Employee
            {
                Name = "Michal",
            });

            this.items.Add(new Employee
            {
                Name = "Iwona",
            });
        }

        public void Add(Employee employee)
        {
            this.items.Add(employee);
        }

        public List<Employee> GetAll()
        {
            return this.items;
        }

        public void Update(string name, string grade)
        {
            var employee = this.items.FirstOrDefault(item => item.Name == name);

            if (employee is null)
            {
                this.items.Add(new Employee { Name = name });
            }

            employee = this.items.First(item => item.Name == name);
            employee.AddGrade(grade);
        }

        public void Delete(string name)
        {
            var employee = this.items.FirstOrDefault(item => item.Name == name);

            if (employee is not null)
            {
                this.items.Remove(employee);
            }
        }
    }
}