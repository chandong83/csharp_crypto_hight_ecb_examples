using System;
using CryptoHIGHT;
namespace crypto_hight_ecb_example
{
    class Program
    {
        static void Main(string[] args)
        {
            CryptoHIGHT.ecb ecb = new CryptoHIGHT.ecb();
            ecb.test();

            Console.Write("Press any key to close");
            Console.ReadKey();
        }
    }
}
