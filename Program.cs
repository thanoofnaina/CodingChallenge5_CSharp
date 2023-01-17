
Console.Write("Enter the number of fares, in odd, that need to be entered: ");
int oddFares = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of fares, in even, that need to be entered: ");
int evenFares = Convert.ToInt32(Console.ReadLine());
int n = oddFares + evenFares;

double[] fares = new double[n*2];
double singleFare = 0;
int odd = 0;
int even = 1;

for (int i = 0; i < n; i++)
{
    Console.Write("Enter the Fare Charge: ");
    singleFare = Convert.ToDouble(Console.ReadLine());
    if (singleFare % 2 != 0)
    {
        fares[odd] = singleFare;
        odd+=2;
    }
    else
    {
        fares[even] = singleFare;
        even+=2;
    }
}
foreach (double fare in fares)
{
    Console.WriteLine(fare);
}


