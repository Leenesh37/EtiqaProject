using System.ComponentModel.DataAnnotations;


namespace FreelancerAPI
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Username { get; set; } = "";

        [StringLength(50)]
        public string Email { get; set; } = "";

        [StringLength(50)]
        public string Phone { get; set; } = "";

        [StringLength(50)]
        public string Skillsets { get; set; } = "";

        [StringLength(50)]
        public string Hobby { get; set; } = "";
    }
}
