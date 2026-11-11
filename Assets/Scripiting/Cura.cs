using UnityEngine;

public class Cura : MonoBehaviour
{
    public int quantidadeDeCura = 20;

    private void OnTriggerEnter(Collider other)
    {
        VidaJogador vida = other.GetComponent<VidaJogador>();

        if (vida != null)
        {
            vida.Curar(quantidadeDeCura);
            Destroy(gameObject);
        }
    }
}
