        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter your monthly salary: ");
        double monthlySalary = double.Parse(Console.ReadLine());

        Console.Write("Enter daily working hours: ");
        int dailyHours = int.Parse(Console.ReadLine());

    
        double yearlySalary = monthlySalary * 12;
        int yearlyWorkingHours = dailyHours * 365;
        int monthlyWorkingHours = dailyHours * 30;
        double dailyIncome = monthlySalary / 30;
        int ageAfterFourYears = age + 4;


        Console.WriteLine("\n===== Results =====");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Yearly Salary: {yearlySalary}");
        Console.WriteLine($"Yearly Working Hours: {yearlyWorkingHours}");
        Console.WriteLine($"Monthly Working Hours: {monthlyWorkingHours}");
        Console.WriteLine($"Average Daily Income: {dailyIncome}");
        Console.WriteLine($"Age after 4 years: {ageAfterFourYears}");
  

