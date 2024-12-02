using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Sujeiras : Click // a classe Sujeira está herdando da classe Click
{
    
    void Start()
    {
        Time.timeScale = 0f; //Ao se igualar a 0, o jogo pausará
        SujLimpas(); // Está chamando a função SujLimpas
    }

    // Update is called once per frame
    void Update()
    {
        Tempo(); // Está chamando a função Tempo
    }

    public void BotaoComecar() // Ao clicar no botão de iniciar, o jogo irá começar e irá ativar suas configurações
    {
        caixaTexto.SetActive(false); // O titulo da fase será desativado
        sujeiraJogo.SetActive(true); // As sujeiras serão ativadas
        display.SetActive(true); // O contador será ativado
        comeco.SetActive(false); // O botão de começo será desativado
        cronometro.SetActive(true); // O cronometro será ativado
        Time.timeScale = 1.0f; // O tempo do jogo voltará a rodar
    }

}
