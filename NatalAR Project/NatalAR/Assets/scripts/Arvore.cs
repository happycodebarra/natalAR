using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    [Header("Entrada e Saida")]
    public InputField[] inputFields;

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

    public void updateFields(bool _input)
    {
        if (!_input)
        {
            for (int i = 0; i < inputFields.Length; i++)
            {
                if (i == 0)
                    inputFields[i].text = (codTronco+1).ToString();
                else if (i == 1)
                    inputFields[i].text = (codVegetacao+1).ToString();
                else if (i == 2)
                    inputFields[i].text = (codEstrela+1).ToString();
                else if (i == 3)
                    inputFields[i].text = (codPresente+1).ToString();
                else if (i == 4)
                    inputFields[i].text = (codEnfeite+1).ToString();
            }
        }
        
        else
        {
            for (int i = 0; i < inputFields.Length; i++)
            {
                if (i == 0)
                    codTronco = System.Int32.Parse(inputFields[i].text)-1;
                else if (i == 1)
                    codVegetacao = System.Int32.Parse(inputFields[i].text)-1;
                else if (i == 2)
                    codEstrela = System.Int32.Parse(inputFields[i].text)-1;
                else if (i == 3)
                    codPresente = System.Int32.Parse(inputFields[i].text)-1;
                else if (i == 4)
                    codEnfeite = System.Int32.Parse(inputFields[i].text)-1;
            }

            carregarArvore();
        }
    }
}


