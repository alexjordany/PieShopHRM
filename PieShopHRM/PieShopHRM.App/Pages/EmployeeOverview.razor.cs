using PieShopHRM.App.Models;
using PieShopHRM.Shared.Domain;

namespace PieShopHRM.App.Pages;

public partial class EmployeeOverview
{
    public List<Employee>? Employees { get; set; } = default!;

    protected override void OnInitialized()
    {
        Employees = MockDataService.Employees;
    }
}

