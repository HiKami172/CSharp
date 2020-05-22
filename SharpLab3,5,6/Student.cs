using System;

namespace SharpLab3
{
    class Student : Human, IIndex
    {
        protected int[] entranceGrades = new int[3];
        protected University univer;
        protected Form form;

        public Student(string name, string surname, int age, string UniverName, Form form) : base(name, surname, age)
        {
            univer.name = UniverName;
            this.form = form;
            occup = Occupation.University;
        }

        public Student(Human human, string UniverName, Form form) : base(human)
        {
            univer.name = UniverName;
            this.form = form;
            occup = Occupation.University;
        }

        public Student(Student student) : base(student.name, student.surname, student.age)
        {
            univer.name = student.univer.name;
            form = student.form;
            entranceGrades = student.entranceGrades;
            occup = Occupation.University;
        }

        public int this[int index]
        {
            get
            {
                return entranceGrades[index];
            }
        }

        public void SetGrades()
        {
            while (true)
            {
                Console.WriteLine("Enter math exam mark: ");
                entranceGrades[0] = Convert.ToInt32(Console.ReadLine());
                if (entranceGrades[0] <= 10 && entranceGrades[0] > 0)
                    break;
            }
            while (true)
            {
                Console.WriteLine("Enter physics exam mark: ");
                entranceGrades[1] = Convert.ToInt32(Console.ReadLine());
                if (entranceGrades[1] <= 10 && entranceGrades[1] > 0)
                    break;
            }
            while (true)
            {
                Console.WriteLine("Enter russian exam mark: ");
                entranceGrades[2] = Convert.ToInt32(Console.ReadLine());
                if (entranceGrades[2] <= 10 && entranceGrades[2] > 0)
                    break;
            }
        }

        public void SetUniverLocation(int x, int y)
        {
            univer.xLocation = x;
            univer.yLocation = y;
        }

        public void GetInfo()
        {
            Console.Write($"Name: {name}\nSurname: {surname}\nAge: {age}\nUniversity: {univer.name}\nForm: {form}\n");
        }

    }
}

