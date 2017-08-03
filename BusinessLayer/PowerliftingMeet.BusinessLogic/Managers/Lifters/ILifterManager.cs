using PowerliftingMeet.BusinessEntities.Lifters;

namespace PowerliftingMeet.BusinessLogic.Managers.Lifters
{
    public interface ILifterManager
    {
        Lifter GetLifter(int lifterId);
    }
}
