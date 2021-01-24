using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Estado do jogador quando estiver andando.

public class PlayerWalk : PlayerState
{
    public override void execute(Player player)
    {
        player.jumped = false; //Reinicia a variável de pulo, possibilitando o jogador a pular denovo.        

        player.GetComponent<Animator>().Play("PlayerWalk");  //Inicia animação.

        if (!PlayerInput.onMoveRight() && !PlayerInput.onMoveLeft())  //True se o jogador não apertar nenhuma tecla de movimentação.
        {
            player.setState(new PlayerIdle());  //Altere o estado do jogador para Idle.
        }

        if (PlayerInput.onMoveRight())  //True se jogador pressionou a tecla direcional para a direita.
        {
            player.GetComponent<Rigidbody2D>().velocity = new Vector2(PlayerInput.horizontalDir() * player.speed, player.GetComponent<Rigidbody2D>().velocity.y);  //Movimenta o jogador

            if (player.transform.localScale.x < 0)
                player.transform.localScale = new Vector2(player.transform.localScale.x * - 1, player.transform.localScale.y);  //Muda o sentido que o jogador está olhando.
        }

        if (PlayerInput.onMoveLeft())  //True se jogador pressionou a tecla direcional para a esquerda.
        {        
            player.GetComponent<Rigidbody2D>().velocity = new Vector2(PlayerInput.horizontalDir() * player.speed, player.GetComponent<Rigidbody2D>().velocity.y);  //Movimenta o jogador

            if (player.transform.localScale.x > 0)
                player.transform.localScale = new Vector2(player.transform.localScale.x * -1, player.transform.localScale.y);  //Muda o sentido que o jogador está olhando.
        }

        if(PlayerInput.onMoveLeft() && PlayerInput.onMoveRight())  //True se jogador pressionou a tecla direcional para a esquerda e esquerda ao mesmo tempo.
        {
            player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);  //Velocidade é zerada.
        }

        if (PlayerInput.onJump() && (player.isGrounded() || player.isOnThinPlatform()) && !player.jumped)  //True se jogandor estiver no solo e tenha pressionado a tecla de pular.
            player.setState(new PlayerJump());  //Altera o estado do jogador para pulando.

        
        if (!player.isGrounded() && !player.isOnThinPlatform()) //True se jogador não estiver mais no solo. 
            player.setState(new PlayerFall());  //Altera o estado do jogador para caindo.

        if (player.isOnThinPlatform() && PlayerInput.onDown())  //True se jogador estiver em uma plataforma fina e pressionar direcional para baixo.
            player.setState(new PlayerFall());  //Altera o estado do jogador para caindo.
    }

}
