// Get the time zone info for the UK
TimeZoneInfo ukTimeZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");

// Get the current time in UTC
DateTime utcNow = DateTime.UtcNow;

// Convert the current time to UK time
DateTime ukTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, ukTimeZone);

// Check if UK time is in daylight saving time
bool isDaylightSaving = ukTimeZone.IsDaylightSavingTime(ukTime);

// Print the current UK time and timezone information
Console.WriteLine("Current UTC Time: " + utcNow);
Console.WriteLine("Current UK Time: " + ukTime);
Console.WriteLine("Is Daylight Saving Time: " + isDaylightSaving);
Console.WriteLine("UK Time Zone: " + (isDaylightSaving ? ukTimeZone.DaylightName : ukTimeZone.StandardName));

string sz = Console.ReadLine();