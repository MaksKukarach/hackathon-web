namespace hackathon.Objects
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Type { get; set; } = "";
        public string? Title { get; set; }
        public bool IsSOS { get; set; }
        public DateTime Date {get; set; }
        public string? Address { get; set; } 
        public string? Text { get; set; }

        public Ticket(int Id, string Type, string? Title, bool IsSOS, DateTime Date, string? Address)
        {
            this.Id = Id;
            this.Type = Type;
            this.Title = Title; 
            this.IsSOS = IsSOS;
            this.Date = Date;
            this.Address = Address;
            this.Text = Text;
        }
        public Ticket()
        { } 
    }
}