using XFrame.Notifications;

namespace XFrame.Specifications
{
    public abstract class Specification<T> : ISpecification<T>
    {
        public bool IsSatisfiedBy(T obj)
        {
            return !IsNotSatisfiedBecause(obj).Any();
        }

        public Notification WhyIsNotSatisfiedBy(T obj)
        {
            return IsNotSatisfiedBecause(obj);
        }

        protected abstract Notification IsNotSatisfiedBecause(T obj);
    }
}
