using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    [SerializeField] private string cenaDoJogo;

    public void ProxFase() // Ao clicar no botão, do menu de ganhador, o jogador irá para a proxima fase
    {
        SceneManager.LoadScene(cenaDoJogo); //carrega a cena da proxima cena
    }
}
