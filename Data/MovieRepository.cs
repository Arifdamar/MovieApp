using System.Collections.Generic;
using System.Linq;
using MovieApp.Models;

namespace MovieApp.Data
{
    public static class MovieRepository
    {
        private static List<Movie> _movies = null;

        static MovieRepository()
        {
            _movies = new List<Movie>()
            {
                new Movie(){ Id=1, Name = "The Lighthouse", Description="Two lighthouse keepers try to maintain their sanity whilst living on a remote and mysterious New England island in the 1890s.", ImageUrl="lighthouse.jpg"},
                new Movie(){ Id=2, Name = "Parasite", Description="A poor family, the Kims, con their way into becoming the servants of a rich family, the Parks. But their easy life gets complicated when their deception is threatened with exposure.", ImageUrl="parasite.jpg"},
                new Movie(){ Id=3, Name = "Suspiria", Description="A darkness swirls at the center of a world-renowned dance company, one that will engulf the artistic director, an ambitious young dancer, and a grieving psychotherapist. Some will succumb to the nightmare. Others will finally wake up.", ImageUrl="Suspiria.jpg"},
                new Movie(){ Id=4, Name = "2001: A Space Odyssey", Description="After discovering a mysterious artifact buried beneath the Lunar surface, mankind sets off on a quest to find its origins with help from intelligent supercomputer H.A.L. 9000.", ImageUrl="a_space_odyssey.jpg"},
                new Movie(){ Id=5, Name = "Spider-Man: Far from Home", Description="Following the events of Avengers: Endgame (2019), Spider-Man must step up to take on new threats in a world that has changed forever.", ImageUrl="Spider-Man_Far_from_Home.jpg"}
            };
        }

        public static List<Movie> Movies{ get { return _movies; } }

        public static void AddMovie(Movie entity){
            _movies.Add(entity);
        }

        public static Movie GetById(int id){
            return _movies.FirstOrDefault(i => i.Id == id);
        }
    }
}