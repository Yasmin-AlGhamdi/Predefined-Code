//#define WITHRETURN
//#undef WITHRETURN
//#define TESTCODE

using System;

#if !WITHRETURN
#warning You must use WITHRETURN in this situation
#endif
namespace PreDirIntro
{
    class Program
    {
#if WITHRETURN

        public static int sum(int first, int second)
        {
            return first + second;
        }
#else
        public static void sum(int first, int second)
        {
            Console.WriteLine(first + second);
        }
#endif
        static void Main(string[] args)
        {
#if DEBUG // predefined symbol
            Console.WriteLine("Debug mode..");
//#endif
//#if TESTCODE
            int a = 10;
            if (a >= 10) Console.WriteLine("XXX");
#endif


#if WITHRETURN
            int result = sum(2, 7);
            Console.WriteLine(result);
#else
            sum(2,7);
#endif

            Console.ReadKey();
        }
    }
}
