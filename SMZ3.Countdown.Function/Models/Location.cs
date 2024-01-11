namespace smz3.countdown.api.Models
{
    public class Location
    {
        public string LocationArea { get; set; } = string.Empty;
        public string LocationName { get; set; } = string.Empty;
        public string LocationRegion { get; set; } = string.Empty;
        public int WorldId { get; set; }
        public int ItemWorldId { get; set; }
        public string ItemName { get; set; } = string.Empty;
    }
}
