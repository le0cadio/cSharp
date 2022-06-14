using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour
{
    public int  DiaSemana;

    void Start()
    {
        switch (DiaSemana)
        {
            case 1:
                Debug.Log("Domingo!");
                break;
            case 2:
                Debug.Log("Segunda!");
                break;
            case 3:
                Debug.Log("Terça!");
                break;
            case 4:
                Debug.Log("Quarta!");
                break;

            default:
                Debug.Log("Dia no encontrado");
                break;
        }
    }

    
    void Update()
    {
        
    }
}
