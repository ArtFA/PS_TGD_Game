using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Estado do jogador quando estiver parado e no chão.

public class PlayerIdle : PlayerState
{
    public override void execute(Player player)
    {
        player.jumped = false;  //Reinicia a variável de pulo, possibilitando o jogador a pular denovo.  

        player.GetComponent<Animator>().Play("PlayerIdle");  //Inicia animação.

        if (PlayerInput.onMoveRight() || PlayerInput.onMoveLeft())  //True se jogador pressionar uma das teclas direcionais (direita ou esquerda).
            player.setState(new PlayerWalk());  //Altera estado do jogador para andando.

        if (PlayerInput.onJump() && (player.isGrounded() || player.isOnThinPlatform()) && !player.jumped)  //True se jogador estiver no solo e pressionar a tecla direcional para cima.
            player.setState(new PlayerJump());

        if (!player.isGrounded() && !player.isOnThinPlatform())  //True se jogador não estiver mais no solo. 
            player.setState(new PlayerFall());  //Altera o estado do jogador para caindo.

        if (player.isOnThinPlatform() && PlayerInput.onDown())  //True se jogador estiver em uma plataforma fina e pressionar direcional para baixo.
            player.setState(new PlayerFall());  //Altera o estado do jogador para caindo.

    }
    
}
