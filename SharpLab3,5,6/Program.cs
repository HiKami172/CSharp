using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace SharpLab3
{
    class Program
    {
        private static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            //======================================Демонстрация работы базового класса=============================
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter surname: ");
            string surname = Console.ReadLine();
            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Human hum1 = new Human(name, surname, age);
            Console.Write("Age: " + hum1.GetAge() + "\n");
            hum1.Bitrthday();
            Console.Write("Bithday occured!\nAge: " + hum1.GetAge() + "\nPress any key...");
            Console.ReadKey();
            while (true)
            {
                Console.Clear();
                Console.Write("Enter hobby: ");
                hum1.AddHobby(Console.ReadLine());
                Console.WriteLine("Press '1' to end entering hobbies.\nPress any other key to continue entering.");
                if (Console.ReadKey().KeyChar == '1')
                    break;
            }

            Console.Clear();
            Console.WriteLine("Hobbies: " + hum1.GetHobbies() + "\nPress any key...");
            Console.ReadKey();
            Console.Clear();

            //======================================Демонстрация классов-наследников================================
            Console.Write("{0} {1} entered University.\nEnter the name of university: ", hum1.name, hum1.surname);
            Student stud1 = new Student(hum1, Console.ReadLine(), Form.Budget);
            Console.Clear();
            stud1.GetInfo();
            Console.WriteLine("Prees any key...");
            Console.ReadKey();
            Console.Clear();
            Console.Write("Enter speciality: ");
            SpecialStudent specStud1 = new SpecialStudent(stud1, Console.ReadLine());
            Console.Clear();
            specStud1.GetSpecInfo();
            Console.WriteLine("Prees any key...");
            Console.ReadKey();
            Console.Clear();

            //======================================Демонстрация работы интерфейсов=================================
            int n = 3;
            SpecialStudent[] spec= new SpecialStudent[n];
            spec[0] = specStud1;
            spec[1] = new SpecialStudent("IaPT", 3, Form.Commerce, "Kevin", "Lewis", 27, "BSUIR");
            spec[2] = new SpecialStudent("ECS", 2, Form.Budget, "John", "Carrol", 36, "BSUIR");
            Console.WriteLine("Sort by Course:");
            Array.Sort(spec, new SpecialStudent.CompareCourse());
            foreach (SpecialStudent x in spec)
            {
                x.GetSpecInfo();
                Console.WriteLine();
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Sort by Age:");
            Array.Sort(spec, new Human.CompareAge());
            foreach (SpecialStudent x in spec)
            {
                x.GetSpecInfo();
                Console.WriteLine();
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Sort by Name:");
            Array.Sort(spec, new Human.CompareName());
            foreach (SpecialStudent x in spec)
            {
                x.GetSpecInfo();
                Console.WriteLine();
            }
            Console.ReadKey();
            Console.Clear();

            for (int j = 0; j < n; j++)
            {
                spec[j].GetSpecInfo();
                spec[j].SetGrades();
                Console.Clear();
            }

            for (int j = 0; j < n; j++)
            {
                Console.Write("{0} {1}'s grades: ", spec[j].name, spec[j].surname);
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(spec[j][i] + ", ");
                }
            }
            Console.ReadKey();
            Console.Clear();

            //======================================Демонстрация работы делегатов=================================
            specStud1.RegisterHandler(new SpecialStudent.StateHandler(ShowMessage));
            specStud1.GetSpecInfo();
            Console.ReadKey();
        }
    }
}
