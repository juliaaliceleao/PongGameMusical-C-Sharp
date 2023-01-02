//Importacoes
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Ball
    Descrição:  Script para controlar a Bola
*/

public class Ball : MonoBehaviour
{
    //Atributos
    public GameObject painelGameOver;

    private Rigidbody2D objRigidbody2D;  //Rigid Body da Bola
    public float speed = 220; //velocidade da bola

    public float x;
    public float y;

    // Metodo Start: Executado assim que o jogo se inicia
    void Start()
    {
        objRigidbody2D = GetComponent<Rigidbody2D> ();
        //estabelecendo a velocidade da bola. 
        //Time.deltaTime: mantem a velocidade constante independente do sistema utilizado
        objRigidbody2D.velocity = new Vector2(3,3);   
    }
}
