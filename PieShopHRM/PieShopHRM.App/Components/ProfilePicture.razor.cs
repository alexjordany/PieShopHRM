using Microsoft.AspNetCore.Components;

namespace PieShopHRM.App.Components;

public partial class ProfilePicture
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}
