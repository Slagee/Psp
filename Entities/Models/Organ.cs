﻿using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Organ
    {
        public Organ()
        {
            Funkce = new HashSet<Funkce>();
            PoslanecIdKandidatkaNavigation = new HashSet<Poslanec>();
            PoslanecIdKrajNavigation = new HashSet<Poslanec>();
            PoslanecIdObdobiNavigation = new HashSet<Poslanec>();
        }

        public short IdOrgan { get; set; }
        public short? OrganIdOrgan { get; set; }
        public short? IdTypOrganu { get; set; }
        public string Zkratka { get; set; }
        public string NazevOrganuCz { get; set; }
        public string NazevOrganuEn { get; set; }
        public DateTime? OdOrgan { get; set; }
        public DateTime? DoOrgan { get; set; }
        public short? Priorita { get; set; }
        public short? ClOrganBase { get; set; }

        public virtual TypOrganu TypOrganu { get; set; }
        public virtual ICollection<Funkce> Funkce { get; set; }
        public virtual ICollection<Poslanec> PoslanecIdKandidatkaNavigation { get; set; }
        public virtual ICollection<Poslanec> PoslanecIdKrajNavigation { get; set; }
        public virtual ICollection<Poslanec> PoslanecIdObdobiNavigation { get; set; }
    }
}
