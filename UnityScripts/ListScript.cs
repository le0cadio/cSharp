using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListScript : MonoBehaviour
{
   [System.Serializable]
   public class Orc 
   {
      public string name;
      public int age;
      public float height;
   }

   public List<Orc> orcs = new List<Orc>();

   void Start() 
   {
      Orc orc2 = new Orc();
      orc2.name = "Frodo";
      orc2.age = 50;
      orc2.height = 1.75f;
      orcs.Add(orc2);

      Orc orc3 = new Orc();
      orc3.name = "Legolas";
      orc3.age = 1000;
      orc3.height = 2.25f;
      orcs.Add(orc3);

      orcs.Remove(orc3);
   }

   // public List<string> Enemy = new List<string>();

   // void Start() 
   // {
   //    Enemy.Add("Orc");
   //    Enemy.Add("Elf");
   //    Enemy.Add("Warrior");
   //    Enemy.Add("Skeleton");
   //    Enemy.Add("Goblin");

   // }
   
 

}
