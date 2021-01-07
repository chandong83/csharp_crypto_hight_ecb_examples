using System;
using CryptoHIGHT;
namespace crypto_hight_ecb_example
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] testUserKey = { 0x88, 0xE3, 0x4F, 0x8F, 0x08, 0x17, 0x79, 0xF1, 0xE9, 0xF3, 0x94, 0x37, 0x0A, 0xD4, 0x05, 0x89 };
            CryptoHIGHT.ecb ecb = new CryptoHIGHT.ecb(testUserKey);
            ecb.test();

            Console.Write("Press any key to close");
            Console.ReadKey();
        }
    }
}
