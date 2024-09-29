using Problem;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Liskov substition principle::");
Console.WriteLine("If Class B is subtype of class A, then we should able to replace object of A with B without breaking the beheviour of the class");
//Subclass should extend the capacity of the parent class not norrow it down.

Car  car = new Car(); 
Bicycle bicycle = new Bicycle();
Console.WriteLine($"{car.HasEngine()} {bicycle.HasEngine()}");
