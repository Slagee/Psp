using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Zarazeni
    {
        public short? IdOsoba { get; set; }
        public short? IdOf { get; set; }
        public short? ClFunkce { get; set; }
        public DateTime? OdO { get; set; }
        public DateTime? DoO { get; set; }
        public DateTime? OdF { get; set; }
        public DateTime? DoF { get; set; }

        public virtual Organ IdOf1 { get; set; }
        public virtual Funkce IdOfNavigation { get; set; }
        public virtual Osoba IdOsobaNavigation { get; set; }
    }
}
