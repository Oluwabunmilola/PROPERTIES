//create employee class with properties firstname,lastname,totalpay,id
// and a method to print all the details
using System;
namespace properties{

    class Employees
    {
public string firstName{  get;set; }

 public string lastName{  get;set; }

 public int ID{  get;set; }

 public int totalPay{  get;set; }

     public void PrintAllDetails()
    {
        Console.WriteLine($"Your details are: id {ID}, \n your first name is {firstName} \n last name is: {lastName}.\n Your total pay is {totalPay}");
    }


    }

    

}



