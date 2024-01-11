﻿namespace smz3.countdown.api.Models
{
    public class Seed
    {
        public int Id { get; set; }

        public string Hash { get; set; } = string.Empty;
        public string Guid { get; set; } = string.Empty;
        public string Mode { get; set; } = string.Empty;
        public int Players { get; set; }
        public List<World> Worlds { get; set; } = [];
    }
}
