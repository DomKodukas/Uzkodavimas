using System;

namespace EncryptionDecryptionUsingSymmetricKey
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = "sdsasdawefasdfg90809as8df90a8sdf";

            Console.WriteLine("Įveskite šifravimo eilutę:");
            var str = Console.ReadLine();
            var encryptedString = AesOperation.EncryptString(key, str);
            Console.WriteLine($"Užšifruota eilutė = {encryptedString}");

            Console.ReadKey();
        }
    }
}