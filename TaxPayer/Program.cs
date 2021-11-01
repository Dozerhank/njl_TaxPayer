using System;

public class TaxPayer
{
    //Attributes
    string ssn;
    double ygn;
    double owe;

    public TaxPayer(string s, double y)
    {
        ssn = s;
        ygn = y;
        if (y < 30000)
        {
            owe = ygn * .15;
        }
        else
        {
            owe = ygn * .28;
        }
    }

    public void Print()
    {
        Console.WriteLine("SSN: {0}\nIncome: {1}\nTax Owed: {2}", ssn, ygn, owe);
    }

}
class Program
{
    public static void Main()
    {
        TaxPayer Smith = new TaxPayer("333333333", 30000.0);
        Smith.Print();
    }
}