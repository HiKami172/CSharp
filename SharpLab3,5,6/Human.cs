using System;
using System.Collections;

namespace SharpLab3
{
    class Human
    {
        protected static int count = 0;
        protected int hobbyCount = 0;
        protected int id;
        protected int age;
        protected Occupation occup;
        protected string[] hobbies;
        public string name { get; protected set; }
        public string surname { get; protected set; }


        public Human(string Name, string Surname, int Age, Occupation Occup)
        {
            name = Name;
            surname = Surname;
            age = Age;
            occup = Occup;
            id = count;
            ++count;
        }

        public Human(string Name, string Surname, int Age)
        {
            name = Name;
            surname = Surname;
            age = Age;
            id = count;
            ++count;
        }

        public Human(string Name, string Surname)
        {
            name = Name;
            surname = Surname;
            id = count;
            ++count;
        }

        public Human(Human human)
        {
            name = human.name;
            surname = human.surname;
            age = human.age;
            occup = human.occup;
            id = human.id;
            hobbies = human.hobbies;
            hobbyCount = human.hobbyCount;
        }

        public int GetAge()
        {
            return age;
        }

        public void Bitrthday()
        {
            ++age;
        }

        public void AddHobby(string Hobby)
        {
            ++hobbyCount;
            string[] arr = new string[hobbyCount];
            arr[hobbyCount - 1] = Hobby;
            if (hobbies != null)
                Array.Copy(hobbies, arr, hobbyCount - 1);
            hobbies = arr;
        }

        public string GetHobbies()
        {
            if (hobbyCount != 0)
            { 
            string final = "";
            for (int i = 0; i < hobbyCount - 1; ++i)
                final += hobbies[i] + ", ";
            final += hobbies[hobbyCount - 1];
            return final;
            }
            return "";
        }

        public class CompareAge : IComparer
        {
            int IComparer.Compare(object obj1, object obj2)
            {
                Human hum1 = (Human)obj1;
                Human hum2 = (Human)obj2;
                if (hum1.age == hum2.age)
                    return 0;
                return (hum1.age > hum2.age) ? 1 : -1;
            }
        }

        public class CompareName : IComparer
        {
            int IComparer.Compare(object obj1, object obj2)
            {
                Human hum1 = (Human)obj1;
                Human hum2 = (Human)obj2;
                if (hum1.surname == hum2.surname)
                    return String.Compare(hum1.name, hum2.name);
                return String.Compare(hum1.surname, hum2.surname);
            }
         }

    }
}
