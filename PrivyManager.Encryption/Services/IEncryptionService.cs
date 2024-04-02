namespace PrivyManager.Encryption.Services
{
    public interface IEncryptionService
    {
        byte[] Encrypt(byte[] data, byte[] key);
        byte[] Decrypt(byte[] encryptedData, byte[] key);
        byte[] ComputeHash(byte[] data);
        string ComputeHashString(byte[] data);
    }
}
