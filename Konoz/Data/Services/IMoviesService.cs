using Konoz.Data.Base;
using Konoz.Data.ViewModels;
using Konoz.Models;

namespace Konoz.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);

        Task UpdateMovieAsync(NewMovieVM data);

    }
}
