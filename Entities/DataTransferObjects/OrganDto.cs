using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class OrganDto
    {
        public string Zkratka { get; set; }
        public string NazevOrganuCz { get; set; }
        public string NazevOrganuEn { get; set; }
        public DateTime? OdOrgan { get; set; }
        public DateTime? DoOrgan { get; set; }
        
        public TypOrganuDto TypOrganu { get; set; }
    }
}
