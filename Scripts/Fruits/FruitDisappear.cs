using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Nesse estado, a fruta irá desaparecer.
public class FruitDisappear : FruitState
{
    public override void execute(Fruit fruit)
    {
        
        fruit.GetComponent<Animator>().Play("FruitDisappear"); //Inicia animação

        if (fruit.canDisappear)  //Retorna true se a fruta puder desaparecer
        {
            fruit.GetComponent<SpriteRenderer>().enabled = false;  //Desabilita o sprite
            fruit.GetComponent<CircleCollider2D>().enabled = false;  //Desabilita o collider
            fruit.canDisappear = false;
            
        }

        if (GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().collectedFruits == GameObject.FindGameObjectsWithTag("Fruit").Length )  //Se o jogador tiver coletado todas as frutas do mapa.
            Game.win();  //Jogador ganha o jogo.

    }
    
}
