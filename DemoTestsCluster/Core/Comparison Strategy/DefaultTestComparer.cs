using System.Collections.Generic;
using TeamMate.ClusterTestManager.Core.Interfaces;

namespace TeamMate.ClusterTestManager.Core.ComparisonStrategy
{
    public class DefaultTestComparer : IComparer<ITMTest>
    {
        public int Compare(ITMTest x, ITMTest y)
        {
            //mas duracion primero
            throw new System.NotImplementedException();
        }
    }
}
