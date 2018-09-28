namespace CoreMVCDemo2.Models.BaseEntity
{
    public class BaseEntity
    {

    }

    public class Entity<T> : BaseEntity,IEntity<T>
    {
        public T Id { get; set; }
    }
}
