using Konoz.Data.Base;
using Konoz.Models;
using Microsoft.EntityFrameworkCore;

namespace Konoz.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {

        public ActorsService(AppDbContext context) : base (context) { }
       
    }
}
