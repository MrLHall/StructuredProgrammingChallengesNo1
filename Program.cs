using System.Globalization;

namespace ConsoleApp8
{
    internal class Program
    {
        static void TVprocedure(int hours) // challenge 1 as a procedure
        {
            if (hours < 2)
            {
                Console.WriteLine("That should be ok");
            }
            else if (hours < 4)
            {
                Console.WriteLine("That will rot your brain");
            }
            else
            {
                Console.WriteLine("That's too much TV");
            }
        }
        static string TVfunction(int hours) // challenge 1 as a function
        {
            string responce = "";
            if (hours < 2)
            {
                responce = "That should be ok";
            }
            else if (hours < 4)
            {
                responce = "That will rot your brain";
            }
            else
            {
                responce = "That's too much TV";
            }
            return responce; // returns the responce
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How much TV do you watch?");
            int HoursOfTV = Convert.ToInt32(Console.ReadLine());
            TVprocedure(HoursOfTV); // calls the procedure and then will output the correct responce within the procedure
            string outcome = TVfunction(HoursOfTV); // calls the function and assigns the returned value to coutcome 
            Console.WriteLine(outcome);
        }
    }
}
