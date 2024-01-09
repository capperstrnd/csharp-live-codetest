public class Program
{
    static string startingLetter = "J";
    public static IEnumerable<Employee> Employees = new Employee[]
        {
            new Employee
            {
                Name = "John Doe",

                Age = 25,

                Skills = { "C#", "Javascript", "React", "HTML", "Css" }

            },

            new Employee

            {

                Name = "Jane Doe",

                Age = 21,

                Skills = { "Rust", "Ruby", "Python", "MongoDb" }

            },

            new Employee

            {

                Name = "Jane Doe",

                Age = 41,

                Skills = { "Python", "MongoDb" }

            },

            new Employee

            {

                Name = "Frank Dandy",

                Age = 35,

                Skills = { "HTML", "Javascript", "Css", "SQL" }

            },

            new Employee

            {

                Name = "Luke Skywalker",

                Age = 37,

                Skills = { "MongoDb", "Vue", "Azure" }

            }
       };

    static async Task Main()
    {
        Console.WriteLine("Hello");

#region previous

        // var filtered = GetEmployeesBasedOnAge(25);

        // foreach (var employee in filtered)
        // {
        //     Console.WriteLine(employee.Name);
        // }

        // var namesAndSkills = GetEmployeeAndSkills();

        // foreach (var employee in namesAndSkills)
        // {
        //     Console.WriteLine(employee.Key);
        //     Console.WriteLine("Skills: ");
        //     foreach (var skill in employee.Value)
        //     {
        //         Console.Write(skill + ", ");
        //     }
        // }

#endregion

        var weekday = Weekday.Monday;

        string greeting = await GetDailyGreeting(weekday);

        Console.WriteLine(greeting);
    }
    public static List<Employee> GetEmployeesBasedOnAge(int ageLimit)
    {
        var filteredList = new List<Employee>();

        filteredList = Employees.Where(x => x.Age > ageLimit).ToList();

        return filteredList;
    }

    public static Dictionary<string, string[]> GetEmployeeAndSkills()
    {

        var employees = new Dictionary<string, string[]>();

        var filteredList = Employees.Where(x => x.Name.StartsWith(startingLetter)).ToList();

        foreach (var employee in filteredList)
        {

            var name = employee.Name;

            if (employees.ContainsKey(name))
                name += " (2)";

            employees.Add(
                name,
                employee.Skills.ToArray()
            );

        }

        return employees;
    }

    public static async Task<string> GetDailyGreeting(Weekday day)
    {
        switch (day)
        {
            case Weekday.Monday:
                return "Happy monday!";
            case Weekday.Tuesday:
                return string.Empty;
            case Weekday.Wednesday:
                return string.Empty;
            case Weekday.Thursday:
                return string.Empty;
            case Weekday.Friday:
                return "Relax";
            case Weekday.Saturday:
                return "Relax";
            case Weekday.Sunday:
                return "Relax";
        }

        return "";
    }
}

public class Employee
{
    public string Name { get; set; } = string.Empty;

    public int Age { get; set; }

    public List<string> Skills { get; set; } = new();

}

public enum Weekday
{
    Monday,

    Tuesday,

    Wednesday,

    Thursday,

    Friday,

    Saturday,

    Sunday

}
