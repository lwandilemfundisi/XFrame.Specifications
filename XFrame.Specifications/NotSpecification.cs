using XFrame.Common.Extensions;
using XFrame.Specifications.Notifications;

namespace XFrame.Specifications
{
    public class NotSpecification<T> : Specification<T>
    {
        private readonly ISpecification<T> _specification;

        public NotSpecification(
            ISpecification<T> specification)
        {
            _specification = specification ?? throw new ArgumentNullException(nameof(specification));
        }

        protected override Notification IsNotSatisfiedBecause(T obj)
        {
            if (_specification.IsSatisfiedBy(obj))
            {
                return Notification
                    .Create(
                    new Message(
                        $"Specification '{_specification.GetType().PrettyPrint()}' should not be satisfied",
                        SeverityType.Critical));
            }

            return Notification.CreateEmpty();
        }
    }
}
