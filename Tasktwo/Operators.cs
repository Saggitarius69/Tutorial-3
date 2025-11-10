using System;

public class NullOperations
{
    public void PerformNullChecks()
    {
        string username = null;
        string result = (username == null) ? "Username is not available" : username;
        Console.WriteLine(result);
        Console.WriteLine(username ?? "Username is not available");
        username ??= "DefaultUser";
        Console.WriteLine("Updated username: " + username);
    }
}
