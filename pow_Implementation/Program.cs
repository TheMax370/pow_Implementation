using System;
using System.Collections.Generic;


namespace pow_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            //We are going to create 2 blocks so Im going to create 9 transactions to add to each block (obviusly we are not counting the genesis block)
            Transaction Block1trans1 = new Transaction("bfuyd8920", "289304hfd", 123.4);
            Transaction Block1trans2 = new Transaction("bzs7920", "24565hfd", 14.4);
            Transaction Block1trans3 = new Transaction("basfdh7", "2lpo9304hfd", 13.4);

            Transaction Block2trans1 = new Transaction("asdf478", "22s83jld", 25.4);
            Transaction Block2trans2 = new Transaction("bmnv83d", "047nf874", 1480.4);
            Transaction Block2trans3 = new Transaction("mlogirk35", "1594fd8932", 153.4);

            //Now we create the list of trans for each block
            List<Transaction> TransList1 = new List<Transaction>();
            TransList1.Add(Block1trans1);
            TransList1.Add(Block1trans2);
            TransList1.Add(Block1trans3);

            List<Transaction> TransList2 = new List<Transaction>();
            TransList1.Add(Block2trans1);
            TransList1.Add(Block2trans2);
            TransList1.Add(Block2trans3);

            //So now we can proceed to create the blocks
            Block Block1 = new Block(TransList1, "");
            Block1.mineBlock(4);// remember to mine the blocks
            Block Block2 = new Block(TransList2, "");
            Block2.mineBlock(3);

            //These block must be appended to the block chain
            Blockchain blockchain = new Blockchain();
            blockchain.AddBlock(Block1);
            blockchain.AddBlock(Block2);

            blockchain.ShowBlocks();
        }
    }
}
