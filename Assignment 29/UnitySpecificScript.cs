using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace Assignment29
{
    public class UnitySpecificScript : MonoBehaviour
    {
        GameObject targetObject;
        GameObject joker;
        Light light;

        void OnEnable()
        {
            print("GameObject Enabled");
        }
        void OnDisable()
        {
            print("GameObject Disabled");
        }
        void Start()
        {
            print("Game started!");

            //by name
            targetObject=GameObject.Find("TargetObject");
            if(targetObject!=null)
            {
                print($"Found object by name: {targetObject.name}");
            }
            else 
            print($"No {targetObject.name} found");

            //by tag
            joker=GameObject.FindGameObjectWithTag("Joker");
            if(joker!=null)
            {
                print($"Found object by tag: {joker.name}");
            }
            else 
            print($"No {joker.name} found");
            
            //by type
           light = FindObjectOfType<Light>();
           if(light!=null)
            {
                print($"Found object of type Light: {light.name}");
            }
            else 
            print($"No {light.name} found");
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.D))
            { 
                targetObject.SetActive(false);
                print("TargetObject deactivated!");

            }

        }
    }
}