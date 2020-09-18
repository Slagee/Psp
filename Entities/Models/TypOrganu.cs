using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TypOrganu
    {
        public TypOrganu()
        {
            Organy = new HashSet<Organ>();
            TypFunkce = new HashSet<TypFunkce>();
        }

        public short IdTypOrg { get; set; }
        public short? TypIdTypOrg { get; set; }
        public string NazevTypOrgCz { get; set; }
        public string NazevTypOrgEn { get; set; }
        public short? TypOrgObecny { get; set; }
        public short? Priorita { get; set; }

        public virtual ICollection<Organ> Organy { get; set; }
        public virtual ICollection<TypFunkce> TypFunkce { get; set; }
    }
}
