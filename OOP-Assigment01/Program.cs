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
        enum Permissions
        {
            read, write, delete, excute
        }
        enum Colors
        {
            red, green, blue
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
            //Console.Write("Enter Name Of The Season (Spring, Summer, Autumn, Winter): ");
            //string input = Console.ReadLine();
            //if (Enum.TryParse(input, true, out Seas selectedSeason))
            //{
            //    switch (selectedSeason)
            //    {
            //        case Seas.Spring:
            //            Console.WriteLine("Spring: From March to May");
            //            break;
            //        case Seas.Summer:
            //            Console.WriteLine("Summer: From June to Augest");
            //            break;
            //        case Seas.Autumn:
            //            Console.WriteLine("Autumn: September to November");
            //            break;
            //        case Seas.Winter:
            //            Console.WriteLine("Winter: December to February");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Season Name!!! Please enter Spring, Summer, Autumn, or Winter.");
            //}
            #endregion

            #region question4
            //dont understand ideaa only made enum 
            #endregion

            #region question5
            //Console.Write("Please Enter Color [Red-Green-Blue]: ");
            //string color = Console.ReadLine();
            //if (Enum.TryParse(color, true, out Colors col))
            //{
            //    Console.WriteLine($"{color} is primary color.");
            //}
            //else
            //{
            //    Console.WriteLine($"{color} is not a primary color.");
            //}
            #endregion

            #region question6
            //Console.WriteLine("Enter The Coordinatesfor point 1 (X Y):");
            //string[] args1 = Console.ReadLine().Split();
            //Point p1 = new Point(double.Parse(args1[0]), double.Parse(args1[1]));

            //Console.WriteLine("Enter The Coordinatesfor point 2 (X Y):");
            //string[] args2 = Console.ReadLine().Split();
            //Point p2 = new Point(double.Parse(args2[0]), double.Parse(args2[1]));

            //double distance=p1.Distance(p2);
            //Console.WriteLine($"The Distance between point1 and point2 is {distance}");

            #endregion

            #region question7
            Person[] persons = new Person[3];
            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine($"Enter Details For Person{i + 1}");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Age: ");
                int age=int.Parse(Console.ReadLine());

                persons[i] = new Person(name, age);
            }
           Person oldest=persons[0];
            for (int i = 1; i < persons.Length; i++)
            {
                if (persons[i].age > oldest.age)
                {
                    oldest = persons[i];
                }
            }
                Console.WriteLine($"The Oldest person is: {oldest.Name}, Age: {oldest.age}");
            #endregion

        }
    }
}
