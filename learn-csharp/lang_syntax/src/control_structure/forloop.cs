using System;


namespace cs {

    class Person {
        public string Name { get; set; }

        public Person(string name) {
            Name = name;
        }

        public Person() {
        }
    }

    class Program {

        public void run() {
            
            Person person = new Person() {
                Name = "Sally"
            };

            Person[] people = new Person[] { person };

            foreach(Person per in people) {
                Console.WriteLine(per.ToString());
            }

        }
    }

}