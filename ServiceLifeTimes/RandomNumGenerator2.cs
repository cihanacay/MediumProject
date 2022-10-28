using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLifeTimes
{
    public class RandomNumGenerator2 : IRandomNumGenerator2
    {
        public readonly IRandomNumGenerator _randomNumGenerator;
        public RandomNumGenerator2(IRandomNumGenerator randomNumGenerator)
        {
            _randomNumGenerator = randomNumGenerator;
        }
        public int RandomNumGenerator()
        {
            return _randomNumGenerator.RandomNumber;
        }

    }
    public interface IRandomNumGenerator2
    {
        public int RandomNumGenerator();
    }
}
