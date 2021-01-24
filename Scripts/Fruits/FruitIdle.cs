using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Nesse estado, a fruta ainda não foi coletada pelo jogador.

public class FruitIdle : FruitState
{
    public override void execute(Fruit fruit)
    {
        fruit.GetComponent<Animator>().Play("Idle"); //Inicia animação.
        if (fruit.onHitPlayer)  //True se jogador colidiu com a fruta.
        {
            
            fruit.setState(new FruitDisappear());  //Altera o estado da fruta para Desaparecendo.
            GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().collectedFruits++;  //Adiciona 1 ao contador de frutas coletadas pelo jogador.
            fruit.onHitPlayer = false;
        }
            
    }
    
}
