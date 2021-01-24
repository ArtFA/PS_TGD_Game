using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Nesse estado, o jogador está sendo criado. Ele ocorre até a animação PlayerCreation acabar.

public class PlayerCreation : PlayerState
{
    public override void execute(Player player)
    {
        player.GetComponent<SpriteRenderer>().enabled = true;  //Habilita o Sprite do jogador

        player.GetComponent<Animator>().Play("PlayerCreation");  //inicia animação

        player.GetComponent<Rigidbody2D>().isKinematic = true;  //Desabilita colisão do jogador.
        player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;  //Desabilita movimentação do jogador.

        if (player.isDoneCreatingPlayer)  //É true quando animação PlayerCreation acaba.
        {
            player.GetComponent<Rigidbody2D>().isKinematic = false;  //Habilita de volta a colisão do jogador.
            player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;  //Habilita de volta a movimetação do jogador.
            player.isDoneCreatingPlayer = false;  //Reinicia a variável booleana para funcionar quando o jogador precisar ser criado denovo.
            player.setState(new PlayerFall());  //Altera o estado do jogador para caindo.
        }
    }
    
}
