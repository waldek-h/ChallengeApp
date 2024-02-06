using ChallengeApp;

var employee = new Employee("Waldemar", "Habiński", 42);
employee.AddGrade(9);
employee.AddGrade(30.669999999999999);
employee.AddGrade(99);
employee.AddGrade(1);
employee.AddGrade(14585445.6451245);
employee.AddGrade(11.61546516);
var statistics = employee.GetStatistics();
Console.WriteLine($"Statistics for employee: {employee.FirstName} {employee.LastName}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");