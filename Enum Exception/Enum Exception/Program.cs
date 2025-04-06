namespace Enum_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group1 = new Group("BB109", Enums.GroupType.Online);
            Group group2 = new Group("BB209", Enums.GroupType.Offline);
            Group group3 = new Group("BB309", Enums.GroupType.Mixed);

            Group.AddGroup(group1);
            Group.AddGroup(group2);
            Group.AddGroup(group3);

            Student student1 = new Student("Sunay", "Kazimbeyli", Enums.Gender.female);
            Student student2 = new Student("Ibrahim", "Memmedeliyev", Enums.Gender.male);
            Student student3 = new Student("Sekhavet", "Agali", Enums.Gender.male);
            Student student4 = new Student("Rena", "Memmedova", Enums.Gender.female);

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
