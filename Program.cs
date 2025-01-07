namespace HurrayForArrays9B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tvProgs = new string[5];
            // ask the user to enter their top 5 tv programs
            // starting with number 5
            // output the list from 1 to 5
            // in the form
            // 1: Fav Prog
            // 2: 2nd Fav Prog
            //...
            for(int i = tvProgs.Length - 1; i >= 0; i--)
            {
                Console.Write($"What is you TV Prog in position {i + 1}: ");
                tvProgs[i] = Console.ReadLine();
            }
            for(int i = 0;i<tvProgs.Length;i++)
            {
                Console.WriteLine($"{i+1}: {tvProgs[i]}");
            }
        }
    }
}
