using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace pow_Implementation
{
    public class Transaction
    {
        public string fromAddress { get; set; }
        public string toAddress { get; set; }
        public double Amount { get; set; }

        public Transaction(string address, string toaddress, double amount) {
            this.fromAddress = address;
            this.toAddress = toaddress;
            this.Amount = amount;

        }
    }
}
