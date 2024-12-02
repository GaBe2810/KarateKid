using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Sujeiras : Click // a classe Sujeira est� herdando da classe Click
{
    
    void Start()
    {
        Time.timeScale = 0f; //Ao se igualar a 0, o jogo pausar�
        SujLimpas(); // Est� chamando a fun��o SujLimpas
    }

    // Update is called once per frame
    void Update()
    {
        Tempo(); // Est� chamando a fun��o Tempo
    }

    public void BotaoComecar() // Ao clicar no bot�o de iniciar, o jogo ir� come�ar e ir� ativar suas configura��es
    {
        caixaTexto.SetActive(false); // O titulo da fase ser� desativado
        sujeiraJogo.SetActive(true); // As sujeiras ser�o ativadas
        display.SetActive(true); // O contador ser� ativado
        comeco.SetActive(false); // O bot�o de come�o ser� desativado
        cronometro.SetActive(true); // O cronometro ser� ativado
        Time.timeScale = 1.0f; // O tempo do jogo voltar� a rodar
    }

}
