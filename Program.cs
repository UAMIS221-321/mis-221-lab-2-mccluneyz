 const double COST_OF_SANDWICH = 4.75;
 const double COST_OF_TOPPINGS = 0.55;
 const double DISCOUNT_AMMOUNT = 0.10;


System.Console.WriteLine("How many sandwiches would you like to buy?");
double numberOfSandwiches =double.Parse(Console.ReadLine());

System.Console.WriteLine("How many toppings would you like to add");
double numberOfToppings = double.Parse(Console.ReadLine());

System.Console.WriteLine("Please enter your tip amount, please express it as a decimal");
double tip = double.Parse(Console.ReadLine());


double totalSanwichCost = COST_OF_SANDWICH * numberOfSandwiches;
double totalToppingCost = COST_OF_TOPPINGS* numberOfToppings;
double baseCost = totalSanwichCost + totalToppingCost;
double orderCost = tip + baseCost * (1-DISCOUNT_AMMOUNT);


System.Console.WriteLine("Your total is" + orderCost);

