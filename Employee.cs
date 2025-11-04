class Employee
{
    public string Name;
    public int TotalSallery;

    public int WorkedHours;

    public int HourlyWage;

    public Employee(string name, int workedHours, int hourlyWage)
    {
        Name = name;
        WorkedHours = workedHours;
        HourlyWage = hourlyWage;
        TotalSallery = workedHours * hourlyWage;
    }
    
    public override string ToString()
    {
        return $"{Name} - {WorkedHours} timmar - {HourlyWage} kr/timme - Total lön: {TotalSallery} kr";
    }

}