using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
    public class ExceptionHandling : MonoBehaviour
    {

        void Start()
        {
            int playerScore = 100;
            int diviser = 0;
            try
            {// i had to put the log above the exception ,because after the excep in the try , none of the lines will work
                Debug.Log("Attempting to calculate score multiplier...");
                int totalScore = playerScore / diviser;
            }
            catch ( System.DivideByZeroException )
            {
                Debug.Log("Error: Division by zero occurred while calculating score multiplier.");
            }
            finally
            {
                Debug.Log("Score calculation complete. Cleaning up resources.");
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}