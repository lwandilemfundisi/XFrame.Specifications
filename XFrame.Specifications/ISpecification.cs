using XFrame.Notifications;

namespace XFrame.Specifications
{
    public interface ISpecification<in T>
    {
        bool IsSatisfiedBy(T obj);

        Notification WhyIsNotSatisfiedBy(T obj);
    }
}
