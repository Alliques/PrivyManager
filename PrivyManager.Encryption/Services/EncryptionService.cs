using System.Security.Cryptography;

namespace PrivyManager.Encryption.Services
{
    public class EncryptionService : IEncryptionService
    {
        private const int KeySize = 256;
        private const int BlockSize = 128;
        private const int DerivationIterations = 1000;

        public byte[] ComputeHash(byte[] data)
        {
            using (var sha512 = SHA512.Create())
            {
                return sha512.ComputeHash(data);
            }
        }

        public string ComputeHashString(byte[] data)
        {
            byte[] hashBytes = ComputeHash(data);
            return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
        }

        public byte[] Decrypt(byte[] encryptedData, byte[] key)
        {
            throw new NotImplementedException();
        }

        public byte[] Encrypt(byte[] data, byte[] key)
        {
            throw new NotImplementedException();
        }
    }
}
