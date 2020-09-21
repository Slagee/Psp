using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Components;
using Poslanci.Client.HttpRepository;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Poslanci.Client.Pages
{
    public partial class PoslanecDetail
    {
        private PoslanecDto _poslanec;
        
        private string datumNarozeni, datumUmrti;

        [Inject]
        IPoslanciHttpRepository PoslanciRepo { get; set; }
        [Inject]
        IZarazeniHttpRepository ZarazeniRepo { get; set; }

        [Parameter]
        public string Id { get; set; }

        private List<ZarazeniDto> Funkce { get; set; }
        private List<ZarazeniDto> Clenstvi { get; set; }

        protected async override Task OnInitializedAsync()
        {
            _poslanec = await PoslanciRepo.GetPoslanec(Id);
            
            short id = _poslanec.OsobniData.IdOsoba;

            await DetailFunkce(id);
            await DetailClenstvi(id);

            datumNarozeni = _poslanec.OsobniData.Narozeni.ToString("dd. MMMM yyyy", CultureInfo.CreateSpecificCulture("cs-CZ"));

            if (!_poslanec.OsobniData.Umrti.Equals(new DateTime(1899, 12, 30)))
            {
                datumUmrti = _poslanec.OsobniData.Umrti.ToString("dd. MMMM yyyy", CultureInfo.CreateSpecificCulture("cs-CZ"));
            }
        }

        private async Task DetailFunkce(short id)
        {
            Funkce = await ZarazeniRepo.GetFunkce(id);
        }

        private async Task DetailClenstvi(short id)
        {
            Clenstvi = await ZarazeniRepo.GetClenstvi(id);
        }
    }
}
