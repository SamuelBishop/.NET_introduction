using System;
using System.Collections.Generic; // new subset of system library for this example

namespace data_collection_list_type
{
    class Program
    {
        static void Main(string[] args){ // main needs to be capitalized in all .NET programming
            working_with_strings();
            working_with_numbers();
        }

        static void working_with_strings()
        {
            // the list type list<T> seems very similar to the vector type in C++
            var names = new List<string> { "Sam", "Ana", "Felipe" };
            
            // An important part of lists (like vectors) is that they are dynamically allocated and can grow or shrink
            names.Add("Yo momma");
            names.Remove("Ana");
            foreach (var name in names) // iteratable object based for loop (as opposed to traditional)
            {
                Console.WriteLine($"Name: {name.ToUpper()}!"); // can do appropriate methods on objects (like string)
            }

            // Can also use list type as array
            Console.WriteLine($"My name is {names[0]}");
            Console.WriteLine($"I've added {names[2]} to the list");

            // Also each list object has certain methods attached to it like Count
            Console.WriteLine($"This list has {names.Count} members in it");

            // How to search and sort lists in C#
            var index = names.IndexOf("Felipe");
            if (index == -1){
                Console.WriteLine($"This item is not found and returns {index}"); // should be -1
            }
            else {
                Console.WriteLine($"The index of this item is {index}");
            }

            // this segment could be abstracted but the false case works as well
            index = names.IndexOf("George Bush");
            if (index == -1){
                Console.WriteLine($"This item is not found and returns {index}"); // should be -1
            }
            else {
                Console.WriteLine($"The index of this item is {index}");
            }

            // This is how list sorting works in C#
            names.Sort(); // not beginning to end stuff like vectors in C++
            foreach (var name in names){
                Console.WriteLine($"Names in sorted order {name.ToUpper()}!");
            }
        }

        static void working_with_numbers(){
            var fib_nums = new List<int> {1, 1}; // remember var functions like auto
            // here we will make the fibinocci sequence for practice
            int previous, previous2;

            // challenge is to write the first 20 numbers in sequence
            for(int i = 0; i < 20; i++){
                previous = fib_nums[fib_nums.Count - 1];
                previous2 = fib_nums[fib_nums.Count - 2];
                fib_nums.Add(previous + previous2);
            }

            foreach (var item in fib_nums) { // could iterate this to run forever however right now it will only have three elements
                Console.WriteLine(item); 
            }
        }
    }
}
