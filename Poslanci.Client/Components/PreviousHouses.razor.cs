using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poslanci.Client.Components
{
    public partial class PreviousHouses
    {
        [Parameter]
        public EventCallback<int> OnHouseChanged { get; set; }

        private async Task ApplySearchAsync(ChangeEventArgs eventArgs)
        {
            int result = Convert.ToInt32(eventArgs.Value);
            
            if (result == 172)
                return;

            await OnHouseChanged.InvokeAsync(result);
        }
    }
}
