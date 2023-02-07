// See https://aka.ms/new-console-template for more information



Clock(GetUserInputHours(), GetUserInputMinutes());

static int Clock(int hours, int minutes)
{
    // Every minute the minute arrow moves 6 degrees
    // Every minute the hour arrow moves 0.5 degrees

    // Every hour the hour arrow moves 30 degrees

    Console.WriteLine($"User input is {hours} hours and {minutes} minutes");

    //CODE for calculating the lesser angle in degrees between hours arrow and minutes arrow:

    //Calculating how much the HOUR arrow moved from 12 o'clock

    int hourDegreeFromTwelve = (hours * 30) + (minutes / 2);

    //Calculating how much the MINUTE arrow moved from 12 o'clock

    int minuteDegreeFromTwelve = (minutes * 6);

    //Calculating the the angle in degrees between hours arrow and minutes arrow:

    int degreesBetweenArrows = Math.Abs(hourDegreeFromTwelve - minuteDegreeFromTwelve);

    degreesBetweenArrows = Math.Min(360 - degreesBetweenArrows, degreesBetweenArrows); // output the lesser angle in degress

    Console.WriteLine($"The angle in degrees between hours arrow and minutes arrow is: {degreesBetweenArrows}");


    return 0;
}

static int GetUserInputHours()
{
    int hours;
    string userInput = "";

    Console.WriteLine("Input hours:");
    userInput = Console.ReadLine();

    try
    {
        hours = Convert.ToInt32(userInput);
        if (hours > 13 || hours < 0)
        {
            Console.WriteLine("Hour must be between 0 and 12");
            return GetUserInputHours();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Invalid hour, try again.");
        return GetUserInputHours();
    }
    hours = Convert.ToInt32(userInput);


    return hours;
}
static int GetUserInputMinutes()
{
    int minutes;
    string userInput = "";

    Console.WriteLine("Input minutes:");
    userInput = Console.ReadLine();

    try
    {
        minutes = Convert.ToInt32(userInput);
        if (minutes > 61 || minutes < 0)
        {
            Console.WriteLine("minutes must be between 0 and 60");
            return GetUserInputMinutes();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Invalid minutes, try again.");
        return GetUserInputMinutes();
    }
    minutes = Convert.ToInt32(userInput);


    return minutes;
}

Console.ReadLine();