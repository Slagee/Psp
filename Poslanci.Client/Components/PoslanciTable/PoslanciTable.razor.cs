using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poslanci.Server.Components.PoslanciTable
{
    public partial class PoslanciTable
    {
        [Parameter]
        public List<PoslanecDto> Poslanecs { get; set; }
    }
}
