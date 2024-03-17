// Placeholder Logger class for demonstration purposes
namespace CSharpExceptionHandlingGuide;
public static class Logger
{
    public static void LogError(Exception ex, string message)
    {
        // Simulate logging the error to console
        Console.WriteLine("Error: " + message);
        Console.WriteLine("Exception details: " + ex.Message);
    }

    public static void LogWarning(Exception ex, string message)
    {
        // Simulate logging the warning to console
        Console.WriteLine("Warning: " + message);
        Console.WriteLine("Exception details: " + ex.Message);
    }
}
