using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandKeysSprite : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (PlayerInput.onDown() || PlayerInput.onJump() || PlayerInput.onMoveRight() || PlayerInput.onMoveLeft()) //checa se o jogador de moveu
        {
            this.GetComponent<SpriteRenderer>().enabled = false; //se sim, apague o sprite
        }
    }
}
