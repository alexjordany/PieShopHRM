using PieShopHRM.App.Components.Widgets;

namespace PieShopHRM.App.Pages;

public partial class Index
{
    public List<Type> Widgets { get; set; } = new List<Type>()
    {
        typeof (EmployeeCountWidget), typeof(InboxWidget)
    };


}

