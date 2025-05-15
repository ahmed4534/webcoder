using System.ComponentModel.DataAnnotations;

namespace CodersCollab.Models
{
    public class Team
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
        public string Technology { get; set; }
        public int RequiredMembers { get; set; }
    }
}