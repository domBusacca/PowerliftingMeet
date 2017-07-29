using PowerliftingMeet.BusinessEntities.Lifters;
using PowerliftingMeet.DataAccessLayer.Repositories;

namespace PowerliftingMeet.BusinessLogic.Managers
{
    public class LifterManager : ILifterManager
    {
        private readonly ILifterRepository _lifterRepo;

        public LifterManager(ILifterRepository lifterRepo)
        {
            _lifterRepo = lifterRepo;
        }

        public Lifter GetLifter(int id)
        {
            var lifterDb = _lifterRepo.GetLifter(id);
            return new Lifter()
            {
                LifterId = lifterDb.LifterId,
                FirstName = lifterDb.FirstName,
                LastName = lifterDb.LastName
            };
        }
    }
}
