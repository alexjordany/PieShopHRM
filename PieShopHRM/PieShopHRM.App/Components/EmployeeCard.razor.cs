﻿using Microsoft.AspNetCore.Components;
using PieShopHRM.Shared.Domain;

namespace PieShopHRM.App.Components;

public partial class EmployeeCard
{
    [Parameter]
    public Employee Employee { get; set; } = default!;

    [Parameter]
    public EventCallback<Employee> EmployeeQuickViewClicked { get; set; }
}

