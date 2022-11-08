using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DEL;
using static DEL.Pong;

namespace DEL
{
    public class Ping
    {
        public delegate void Ping1();

        Ping1 test = new Ping1(Pong.Pong2);

        public Ping()
        {
            Pong x = new Pong();
            test.Invoke();
        }
        public static void Ping2()
        {
            Console.WriteLine("Ping recieved Pong");
        }
    }
}
