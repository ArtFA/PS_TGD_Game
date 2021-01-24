using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Classe abstrata do estado do jogador.

public abstract class PlayerState
{

    public abstract void execute(Player player);  //Implementa o que deve acontecer naquele estado.


}