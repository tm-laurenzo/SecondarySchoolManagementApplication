using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SSMA.Models.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        public string Discriminator { get; set; } = "AppUser";
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        /// <summary>
        /// User can set account to be inactive
        /// or the account can be inactive due to non-usage
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// The user has deleted one's data
        /// but we still want to keep the 
        /// data for analysis etc.
        /// </summary>
        public bool IsSoftDeleted { get; set; }
        public string? PublicId { get; set; }
        public string? Avatar { get; set; }
        public Staff Staff { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime PostionStartDate { get; set; }
        public DateTime PostionEndtDate { get; set; }
        public Guid RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}
