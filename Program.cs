// See void methods -- complete a task without returning a value
void PrintName()
{
    // Method Code
    Console.WriteLine("Trevoir");
}

// value returning methods -  returns a value after an operation
int GetFiveYearsAgo()
{
    int year = DateTime.Now.AddYears(-5).Year;
    return year;
}


// methods parameters

// methods with optional parameters

// methods with nullable parameters

/* Function Calls */
PrintName();
Console.WriteLine("Five Years Ago: " + GetFiveYearsAgo());