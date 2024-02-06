using ChallengeApp;

var employee = new Employee("Waldemar", "Habiński", 42);
employee.AddGrade(9);
employee.AddGrade(3);
employee.AddGrade(4);
employee.AddGrade(8);
employee.AddGrade(6);
employee.AddGrade(11);
var statistics = employee.GetStatistics();
Console.WriteLine($"Statistics for employee: {employee.FirstName} {employee.LastName}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");