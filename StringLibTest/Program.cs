using UtilityLibraries;

namespace StringLibTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test various cases
            TestString("Hello");          // True - normal case
            TestString("hello");          // False - lowercase start
        }

        static void TestString(string testStr)
        {
            bool result = testStr.StartsWithUpper();
            Console.WriteLine($"\"{testStr}\" {(result ? "starts with" : "does not start with")} uppercase.");
        }
    }
}
