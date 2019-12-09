namespace Runner
{
    using System;
    using Collections;
    using System.Collections.Generic;

    class Random_Generator
    {
        readonly Person[] persons;
        readonly List<string> numbers;
        public List<Person> listPerson;
        Random rand;// = new Random();

        public Random_Generator()
        {
            rand = new Random();

            numbers = new List<string>
            {
                "+123-445-00",
                "3-098-22-33",
                "+20-00-33-44",
                "+4566-99-66-22",
                "3-098-22-33",
                "+20-00-33-44",
                "+2368-443-00",
                "3-678-22-33",
                "+65-45-43-44",
                "+123-345-00",
                "3-784-22-33",
                "+345-00-12-44",
                "+3454-3453-00",
                "3-5453-22-33",
                "+234-00-09",
                "+22-445-46",
                "3-57-877-11",
                "+1-22-33-23",
                "+33-456-04560",
                "+3-088-34-567",
                "+2-00-93-50",
                "+44-445-00-99",
                "+3-098-65-46",
                "+3-43-03-577"
            };

            persons = new Person[]
            {
                  new Person { Name = "Person 1", Age = 33, PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 2", Age = 42, PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 3", Age = 42, PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 4",  Age = 42, PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 5",  Age = 42, PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 6", Age = 42,  PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 7", Age = 42,  PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 8", Age = 42,  PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 9", Age = 42, PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 10", Age = 42,  PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 11", Age = 42,  PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 12",  Age = 42, PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 13", Age = 42,  PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 14", Age = 42,  PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 15", Age = 42, PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 16", Age = 42,  PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 17", Age = 42,  PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 18",  Age = 42, PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 19", Age = 42,  PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 20", Age = 42,  PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 21", Age = 42, PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 22", Age = 42,  PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 23", Age = 42,  PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 24", Age = 42,  PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 25", Age = 42,  PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 26",  Age = 42, PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 27", Age = 42, PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 28", Age = 42,  PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 29",  Age = 42, PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 30", Age = 42,  PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 31", Age = 42,  PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 32", Age = 42,  PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 33", Age = 42, PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 34", Age = 42,  PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 35", Age = 42,  PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 36",  Age = 42, PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 37",  Age = 42, PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 38", Age = 42,  PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 39", Age = 42, PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 40", Age = 42,  PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 41", Age = 42,  PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))},
                  new Person { Name = "Person 42",  Age = 42, PhoneNumbers = GetNumbersRandom(rand.Next(2, 24))}
            };

            int length = persons.Length;

            listPerson = new List<Person>();
            listPerson.AddRange(persons);
        }


        public IEnumerable<Person> GetPersonsRandom(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return persons[i];
            }
        }

        public IEnumerable<string> GetNumbersRandom(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return numbers[i];
            }
        }
    }
}
