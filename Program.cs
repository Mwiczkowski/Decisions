using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade;

            Console.WriteLine("Type a grade between 1 and 6.");
            grade = int.Parse(Console.ReadLine());

            //You can write the grades this way
            switch (grade)
            {
                case 6:
                    Console.WriteLine("Six is max");
                    break;
                case 5:
                    Console.WriteLine("5 is second best");
                    break;
                case 4:
                    Console.WriteLine("5 is acceptable");
                    break;
                case 3:
                    Console.WriteLine("3 is not enough");
                    break;
                case 2:
                    Console.WriteLine("2 is bad");
                    break;
                case 1:
                    Console.WriteLine("1 is terrible");
                    break;
                default:
                    Console.WriteLine("The grade is out of provided scale.");
                    break;
            }


            //Or you can write them this way
            if (grade == 6)
                Console.WriteLine("Six is max");
            else if (grade == 5)
                Console.WriteLine("5 is second best");
            else if (grade == 4)
                Console.WriteLine("5 is acceptable");
            else if (grade == 3)
                Console.WriteLine("3 is not enough");
            else if (grade == 2)
                Console.WriteLine("2 is bad");
            else if (grade == 1)
                Console.WriteLine("1 is terrible");
            else
                Console.WriteLine("The grade is out of provided scale.");









            //Example 2 made by myself
            //int grade;

            //Console.WriteLine("Type a grade between 1 and 6.");
            //grade = int.Parse(Console.ReadLine());

            //if (grade < 3)
            //{
            //    Console.WriteLine("Oh, this grade is so low. You didn't study enough!");
            //}
            //else if (grade > 6)
            //{
            //    Console.WriteLine("This grade does not exist, don't lie to me!");
            //}
            //else if (grade == 6)
            //{
            //    Console.WriteLine("What a genius!");
            //}
            //else
            //{
            //    Console.WriteLine("Oh, you are so smart!");
            //}









            ////Example 1 of IF and ELSE statements working
            //int age;

            //Console.WriteLine("Introduce your age:");

            //age = int.Parse(Console.ReadLine());

            //char gender;

            //Console.WriteLine("Define your gender (M - Man, W - Woman)");
            //gender = char.Parse(Console.ReadLine());


            //if (age >= 18 && gender == 'M')
            //{
            //    Console.WriteLine("You are an adult man.");
            //}
            //else if (age >= 18 && gender == 'W')
            //{
            //    Console.WriteLine("You are an adult woman.");
            //}
            //else if (age < 18 && gender == 'M')
            //{
            //    Console.WriteLine("You are not 18+, so you can't pass.");
            //}
            //else
            //{
            //    Console.WriteLine("You are not 18+, so you can't pass.");
            //}
        }
    }
}
