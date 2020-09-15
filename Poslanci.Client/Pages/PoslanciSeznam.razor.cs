using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using Entities.DataTransferObjects;
using Poslanci.Client.HttpRepository;
using Entities.RequestFeatures;

namespace Poslanci.Client.Pages
{
    public partial class PoslanciSeznam
    {
        public List<PoslanecDto> PoslanciList { get; set; } = new List<PoslanecDto>();
        public MetaData MetaData { get; set; } = new MetaData();
        private readonly PoslanciParameters _poslanciParameters = new PoslanciParameters();

        [Inject]
        public IPoslanciHttpRepository PoslanciRepo { get; set; }
        
        protected async override Task OnInitializedAsync()
        {
            await GetPoslance();
        }

        private async Task SelectedPage(int page)
        {
            _poslanciParameters.PageNumber = page;
            await GetPoslance();
        }

        private async Task GetPoslance()
        {
            var pagingResponse = await PoslanciRepo.GetCurrentPoslanci(_poslanciParameters);
            PoslanciList = pagingResponse.Items;
            MetaData = pagingResponse.MetaData;
        }
    }
}