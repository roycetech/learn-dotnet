using System;
using System.Threading.Tasks;
using System.Threading;

namespace async {

    class Worker {

        public Worker() {
            Work();
        }

        public void Work() {

        }
    }


        class AsyncClass {

        public async void Work() {
            Thread.Sleep(100);
        }
    }
}