/*Author Charles Yingling                                   Date 10/13/21
*/
using System;

class Program {
static void CalculateCharges() {
  //Input – Get the hours parked for each customer. 
  Console.WriteLine("How many hours parked?");
    double hrpark = Convert.ToDouble(Console.ReadLine());
  if (hrpark <= 3) {
      Console.WriteLine("Parking charges = $2.00");
  } else if (hrpark > 3) {
    //Calculate parking charges
    double fee = (hrpark * 0.50) + 2.00;
     if (fee > 10) {
      Console.WriteLine("Parking charges = $10");
    } else {
      //Return the total parking charges for the customer.
      Console.WriteLine("Parking charges = $" + fee);
    }
  }
  }

  public static void Main (string[] args) {
    //From the calling app, call CalculateCharges() for each customer
    CalculateCharges();
  for (int i = 0; ; i++) {
    //Ask the user if there is any more customer
    Console.WriteLine("Is there any more customers?");
     string custs = Console.ReadLine();
     //if answer is “No” then stop. Else continue.
    if (custs == "no") {
        return;
      } else {
        CalculateCharges();
      }
      continue;
}
  }
}