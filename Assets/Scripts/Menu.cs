using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    
    [SerializeField] private string NomeDoLevelDeJogo;

    public void Jogar(){
        SceneManager.LoadScene(NomeDoLevelDeJogo);
    }

    public void SairJogo(){
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }
}
