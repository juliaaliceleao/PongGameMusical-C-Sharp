using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PainelBotaoInstrucoes : MonoBehaviour
{
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