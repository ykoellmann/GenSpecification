using Specifications.Specification.Include;
using Specifications.Specification.Order;

namespace Specifications.Specification;

public class SpecificationBase<TEntity>
{
    protected virtual bool AsNoTracking => false;
    protected virtual bool AsSplitQuery => false;
    protected virtual bool IgnoreQueryFilters => false;

    protected virtual IIncludableSpecification<TEntity> Include(IIncludableSpecification<TEntity> includable)
    {
        return null;
    }

    protected virtual IOrderedSpecification<TEntity> Order(IOrderedSpecification<TEntity> ordered)
    {
        return null;
    }
}