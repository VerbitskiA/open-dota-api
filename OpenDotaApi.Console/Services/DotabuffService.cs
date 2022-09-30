using OpenDotaApi.Console.Abstractions;
using OpenDotaApi.Console.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDotaApi.Console.Services
{
    public class DotabuffService : IDotaService
    {
        public IHero[] FindHeroesByName(string name)
        {
            throw new NotImplementedException();
        }

        public IHero[] GetTop10HeroesByAttribute(string attribute)
        {
            DotabuffHeroInfo[] result = 
            { 
                new DotabuffHeroInfo()
                {
                    HeroId = 1,
                    FullName = "antimage",
                    RockName = "AM",
                    DotabuffId = "444rrr",
                    PrimaryAttribute = "agi"
                },
                new DotabuffHeroInfo()
                {
                    HeroId = 2,
                    FullName = "axe",
                    RockName = "AXE",
                    DotabuffId = "555rrr",
                    PrimaryAttribute = "str"
                }
            };

            return result;
        }

        public ITeam[] GetTopNTeams(int N)
        {
            throw new NotImplementedException();
        }
    }
}
