using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script para receber inputs do jogador.

public class PlayerInput : MonoBehaviour
{
    public static bool onMoveRight()   //Retorna true se jogador apertar a seta para direita.
    {
        if (Input.GetKey(KeyCode.RightArrow))
            return true;
        else
            return false;
    }

    public static bool onMoveLeft()   //Retorna true se jogador apertar a seta para esquerda.
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            return true;
        else
            return false;
    }

    public static float horizontalDir()   //Retorna direção horizontal do jogador (positivo se apertada tecla direita ou negativo se apertada tecla esquerda).
    {
        return Input.GetAxis("Horizontal");
    }

    public static float verticalDir()   //Retorna direção horizontal do jogador (positivo se apertada tecla direita ou negativo se apertada tecla esquerda).
    {
        return Input.GetAxis("Vertical");
    }

    public static bool onJump()   //Retorna true se jogador apertar a seta para cima.
    {
        if (Input.GetKey(KeyCode.UpArrow))
            return true;
        else
            return false;
    }

    public static bool onDown()   //Retorna true se jogador apertar a seta para baixo.
    {
        if (Input.GetKey(KeyCode.DownArrow))
            return true;
        else
            return false;
    }
}
