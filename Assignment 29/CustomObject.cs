using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
    public class CustomObject
    {
        int _id;
        string _name;
        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public CustomObject(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"object[ ID:{Id} NAME :{Name} ]";
        }

        // public override bool Equals(object obj)
        // {
        //     if (obj != null)
        //     {
        //         if (obj is CustomObject customObject)
        //         {
        //             return this.Id == customObject.Id && this.Name == customObject.Name;
        //         }
        //     }    

        //     return false;
        // }


        public static bool operator ==(CustomObject first, CustomObject second)
        {
            if (first != null && second != null)
            {
                if (first is CustomObject customObject1 && second is CustomObject customObject2)
                {
                    return customObject1.Id == customObject2.Id && customObject2.Name == customObject1.Name;
                }
            }

            return false;
        }
        public static bool operator !=(CustomObject first, CustomObject second)
        {
            if (first != null && second != null)
            {
                if (first is CustomObject customObject1 && second is CustomObject customObject2)
                {
                    return !(customObject1.Id == customObject2.Id && customObject2.Name == customObject1.Name);
                }
            }

            return false;
        }
        //the first operator method stayed with a red line until i added the second one


    }
}