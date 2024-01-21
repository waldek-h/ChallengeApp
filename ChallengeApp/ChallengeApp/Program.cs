//2. Stwórz 3 pracowników i każdemu przydziel po 5 ocen z zakresu od 1 do 10.
//3. Napisz program, który wyszuka pracownka z najwyższą liczbą ocen a nastpnie wyświetli jego dane oraz wyniki.

using ChallengeApp;
Employee employee1 = new Employee("Kamil", "Nowak", 28);
Employee employee2 = new Employee("Michał", "Kowalski", 35);
Employee employee3 = new Employee("Bartek", "Rozwadowski", 31);

employee1.AddScore(5);
employee2.AddScore(4);
employee3.AddScore(5);
employee1.AddScore(6);
employee2.AddScore(8);
employee3.AddScore(9);
employee1.AddScore(2);
employee2.AddScore(3);
employee3.AddScore(7);
employee1.AddScore(5);
employee2.AddScore(1);
employee3.AddScore(2);
employee1.AddScore(8);
employee2.AddScore(1);
employee3.AddScore(6);

List<Employee> employeeList = new List<Employee>() { employee1, employee2, employee3 };

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var empleyee in employeeList)
{
    if (empleyee.Result > maxResult)
    {
        employeeWithMaxResult = empleyee;
    }
}

Console.WriteLine($"Najwyższą liczbę ocen w wysokości {employeeWithMaxResult.Result} osiągnął pracownik {employeeWithMaxResult.FirstName} {employeeWithMaxResult.LastName}.\n");

Console.WriteLine($"Oceny poszczeólnych pracowników:\n");

foreach (var empleyee in employeeList)
{
    Console.WriteLine($"{empleyee.FirstName} {empleyee.LastName} - {empleyee.Result}");

}

