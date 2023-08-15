using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.03f;
    [SerializeField]
    private float variacaoY;
    private Vector3 posicaoDoPlayer;
    private bool pontuei;
    private Pontuacao pontuacao;
    private void Awake() {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoY,variacaoY));
    }

    private void Start() {
        this.posicaoDoPlayer = GameObject.FindObjectOfType<Player>().transform.position;
        this.pontuacao = GameObject.FindObjectOfType<Pontuacao>();
    }
    private void Update()
    {
        this.transform.Translate(Vector3.left * this.velocidade * Time.deltaTime);
        if (!this.pontuei && this.transform.position.x < this.posicaoDoPlayer.x){
            this.pontuei = true;
            this.pontuacao.AdicionarPontos();
        }
        
    }

    private void OnTriggerEnter2D(Collider2D outro) {
            this.Destruir();
        }
    public void Destruir(){
        GameObject.Destroy(this.gameObject);
    }
}
