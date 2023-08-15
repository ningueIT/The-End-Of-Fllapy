using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Pontuacao : MonoBehaviour
{
    public TextMeshProUGUI textoPontuacao;
    private int pontos;
    private GeradorDeObjs geradorDeObjs;

    private void Start()
    {
        geradorDeObjs = FindObjectOfType<GeradorDeObjs>(); // Encontre o componente GeradorDeObjs no início
    }

    public void AdicionarPontos()
    {
        this.pontos++;
        Debug.Log(this.pontos);
        this.textoPontuacao.text = this.pontos.ToString();

        // Verifique se a pontuação é um múltiplo de 5
        if (this.pontos % 5 == 0 && geradorDeObjs != null)
        {
            geradorDeObjs.AjustarVelocidade();
        }
    }

    public void Reiniciar()
    {
        this.pontos = 0;
        this.textoPontuacao.text = this.pontos.ToString();
    }

    public void DefinirGerador(GeradorDeObjs gerador)
    {
        geradorDeObjs = gerador;
    }
}
