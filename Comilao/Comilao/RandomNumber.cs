using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Comilao
{
    public class RandomNumber : Random
    {
        private static readonly Random Global = new Random();
        [ThreadStatic]
        private static Random _local;

        public static int NextVal(int min, int max)
        {
            var localBuffer = _local;
            if (localBuffer == null)
            {
                int seed;
                lock (Global) seed = Global.Next();
                localBuffer = new Random(seed);
                _local = localBuffer;
            }
            return localBuffer.Next(min, max);
        }
    }
}
