using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Classe abstrata do estado da fruta.
public abstract class FruitState
{
    public abstract void execute(Fruit fruit);  //Implementa o que deve acontecer naquele estado.

}

