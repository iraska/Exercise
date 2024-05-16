/* You'll implement decision logic based on a series of business rules. 
The business rules specify the access that will be granted to users based on their role-based permissions and their career level. 
  Code branches will display a different message to the user depending on their permissions and level. */

string permission = "Admin|Manager";
int level = 55;
string output = "";

if (permission.Contains("Admin"))
{
  if (level > 55)
  {
    output = "Welcome, Super Admin user.";
  }
  else
  {
    output = "Welcome, Admin user.";
  }
}
else if (permission.Contains("Manager"))
{
  if (level >= 20)
  {
    output = "Contact an Admin for access.";
  }
  else
  {
    output = "You do not have sufficient privileges.";
  }
}
else
{
  output = "You do not have sufficient privileges.";
}

Console.WriteLine(output);
