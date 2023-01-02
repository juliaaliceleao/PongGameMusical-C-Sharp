//Importacoes
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    PlayerRight
    Descrição:  Script para controlar player da direita(Right)
    Controles: UpArrow = Player vai para Cima DownArrow = Player vai para Baixo
*/

public class PlayerRight : MonoBehaviour
{
    //Atributos
    public bool playerRight; // Bool para verificar se o objeto PlayerRight existe
    public float speed;      // Velocidade do Player. Atribuido na Unity
    public float yMaximo;    // Movimento maximo do player
    public float yMinimo;    // Movimento maximo do player

    //Metodos
    /*  Update: Chamado uma vez a cada frame*/
    void Update()
    {
        if(playerRight == true) //se existe o Objeto playerRight
        {   
            movementPlayerRight();  //chamando metodo de movimento do player

            //verificando se o player esta dentro dos limites da camera
            transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, yMinimo, yMaximo), transform.position.z);
        }
    }

    /*  Movimento PlayerRight: UpArrow = Up DownArrow = Down  */
    public void movementPlayerRight()
    {
        //Se a tecla UpArrow do teclado foi pressionada
        if(Input.GetKey(KeyCode.UpArrow) == true)
        {
            //modificando a posição para cima
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }

        //Se a tecla DownArrow do teclado foi pressionada
        if(Input.GetKey(KeyCode.DownArrow) == true)
        {
            //modificando a posição para baixo
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
    }
}