using System;
using System.Linq.Expressions;
using Core.Interfaces;

namespace Core.Specification;

public class BaseSpesification<T>(Expression<Func<T, bool>>? criteria) : ISpecification<T>
{
    protected BaseSpesification() : this(null) {}
    public Expression<Func<T, bool>>? Criteria => criteria;
}
