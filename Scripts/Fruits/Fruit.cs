using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// State Machine da fruta.

public class Fruit : MonoBehaviour
{
    public FruitState currentState;  //Estado atual da fruta.
    public bool onHitPlayer;   //Deve ser true se fruta tiver colidido com o jogador.
    public bool canDisappear;  //Deve ser true se animação de desaparecimento da fruta estiver finalizada.


    void Start()
    {
        currentState = new FruitIdle();
        onHitPlayer = false;
        canDisappear = false;
    }

    void Update()
    {
        currentState.execute(this);  //Executa o estado atual da fruta.
        
    }

    public void setState(FruitState nextState)
    {
        currentState = nextState;  //Altera o estado atual da fruta.

    }   

    public void disappear()  //Atribui à variável o valor true quando a animação de desaparecimento da fruta estiver finalizada. (método é chamado por um evento na animação)
    {       

        canDisappear = true;
        
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
