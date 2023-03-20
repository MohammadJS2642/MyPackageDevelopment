namespace MyPackageDevelopment
{
    public class MyPackageDevelopment
    {
        
        public static string Status = "Development";

        public static void Log(string logString)
        {
            Console.WriteLine(logString);
        }

        public static string SomeText()
        {
            return Status;
        }

    }
}