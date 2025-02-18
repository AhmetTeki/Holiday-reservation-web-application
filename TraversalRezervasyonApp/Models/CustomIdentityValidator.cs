using Microsoft.AspNetCore.Identity;

namespace TraversalRezervasyonApp.Models
{
    public class CustomIdentityValidator : IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError
            {
                Code = "PasswordTooShort",
                Description = $"Parola Min {length} karakterinden oluşmalıdır"
            };
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresUpper",
                Description = $"Parolada en az 1 büyük harf olmalıdır"
            };
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresLower",
                Description = $"Parolada en az 1 küçük harf olmalıdır"
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = $"Parolada en az 1 sembol içermektedir"
            };
        }
    }
}
