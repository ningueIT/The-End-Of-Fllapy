using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObjs : MonoBehaviour
{
    [SerializeField]
    private float tempoParaGerar;
    [SerializeField]
    private GameObject manualDeExtrucoes;
    private float cronometro;
    private float velocidadeInicial;

    private void Awake()
    {
        this.cronometro = this.tempoParaGerar;
        this.velocidadeInicial = this.tempoParaGerar; // Defina a velocidade inicial
    }
    void Update(){
        this.cronometro -= Time.deltaTime;
        if(this.cronometro < 0)
        {
            GameObject.Instantiate(this.manualDeExtrucoes,this.transform.position, Quaternion.identity);
            this.cronometro = this.tempoParaGerar;
        }
    }
    public void AjustarVelocidade()
    {
        tempoParaGerar -= 0.5f; // Ajuste a velocidade aqui como desejado
    }
}