﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : PlayerState
{
    public override void execute(Player player)
    { 
        player.GetComponent<Animator>().Play("PlayerJump");  //Inicia animação

        if ((player.isGrounded() || player.isOnThinPlatform()) && !player.jumped)
        {
            player.GetComponent<Rigidbody2D>().velocity = new Vector2(player.GetComponent<Rigidbody2D>().velocity.x, player.jumpHeight);  //Executa o pulo do jogador.
            player.jumped = true;
            
        }

        if (PlayerInput.onMoveRight())  //True se jogador pressionou a tecla direcional para a direita.
        {
            player.GetComponent<Rigidbody2D>().velocity = new Vector2(PlayerInput.horizontalDir() * player.speed, player.GetComponent<Rigidbody2D>().velocity.y);  //Movimenta o jogador

            if (player.transform.localScale.x < 0)
                player.transform.localScale = new Vector2(player.transform.localScale.x * -1, player.transform.localScale.y);  //Muda o sentido que o jogador está olhando.
        }

        if (PlayerInput.onMoveLeft())  //True se jogador pressionou a tecla direcional para a esquerda.
        {
            player.GetComponent<Rigidbody2D>().velocity = new Vector2(PlayerInput.horizontalDir() * player.speed, player.GetComponent<Rigidbody2D>().velocity.y);  //Movimenta o jogador

            if (player.transform.localScale.x > 0)
                player.transform.localScale = new Vector2(player.transform.localScale.x * -1, player.transform.localScale.y);  //Muda o sentido que o jogador está olhando.
        }

        if (player.GetComponent<Rigidbody2D>().velocity.y <= 0)  //True se velocidade vertical do jogador se tornar negativa
            player.setState(new PlayerFall());  //Altera estado do jogador para caindo.
        
    }
    
}
