// Code project 1 - write code that validates integer input

string readResult, valueEntered = "";
int numbValue = 0;
bool validEntry = false;

Console.WriteLine("Please enter an integer value between 5 and 10");

do
{
  readResult = Console.ReadLine();

  if (readResult != null)
  {
    valueEntered = readResult;
  }
  validEntry = int.TryParse(valueEntered, out numbValue);

  if (validEntry == true)
  {
    if (numbValue <= 5 || numbValue >= 10)
        {
            validEntry = false;
            Console.WriteLine($"You entered {numbValue}. Please enter a number between 5 and 10.");
        }
  }
  else
  {
    Console.WriteLine("Your input is invalid, please try again.");
  }
} while (validEntry == false);

Console.WriteLine($"Your input value ({numbValue}) has been accepted.");
