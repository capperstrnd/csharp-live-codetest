public class Program
{
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

        var filtered = GetEmployeesBasedOnAge(25);

        foreach(var employee in filtered) {
            Console.WriteLine(employee.Name);
        }
    }
    public static List<Employee> GetEmployeesBasedOnAge(int ageLimit) {
        var filteredList = new List<Employee>();

        filteredList = Employees.Where(x => x.Age > ageLimit).ToList();

        return filteredList;
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
