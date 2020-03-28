using System;

/* Bit of trivia (I had to write this down to remember it):
    The reason why C# is better than C++ is because C# is a modern,
    memory safe language. C++ is pure OO, C# has a huge standard library.
    C# has negative garbage collection (should probablly review the concept
    of garbage collection).
*/

/*
    The Garbage Collector:
    Frees up memory that was previously used for created objects that are no longer
    in use. In fancier words: The garbage collector manages allocation and reclaiming of memory.
    The "Garbage" (old objects) are stored in the heap. The collector visits them
    and frees them. Objects are stored in generations:
    - 0 Holds short lived objects. GC visits it frequently.
    - 1 Somewhere inbetween short and long lifespace
    - 2 Long lifespan like static and global variables

    Survivor objects are objects that are moved from lower gens to higher gens.
    Mostly the GC is used automatically in the background, but can manually be called with
    functions like GC.Collect() to recieve object instances.

    Managed vs. Unmanaged Objects:
    Managed: .NET code managed at runtime (Managed by CLR).
        CLR = Common Language Runtime (MS proprietary resource manager)
    Unmanaged: Objects created outside of .Net libraries (Not managed by CLR)
        Examples: COM Objects, file streams, connection objects, interop objects (usually third party libraries) 
        COM = Componenet Object Model (Language Neutral Way of Implementing Objects)

    To empty the garbage collector use dispose method. Review this later.
*/

namespace branches_and_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // The rest of this program is common sense and I've opted to skip the rest of it
            int a = 5;
            int b = 6;
            int c = 4;
            if ((a + b + c> 10) && ( a == b)) { // logic statements work exactly the same way as C++
                Console.WriteLine("The answer of the variables is greater than 10");
                Console.WriteLine("The first number also equals the second");
            }
            else {
                Console.WriteLine("This tutorial was definetly not written for someone who knows how to code already");
                Console.WriteLine("The first number does not equal the second");
            }

            if(a + b > 10 || a + c > 10){
                Console.WriteLine("Or statements are verbatim C++");
            }

            int counter = 0;
            // while (counter < 10)
            // {
            //     Console.WriteLine($"This is going to loop 10 (0-9) times: {counter}");
            //     counter++;
            // }

            // Do while loops are also the same from C++
            do {
                Console.WriteLine($"This is going to loop 10 (0-9) times: {counter}");
                counter++;
            } while (counter < 10);

            // for loops are the same as C=+
            for (int index = 0; index < 10; index++) {
                Console.WriteLine($"The index is: {index}");
            }
            is_div_by_three();
        }

        // challenge problem (not very hard)
        static void is_div_by_three(){
            for(int i = 1; i < 21; i++) {
                if (i % 3 == 0){
                    Console.WriteLine($"{i} is divisible by 3");
                }
                else{
                    Console.WriteLine($"{i} is not divisible by 3");
                }
            }
        }
    }
}
