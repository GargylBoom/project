using System;


namespace matches
{
    class Program
    {
        static void Main(string[] args)
        {
            point:
            Console.WriteLine("Число квадратов в цифрах ");
            Console.WriteLine(" __  __\n" +
                "|   |   |\n" +
                " --- ---\n" +           //это 4 квадрата или 12 спичек
                "|   |   |\n" +
                " --- ---\n");

            if (int.TryParse(Console.ReadLine(), out int cube))
            {
                int FullCubes = cube * 4;
                int match;
                int side_1 = (int)(Math.Sqrt(cube)); 
                int side_2 = cube / side_1; 
                int last = cube - side_1 * side_2; 
                match = side_1 * (side_2 + 1) + side_2 * (side_1 + 1);
                if (last != 0)
                {
                    match = match + 2 * last + 1;
                }
                Console.WriteLine($" {match} спичек {cube} квадратов из спичек , хотя могло быть {FullCubes}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Я ведь сказал число ввести");
                goto point;
            }
        }
    }
}