using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model
{
    public class CompanyDetails
    {
        [Key]
        public int Id { get; set; } // Primary key
        public string CompanyName { get; set; }
        public string DurationWorked { get; set; }
        public string SkillsUtilized { get; set; }

        public string Role { get; set; }

    }

}
