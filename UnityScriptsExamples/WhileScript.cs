using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileScript : MonoBehaviour
{

    public int Moedas = 100;

    void Start()
    {
        do
        {
            Debug.Log("Sua quantidade de moedas é: " + Moedas);
            Moedas += 100;

        } while (Moedas < 1000);
        
    }

    void Update()
    {
        
    }
}
