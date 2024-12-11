using MovieSStore.Models.DTO;

namespace MovieSStore.DataLayer.Interfaces
{
    public interface IActorRepository
    {
        Actor? GetById(int id);
    }
}