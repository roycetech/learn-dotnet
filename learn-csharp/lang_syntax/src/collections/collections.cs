using System;
using System.Collections.Generic;

namespace collections {

    class Person {

        public string Name { get; set; }

        public int Age { get; set; }
    }

    class CollectionProgram {

        public void run() {

            // 1. List
            List<Person> personList = new List<Person>();
            personList.Add(new Person() { Name="George", Age=90 });
            Console.WriteLine(personList[0]);

            // Dictionary
            Dictionary<String, Person> personMap = new Dictionary<String, Person>();
            personMap.Add("george", new Person() { Name="George", Age=90 });
            Console.WriteLine(personMap["george"]);

        }
    }

}