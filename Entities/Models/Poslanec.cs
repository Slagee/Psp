namespace Entities.Models
{
    public partial class Poslanec
    {
        public short IdPoslanec { get; set; }
        public short? IdOsoba { get; set; }
        public short? IdKraj { get; set; }
        public short? IdKandidatka { get; set; }
        public short? IdObdobi { get; set; }
        public string Web { get; set; }
        public string Ulice { get; set; }
        public string Obec { get; set; }
        public string Psc { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Fax { get; set; }
        public string PspTelefon { get; set; }
        public string Facebook { get; set; }
        public short? Foto { get; set; }

        public virtual Organ Kandidatka { get; set; }
        public virtual Organ Kraj { get; set; }
        public virtual Organ VolebniObdobi { get; set; }
        public virtual Osoba OsobniData { get; set; }
    }
}
