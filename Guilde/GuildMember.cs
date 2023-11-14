using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guilde.Enum;

namespace Guilde
{
    public class GuildMember
    {
        public string Pseudo;

        public EnumRole Role { get; set; }

        public GuildMember(string pseudo, EnumRole role)
        {

            this.Pseudo = pseudo;
            this.Role = role;
        }
    }
}
