using System;
using BankTransferConfig;

class Program {
    static void Main(string[] args)
    {
        BankTransferConfig bank = new BankTransferConfig();
        int tf = 0, fee = 0;

        if (bank.lang == "en") {
            Console.WriteLine("please insert the amount of money to transfer: ");
            tf = int.Parse(Console.ReadLine());
            if (tf < bank.Transfer.threshold)
            {
                fee = bank.Transfer.low_fee;
                Console.WriteLine("transfer fee = " + fee);
                Console.WriteLine("total amount = " + (tf + fee));
            }else { 
                fee = bank.Transfer.high_fee;
                Console.WriteLine("transfer fee = " + fee);
                Console.WriteLine("total amount = " + (tf + fee));
            }

            Console.WriteLine("please select transfer method: ");
            string sel = Console.ReadLine();
            if (sel == "RTO") {
                bank.methods = "RTO";
            } else if (sel == "SKN") {
                bank.methods = "SKN";
            }

            Console.WriteLine("Please type yes to confirm the transcation "
            string conf = Console.ReadLine());

            if (conf == "yes") {
                Console.WriteLine("The transfer is completed");
            } else {
                Console.WriteLine("Transfer is cancelled");
            }
        }

        if (bank.lang == "id") {
            Console.WriteLine("Masukkan jumlah uang yang akan di-transfer: ");
            tf = int.Parse(Console.ReadLine());
            if (tf < bank.Transfer.threshold)
            {
                fee = bank.Transfer.low_fee;
                Console.WriteLine("transfer fee = " + fee);
                Console.WriteLine("total amount = " + (tf + fee));
            }
            else
            {
                fee = bank.Transfer.high_fee;
                Console.WriteLine("transfer fee = " + fee);
                Console.WriteLine("total amount = " + (tf + fee));
            }

            Console.WriteLine("Please type yes to confirm the transcation "
            string conf = Console.ReadLine());

            if (conf == "yes")
            {
                Console.WriteLine("The transfer is completed");
            }
            else
            {
                Console.WriteLine("Transfer is cancelled");
            }
        }
    }
}
