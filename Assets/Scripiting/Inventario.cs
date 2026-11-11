using UnityEngine;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using TMPro;
using Unity.VisualScripting;
public class Inventario : MonoBehaviour
{
    public List<string> itens = new List<string>();
    [Header("Interface(UI)")]
    public GameObject painelinventario; public TextMeshProUGUI TextoItem;
    void Start()
    {
        painelinventario.SetActive(false);
        AtualizarTela();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.iKey.wasPressedThisFrame)
        {
            painelinventario.SetActive(!painelinventario.activeSelf);
        }
    }

    public void AdicionarItem(string nomeDoItem)
    {
        itens.Add(nomeDoItem);
        Debug.Log("Guardou no inventario: " + nomeDoItem);
        AtualizarTela();
    }
    void AtualizarTela()
    {
        if (itens.Count == 0)
        {
            TextoItem.text = "Inventário Vazio";
        }
        else
        {
            TextoItem.text = "";
            foreach (string item in itens)
            {
                TextoItem.text += item + "\n";
            }
        }
    }
    public bool TemItem(string nomeItem)
    {
        return itens.Contains(nomeItem);
    }
}
