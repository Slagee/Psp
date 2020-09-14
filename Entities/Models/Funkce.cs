using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Funkce
    {
        public short IdFunkce { get; set; }
        public short? IdOrgan { get; set; }
        public short? IdTypFunkce { get; set; }
        public string NazevFunkceCz { get; set; }
        public short? Priorita { get; set; }

        public virtual TypFunkce IdTypFunkceNavigation { get; set; }
    }
}
