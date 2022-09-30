namespace OpenDotaApi.Console.Abstractions
{
    public interface IDotaService
    {
        ITeam[] GetTopNTeams(int N);

        IHero[] GetTop10HeroesByAttribute(string attribute);

        IHero[] FindHeroesByName(string name);
    }
}
