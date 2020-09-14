namespace Entities.DataTransferObjects
{
    public class PoslanecDto
    {
        public string Web { get; set; }
        public string Ulice { get; set; }
        public string Obec { get; set; }
        public string Psc { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }

        public OsobaDto OsobniData { get; set; }
        public OrganDto Kandidatka { get; set; }
        public OrganDto VolebniObdobi { get; set; }
        public OrganDto Kraj { get; set; }
    }
}
