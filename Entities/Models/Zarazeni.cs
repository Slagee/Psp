using System;

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

        public virtual Organ IdOrgan { get; set; }
        public virtual Funkce IdFunkce { get; set; }
        public virtual Osoba IdOsobaNavigation { get; set; }
    }
}
