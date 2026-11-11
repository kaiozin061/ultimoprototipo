using UnityEngine;

public class Dano : MonoBehaviour
{
    public int quantidadeDeDano = 10;

    private void OnTriggerEnter(Collider other)
    {
        VidaJogador vida = other.GetComponent<VidaJogador>();

        if (vida != null)
        {
            vida.ReceberDano(quantidadeDeDano);
        }
    }
}