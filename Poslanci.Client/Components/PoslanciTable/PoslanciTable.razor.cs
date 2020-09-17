using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Poslanci.Client.Components.PoslanciTable
{
    public partial class PoslanciTable
    {
        [Parameter]
        public List<PoslanecDto> Poslanecs { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        private void RedirectToDetail(short id)
        {
            var url = Path.Combine("/poslanecDetail/", id.ToString());
            NavigationManager.NavigateTo(url);
        }
    }
}
