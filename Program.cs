using System;

namespace properties
{
    class Program
    {
        static void Main(string[] args)
        {

           Employees EmployeeAndrew = new Employees();
            EmployeeAndrew.firstName = "Presh";
            EmployeeAndrew.lastName = "Mick";
            EmployeeAndrew.totalPay = 100000;
            EmployeeAndrew.ID = 025;

           EmployeeAndrew.PrintAllDetails();

            // student Andrey = new student();
            // property newProp = new property();

            // newProp.FirstId = -2;
            // Console.WriteLine(newProp.FirstId);

            // Andrey.setId(03);
            // Andrey.setName("Andrey");
            // Andrey.setPassMark(100);
            // Console.WriteLine($"Students Data = id {Andrey.getId()} \n name = {Andrey.getName()} \n Pass Mark = {Andrey.getPassMark()}");
        }
    }
    
 
}