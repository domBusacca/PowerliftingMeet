using PowerliftingMeet.DataAccessEntities.Lifters;

namespace PowerliftingMeet.DataAccessLayer.Repositories.Lifters
{
    public interface ILifterRepository
    {
        LifterDb GetLifter(int id);
    }
}
