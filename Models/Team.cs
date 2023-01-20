using System;
using System.ComponentModel.DataAnnotations;

namespace TeamPlayers.Models
{
    public class Team
    {
        [Key]
        public string? TeamName { get; set; }
        public string? City { get; set; }
        public string? Province { get; set; }
        public string? Country { get; set; }

        public List<Player>? Players { get; set; }
    }
}