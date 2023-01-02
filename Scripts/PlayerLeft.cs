//Importacoes
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    PlayerLeft
    Descrição:  Script para controlar player da esquerda(Left)
    Controles: W = Player vai para Cima S = Player vai para Baixo
*/

public class PlayerLeft : MonoBehaviour
{
    //Atributos
    public float speed;      // Velocidade do Player. Atribuido na Unity
    public float yMaximo;    // Movimento maximo do player
    public float yMinimo;    // Movimento maximo do player
    public bool playerLeft; // Bool para verificar se o objeto PlayerLeft existe

    //Metodos
    /*  Update: Chamado uma vez a cada frame*/
    void Update()
    {
        if(playerLeft == true) //se existe o Objeto playerLeft
        {   
            movementPlayerLeft();//chamando metodo de movimento do player

            //verificando se o player esta dentro dos limites da camera
            transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, yMinimo, yMaximo), transform.position.z);
        }
    }

    /*  Movimento PlayerLeft: W = Up S = Down  */
    public void movementPlayerLeft()
    {
        //Se a tecla W do teclado foi pressionada
        if(Input.GetKey(KeyCode.W) == true)
        {
            //modificando a posição para cima
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }

        //Se a tecla S do teclado foi pressionada
        if(Input.GetKey(KeyCode.S) == true)
        {   
            //modificando a posição para baixo
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
    }
}