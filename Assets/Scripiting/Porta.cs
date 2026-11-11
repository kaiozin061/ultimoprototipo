using UnityEngine;
using UnityEngine.SceneManagement;

public class Porta : MonoBehaviour
{
    [Header("Configuração da Porta")]
    public bool correta = false;
    public bool aberta = false;

    [Header("Item Necessário")]
    public string itemNecessario = "Chave";

    [Header("Movimento ao abrir")]
    public Vector3 direcao = Vector3.right;
    public float distanciaAbrir = 1.5f;
    public float velocidade = 2f;

    [Header("Próxima Fase")]
    public string proximaFase = "Fase2";
    public float tempoAntesDaTroca = 2f;

    private Vector3 posicaoAberta;

    void Start()
    {
        posicaoAberta = transform.position + direcao.normalized * distanciaAbrir;
    }

    public string Interagir(Inventario inventario)
    {
        // Se estiver com a chave errada
        if (inventario.TemItem("ChaveErrada"))
        {
            SceneManager.LoadScene("GameOver");
            return "";
        }

        // Se não tiver a chave correta
        if (!inventario.TemItem("Chave"))
        {
            return "Você precisa da chave!";
        }
       
        // Abre a porta correta
        if (correta)
        {
            aberta = true;
            Invoke(nameof(IrParaProximaFase), tempoAntesDaTroca);
            return "Você acertou a chave!";
        }

        return "Trancada! Tente outra porta.";
    }
    void IrParaProximaFase()
    {
        SceneManager.LoadScene(proximaFase);
    }
}