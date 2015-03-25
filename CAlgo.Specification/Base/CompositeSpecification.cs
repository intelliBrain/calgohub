namespace CAlgo.Specification
{
    public abstract class CompositeSpecification<T> : ISpecification<T>
    {
        public abstract bool IsSatisfiedBy(T o);

        public ISpecification<T> And(ISpecification<T> specification)
        {
            return new AndSpecification<T>(this, specification);
        }

        public ISpecification<T> Or(ISpecification<T> specification)
        {
            return new OrSpecification<T>(this, specification);
        }

        public ISpecification<T> Not(ISpecification<T> specification)
        {
            return new NotSpecification<T>(specification);
        }

        public static CompositeSpecification<T> operator &(CompositeSpecification<T> x, CompositeSpecification<T> y)
        {
            return new AndSpecification<T>(x, y);
        }

        public static CompositeSpecification<T> operator |(CompositeSpecification<T> x, CompositeSpecification<T> y)
        {
            return new OrSpecification<T>(x, y);
        }

        public static CompositeSpecification<T> operator !(CompositeSpecification<T> x)
        {
            return new NotSpecification<T>(x);
        }
    }
}