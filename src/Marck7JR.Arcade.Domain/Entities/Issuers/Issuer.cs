using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marck7JR.Arcade.Domain.Entities.Issuers
{
    public class Issuer : Entity<Guid>
    {
        public string? Name { get; set; }
    }
}
