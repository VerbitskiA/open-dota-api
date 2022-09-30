namespace OpenDotaApi.Console.Abstractions
{
    public interface IHero
    {
        public int HeroId { get; set; }
        
        public string RockName { get; set; }
        
        public string FullName { get; set; }
        
        public string PrimaryAttribute { get; set; }        
    }
}
