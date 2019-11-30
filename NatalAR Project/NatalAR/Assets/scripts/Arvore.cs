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

    private void Start()
    {
        carregarArvore();
    }

    public void carregarArvore()
    {
        // Desativando
        for (int i = 0; i < troncos.Length; i++)
        {
            troncos[i].SetActive(false);
        }

        for (int i = 0; i < vegetacoes.Length; i++)
        {
            vegetacoes[i].SetActive(false);
        }

        for (int i = 0; i < enfeites.Length; i++)
        {
            enfeites[i].SetActive(false);
        }

        for (int i = 0; i < presentes.Length; i++)
        {
            presentes[i].SetActive(false);
        }

        for (int i = 0; i < estrelas.Length; i++)
        {
            estrelas[i].SetActive(false);
        }

        // Ativando
        vegetacoes[codTronco].SetActive(true);
        troncos[codTronco].SetActive(true);
        vegetacoes[codVegetacao].SetActive(true);
        estrelas[codEstrela].SetActive(true);
        presentes[codPresente].SetActive(true);
        enfeites[codEnfeite].SetActive(true);
    }


}


