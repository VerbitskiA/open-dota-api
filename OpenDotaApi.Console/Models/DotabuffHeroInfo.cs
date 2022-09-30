using OpenDotaApi.Console.Abstractions;

namespace OpenDotaApi.Console.Models
{
    public class DotabuffHeroInfo : IHero
    {
        public int HeroId { get; set; }
        public string RockName { get; set; }
        public string FullName { get; set; }
        public string PrimaryAttribute { get; set; }
        public string DotabuffId { get; set; }

        public override string ToString()
        {
            return String.Format("{0,4} {1, 30}\t{2,12}\t{3,4}\t{4,24}",
                                        HeroId,
                                        RockName,
                                        FullName,
                                        PrimaryAttribute,
                                        DotabuffId);
        }
    }
}
