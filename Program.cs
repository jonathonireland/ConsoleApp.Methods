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

// methods with optional parameters - parameter is not required... also has a default value
int GetFutureOrPastYear(int numberOfYears = 0)
{
    int pastYear = DateTime.Now.AddYears(numberOfYears).Year;
    return pastYear;
}


// methods with nullable parameters and optional parameters
void PrintNameNullableParam(string? name, int? count = 0)
{
    // if name is null use default name,
    // if (string.IsNullOrEmpty(name))
    // {
    //    name = "Default Name";
    // }

    name ??= "Default Name";
    
    // if count is null than count is 1
    // if (!count.HasValue)
    // {
    //     count = 1;
    // }
    count ??= 1;


    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(name);
    }
    
}

/* Function Calls */
// PrintName();
// Console.WriteLine("Five Years Ago: " + GetFiveYearsAgo());
// PrintNameWithParams("Dynamic Name");

// Console.WriteLine("Enter Your Name: ");
// string name1 = Console.ReadLine();
// PrintNameWithParams(name1);

// Console.WriteLine("Enter A Year: ");
// int pastYear = Convert.ToInt32(Console.ReadLine());
// int yearsAgo = GetYearDifferenceWithParams(pastYear);
// Console.WriteLine("This was " + yearsAgo + "years ago");

// Console.WriteLine("Enter number of year in the future or past");
// int numberOfYears = Convert.ToInt32(Console.ReadLine());

// var pastYear1 = GetFutureOrPastYear();
// Console.WriteLine("The year is " + pastYear1);

// var pastYear2 = GetFutureOrPastYear(numberOfYears);
// Console.WriteLine("The year is: " + pastYear2);

PrintNameNullableParam(null, null);

PrintNameNullableParam("Chester", 5);

