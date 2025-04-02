using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
    public class Testpart3 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            int[] arr=new int[]{3,5,6,4,3,2,2}; 
            print(Utilities.Add(arr));
            print("Hello".RepeatString(6));

        }

       
    }
}