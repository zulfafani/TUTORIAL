using System;

class Program
{
    static void Main()
    {
        // DateTime example
        DateTime dt1 = new DateTime(2022, 4, 1, 9, 0, 0);
        DateTime dt2 = new DateTime(2022, 4, 1, 14, 0, 0);

        // Calculate the difference between the two DateTime objects
        TimeSpan ts = dt2 - dt1;

        // Display the total number of minutes in the TimeSpan object
        Console.WriteLine("Total minutes: {0}", ts.TotalMinutes);

        // DateTimeOffset example
        DateTimeOffset dto1 = new DateTimeOffset(2022, 4, 1, 9, 0, 0, new TimeSpan(-5, 0, 0));
        DateTimeOffset dto2 = new DateTimeOffset(2022, 4, 1, 14, 0, 0, new TimeSpan(-4, 0, 0));

        // Calculate the difference between the two DateTimeOffset objects
        TimeSpan ts2 = dto2 - dto1;

        // Display the total number of minutes in the TimeSpan object
        Console.WriteLine("Total minutes: {0}", ts2.TotalMinutes);

        // TimeZoneInfo example
        TimeZoneInfo tz1 = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
        DateTimeOffset dto3 = TimeZoneInfo.ConvertTime(dto1, tz1);

        // Display the converted DateTimeOffset object
        Console.WriteLine("Converted DateTimeOffset object: {0}", dto3);

        // DateOnly example
        DateOnly date1 = new DateOnly(2022, 4, 1);
        DateOnly date2 = date1.AddDays(10);

        // Display the new DateOnly object
        Console.WriteLine("New DateOnly object: {0}", date2);

        // TimeOnly example
        TimeOnly time1 = new TimeOnly(9, 0, 0);
        TimeOnly time2 = time1.AddMinutes(30);

        // Display the new TimeOnly object
        Console.WriteLine("New TimeOnly object: {0}", time2);
    }
}
