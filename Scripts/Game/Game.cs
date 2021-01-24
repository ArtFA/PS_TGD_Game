using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Classe para controlar eventos no jogo.

public class Game : MonoBehaviour   
{
    private static Game gameInstance;  //Intância da classe para ter acesso ao método StartCoroutine.
    private GameObject player;  //Jogador.
    private GameObject winText;  //Texto de vitória (Parabéns).

    private void Awake()
    {
        gameInstance = this;
        player = GameObject.FindGameObjectWithTag("Player");
        winText = GameObject.Find("winText");
    }
    

    public static void reset()  //Reseta o jogo.
    {
        gameInstance.StartCoroutine(gameInstance.resetPlayer());  //Reseta o jogador.
        gameInstance.StartCoroutine(gameInstance.resetFruits());  //Reseta as frutas.
        gameInstance.player.GetComponent<Player>().collectedFruits = 0;  //Reseta o numero de frutas coletadas pelo jogador.
        
    }

    public static void win()
    {
        gameInstance.StartCoroutine(gameInstance.showWinText());  //Mostra o texto de vitória na tela.
        reset();
    }

    private IEnumerator resetPlayer()  //Método para resetar o jogador.
    {
        

        player.GetComponent<SpriteRenderer>().enabled = false;  //Desabilita o sprite do jogador.
        player.transform.position = new Vector3(-2.7f, -2.7f, 0f);  //Coloca o jogador de volta na posição inicial
        player.GetComponent<Rigidbody2D>().isKinematic = true;  //Impede colisão do jogador.
        player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;  //Impede movimentação do jogador. 

        yield return new WaitForSeconds(1.5f);  //Espera 1.5 segundos (tempo de respawn)
        
        player.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);  //Retira qualquer velocidade do jogador.
        player.GetComponent<Player>().setState(new PlayerCreation());  //Altera o estado do jogador para Criação.
        

    }

    private IEnumerator resetFruits() //Método para resetar as frutas.
    {

        yield return new WaitForSeconds(1.5f);  //Espera 1.5 segundos (tempo de respawn)
        foreach (GameObject fruit in GameObject.FindGameObjectsWithTag("Fruit"))  //Acha todas as frutas no mapa.
        {
            fruit.GetComponent<SpriteRenderer>().enabled = true;  //Habilita o Sprite da fruta.
            fruit.GetComponent<CircleCollider2D>().enabled = true;  //Habilita o collider da fruta.
            fruit.GetComponent<Fruit>().setState(new FruitIdle());  //Altera o estado da fruta para Idle.
            fruit.GetComponent<Fruit>().onHitPlayer = false;
        } 

    }

    private IEnumerator showWinText()  //Método para mostrar texto de vitória.
    {
        yield return new WaitForSeconds(0.5f);
        winText.GetComponent<SpriteRenderer>().enabled = true;

        yield return new WaitForSeconds(1);
        winText.GetComponent<SpriteRenderer>().enabled = false;

    }
}
