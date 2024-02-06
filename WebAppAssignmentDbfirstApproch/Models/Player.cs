using System;
using System.Collections.Generic;

namespace WebAppAssignmentDbfirstApproch.Models
{
    public partial class Player
    {
        public int PlayerId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int? JerseyNumber { get; set; }
        public int? Position { get; set; }
        public string Team { get; set; } = null!;
    }
}
