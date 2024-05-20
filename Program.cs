// See void methods -- complete a task without returning a value
void PrintName()
{
 
    Console.WriteLine("Trevoir");
}

// value returning methods -  returns a value after an operation
int GetFiveYearsAgo()
{
    int year = DateTime.Now.AddYears(-5).Year;
    return year;
}


// methods with parameters - represent data being passed into a method
void PrintNameWithParams(string name)
{
    Console.WriteLine("Your name is: "+name);
}

// value returning methods -  returns a value after an operation
int GetYearDifferenceWithParams(int year)
{
    int yearDifference = DateTime.Now.Year - year;
    return yearDifference;
}




// methods with optional parameters

// methods with nullable parameters

/* Function Calls */
PrintName();
Console.WriteLine("Five Years Ago: " + GetFiveYearsAgo());
PrintNameWithParams("Dynamic Name");

Console.WriteLine("Enter Your Name: ");
string name1 = Console.ReadLine();
PrintNameWithParams(name1);

Console.WriteLine("Enter A Year: ");
int pastYear = Convert.ToInt32(Console.ReadLine());
int yearsAgo = GetYearDifferenceWithParams(pastYear);
Console.WriteLine("This was " + yearsAgo + "years ago");