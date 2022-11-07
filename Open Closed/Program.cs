using Open_Closed.OCPGoodWithDelegate;
using Open_Closed.OCPGoodWithInterface;


// Bad way
/*
SalaryCalculatorBad salaryCalculator = new();
Console.WriteLine($"Low salary: {salaryCalculator.Calculate(1000, SalaryType.Low)}");
Console.WriteLine($"MIddle salary: {salaryCalculator.Calculate(1000, SalaryType.Middle)}");
Console.WriteLine($"High salary: {salaryCalculator.Calculate(1000, SalaryType.High)}");
*/

// Good way with interface
/*
SalaryCalculatorGood salaryCalculator = new();
Console.WriteLine($"Low salary: {salaryCalculator.Calculate(1000, new LowSalaryCalculate())}");
Console.WriteLine($"Middle salary: {salaryCalculator.Calculate(1000, new MiddleSalaryCalculate())}");
Console.WriteLine($"High salary: {salaryCalculator.Calculate(1000, new HighSalaryCalculate())}");
// new salary added
Console.WriteLine($"Manager salary: {salaryCalculator.Calculate(1000, new ManagerSalaryCalculate())}");
*/

// Good way with delegate

SalaryCalculatorGood2 salaryCalculator = new();
Console.WriteLine($"Low salary: {salaryCalculator.Calculate(1000, new LowSalaryCalculate().Calculate)}");
Console.WriteLine($"Middle salary: {salaryCalculator.Calculate(1000, new MiddleSalaryCalculate().Calculate)}");
Console.WriteLine($"High salary: {salaryCalculator.Calculate(1000, new HighSalaryCalculate().Calculate)}");
// new salary added
Console.WriteLine($"Manager salary: {salaryCalculator.Calculate(1000, x =>
{
    return x * 7;
})}");

// (EN)When writing with a delegate, when we add a new salary calculation, we don't need to create a class. We can write using function delegate inside the method.
// (AZ)Delegate ilə yazdıqda, yeni bir salary hesablaması əlavə etdikdə, class yaratmağımıza ehtiyac qalmır. Metod daxilində function delegate istifadə edərək yaza bilərik.




