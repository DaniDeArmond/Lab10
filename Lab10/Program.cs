using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Repeat = true;
            string DoAgain = "N";
            string UserChoice;
            List<string> MyList, MyList1;
            Movie[] MyMovieList = new Movie[10];

            MyMovieList[0] = new Movie("Pulp Fiction", "Cult Classic");
            MyMovieList[1] = new Movie("Cecil B. Demented", "Cult Classic");
            MyMovieList[2] = new Movie("Fight Club", "Cult Classic");
            MyMovieList[3] = new Movie("The Rocky Horror Picture Show", "Cult Classic");
            MyMovieList[4] = new Movie("Lady and the Tramp", "Animation");
            MyMovieList[5] = new Movie("The Brave Little Toaster", "Animation");
            MyMovieList[6] = new Movie("The Labyrinth", "Fantasy");
            MyMovieList[7] = new Movie("The NeverEnding Story", "Fantasy");
            MyMovieList[8] = new Movie("The Dark Crystal", "Fantasy");
            MyMovieList[9] = new Movie("The Fox and the Hound", "Animation");

            Console.WriteLine("Welcome to the Dark Side. We have movies.");

            while (Repeat)
            {
                Console.WriteLine("Please choose a category from below to see a list of movies from that category.\n");

                MyList = new List<string>();

                foreach (Movie s in MyMovieList)
                {
                    MyList.Add(s.Category);
                }
                MyList = MyList.Distinct().ToList();

                foreach (string s in MyList)
                {
                    Console.WriteLine(s);
                }

                Console.WriteLine();
                UserChoice = Validation.ValidateInput(Console.ReadLine());
                Console.WriteLine();

                MyList1 = new List<string>();
                foreach (Movie s in MyMovieList)
                {
                    if (string.Compare(s.Category, UserChoice) == 0)
                    {
                        MyList1.Add(s.Title);
                    }
                }
                MyList1 = MyList1.OrderBy(x => x).ToList();
                foreach (string s in MyList1)
                {
                    Console.WriteLine(s);
                }

                Console.WriteLine("\nWould you like to see another category? (Y or N)");
                DoAgain = Validation.ValidateYesNo(Console.ReadLine());
                
                if (string.Compare(DoAgain, "N", true)==0)
                {
                    Console.WriteLine("Goodbye!");
                    Repeat = false;
                }
            }   
        }
    }
}
