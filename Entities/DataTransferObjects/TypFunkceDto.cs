namespace Entities.DataTransferObjects
{
    public class TypFunkceDto
    {
        public string TypFunkceCz { get; set; }
        public string TypFunkceEn { get; set; }
        public short? TypFunkceObecny { get; set; }

        public virtual TypOrganuDto TypOrganu { get; set; }
    }
}
