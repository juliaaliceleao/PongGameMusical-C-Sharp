using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    //Armazenar a pontuacao
    public int pontuacaoLeft = 0;
    public int pontuacaoRight = 0;

    //Mudando o placar na interface do usuario
    //texto
    public Text txtPontuacaoRight;
    public Text txtPontuacaoLeft;

    public GameObject painelGameOver;

    //Sombreado do texto
    public Text txtPontuacaoSombraRight;
    public Text txtPontuacaoSombraLeft;

    void Start()
    {
        pontuacaoRight = -1;
        pontuacaoLeft = -1;
        painelGameOver.SetActive(false);
        GamePointLeft();
        GamePointRight();
    }
    
    void Update()
    {
        /*verificando se a partida acabou 
        o primeiro player a marcar 10 gols*/
        if(pontuacaoLeft == 10 || pontuacaoRight == 10)
        {
            pontuacaoLeft = 0;
            pontuacaoRight = 0;
            Debug.Log("GameOver");
            GameOver();
        }
    }
    public void GamePointLeft()
    {
        if(painelGameOver.activeSelf == false)
        {
            pontuacaoLeft++;
            txtPontuacaoLeft.text = (pontuacaoLeft + " ");
            txtPontuacaoSombraLeft.text = (pontuacaoLeft + " ");
        }
    }
    public void GamePointRight()
    {
        if(painelGameOver.activeSelf == false)
        {
            pontuacaoRight++;
            txtPontuacaoRight.text = (pontuacaoRight + " ");
            txtPontuacaoSombraRight.text = (pontuacaoRight + " ");
        }
    }
    public void GameOver()
    {
        painelGameOver.SetActive(true);   
    }
}