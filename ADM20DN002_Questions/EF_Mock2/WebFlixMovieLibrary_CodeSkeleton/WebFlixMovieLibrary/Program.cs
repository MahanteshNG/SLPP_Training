using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFlixMovieLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieGenere movieGenere;
            MovieInformation movieInformation;
            MovieRepository movieRepository;
            string loopInput = string.Empty;
            int menuChoice = 0;
            do
            {
                Console.WriteLine("Welcome Admin to WebFlix Movie Library");
                Console.WriteLine("Menu:\n1. Add New Movie Genere\n2. Display All Movie Genere\n" +
                    "3. Add New Movie to library\n4. Display Movie Library");
                menuChoice = Convert.ToInt32(Console.ReadLine());
                
                switch(menuChoice)
                {
                    case 1:
                        try
                        {
                            movieGenere = new MovieGenere();
                            Console.WriteLine("Enter Genere Id:");
                            movieGenere.MovieGenereId = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter movie category:");
                            movieGenere.MovieCategory = Console.ReadLine();
                            movieRepository = new MovieRepository();
                            MovieGenere newGenere = movieRepository.AddNewGenere(movieGenere);
                            Console.WriteLine("New movie genere added successfully");
                        }
                        catch
                        {
                            Console.WriteLine("New movie genere addition failed. Check your entry or application logic.");
                        }
                        break;

                    case 2:
                        movieRepository = new MovieRepository();
                        Console.WriteLine("List of movie categories:");
                        Console.WriteLine("{0,-20}{1}", "Genere Id", "Genere Type");
                        IList<MovieGenere> genereList = movieRepository.DisplayMovieGeneres();
                        foreach (var genere in genereList)
                        {
                            Console.WriteLine("{0,-20}{1}", genere.MovieGenereId, genere.MovieCategory);
                        }
                        break;

                    case 3:
                        try
                        {
                            movieInformation = new MovieInformation();
                            movieRepository = new MovieRepository();
                            Console.WriteLine("Enter movie id:");
                            movieInformation.MovieId = Convert.ToInt32(Console.ReadLine());                            
                            Console.WriteLine("Choose the movie genere id:");
                            movieInformation.MovieCategoryId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the movie name:");
                            movieInformation.MovieName = Console.ReadLine();
                            Console.WriteLine("Enter movie release year:");
                            movieInformation.ReleaseYear = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Viewer Rating(between 1 to 5):");
                            int rating = Convert.ToInt32(Console.ReadLine());
                            RatingFeedback feedback = new RatingFeedback();
                            movieInformation.AudienceFeedback = feedback.FeedbackInfo(rating);
                            MovieInformation newMovie = movieRepository.AddNewMovie(movieInformation);
                            Console.WriteLine("New movie added to database");
                        }
                        catch
                        {
                            Console.WriteLine("New movie addition failed.");
                            Console.WriteLine("Either same movie id already exists in database or wrong data input.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Display Movie Library:");
                        Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}{4}",
                            "Movie Id", "Movie Name", "Category", "Release Year", "Audiance Feedback");
                        movieRepository = new MovieRepository();
                        IList<MovieInformation> movieList = movieRepository.DisplayMovieLibrary();
                        if (movieList.Count > 0)
                        {
                            foreach (var movie in movieList)
                            {
                                Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}{4}",
                                    movie.MovieId, movie.MovieName, movie.Genere.MovieCategory,
                                    movie.ReleaseYear, movie.AudienceFeedback);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No movie is present in library");
                        }

                        break;

                    

                    default:
                        Console.WriteLine("Invalid menu entry. Enter 1 or 2 or 3");
                        break;

                }
                Console.WriteLine("Enter yes to continue..Any other key to terminate:");
                loopInput = Console.ReadLine();
            }
            while (loopInput.Equals("yes", StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine("Thank you for using the movie application. Have a nice day");
        }
    }
}
