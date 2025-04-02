using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{

    public class TypeManagementScript : MonoBehaviour
    {
        public class Animal
        {
            public virtual void MakeSound()
            {
                Debug.Log("Animal sound");
            }
            public void Move()
            {
                Debug.Log("Animal moves.");
            }
        }
        public class Cat : Animal,ICanFight
        {
            public void Attack()
            {
                Debug.Log("Cat attacks with claws!");
            }

            public override void MakeSound()
            {
                Debug.Log("Meow!");
            }
            public new void Move()
                 {
                Debug.Log("Cat runs quickly.");
            }
           
        }
         public class Warrior : ICanFight
            {
                public void Attack()
                {
                    Debug.Log("Warrior attacks with a sword!");
                }
            }
        void Start()
        {
            //upcasting
            Cat cat = new Cat();
            Animal catToAnimal = cat;
            catToAnimal.MakeSound();
            catToAnimal.Move();

            //downcasting
            Cat animalToCat = catToAnimal as Cat;
            animalToCat.MakeSound();
            animalToCat.Move();

            //the second part
            List<ICanFight> fights=new List<ICanFight>();
            fights.Add(new Cat());
            fights.Add(new Warrior());
            foreach(ICanFight can in fights)
            {
                can.Attack();
            }
            foreach(ICanFight can in fights)
            {
                if (can is Cat)
                {
                    Debug.Log("The object is a Cat.");
                }
                if (can is Warrior)
                {
                    Debug.Log("The object is a Warrior.");
                }
            }
            
        }
        public interface ICanFight
        {
            public void Attack();
        }
    }
}