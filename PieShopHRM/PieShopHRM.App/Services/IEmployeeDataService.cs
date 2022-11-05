using PieShopHRM.Shared.Domain;

namespace PieShopHRM.App.Services;

public interface IEmployeeDataService
{
    Task<IEnumerable<Employee>> GetAllEmployees(bool refreshRequired);
    Task<Employee> GetEmployeeDetails(int employeeId);
    Task<Employee> AddEmployee(Employee employee);
    Task UpdateEmployee(Employee employee);
    Task DeleteEmployee(int employeeId);
}

