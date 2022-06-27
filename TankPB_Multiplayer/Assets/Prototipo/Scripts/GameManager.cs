using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager controlador;
    [SerializeField]
    Text pontuacao;
    [SerializeField]
    Text cronometro;
    [SerializeField]
    Text tempoFinal;

    public GameObject menuI;
    public GameObject menuF;
    public GameObject hud;

    float tempo = 0;
    int pontos = 0;
    public float tempoMax;
    private void Awake()
    {
        Time.timeScale = 0;
        controlador = this;
    }
    private void Start()
    {
        menuF.SetActive(false);
        hud.SetActive(false);
    }
    public void GanharPontos()
    {
        pontos += 1;
        pontuacao.text = "Alvos: " + pontos;
        if(pontos >= 5)
        {
            FinalJogo();
        }
    }
    private void Update()
    {
        Cronometro();
    }
    void Cronometro()
    {
        tempo += Time.deltaTime;
        tempoMax = tempo;
        cronometro.text = "Tempo: " + tempo;
    }
    public void Jogar()
    {
        hud.SetActive(true);
        Time.timeScale = 1;
        menuI.SetActive(false);
    }
    public void FinalJogo()
    {
        Time.timeScale = 0;
        hud.SetActive(false);
        menuF.SetActive(true);
        tempoFinal.text = "Seu tempo final: " + tempoMax;
    }
    public void JogarNovamente()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
