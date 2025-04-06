using Enum_Exception.Enums;

namespace Enum_Exception
{
    class Group
    {
        public static Group[] Groups = new Group[0];
        public static int GroupCount { get; private set; } = 0;

        public int GroupId { get; private set; }
        public string GroupName { get; set; }
        public GroupType GroupType { get; set; }
        public Student[] Students { get; set; } = new Student[0];

        public Group(string name, GroupType type)
        {
            GroupCount++;
            GroupId = GroupCount;
            GroupName = name;
            GroupType = type;
        }

        public void GetGroupInfo()
        {
            Console.WriteLine($"{GroupId}, {GroupName}, {GroupType}, {Students.Length}");
        }

        public Student GetStudent(int id)
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Id == id)
                {
                    return Students[i];
                }
            }
            return null;
        }

        public void AddStudent(Student student)
        {
            if (student != null)
            {
                Student[] arr = new Student[Students.Length + 1];

                for (int i = 0; i < Students.Length; i++)
                {
                    arr[i] = Students[i];
                }

                arr[Students.Length] = student;

                Students = arr;
            }
            else
            {
                Console.WriteLine("null");
            }
        }

        public void RemoveStudent(int id)
        {
            if (GetStudent(id) != null)
            {
                Student[] arr = new Student[Students.Length - 1];
                for (int i = 0; i < Students.Length; i++)
                {
                    if (Students[i].Id != id)
                    {
                        arr[i] = Students[i];
                    }
                }
                Students = arr;
            }
            else
            {
                Console.WriteLine("student not found");
            }
        }

        public void ShowStudents()
        {
            if (Students.Length > 0)
            {
                for (int i = 0; i < Students.Length; i++)
                {
                    Students[i].GetInfo();
                }
            }
            else
            {
                Console.WriteLine("group is empty");
            }
        }

        public static void ShowAllGroups()
        {
            if (Groups.Length > 0)
            {
                for (int i = 0; i < Groups.Length; i++)
                {
                    Groups[i].GetGroupInfo();
                }
            }
            else
            {
                Console.WriteLine("there is not any group");
            }
        }

        public static void AddGroup(Group group)
        {
            if (group != null)
            {
                Group[] arr = new Group[Groups.Length + 1];

                for (int i = 0; i < Groups.Length; i++)
                {
                    arr[i] = Groups[i];
                }

                arr[Groups.Length] = group;

                Groups = arr;
            }
        }

        public static void RemoveGroup(int id)
        {
            Group[] arr = new Group[Groups.Length - 1];
            for (int i = 0; i < Groups.Length; i++)
            {
                if (Groups[i].GroupId != id)
                {
                    arr[i] = Groups[i];
                }
            }
            Groups = arr;
        }
    }
}

