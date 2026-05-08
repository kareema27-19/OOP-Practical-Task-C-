
// 1. Create a Base Class


using System;

class Employee
{
    // Private Fields
    private int id;
    private double salary;

    // Public Properties with validation
    public int ID
    {
        get { return id; }
        set
        {
            if (value > 0)
            {
                id = value;
            }
            else
            {
                Console.WriteLine("ID must be greater than 0");
            }
        }
    }

    public double Salary
    {
        get { return salary; }
        set
        {
            if (value >= 0)
            {
                salary = value;
            }
            else
            {
                Console.WriteLine("Salary cannot be negative");
            }
        }
    }

    // Additional Public Members
    public string Name { get; set; }
    public string Department { get; set; }

    // Virtual Method
    public virtual void Work()
    {
        Console.WriteLine("Employee is working");
    }
}

// Test Program
class Program
{
    static void Main()
    {
        Employee emp = new Employee();

        emp.ID = 8582;
        emp.Name = "Kareema";
        emp.Department = "Engg";
        emp.Salary = 1500;

        Console.WriteLine("ID: " + emp.ID);
        Console.WriteLine("Name: " + emp.Name);
        Console.WriteLine("Department: " + emp.Department);
        Console.WriteLine("Salary: " + emp.Salary);

        emp.Work();
    }
}

2.Create Derived Classes

using System;

// Base Class
class Employee
{
    // Private Fields
    private int id;
    private double salary;

    // Properties with validation
    public int ID
    {
        get { return id; }
        set
        {
            if (value > 0)
                id = value;
            else
                Console.WriteLine("ID must be greater than 0");
        }
    }

    public double Salary
    {
        get { return salary; }
        set
        {
            if (value >= 0)
                salary = value;
            else
                Console.WriteLine("Salary cannot be negative");
        }
    }

    // Additional Members
    public string Name { get; set; }
    public string Department { get; set; }

    // Virtual Method
    public virtual void Work()
    {
        Console.WriteLine("Employee is working");
    }
}

// Derived Class: Developer
class Developer : Employee
{
    // Additional Property
    public string ProgrammingLanguage { get; set; }

    // Override Work Method
    public override void Work()
    {
        Console.WriteLine("Developer is writing code");
    }
}

// Derived Class: Designer
class Designer : Employee
{
    // Additional Property
    public string DesignTool { get; set; }

    // Override Work Method
    public override void Work()
    {
        Console.WriteLine("Designer is creating UI designs");
    }
}

// Test Program
class Program
{
    static void Main()
    {
        // Developer Object
        Developer dev = new Developer();
        dev.ID = 1111;
        dev.Name = "Moosa";
        dev.Department = "IT";
        dev.Salary = 1000;
        dev.ProgrammingLanguage = "C#";

        // Designer Object
        Designer des = new Designer();
        des.ID = 2222;
        des.Name = "Amal";
        des.Department = "Design";
        des.Salary = 900;
        des.DesignTool = "Figma";

        // Call Work Methods
        dev.Work();
        des.Work();
    }
}

3.Demonstrate Polymorphism

using System;
using System.Collections.Generic;

class Employee
{
    public string Name { get; set; }

    public virtual void Work()
    {
        Console.WriteLine("Employee is working");
    }
}

class Developer : Employee
{
    public string ProgrammingLanguage { get; set; }

    public override void Work()
    {
        Console.WriteLine("Developer is writing code");
    }
}

class Designer : Employee
{
    public string DesignTool { get; set; }

    public override void Work()
    {
        Console.WriteLine("Designer is creating designs");
    }
}

class Program
{
    static void Main()
    {
        // Create list of Employee objects
        List<Employee> employees = new List<Employee>();

        // Add Developer object
        employees.Add(new Developer
        {
            Name = "Ahmed",
            ProgrammingLanguage = "C#"
        });

        // Add Designer object
        employees.Add(new Designer
        {
            Name = "Sara",
            DesignTool = "Photoshop"
        });

        // Loop through collection and call Work()
        foreach (Employee emp in employees)
        {
            emp.Work();
        }
    }
}

// 4. Demonstrate Encapsulation

using System;

class Employee
{
    private double salary;
    private int id;

    // Property for Salary
    public double Salary
    {
        get { return salary; }
        set
        {
            if (value > 0)
            {
                salary = value;
            }
            else
            {
                Console.WriteLine("Invalid salary value!");
            }
        }
    }

    // Property for ID
    public int ID
    {
        get { return id; }
        set
        {
            if (value > 0)
            {
                id = value;
            }
            else
            {
                Console.WriteLine("Invalid ID value!");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee();

        // Valid values
        emp.ID = 10101;
        emp.Salary = 550;

        Console.WriteLine("Employee ID: " + emp.ID);
        Console.WriteLine("Employee Salary: " + emp.Salary);

        // Invalid values
        emp.ID = -5;
        emp.Salary = -100;
    }
}