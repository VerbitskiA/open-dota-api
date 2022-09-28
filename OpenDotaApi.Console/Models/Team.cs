namespace OpenDotaApi.Console.Models
{
    public class Team
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Tag { get; set; }

        public int Wins { get; set; }

        public int Losses { get; set; }

        public int Last_Match_Time { get; set; }
        
        public double Rating { get; set; }

        public string LogoUrl { get; set; }
        
    }
}
