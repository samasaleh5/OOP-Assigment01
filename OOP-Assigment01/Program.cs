namespace OOP_Assigment01
{
    internal class Program
    {
        enum WeekDays
        {
            monday, tuesday, wednesday, thursday, friday, saturday, sunday
        }
        enum Seas
        {
            Spring, Summer, Autumn, Winter
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
            //Person[] persons = new Person[3];
            //persons[0] = new Person { Name = "Sama", age = 23 };
            //persons[1] = new Person { Name = "Zeyad", age = 24 };
            //persons[2] = new Person { Name = "Habiba", age = 24 };

            //foreach (Person person in persons) 
            //{
            //    Console.WriteLine($"Name:{person.Name} , Age:{person.age}");
            //}
            #endregion

            #region question3
            Console.Write("Enter Name Of The Season (Spring, Summer, Autumn, Winter): ");
            string input = Console.ReadLine();
            if (Enum.TryParse(input, true, out Seas selectedSeason))
            {
                switch (selectedSeason)
                {
                    case Seas.Spring:
                        Console.WriteLine("Spring: From March to May");
                        break;
                    case Seas.Summer:
                        Console.WriteLine("Summer: From June to Augest");
                        break;
                    case Seas.Autumn:
                        Console.WriteLine("Autumn: September to November");
                        break;
                    case Seas.Winter:
                        Console.WriteLine("Winter: December to February");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid Season Name!!! Please enter Spring, Summer, Autumn, or Winter.");
            }
            #endregion


        }
    }
}
