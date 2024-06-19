using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;

public class HashingService : IHashingService{
    public string HashPassword(string password)
    {
        //Generate 128-bit salt 
        byte[] salt = RandomNumberGenerator.GetBytes(128 / 8);
        //Derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
        string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password:  password,
            salt:      salt,
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: 100000,
            numBytesRequested: 256 / 8));

        return hashed;

    }



}