using PowerliftingMeet.DataAccessEntities.Lifters;

namespace PowerliftingMeet.DataAccessLayer.Repositories
{
    public interface ILifterRepository
    {
        LifterDb GetLifter(int id);
    }
}
