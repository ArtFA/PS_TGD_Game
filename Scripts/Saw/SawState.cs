using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Classe abstrata do estado da serra.

public abstract class SawState
{

    public abstract void execute(Saw saw);  //Implementa o que deve acontecer naquele estado.


}