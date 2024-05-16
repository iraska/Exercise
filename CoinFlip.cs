/* You'll implement a conditional operator to simulate a "coin flip". 
The resulting decision logic will display either heads or tails. */

Random value = new Random();
int coinFlip = value.Next(0, 2);
Console.WriteLine(coinFlip == 0 ? "heads" : "tails");
