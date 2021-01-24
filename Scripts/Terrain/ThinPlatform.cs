using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Classe para controlar as One Way Platforms.

public class ThinPlatform : MonoBehaviour
{
    private PlatformEffector2D effector;
    
    
    float waitTime;  //Tempo de espera para voltar ao ângulo inicial.
    bool playerDropped;  //Deve ser true se jogador desceu da plataforma.

    void Start()
    {
        
        effector = this.GetComponent<PlatformEffector2D>();  //Componente Effector2D torna a colisão com essa plataforma em apenas um sentido.
        playerDropped = false;
        

    }

    void Update()
    {       
        if (PlayerInput.onDown())  
        {
            effector.rotationalOffset = 180;  //Gira a plataforma em 180° para jogador descer
            playerDropped = true;           

        }

        if (playerDropped)
        {
            if (waitTime <= 0)  //Espera um tempo mínimo para o jogador conseguir atravessar a plataforma 
            {
                waitTime = 0.145f;  //Reinicia o tempo de espera  
                effector.rotationalOffset = 0; //Quando o tempo mínimo passar, retora a plataforma de volta para o ângulo inicial.
                playerDropped = false;
            }
            else
            {
                waitTime -= Time.deltaTime;  //Passa o tempo.

            }
        }
        
        
    }
}
