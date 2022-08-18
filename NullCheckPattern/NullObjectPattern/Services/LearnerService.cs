using NullObjectPattern.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern.Services
{
    public class LearnerService
    {
        private readonly LearnerRepo _repo;

        public ILearner GetCurrentLearner()
        {
            // go get the Learner's id from JWT token cookie
            // or by some other appropriate means

            int learnerId = 1;

            ILearner learner = _repo.GetLearner(learnerId);

            if (learner == null)
                return new NullLearner();

            return learner;
        }
    }

    class LearnerRepo
    {
        readonly IList<Learner> _learners = new List<Learner>();  

        /*
         * In memory leanrers 
         * 
         */
        internal LearnerRepo()
        {
            _learners.Add(new Learner(1, "David", 83));
            _learners.Add(new Learner(2, "Julie", 89));
            _learners.Add(new Learner(3, "Scott", 92));
        }

        internal ILearner GetLearner(int id)
        {
            bool learnerExists = _learners.Any(l => l.Id == id);

            if (learnerExists)
            {
                return _learners.FirstOrDefault(l => l.Id == id);
            }
            return null;
        }
    }
}
