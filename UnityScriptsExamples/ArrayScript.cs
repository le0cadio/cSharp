using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayScript : MonoBehaviour
{
    public int[] Numbers = new int[5];
    public int[] OthersNumbers;

    void Start()
    {
        OthersNumbers = new int[5];
        OthersNumbers[0] = 10;
        OthersNumbers[1] = 20;
        OthersNumbers[2] = 30;
        OthersNumbers[3] = 40;

        foreach (float ValueNumber in OthersNumbers)
        {
            Debug.Log(ValueNumber);
        }
    }

    void Update()
    {
        
    }
}
