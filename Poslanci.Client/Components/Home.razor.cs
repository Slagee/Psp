using Microsoft.AspNetCore.Components;

namespace Poslanci.Client.Components
{
    public partial class Home
    {
        [Parameter]
        public string Title { get; set; }

        [CascadingParameter]
        public string Color { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}
