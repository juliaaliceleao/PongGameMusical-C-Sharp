using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PainelGameOver : MonoBehaviour
{
 
    public GameObject painelGameOver;
    
    //Metodos

    //Reinicia Partida - Ja dentro do Game
     public void ReiniciarPartida()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("Reiniciou o Jogo PongGame Atual");
    }

    //Sai da Partida
    public void SairPartida()
    {
        SceneManager.LoadScene("PongMenu");
        Debug.Log("Saiu da Partida");
    }

    //Sai do Jogo
    public void SairJogo()
    {
        Application.Quit();
        Debug.Log("Saiu do Jogo");
    }

    public GameObject painelMenuTemas;
    
    //Abre Menu Jogar
    public void MenuJogar()
    {
        painelMenuTemas.SetActive(true);
        Debug.Log("Abriu o Menu de Jogar");
    }
    //Fecha Temas - Menu Jogar
    public void FecharMenuJogar()
    {
        painelMenuTemas.SetActive(false);
        Debug.Log("Fechou Menu de Jogar");
    }

    //Inicia Partida - Menu do tema/Jogar
    public void IniciarPartidaCavetown()
    {
        SceneManager.LoadScene("PongGameCavetown");
        Debug.Log("Iniciou o Jogo PongGame Cavetown");
    }

    //Inicia Partida - Menu do tema/Jogar
    public void IniciarPartidaLiniker()
    {
        SceneManager.LoadScene("PongGameLiniker");
        Debug.Log("Iniciou o Jogo PongGame Liniker");
    }
    public GameObject painelMenuInstrucoes;
    
    //Abre Instrucoes - Menu Principal
    public void MenuInstrucoes()
    {
        painelMenuInstrucoes.SetActive(true);
        Debug.Log("Abriu o Menu de Instrucoes");
    }
    //Fecha Instrucoes - Menu Principal
    public void FecharInstrucoes()
    {
        painelMenuInstrucoes.SetActive(false);
        Debug.Log("Fechou Menu de Instrucoes");
    }
}
