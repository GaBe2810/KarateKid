using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JetBrains.Annotations;
using System.ComponentModel;
using TMPro;

public class Click : MonoBehaviour
{
    public GameObject caixaTexto;
    public GameObject sujeiraJogo;
    public GameObject display;
    public GameObject comeco;
    public GameObject cronometro;
    public Transform Jogo;
    public Transform gameOver;
    public Transform gameWinner;

    public TMP_Text sujText;
    int sujeiras = 0;
    public int limite;
    public GameObject sujAleatoria;

    [SerializeField] TextMeshProUGUI timerText;
    public float tempoAtual;

    public void SujLimpas()
    {
        if (sujeiras < limite) //Se o numero de sujeiras limpas for menor que o limite, o jogo ir� funcionar e contar as sujeiras e muda-las de posi��o 
        {
            sujeiras++;
            sujText.text = "Limpas: " + sujeiras;
            sujAleatoria.transform.position = new Vector3(Random.Range(0, 800), Random.Range(0, 350), 0); // A sujeira ir� mudar de posi��o aleatoriamente
        }
        if (sujeiras >= limite) // Caso o numero iguale limite, o jogador ir� ganhar
        {
            gameWinner.gameObject.SetActive(true); // a tela de vitoria aparecer�
            Jogo.gameObject.SetActive(false); // a tela do jogo desaparecer�
        }
    }
    public void Tempo()
    {
        tempoAtual -= 1 * Time.deltaTime;
        timerText.text = tempoAtual.ToString("0");

        if (tempoAtual <= 0) // Caso o Tempo seja menor que 0 segundos, o jogador perde
        {
            tempoAtual = 0;
            gameOver.gameObject.SetActive(true); // a tela de game over aparecer� 
            Jogo.gameObject.SetActive(false); // a tela do jogo desaparecer�
        }
    }
}