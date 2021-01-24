using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Estado do jogador quando estiver caindo.

public class PlayerFall : PlayerState
{
    public override void execute(Player player)
    {
        player.GetComponent<Animator>().Play("PlayerFall");  //Inicia animação.

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

        if ((player.isGrounded() || player.isOnThinPlatform()) && player.GetComponent<Rigidbody2D>().velocity.y >= 0) //True se jogador entrar em contato com o solo e velocidade vertical não for mais negativa
            player.setState(new PlayerIdle());  //Altera estado do jogador para Idle.

    }

}
