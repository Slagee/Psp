using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TypFunkce
    {
        public TypFunkce()
        {
            Funkce = new HashSet<Funkce>();
        }

        public short IdTypFunkce { get; set; }
        public short? IdTypOrg { get; set; }
        public string TypFunkceCz { get; set; }
        public string TypFunkceEn { get; set; }
        public short? Priorita { get; set; }
        public short? TypFunkceObecny { get; set; }

        public virtual TypOrganu TypOrganu { get; set; }
        public virtual ICollection<Funkce> Funkce { get; set; }
    }
}
