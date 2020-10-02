using System;

namespace Studio2_Counting_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string someString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            Console.WriteLine("Enter a string to count characters for: ");
            string input = Console.ReadLine();
            CountCharacters.countCharacters(input);
        }
    }
}
