
namespace HotelProject.Entities.Abstract
{
    public abstract class Entity<TId> : IEntity<TId>
    {
        public TId Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? UpdatedTime { get ; set ; }
    }
}
