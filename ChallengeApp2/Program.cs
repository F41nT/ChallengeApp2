using System;

List<string> daysOfWeek = new List<string>();

daysOfWeek.Add("poniedziałek");
daysOfWeek.Add("wtorek");
daysOfWeek.Add("środa");
daysOfWeek.Add("czwartek");
daysOfWeek.Add("piątek");
daysOfWeek.Add("sobota");
daysOfWeek.Add("niedziela");

foreach (var day in daysOfWeek) 
Console.WriteLine(day);

for (int a = 0; a < daysOfWeek.Count; a++) 
{
    Console.WriteLine(daysOfWeek[a]);
}