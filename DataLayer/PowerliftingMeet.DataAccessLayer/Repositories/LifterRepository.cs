﻿using PowerliftingMeet.DataAccessEntities.Lifters;

namespace PowerliftingMeet.DataAccessLayer.Repositories
{
    public class LifterRepository : ILifterRepository
    {
        public LifterDb GetLifter(int id)
        {
            return new LifterDb()
            {
                LifterId = 1,
                FirstName = "Test",
                LastName = "User"
            };
        }
    }
}
