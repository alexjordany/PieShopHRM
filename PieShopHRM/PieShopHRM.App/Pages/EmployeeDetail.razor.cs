using Microsoft.AspNetCore.Components;
using PieShopHRM.App.Models;
using PieShopHRM.Shared.Domain;

namespace PieShopHRM.App.Pages;

public partial class EmployeeDetail
{
    [Parameter]
    public int EmployeeId { get; set; }

    public Employee? Employee { get; set; } = new Employee();

    protected override Task OnInitializedAsync()
    {
        Employee = MockDataService.Employees.FirstOrDefault(e => e.EmployeeId == EmployeeId);

        return base.OnInitializedAsync();
    }
}

