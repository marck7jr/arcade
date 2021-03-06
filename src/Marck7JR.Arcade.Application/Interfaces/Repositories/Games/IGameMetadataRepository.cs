﻿using Marck7JR.Arcade.Domain.Entities.Games;
using System;

namespace Marck7JR.Arcade.Application.Interfaces.Repositories.Games
{
    public interface IGameMetadataRepository : IRepository<Guid, GameMetadata>
    {

    }
}
