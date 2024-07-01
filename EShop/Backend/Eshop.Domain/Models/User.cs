using Eshop.Domain.Enums;

namespace Eshop.Domain.Models
{
    public class User : BaseModel
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Hash { get; set; } = string.Empty;
        public string Salt { get; set; } = string.Empty;
        public Address? ResidenceAddress { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public UserRole Role { get; set; } = UserRole.User;
        public bool EmailConfirmed { get; set; }
        public string? EmailVerificationToken { get; set; }
        public DateTime? EmailVerificationExpiration { get; set; }
        public string? PasswordResetToken { get; set; }
        public DateTime? PasswordResetExpiration { get; set; }
    }
}
