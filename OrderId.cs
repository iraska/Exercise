/* Code challenge - Report the Order IDs that need further investigation
Your team has found a pattern. Orders that start with the letter "B" encounter fraud at a rate 25 times greater than the normal rate. 
You write new code that outputs the Order ID of new orders where the Order ID starts with the letter "B". This will be used by the fraud team to investigate further.
Use the following steps to complete this challenge.
Declare an array and initialize it to contain the following elements:
    Output
    B123
    C234
    A345
    C15
    B177
    G3003
    C235
    B179
These values represent the fraudulent Order ID data that your application use.
Create a foreach statement to iterate through each element of your array.
Report the Order IDs that start with the letter "B".
Your output should match the following:
    Output
    B123
    B177
    B179 */

string[] fraudulentOrderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

foreach (var fraudulentOrderID in fraudulentOrderIDs)
{
    if (fraudulentOrderID.StartsWith("B"))
    {
        Console.WriteLine(fraudulentOrderID);  // B123, B177, B179
    }
}
