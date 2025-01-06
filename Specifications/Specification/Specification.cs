using System.Linq.Expressions;

namespace Specifications.Specification;

// Mapping of DTO, Include, OrderBy, Tracking, AsNoTracking, AsSplitQuery, IgnoreQueryFilters, 
public abstract class Specification<TEntity, TDto> : SpecificationBase<TEntity>,
    ISpecification<TEntity, TDto>
{
    public abstract IQueryable<TDto> Specificate(IQueryable<TEntity> query);
    protected abstract Expression<Func<TEntity, TDto>> Map();
}

public abstract class Specification<TEntity> : SpecificationBase<TEntity>, ISpecification<TEntity>
{
    public abstract IQueryable<TEntity> Specificate(IQueryable<TEntity> query);
}