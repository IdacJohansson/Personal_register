class Register
{
    private List<Employee> employees = new List<Employee>();

    public void AddNewEmployee(Employee e)
    {
        employees.Add(e);
    }
    
    public void printEmployees()
    {
        Console.WriteLine("Personal register: ");
        foreach (var e in employees)
        {
            Console.WriteLine(e);
        }
    }
}