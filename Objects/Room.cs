namespace hackathon.Objects
{
    public class Room
    {
        public int Id { get; set; }
        public double Area { get; set; }
        public double MonthlyRent { get; set; } = 0;
        public bool HasExpiredPayments { get; set; }
        public string Type { get; set; } = "";
        public string? Tenant { get; set; }
        public List<string>? Equipment { get; set; }
        public double MonthlyIncome { get; set; }
        public double TotalIncome { get; set; }
        public DateTime LatestInspection { get; set; }
        public DateTime StartContract { get; set; }
        public DateTime EndContract { get; set; }
        public string ImgSrc { get; set; } = "";
        public string Link { get; set; } = "";

        public Room()
        {

        }
    }
}
