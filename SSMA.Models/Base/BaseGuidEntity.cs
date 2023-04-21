namespace SSMA.Models.Base
{
    public class BaseGuidEntity : BaseEntity<Guid>
    {
        public BaseGuidEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}
