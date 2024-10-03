namespace HotelProject.DataAccess
{
    public interface IRepository<TEntity> 
    {
        public IList<TEntity> GetList(Func<TEntity, bool>? predicate = null);
        public TEntity? Get(Func<TEntity, bool> predicate);
        public TEntity Add(TEntity entity);
        public TEntity Delete(TEntity entity, bool IsDeleted = true);
        public TEntity Update(TEntity entity);
    }
}
