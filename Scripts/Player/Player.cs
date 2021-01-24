using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//State Machine do joador.

public class Player : MonoBehaviour
{
    public float speed;  //Velocidade de movimento.
    public float jumpHeight;  //Força do pulo.
    public bool jumped;  //Deve ser true se jogador pulou e ainda não voltou ao solo.
    public bool grounded;  //Deve ser true se jogador está em contato com o solo. 
    private BoxCollider2D playerCollider;  //Collider do jogador.
    public float friction;  //Atrito do jogador com o terreno.
    public int collectedFruits;  //Qtd frutas coletadas.
    public bool isDoneCreatingPlayer;  //Deve ser true quando encerrar animação de criação do jogador.

    [SerializeField]
    private LayerMask groundLayerMask;  //Cama da chão.

    public PlayerState currentState;  //Estado atual do jogador.

    void Start()
    {
        currentState = new PlayerCreation();
        speed = 5.5f;
        jumpHeight = 14f;
        jumped = false;
        friction = 0.4f;
        playerCollider = this.GetComponent<BoxCollider2D>();
        collectedFruits = 0;
        isDoneCreatingPlayer = false;

}
    
    void Update()
    {
        currentState.execute(this);  //Executa o estado atual do jogador.

        changeFriction();  //Muda o atrito do jogador com o terreno.

    }

    public void setState(PlayerState nextState)  //Altera o estado atual do jogador.
    {
        currentState = nextState;
        
    }

    public bool isGrounded()  //Retorna true se jogador está em contato com o solo.
    {

        //Casta uma caixa de colisão para checar se jogador está em contato com o solo.
        RaycastHit2D raycastHitGround = Physics2D.BoxCast(playerCollider.bounds.center, playerCollider.bounds.size - new Vector3(0.2f, 0f, 0f), 0f, Vector2.down, 0.02f, LayerMask.GetMask("Ground"));        
        
        if (raycastHitGround.collider != null )
            return true;
        else
            return false;        


    }

    public bool isOnThinPlatform() //Retorna true se jogador está em contato com uma plataforma fina (one way platform).
    {

        //Casta uma caixa de colisão para checar se jogador está em contato com uma plataforma fina.
        RaycastHit2D raycastHitThinPlatform = Physics2D.BoxCast(playerCollider.bounds.center, playerCollider.bounds.size - new Vector3(0.2f, 0f, 0f), 0f, Vector2.down, 0.2f, LayerMask.GetMask("Thin Platform"));
                
        if (raycastHitThinPlatform.collider != null)
            return true;
        else
            return false;

        

    }


    public void changeFriction() //Muda atrito do jogador com o terreno de acordo com certas condições.
    {
        if ((this.isGrounded() || this.isOnThinPlatform()) && this.GetComponent<Rigidbody2D>().velocity.y == 0)  //Se jogador estiver no solo, atrito volta ao normal.
        {
            playerCollider.sharedMaterial.friction = friction;
            playerCollider.enabled = false;
            playerCollider.enabled = true;
        }
        else  //Se jogador não estiver no solo, atrito é zerado, isso previne colisões com a parede do cenário quando jogador estiver pulando.
        {
            this.GetComponent<BoxCollider2D>().sharedMaterial.friction = 0f;
            playerCollider.enabled = false;
            playerCollider.enabled = true;

        }
    }

    public void doneCreatingPlayer()  //Atribui true para a variável se a animação de criação do jogador estiver finalizada. (método é chamado por um evento na animação)
    {
        isDoneCreatingPlayer = true;        
    }
}
