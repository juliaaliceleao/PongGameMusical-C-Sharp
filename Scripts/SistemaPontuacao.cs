//Importacoes
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaPontuacao : MonoBehaviour
{
    //Atributos
    public bool golLeft;    //bool para detectar movimento no gol da esquerda
    public bool golRight;   //bool para detectar movimento no gol da direita
    
    //Metodos
    /*  OnTriggerEnter2D: Caso detecte movimento na parede direira 
        ou esquerda marca ponto e recomeca o jogo   */
    void OnTriggerEnter2D(Collider2D other)
    {
        if(golLeft == true) //se houve alguma colisao com o gol  direito
        {
            //Ponto para lado Direito e bola volta a Posicao inicial
            FindObjectOfType<GameManager>().GamePointRight();
            FindObjectOfType<Ball>().transform.position = new Vector3(0, 0,0);
        }
        
        if(golRight == true) //se houve alguma colisao com o gol direito
        {
            //Ponto para lado Esquerdo e bola volta a Posicao inicial
            FindObjectOfType<GameManager>().GamePointLeft();
            FindObjectOfType<Ball>().transform.position = new Vector3(0, 0,0);
        }
    }  
}
