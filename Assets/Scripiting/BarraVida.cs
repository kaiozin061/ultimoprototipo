using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class VidaJogador : MonoBehaviour
{
    public int vidaMaxima = 100;
    public int vidaAtual;

    public Slider barraDeVida;

    void Start()
    {
        vidaAtual = vidaMaxima;
        barraDeVida.maxValue = vidaMaxima;
        barraDeVida.value = vidaAtual;
    }

    public void ReceberDano(int dano)
    {
        vidaAtual -= dano;

        if (vidaAtual < 0)
            vidaAtual = 0;

        barraDeVida.value = vidaAtual;

        if (vidaAtual <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    public void Curar(int cura)
    {
        vidaAtual += cura;

        if (vidaAtual > vidaMaxima)
            vidaAtual = vidaMaxima;

        barraDeVida.value = vidaAtual;
    }
}