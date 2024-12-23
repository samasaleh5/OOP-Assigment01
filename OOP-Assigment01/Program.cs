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
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
            #endregion


        }
    }
}
