using Microsoft.AspNetCore.Components;
using PieShopHRM.App.Models;
using PieShopHRM.App.Services;
using PieShopHRM.Shared.Domain;

namespace PieShopHRM.App.Pages;

public partial class EmployeeDetail
{
    [Inject]
    public IEmployeeDataService? _employeeDataService { get; set; }

    [Parameter]
    public int EmployeeId { get; set; }

    public Employee? Employee { get; set; } = new Employee();

    protected override async Task OnInitializedAsync()
    {
        Employee = await _employeeDataService.GetEmployeeDetails(EmployeeId);
    }


}

