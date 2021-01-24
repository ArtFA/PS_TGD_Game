using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Nesse estado, a serra está se movimentando (é o único estado dela).

public class SawMove : SawState
{
    public override void execute(Saw saw)
    {
        if(saw.initialP != null && saw.finalP != null)  //Checa se os pontos de destino são nulos (como no caso de uma serra estática).
        {
            goToInitialPoint(saw);
            goToFinalPoint(saw);
        }

    }

    public void goToInitialPoint(Saw saw)  //Método para ir ao ponto inicial.
    {
        if (saw.transform.position != saw.initialP.transform.position && saw.goToInitialP)        
            saw.transform.position = Vector2.MoveTowards(saw.transform.position, saw.initialP.transform.position, saw.speed * Time.deltaTime);  //Movimentar a serra
            
        
        if(saw.transform.position == saw.initialP.transform.position)  //Se serra chegou ao destino
        {
            saw.goToInitialP = false; 
            saw.goToFinalP = true;  //Serra deve ir ao próximo ponto
        }

        

    }

    public void goToFinalPoint(Saw saw)  //Método para ir ao ponto final.
    {
        if (saw.transform.position != saw.finalP.transform.position && saw.goToFinalP)        
            saw.transform.position = Vector2.MoveTowards(saw.transform.position, saw.finalP.transform.position, saw.speed * Time.deltaTime); //Movimentar a serra

        if (saw.transform.position == saw.finalP.transform.position)  //Se serra chegou ao destino.
        { 
            saw.goToFinalP = false;
            saw.goToInitialP = true; //Serra deve ir ao próximo ponto (voltarpara o ponto inicial).
        }

    }

}
