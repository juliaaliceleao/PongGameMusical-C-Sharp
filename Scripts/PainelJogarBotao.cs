using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PainelJogarBotao : MonoBehaviour
{
 
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
}
