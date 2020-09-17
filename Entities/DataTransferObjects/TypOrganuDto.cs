using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class TypOrganuDto
    {
        public short IdTypOrg { get; set; }
        public short? TypIdTypOrg { get; set; }
        public string NazevTypOrgCz { get; set; }
        public string NazevTypOrgEn { get; set; }
    }
}
