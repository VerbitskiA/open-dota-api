namespace OpenDotaApi.Console.Abstractions
{
    public interface ITeam
    {        
        public int TeamId { get; set; }
        
        public string FullName { get; set; }
        
        public string Tag { get; set; }   
    }
}
