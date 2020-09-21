using System;

namespace Entities.DataTransferObjects
{
    public class OsobaDto
    {
        public short IdOsoba { get; set; }
        public string Pred { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Za { get; set; }
        public DateTime Narozeni { get; set; }
        public string Pohlavi { get; set; }
        public DateTime? Zmena { get; set; }
        public DateTime Umrti { get; set; }
    }
}
