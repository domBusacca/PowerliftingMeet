using System.Collections.Generic;
using System.Linq;
using PowerliftingMeet.BusinessEntities.Attempts;
using PowerliftingMeet.BusinessEntities.Flights;
using PowerliftingMeet.BusinessEntities.Lifters;
using PowerliftingMeet.DataAccessLayer.Repositories.Flights;

namespace PowerliftingMeet.BusinessLogic.Managers.Flights
{
    public class FlightManager : IFlightManager
    {
        private readonly IFlightRepository _flightRepo;

        public FlightManager(IFlightRepository flightRepo)
        {
            _flightRepo = flightRepo;
        }

        public Flight PrioritizeFlight(int flightId)
        {
            // Get flight details 
            var flightDb = _flightRepo.GetFlight(flightId);

            // Get all Lifters and their corresponding Attempts for a given Flight
            var lifters = GetLiftersByFlightId(flightId);

            // Gets lifters next attempt
            var nextAttempt = new List<Attempt>();
            foreach (var lifter in lifters)
            {
                var attempt = lifter.Attempts.Where(x => !x.IsComplete)
                                             .OrderBy(x => x.AttemptNumber)
                                             .FirstOrDefault();

                nextAttempt.Add(attempt);
            }

            // Order next attempts
            var nextAttemptOrdered = nextAttempt.OrderBy(x => x.AttemptNumber)
                                                .ThenBy(x => x.AmountInLbs)
                                                .ToList();

            // Create ordered list for lifter priority in flight
            var liftersOrdered = new List<Lifter>();
            foreach (var attempt in nextAttemptOrdered)
            {
                var foundLifter = lifters.First(x => x.LifterId == attempt.LifterId);
                liftersOrdered.Add(foundLifter);
            }

            return new Flight()
            {
                FlightId = flightDb.FlightId,
                FlightName = flightDb.FlightName,
                Lifters = liftersOrdered
            };
        }

        private List<Lifter> GetLiftersByFlightId(int flightId)
        {
            return new List<Lifter>()
            {
                new Lifter()
                {
                    LifterId = 4,
                    UserId = 4,
                    Attempts = new List<Attempt>()
                    {
                        new Attempt()
                        {
                            LifterId = 4,
                            AmountInLbs = 800,
                            AttemptNumber = 1,
                            IsComplete = true,
                            IsGoodLift = true
                        },
                        new Attempt()
                        {
                            LifterId = 4,
                            AmountInLbs = 900,
                            AttemptNumber = 2,
                            IsComplete = true,
                            IsGoodLift = true
                        },
                        new Attempt()
                        {
                            LifterId = 4,
                            AmountInLbs = 1000,
                            AttemptNumber = 3,
                            IsComplete = false,
                            IsGoodLift = false
                        }
                    }
                },
                new Lifter()
                {
                    LifterId = 1,
                    UserId = 1,
                    Attempts = new List<Attempt>()
                    {
                        new Attempt()
                        {
                            LifterId = 1,
                            AmountInLbs = 500,
                            AttemptNumber = 1,
                            IsComplete = false,
                            IsGoodLift = false
                        },
                        new Attempt()
                        {
                            LifterId = 1,
                            AmountInLbs = null,
                            AttemptNumber = 2,
                            IsComplete = false,
                            IsGoodLift = false
                        },
                        new Attempt()
                        {
                            LifterId = 1,
                            AmountInLbs = null,
                            AttemptNumber = 3,
                            IsComplete = false,
                            IsGoodLift = false
                        }
                    }
                },
                new Lifter()
                {
                    LifterId = 2,
                    UserId = 2,
                    Attempts = new List<Attempt>()
                    {
                        new Attempt()
                        {
                            LifterId = 2,
                            AmountInLbs = 600,
                            AttemptNumber = 1,
                            IsComplete = true,
                            IsGoodLift = true
                        },
                        new Attempt()
                        {
                            LifterId = 2,
                            AmountInLbs = 700,
                            AttemptNumber = 2,
                            IsComplete = false,
                            IsGoodLift = false
                        },
                        new Attempt()
                        {
                            LifterId = 2,
                            AmountInLbs = null,
                            AttemptNumber = 3,
                            IsComplete = false,
                            IsGoodLift = false
                        }
                    }
                },
                new Lifter()
                {
                    LifterId = 3,
                    UserId = 3,
                    Attempts = new List<Attempt>()
                    {
                        new Attempt()
                        {
                            LifterId = 3,
                            AmountInLbs = 450,
                            AttemptNumber = 1,
                            IsComplete = true,
                            IsGoodLift = true
                        },
                        new Attempt()
                        {
                            LifterId = 3,
                            AmountInLbs = 500,
                            AttemptNumber = 2,
                            IsComplete = false,
                            IsGoodLift = false
                        },
                        new Attempt()
                        {
                            LifterId = 3,
                            AmountInLbs = null,
                            AttemptNumber = 3,
                            IsComplete = false,
                            IsGoodLift = false
                        }
                    }
                }
            };
        }
    }
}
