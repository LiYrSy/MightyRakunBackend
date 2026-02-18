using Microsoft.AspNetCore.Identity;

namespace MightyRakunWebApp.Services;

public class PasswordHasher : IPasswordHasher
{
    private static readonly PasswordHasher<object> _hasher = new();
    private static readonly object _fakeUser = new();
    public string Hash(string password) => _hasher.HashPassword(_fakeUser, password);
    public bool Verify(string password, string hash)
    {
        var result = _hasher.VerifyHashedPassword(_fakeUser, hash, password);
        return result is PasswordVerificationResult.Success or PasswordVerificationResult.SuccessRehashNeeded;
    }

}