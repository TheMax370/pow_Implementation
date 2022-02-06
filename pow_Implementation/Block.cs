using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Threading;

namespace pow_Implementation
{
    public class Block
    {
        public int BlockNumber = 0;
        public int Nonce { get; set; }
        public List<Transaction> Transactions { get; set; }
        public DateTime Date { get; set; }
        public string PrevHash { get; set; }
        public string Hash { get; set; }

        public Block(List<Transaction> transactions, string prevHash) {
            this.BlockNumber++;
            this.Nonce = 0;
            this.Transactions = transactions;
            this.Date = DateTime.Now;
            this.PrevHash = prevHash;
            this.Hash = this.calculateHash();

        }

        public string calculateHash()
        {
            SHA256 sha256 = SHA256.Create();

            byte[] inputBytes = Encoding.ASCII.GetBytes($"{Date}-{PrevHash ?? ""}-{Transactions}-{Nonce}-{BlockNumber}");
            byte[] outputBytes = sha256.ComputeHash(inputBytes);

            return Convert.ToBase64String(outputBytes);
        }

        public void mineBlock(int powDifficulty) {
            string hashValidation = new String('0', powDifficulty);

            while (Hash.Substring(0, powDifficulty) != hashValidation)
            {
                this.Nonce++;
                this.Hash = calculateHash();
            }

            Console.WriteLine($"block HASH={this.Hash} mined");
        }


    }
}
