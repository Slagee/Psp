namespace Entities.DataTransferObjects
{
    public class FunkceDto
    {
        public string NazevFunkceCz { get; set; }

        public virtual OrganDto OrganClenstvi { get; set; }
        public virtual TypFunkceDto TypFunkce { get; set; }
    }
}
