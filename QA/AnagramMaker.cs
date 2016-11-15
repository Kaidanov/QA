using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace QA
{
    class AnagramMaker{

        //static void Main(String[] args) {
        //    MakeAnagram();
        //}

        private static void MakeAnagram()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            MySort(a);
            MySort(b);
            Console.WriteLine(anagramMaker(a, b));
        }
    
        /// <summary>
        /// Sort the string alphabetically
        /// </summary>
        /// <param name="anyString"></param>
        /// <returns></returns>
        public static string MySort(string anyString)
        {
            char[] sorted = anyString.Replace(" ", string.Empty).ToArray(); //handling white spaces
            Array.Sort(sorted);
            return new string(sorted);
        }
    
        //Count the letters to delete to make the strings anagram
        public static int anagramMaker(string first, string second)
        {
            //if one of the strings with legth 0 and the other not than the count to remove will be the other string
            if (first.Length == 0 && second.Length != 0)
                return second.Length;
            else if(first.Length != 0 && second.Length ==0)
                return first.Length;

            if(first == second)
                return 0; //if they are equal then no changes needed (that is after sorting therefore more accurate)

            Dictionary<char, int> pool = new Dictionary<char, int>();
            foreach(char element in first.ToCharArray()) //fill the dictionary with that available chars and count them up
            {
                if(pool.ContainsKey(element))
                    pool[element]++;
                else
                    pool.Add(element, 1);
            }
        
            foreach(char element in second.ToCharArray()) //take them out again
            {
            
                if(pool.ContainsKey(element)) //remove the letters that are in both strings one by one
                    pool[element]--;
                else
                    if(pool.ContainsKey(element)) //add letters that aren't there yet
                         pool[element]++;
                    else
                         pool.Add(element, 1);
            }
        
            foreach(var item in pool.Where(kvp => kvp.Value == 0).ToList()) //remove the nullified keys
            {
                pool.Remove(item.Key);
            }
           return  pool.Count;
        }
    }
}
//https://www.hackerrank.com/challenges/ctci-making-anagrams
//Check out the resources on the page's right side to learn more about strings. The video tutorial is by Gayle Laakmann McDowell, author of the best-selling interview book Cracking the Coding Interview.
//Alice is taking a cryptography class and finding anagrams to be very useful. We consider two strings to be anagrams of each other if the first string's letters can be rearranged to form the second string. In other words, both strings must contain the same exact letters in the same exact frequency For example, bacdc and dcbac are anagrams, but bacdc and dcbad are not.

//Alice decides on an encryption scheme involving two large strings where encryption is dependent on the minimum number of character deletions required to make the two strings anagrams. Can you help her find this number?

//Given two strings,  and , that may or may not be of the same length, determine the minimum number of character deletions required to make  and  anagrams. Any characters can be deleted from either of the strings.

//This challenge is also available in the following translations:

//Chinese
//Russian
//Input Format

//The first line contains a single string, . 
//The second line contains a single string, .

//Constraints

//It is guaranteed that  and  consist of lowercase English alphabetic letters (i.e.,  through ).
//Output Format

//Print a single integer denoting the number of characters you must delete to make the two strings anagrams of each other.

//Sample Input

//cde
//abc
//Sample Output

//4
//Explanation

//We delete the following characters from our two strings to turn them into anagrams of each other:

//Remove d and e from cde to get c.
//Remove a and b from abc to get c.
//We must delete  characters to make both strings anagrams, so we print  on a new line.