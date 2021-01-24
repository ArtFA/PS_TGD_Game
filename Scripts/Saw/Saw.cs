using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// State Machine da serra.

public class Saw : MonoBehaviour
{
    public float speed; 
    public SawState currentState;  //Estado atual da serra.
    public GameObject initialP;  //Ponto de destino inicial da serra.
    public GameObject finalP;  //Ponto de destino final da serra.
    public bool goToInitialP;  //Deve ser true quando serra puder ir para o ponto inicial.
    public bool goToFinalP;  //Deve ser true quando serra puder ir para o ponto final.
    public bool onHitPlayer;  //Deve ser true se serra tiver colidido com o jogador.

    void Start()
    {
        speed = 3.5f;
        currentState = new SawMove();
        goToInitialP = true;
        goToFinalP = false;
        onHitPlayer = false;
}

    void Update()
    {
        currentState.execute(this);  //Executa o estado atual da fruta.
        checkIfHitPlayer();  //Checa se está colidindo com o jogador.

    }

    public void setState(SawState nextState)  //Altera o estado atual da serra.
    {
        currentState = nextState;  

    }

    public void checkIfHitPlayer()
    {
        if (onHitPlayer)  //Se colidir com o jogador, deve reiniciar o jogo.
        {
            Game.reset();
            onHitPlayer = false;
        }
            

    }    

    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.transform.gameObject.tag == "Player")  //Checa se está em colisão com o jogador, se sim, atribui true à variável onHitPlayer
            onHitPlayer = true;
        else
            onHitPlayer = false;
    }

    private void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.transform.gameObject.tag == "Player")  //Checa se está em colisão com o jogador, se sim, atribui true à variável onHitPlayer
            onHitPlayer = true;
        else
            onHitPlayer = false;
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.transform.gameObject.tag == "Player")  //Checa se está em colisão com o jogador, se sim, atribui true à variável onHitPlayer
            onHitPlayer = true;
        else
            onHitPlayer = false;
    }

    
   
}
