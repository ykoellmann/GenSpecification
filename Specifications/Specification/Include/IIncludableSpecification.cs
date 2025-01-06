namespace Specifications.Specification.Include;

public interface IIncludableSpecification<TEntity>;

public interface IIncludableSpecification<TEntity, TProperty> : IIncludableSpecification<TEntity>;
