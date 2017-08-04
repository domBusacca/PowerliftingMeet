using System.Collections.Generic;
using PowerliftingMeet.BusinessEntities.Attempts;

namespace PowerliftingMeet.BusinessEntities.Lifters
{
    // Note: a new Lifter is created each Meet
    public class Lifter
    {
        public int LifterId { get; set; }
        public int UserId { get; set; } // corresponds to their user profile (name, address, etc) 
        public List<Attempt> Attempts { get; set; }
    }
}
