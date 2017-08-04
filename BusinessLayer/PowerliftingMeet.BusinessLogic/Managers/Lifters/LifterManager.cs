using PowerliftingMeet.BusinessEntities.Lifters;
using PowerliftingMeet.DataAccessLayer.Repositories.Lifters;

namespace PowerliftingMeet.BusinessLogic.Managers.Lifters
{
    public class LifterManager : ILifterManager
    {
        private readonly ILifterRepository _lifterRepo;

        public LifterManager(ILifterRepository lifterRepo)
        {
            _lifterRepo = lifterRepo;
        }

        public Lifter GetLifter(int lifterId)
        {
            var lifterDb = _lifterRepo.GetLifter(lifterId);
            return new Lifter()
            {
                LifterId = lifterDb.LifterId,
                UserId = lifterDb.UserId
            };
        }
    }
}
