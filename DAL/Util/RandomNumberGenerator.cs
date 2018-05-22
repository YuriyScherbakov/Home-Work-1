using System;
namespace DAL.Util
    {
    class RandomNumberGenerator
        {
        private static   Random getrandom;
        private static readonly object locker = new object();
        private static int i = 0;
        public static int GetRandomNumber (int min,int max)
            {
            lock ( locker ) // synchronize
                {
                getrandom = new Random (DateTime.Now.Millisecond + i);
                i += 594;
                return getrandom.Next (min,max + 1);
                }
            }
        }
    }
