namespace Specifications.Specification;

public interface ISpecification<in TEntity, out TResult>
{
    IQueryable<TResult> Specificate(IQueryable<TEntity> query);
}

public interface ISpecification<TEntity>
{
    IQueryable<TEntity> Specificate(IQueryable<TEntity> query);
}