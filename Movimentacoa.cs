using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movimentacoa : MonoBehaviour
{
    public Transform menuTreinos;
    Vector3 movimento;
    

    // Start is called before the first frame update
    void Start()
    {
        movimento = new Vector3(-6.9f, 0.5f, -5.8f);
        transform.position = movimento;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1f) // O Personagem andará quando o timeScale for igual a 1f, ou seja, quando o jogo não estiver pausado 
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                if (transform.position.z <= 6.5)
                {
                    movimento.z = 0.1f;
                    movimento.x = 0f;
                    movimento.y = 0f;
                    transform.Translate(movimento);
                }
            }
            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                if (transform.position.z >= -6.5)
                {
                    movimento.z = -0.1f;
                    movimento.x = 0f;
                    movimento.y = 0f;
                    transform.Translate(movimento);
                }
            }
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                if (transform.position.x >= -6.9)
                {
                    movimento.x = -0.1f;
                    movimento.z = 0f;
                    movimento.y = 0f;
                    transform.Translate(movimento);
                }
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                if (transform.position.x <= 6.9)
                {
                    movimento.x = 0.1f;
                    movimento.z = 0f;
                    movimento.y = 0f;
                    transform.Translate(movimento);
                }
            }
        }
        
    } 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag ("Miyagi")) // Ao colidir com o GameObject com a tag Miyagi, o jogo abrirá o menu pros treinos
        {
            menuTreinos.gameObject.SetActive(true); // O menu ficará ativo
            Time.timeScale = 0f; // Ao se igualar a 0, o jogo pausará
        }
    }
}
