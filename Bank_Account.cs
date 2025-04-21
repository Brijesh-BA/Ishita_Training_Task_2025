using System;


namespace ConsoleApplication1.task1
{
    class Bank_Account
    {
        int acc_no;
        String email;
        String user_name;
        String acc_type;
        int acc_balance;

        void GetAccountDetails()
        {
            acc_no = 13456654;
            email="john@email.com";
            user_name = "john";
            acc_type = "savings";
            acc_balance = 10000;
        }

        void DisplayAccountDetails()
        {
            Console.WriteLine("Account number:" + acc_no);
            Console.WriteLine("Account email:" + email);
            Console.WriteLine("Account user_name:" + user_name);
            Console.WriteLine("Account acc_type:" + acc_type);
            Console.WriteLine("Account acc_balance:" + acc_balance);
        }

        public static void Main(string[] args)
        {
            Bank_Account b1 = new Bank_Account();
            b1.GetAccountDetails();
            b1.DisplayAccountDetails();

        }

    }  
}
