using Microsoft.AspNetCore.Components;
using PieShopHRM.App.Models;
using PieShopHRM.App.Services;
using PieShopHRM.Shared.Domain;

namespace PieShopHRM.App.Pages;

public partial class EmployeeOverview
{
    [Inject]
    public IEmployeeDataService? _employeeDataService { get; set; }

    public List<Employee>? Employees { get; set; } = default!;

    private Employee? _selectedEmployee;

    private string Title = "Employee overview";

    protected override async Task OnInitializedAsync()
    {
        Employees = (await _employeeDataService.GetAllEmployees()).ToList();
    }

    public void ShowQuickViewPopup(Employee selectedEmployee)
    {
        _selectedEmployee = selectedEmployee;
    }
}

