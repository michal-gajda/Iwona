using SampleWebApi.Models;

namespace SampleWebApi.Interfaces
{
    public interface IEmployeeService
    {
        void Add(Employee employee);
        List<Employee> GetAll();
        void Update(string name, string grade);
        void Delete(string name);
    }
}