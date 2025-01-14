using System.Text;

namespace HurrayForArrays9B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] tvProgs = new string[5];
            //// ask the user to enter their top 5 tv programs
            //// starting with number 5
            //// output the list from 1 to 5
            //// in the form
            //// 1: Fav Prog
            //// 2: 2nd Fav Prog
            ////...
            //for (int i = tvProgs.Length - 1; i >= 0; i--)
            //{
            //    Console.Write($"What is you TV Prog in position {i + 1}: ");
            //    tvProgs[i] = Console.ReadLine();
            //}
            //for (int i = 0; i < tvProgs.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}: {tvProgs[i]}");
            //}
            ////
            
            string[] months = new string[] { "January", "February", "March","April","May","June","July","August","September","October","November","December" };
            int[] rain = new int[12]; //index go from 0 to 11
                        // for each month ask the user how much rainfall was there in that month
            for(int i = 0;i<months.Length;i++)
            {
                // it should be output in the form: 
                //"How much rain was their in January?: "
                //Console.Write($"How much rain was there in {months[i]}?: ");
                //rain[i] = Convert.ToInt32(Console.ReadLine());
                //while (rain[i] < 0)
                //{
                //    Console.Write($"How much rain was there in {months[i]}?: ");
                //    rain[i] = Convert.ToInt32(Console.ReadLine());

                //}

                // check the user enters a valid number
                // if it isn't ask again for the same month
                // keep asking until a valid number is entered
                // store the answer in an array
                int rainfall = -1;
                while (rainfall < 0)
                {
                    Console.Write($"How much rain was there in {months[i]}?: ");
                    rainfall = Convert.ToInt32(Console.ReadLine());
                }
                rain[i] = rainfall;
             
            }

            // after all months have been entered

            // find:
            // Average rain for the year
            Console.WriteLine(rain.Average());
            // the month with the lowest rain - Output name and rainfall has the lowest rainfall
            int index = 0;
            while (rain[index] != rain.Min())
            {
                index++;
            }
            Console.WriteLine($"{months[index]} has the lowest rainfall of {rain.Min()}");
            // the month with the highest rain - Output name and rainfall has the highest rainfall
           index = 0;
            while (rain[index] != rain.Max())
            {
                index++;
            }
            Console.WriteLine($"{months[index]} has the highest rainfall of {rain.Max()}");
                        
            // the difference between the lowest and highest - output value with description
            Console.WriteLine(rain.Max()-rain.Min()+ " is the difference between min and max");
            // the month that has the closest rain to the average - output in a descriptive way
            double lowdif = Math.Abs(rain[0]-rain.Average());
            int avgMonth = 0;
            for(int i = 1; i < months.Length; i++)
            {
                double dif = Math.Abs(rain[i] - rain.Average());
                if (dif < lowdif)
                {
                    lowdif = dif;
                    avgMonth = i;
                }
            }
            Console.WriteLine($"The month closest to the average rainfall is {months[avgMonth]} with a rainfall of {rain[avgMonth]}");

        }
    }
}
