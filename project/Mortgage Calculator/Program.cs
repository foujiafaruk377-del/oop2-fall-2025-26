// See https://aka.ms/new-console-template for more information

using System.Globalization;


double salary = 0f;
double creditscore = 0f;
Boolean criminalrecord = false;

while (true)
{
    Console.Write("Enter your salary: ");
    string salaryinput = (Console.ReadLine() ?? string.Empty).Trim();
    if (double.TryParse(salaryinput, out salary))
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter numerical values.");
    }
}

while (true)
{
    Console.Write("Enter your credit score: ");
    string creditscoreinput = (Console.ReadLine() ?? string.Empty).Trim();
    if (double.TryParse(creditscoreinput, out creditscore))
    {
        if (creditscore >= 0 && creditscore <= 500)
        {
            if (creditscore >= 300 && creditscore <= 500)
            {
                break;
            }
            else
            {
                Console.WriteLine("Sorry! you are not eligible for loan..");
            }

        }
    }
    //else
    //{
    // Console.WriteLine("Credit score must be between 0 and 500.");
    //}
    else
    {
        Console.WriteLine("Invalid input. Please enter a numericlal values.");
    }

}

while (true)
{
    Console.Write("Do you have a criminal record? (true/false): ");
    string criminlrecords = (Console.ReadLine() ?? string.Empty).Trim().ToLower();

    if (criminlrecords == "false")
    {
        Console.WriteLine("You are eligible for loan!");
        break;
    }
    else
    {
        Console.WriteLine("Please write true/false");
    }
}

Console.Write("Enter loal ammount: ");
string loanammounts = (Console.ReadLine()).Trim();
double loanammount = double.Parse(loanammounts);


if (loanammount <= (2 * salary))
{

    Console.Write("Enter annual interenst rate (in %): ");
    string interenstrates = (Console.ReadLine()).Trim();

    //double loanammount = double.Parse(loanammounts);
    double interestrate = double.Parse(interenstrates);

    interestrate = interestrate / 100;

    Console.Write("Enter loan in years: ");
    string loanterms = Console.ReadLine();

    int loanterm = int.Parse(loanterms);
    loanterm = loanterm * 12;

    double monthlypayment = (loanammount * (interestrate / 12) * Math.Pow(1 + (interestrate / 12), loanterm)) / (Math.Pow(1 + (interestrate / 12), loanterm) - 1);

    Console.WriteLine("Your monthly payment is: " + monthlypayment);

    double totalpaid = monthlypayment * loanterm;
    double totalinterest = totalpaid - loanammount;

    CultureInfo bdCulture = new CultureInfo("bn-BD");

    Console.WriteLine("Mothly Payment: " + monthlypayment.ToString("C", bdCulture));
    Console.WriteLine("Total paid: " + totalpaid.ToString("C", bdCulture));
    Console.WriteLine("Total interest: " + totalinterest.ToString("C", bdCulture));
}
else
{
    Console.WriteLine("Your loan must be in between twice of your salary.");
    Console.WriteLine("Sorry! You are not eligible for this ammount.");
}

