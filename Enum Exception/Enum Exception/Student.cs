using Enum_Exception.Enums;

namespace Enum_Exception
{
    class Student
    {
        public static int Count { get; private set; } = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Gender Gender { get; set; }

        public Student(string name, string surname, Gender gender)
        {
            Id = ++Count;
            Name = name;
            Surname = surname;
            Gender = gender;
        }

        public void GetInfo()
        {
            Console.WriteLine($"{Id}, {Name}, {Surname}, {Gender}, {Count}");

        }
    }
}
