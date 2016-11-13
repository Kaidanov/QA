using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        
        for(int i=0; i<k ; i++)
        {
            int firstElement = a[0];
            int[] newArray = a.Skip(1).ToArray(); 
            List<int> listOfNumbers = newArray.ToList<int>();
            listOfNumbers.Insert(n-1, firstElement);
            a = listOfNumbers.ToArray();
            
        }
        Console.WriteLine("{0}", string.Join(" ", a));
        
    }
    
    
}


//https://www.hackerrank.com/challenges/ctci-array-left-rotation
//Check out the resources on the page's right side to learn more about arrays. The video tutorial is by Gayle Laakmann McDowell, author of the best-selling interview book Cracking the Coding Interview.
//A left rotation operation on an array of size  shifts each of the array's elements  unit to the left. For example, if left rotations are performed on array , then the array would become .
//
//Given an array of  integers and a number, , perform  left rotations on the array. Then print the updated array as a single line of space-separated integers.
//
//Input Format
//
//The first line contains two space-separated integers denoting the respective values of  (the number of integers) and  (the number of left rotations you must perform). 
//The second line contains  space-separated integers describing the respective elements of the array's initial state.
//
//Constraints
//
//Output Format
//
//Print a single line of  space-separated integers denoting the final state of the array after performing  left rotations.
//
//Sample Input
//
//5 4
//1 2 3 4 5
//Sample Output
//
//5 1 2 3 4
//Explanation
//
//When we perform  left rotations, the array undergoes the following sequence of changes:
//
//Thus, we print the array's final state as a single line of space-separated values, which is 5 1 2 3 4.