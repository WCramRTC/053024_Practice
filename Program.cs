namespace _053024_Practice
{
    internal class Program
    {

        public static Movie[] movies = new Movie[3];

        static void Main(string[] args)
        {
            movies[0] = new Movie("Fun with Dick and Jane", 2005);
            movies[1] = new Movie("Borne Identity", 2002);
            movies[2] = new Movie("Avengers: Endgame", 2019);

            for (int i = 0; i < movies.Length; i++)
            {
                Movie currentMovie = movies[i];

                Console.WriteLine(currentMovie.DisplayInfo());
            }
        }
    }

    public class Movie
    {
        public string Title;
        public int Year;   

        public Movie(string title)
        {
            Title = title;
            Year = 0000;
        }

        public Movie(string title, int year)
        {
            Title = title;
            Year = year;
        }

        public string DisplayInfo()
        {
            return $"{Title} and {Year}";
        }

    }
}


//Practice

//make a class called move
//fields(title, year)
//constuctor to take both title and year
//method to display "Movie name and Year"

//Create an array of 3 movies
//Display the movies

//Fun with Dick and Jane 2005
//Borne Identity 2002
//Avengers: Endgame 2019 