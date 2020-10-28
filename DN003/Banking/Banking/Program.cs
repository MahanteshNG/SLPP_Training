using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   public class Program
    {
        public static void Main(string[] args)
        {
        Account Account = new Account(); //This will call default constructor
        Console.WriteLine("Enter account id");
        int custId = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter account type");
        string accType = Console.ReadLine();
        Console.WriteLine("Enter account balance");
        var accBal = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter amount to withdraw");
        double withdrawAmt=double.Parse(Console.ReadLine());
        Account = new Account(custId, accType, accBal); //Here we have called Pamaterized contructor
        bool res = Account.Withdraw(withdrawAmt);
        string storage = string.Empty;
        if(res)
        {
            double newBalance = accBal - withdrawAmt;
            storage = Account.GetDetails() + "\n" + "New Balance : " + newBalance;
            Console.WriteLine(storage);
        }
        else
        {
            Console.WriteLine(Account.GetDetails());
            
        }
    }
    }

public class Account
{ 
    //Class members are always declared with private scope (Data Abstraction)
    private int id;
    private string accountType;
    private double balance;

    //Properties: Properties are public members of class which contains to accessors:
    //get: This will fetch data from private class members for display
    //set: This can be used to pass data to private class members from Main method
    public int Id {
       set { id = value; }
        get { return id; }
    }
    public string AccountType
    {
        set { accountType = value; }
        get { return accountType; }
    }
    public double Balance
    {
        set { balance = value; }
        get { return balance; }
    }

    //Constrctors: Special method of class which takes same name as that of the class
    //Do not use any void or datatype as constructor signature for constructor declaration
    //Automatically called whenever we create class object
    //Empty or default constructor
    public Account()
    {
    }
    //Parameterized Constructor will be used to pass data from Main program to private class members
    public Account(int id, string accountType, double balance)
    {
        this.id = id;
        this.accountType = accountType;
        this.balance = balance;
    }



    public bool Withdraw(double amount)
    {
        if (this.balance > amount)
            return true;
        else
            return false;
    }

    public string GetDetails()
    {
        string record = "Account Id: " + this.Id + "\n" + "Account Type: " + this.AccountType + "\n" +
             "Balance: " + this.Balance;
        return record;
    }

}


