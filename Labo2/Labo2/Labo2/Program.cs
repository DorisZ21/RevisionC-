using System;

namespace labo2
{
    internal class Program
    {
        /*
         * Test qui permait de tester une fonction en connaissant le résultat attendu et en
         * le comparant avec le résultat observé 
         */
        static void AssertBool (string test, bool expected, bool observed)
        {
            Console.WriteLine("Test: " + test);
            Console.WriteLine("Expected: " + expected + ", observed: " + observed);
            Console.WriteLine(expected == observed ? "Ok!" : "KO !!!");
            Console.WriteLine();
        }
        static void TestValidLogin()
        {
            AssertBool("Herbert", true, ForumUtils.ValidLogin("Herbert"));
            AssertBool("empty string", false, ForumUtils.ValidLogin(""));
            AssertBool("fart", false, ForumUtils.ValidLogin("fart"));
            AssertBool("FART", false, ForumUtils.ValidLogin("FART"));
            AssertBool("FaRt", false, ForumUtils.ValidLogin("FaRt"));
        }
        
        static void Main(string[] args)
        {
            User monUser1 = new User("dodo", "test");
            User monUser2 = new User("dodoTest", "testDodo",DateTime.Today);
            
            Console.WriteLine(monUser1);
            Console.WriteLine(monUser2);
            
            TestValidLogin();
            
            monUser1.SetLogin("FaRT");
            Console.WriteLine(monUser1.GetLogin());
            // Ok le setter fonctionne bien
            
            
        }
    }
}