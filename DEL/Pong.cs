using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DEL;

namespace DEL
{
    public class Pong
    {
        public delegate void Pong1();

        Pong1 test = new Pong1(Ping.Ping2);
        public Pong()
        {
            Ping x = new Ping();
            test.Invoke();
        }

        public static  void Pong2()
        {
            Console.WriteLine("Ping recieved Pong");
        }
    }
}
