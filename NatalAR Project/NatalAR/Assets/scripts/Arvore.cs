using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arvore : MonoBehaviour
{

    [Header("Corpo da arvore")]
    public GameObject[] troncos;
    public GameObject[] vegetacoes;
    public GameObject[] estrelas;
    public GameObject[] enfeites;
    public GameObject[] presentes;

    [Header("Codigo da arvore")]
    public int codTronco;
    public int codVegetacao;
    public int codEstrela;
    public int codEnfeite;
    public int codPresente;

    public void carregarArvore()
    {
        for (int i = 0; i < troncos.Length; i++)
        {
            troncos[i].SetActive(false);
        }



        vegetacoes[codTronco].SetActive(false);
        troncos[codTronco].SetActive(true);
        vegetacoes[codVegetacao].SetActive(false);
        estrelas[codEstrela].SetActive(false);
        presentes[codPresente].SetActive(false);

    }
}


