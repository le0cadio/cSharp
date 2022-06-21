using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForScript : MonoBehaviour
{
    
    public int[] ArrayInt = {1,2,3,4,5,6,7,8,9,10};
    void Start()
    {
        foreach (int Valor in ArrayInt)
        {
            Debug.Log(Valor);
        }
    }

    void Update()
    {
        
    }
}
