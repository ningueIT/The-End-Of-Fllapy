using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    [SerializeField]
    private GameObject imagemGameOver;
    private Player player;
    private Pontuacao pontucao;
    private void Start() {
        this.player = GameObject.FindObjectOfType<Player>();
        this.pontucao = GameObject.FindObjectOfType<Pontuacao>();
    }
    public void FinalizarJogo(){
        Time.timeScale = 0;
        this.imagemGameOver.SetActive(true);
    }

    public void ReiniciarJogo(){
        this.imagemGameOver.SetActive(false);
        Time.timeScale = 1;
        this.player.Reiniciar();
        this.destruirObstaculos();
        this.pontucao.Reiniciar();
    }

    private void destruirObstaculos(){
        Obstaculo[] obstaculos = GameObject.FindObjectsOfType<Obstaculo>();
        foreach(Obstaculo obstaculo in obstaculos){
            obstaculo.Destruir();
            }
        }
    }
