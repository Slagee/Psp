using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using Entities.DataTransferObjects;
using Poslanci.Client.HttpRepository;

namespace Poslanci.Client.Pages
{
    public partial class PoslanciSeznam
    {
        public List<PoslanecDto> PoslanciList { get; set; } = new List<PoslanecDto>();

        [Inject]
        public IPoslanciHttpRepository PoslanciRepo { get; set; }

        protected async override Task OnInitializedAsync()
        {
            PoslanciList = await PoslanciRepo.GetCurrentPoslanci();
        }
    }
}