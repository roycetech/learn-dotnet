using System;
using System.Collections.Generic;


namespace nullopers {

    class Program {
        public void run() {

            List<string> list = null;
            int i = list?.Count ?? 0;

            Console.WriteLine(i);
        }
    }

}