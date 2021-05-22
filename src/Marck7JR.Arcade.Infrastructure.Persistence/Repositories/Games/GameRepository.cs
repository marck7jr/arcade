using Marck7JR.Arcade.Application.Interfaces.Repositories.Games;
using Marck7JR.Arcade.Domain.Entities.Games;
using Marck7JR.Arcade.Infrastructure.Persistence.Data;
using System;

namespace Marck7JR.Arcade.Infrastructure.Persistence.Repositories.Games
{
    public class GameRepository : Repository<Guid, Game>, IGameRepository
    {
        public GameRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }
    }
}
