namespace OOP_Assigment01
{
    internal class Program
    {
        enum WeekDays
        {
            monday, tuesday, wednesday, thursday, friday, saturday, sunday
        }

        static void Main(string[] args)
        {
            #region question1
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion

            #region question2
            Person[] persons = new Person[3];
            persons[0] = new Person { Name = "Sama", age = 23 };
            persons[1] = new Person { Name = "Zeyad", age = 24 };
            persons[2] = new Person { Name = "Habiba", age = 24 };

            foreach (Person person in persons) 
            {
                Console.WriteLine($"Name:{person.Name} , Age:{person.age}");
            }
            #endregion


        }
    }
}
