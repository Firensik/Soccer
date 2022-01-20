using System;

namespace Soccer.Logic
{


    public class LuckFactory : ILuckFactory
    {
        private readonly Random random;

        public LuckFactory(int seed)
        {
            random = new Random();
            random.Next(0,20);
           
           
          





        }

        public int GetLuck()
        {
            return random.Next(0 , 20);
        }
    }
}
