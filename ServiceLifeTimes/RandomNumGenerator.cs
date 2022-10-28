using System;

namespace ServiceLifeTimes
{
    public class RandomNumGenerator : IRandomNumGenerator
    {
        public int RandomNumber { get; set; }
        public RandomNumGenerator()
        {
            RandomNumber = new Random().Next(1000);
        }

    }
    public interface IRandomNumGenerator
    {
        public int RandomNumber { get; }
    }
}
