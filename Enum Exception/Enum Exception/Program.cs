using Enum_Exception.Enums;

namespace Enum_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group1 = new Group("BB109", GroupType.Offline);
            Group group2 = new Group("BB209", GroupType.Offline);
            Group group3 = new Group("BB309", GroupType.Mixed);

            Group.AddGroup(group1);
            Group.AddGroup(group2);
            Group.AddGroup(group3);

            Student student1 = new Student("Sunay", "Kazimbeyli", Gender.female);
            Student student2 = new Student("Ibrahim", "Memmedeliyev", Gender.male);
            Student student3 = new Student("Sekhavet", "Agali", Gender.male);
            Student student4 = new Student("Rena", "Memmedova", Gender.female);

            group1.AddStudent(student1);
            group2.AddStudent(student2);
            group3.AddStudent(student3);

            group1.ShowStudents();

            group1.AddStudent(student4);
            group1.ShowStudents();

            Group.RemoveGroup(0);
            Group.ShowAllGroups();
        }
    }
}
