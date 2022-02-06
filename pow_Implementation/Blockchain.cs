using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace pow_Implementation
{
    public class Blockchain
    {
        public IList<Block> Chain { set; get; }

        public Blockchain() {
            InitializeChain();
            GenesisBlock();
        }

        public void InitializeChain()
        {
            Chain = new List<Block>();
        }

        public void GenesisBlock() {
            Chain.Add(CreateGenesisBlock());
        }
        public Block CreateGenesisBlock()
        {
            Transaction trans = new Transaction("0", "0", 0);
            List<Transaction> genesisTransaction = new List<Transaction>();
            genesisTransaction.Add(trans);
            return new Block(genesisTransaction, "0000000000000000000000000000000000000000000000000000000000000000");
        }

        public Block GetLatestBlock()
        {
            return Chain[Chain.Count - 1];
        }

        public void AddBlock(Block block)
        {
            block.BlockNumber = Chain.Count;
            block.PrevHash = GetLatestBlock().Hash;
            Chain.Add(block);
        }

        public void ShowBlocks() {
            foreach (var block in Chain)
            {
                Console.WriteLine($"Block Number: {block.BlockNumber} | Hash: {block.Hash} | Previous Hash: {block.PrevHash} | Nonce: {block.Nonce} | Date: {block.Date}");
            }
        }
    }
}
