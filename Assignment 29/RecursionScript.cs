using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
    public class RecursionScript : MonoBehaviour
    {
        public int FibonacciRecursive(int n)
        {
            if (n <= 1)
                return n;
            else
            {
                return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
            }
        }
        public int FibonacciIterative(int n)
        {
            if (n <= 1)
                return n;
            else
            {
                int a = 0, b = 1;
                for (int i = 2; i <= n; i++)
                {
                    int temp = a + b;
                    a = b;
                    b = temp;
                }
                return b;
            }
        }

        
        
        void Start()
        {
            Debug.Log("Fibonacci Recursive : " + FibonacciRecursive(10));
            Debug.Log("Fibonacci Recursive : " + FibonacciRecursive(30));
            Debug.Log("Fibonacci Iterative : " + FibonacciIterative(10));
            Debug.Log("Fibonacci Iterative : " + FibonacciIterative(30));

        }

    }
}