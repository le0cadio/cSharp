using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponents : MonoBehaviour
{

    private BoxCollider2D box;
    private Characters character;

    void Start()
    {
        box = GetComponent<BoxCollider2D>();
        box.isTrigger = true;
        box.size = new Vector2(10, 10);

        character = GetComponent<Characters>();
        character.life = 30;
        character.type = "Warrior";


    }

    void Update()
    {
        
    }
}
