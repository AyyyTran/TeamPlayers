using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamPlayers.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Position { get; set; }
        public string? TeamName { get; set; }
        public double Salary { get; set; }

        [ForeignKey("TeamName")]
        public Team? Team { get; set; }
    }
}