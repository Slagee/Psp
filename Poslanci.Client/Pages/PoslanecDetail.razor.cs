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
        [Parameter]
        public string Id { get; set; }

        protected async override Task OnInitializedAsync()
        {
            _poslanec = await PoslanciRepo.GetPoslanec(Id);

            datumNarozeni = _poslanec.OsobniData.Narozeni.ToString("dd. MMMM yyyy", CultureInfo.CreateSpecificCulture("cs-CZ"));

            if (!_poslanec.OsobniData.Umrti.Equals(new DateTime(1899, 12, 30)))
            {
                datumUmrti = _poslanec.OsobniData.Umrti.ToString("dd. MMMM yyyy", CultureInfo.CreateSpecificCulture("cs-CZ"));
            }
        }
    }
}
