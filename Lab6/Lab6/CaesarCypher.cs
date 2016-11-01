using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public delegate void EncryptDecryptDelegate(string s);

    class CaesarCypher
    {
        const int offset = 1;

        public string Encrypt(string s)
        {
            StringBuilder cyphertext = new StringBuilder();
            for (int i = 0; i < s.Length; i++){
                cyphertext.Append((char)((s[i] + offset) % char.MaxValue));
            }
            return cyphertext.ToString();
        }

        public string Decrypt(string s)
        {
            StringBuilder cyphertext = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                cyphertext.Append((char)((s[i] - offset) % char.MaxValue));
            }
            return cyphertext.ToString();
        }
    }

    class TestClass
    {
        static void Main()
        {
            CaesarCypher cs = new CaesarCypher();
            string plaintext = "Linda Malone";
            string cyphertext = cs.Encrypt(plaintext);
            Console.WriteLine(cyphertext);
            string newText = cs.Decrypt(cyphertext);
            Console.WriteLine(newText);
            Console.ReadLine();
        }
    }
}
