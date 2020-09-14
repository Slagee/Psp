using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poslanci.Server.Pages
{
    public partial class NotFound
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public void NavigateToHome()
        {
            Console.WriteLine(NavigationManager.Uri);
            NavigationManager.NavigateTo("/");
        }
    }
}
