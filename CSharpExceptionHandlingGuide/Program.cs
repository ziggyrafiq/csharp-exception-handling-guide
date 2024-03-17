
using CSharpExceptionHandlingGuide;
using Microsoft.Data.SqlClient;

string connectionString = "Never Do This as its only for this Article Example";

Console.WriteLine("Hello from Ziggy Rafiq the author of this article");

Console.WriteLine(connectionString);
try
{
    // Code that might throw an exception
    Console.WriteLine("Code that might throw exception");
}
catch (Exception ex)
{
    Logger.LogError(ex, "An error occurred");
    // Handle the exception or rethrow if necessary
}
 

try
{
    // Code that might throw InvalidOperationException
}
catch (InvalidOperationException ex)
{
    // Handle InvalidOperationException
    Console.WriteLine("InvalidOperationException occurred: " + ex.Message);
}
catch (Exception ex)
{
    // Handle other exceptions
    Console.WriteLine("An error occurred: " + ex.Message);
}

try
{
    // Code that might throw an exception
    Console.WriteLine("Code that might throw exception");
}
catch (Exception ex)
{
    Logger.LogError(ex, "An error occurred");
    // Handle the exception or rethrow if necessary
}

try
{
    // Code that might throw an exception
    Console.WriteLine("Code that might throw exception");
}
catch (Exception ex)
{
    Logger.LogError(ex, "An error occurred");
    throw; // Rethrow the same exception
}

FileStream? file = null;
try
{
    file = new FileStream("example.txt", FileMode.Open);
    // Code that uses the file
}
catch (IOException ex)
{
    Logger.LogError(ex, "An error occurred");
}
finally
{
    file?.Dispose(); // Cleanup resources
}

try
{
    // Code that might throw an exception
    Console.WriteLine("Code that might throw exception");
}
catch (Exception ex)
{
    // Empty catch block, not recommended
    Logger.LogWarning(ex, "Caught an exception");
}

using (var connection = new SqlConnection(connectionString))
{
    // Code that uses the connection
    Console.WriteLine($" We will use the SQL Connection here and {connection}");
}
