using OpenClose;

ShowSalaryMonthly(new List<IEmployee>() {
            new EmployeeFullTime("Pepito Pérez", 160),
            new EmployeePartTime("Manuel Lopera", 180),
            new EmployeeFullTime("Raul Yllescas", 160),
            new EmployeeContractor("Kenvin Yllescas", 120)
        });


static void ShowSalaryMonthly(List<IEmployee> employees)
{
    foreach (var employee in employees)
    {
        Console.WriteLine($"Empleado: {employee.Fullname}, Pago: {employee.CalculateSalaryMonthly():C1} ");
    }
}
