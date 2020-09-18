using System;

namespace Entities.DataTransferObjects
{
    public class ZarazeniDto
    {
        public DateTime? OdO { get; set; }
        public DateTime? DoO { get; set; }
        public DateTime? OdF { get; set; }
        public DateTime? DoF { get; set; }

        public virtual OrganDto IdOrgan { get; set; }
        public virtual FunkceDto IdFunkce { get; set; }
        public virtual OsobaDto IdOsobaNavigation { get; set; }
    }
}
