using PowerliftingMeet.BusinessEntities.Lifters;

namespace PowerliftingMeet.BusinessLogic.Managers
{
    public interface ILifterManager
    {
        Lifter GetLifter(int id);
    }
}
