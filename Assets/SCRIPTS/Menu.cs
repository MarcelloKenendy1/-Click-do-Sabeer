using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
  
    void Start()
    {
       
    }

    public void Jogar()
    {
       
        Invoke("SelecionaPersonagens", 1f); //Chama a função SelecionaPersonagens após 1 segundo
    }

    public void Creditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void TelaInicial()
    {
        SceneManager.LoadScene("TelaInicial");
    }

    public void Fase1()
    {
        SceneManager.LoadScene("Fase1");
    }

    public void portugues()
    {
        SceneManager.LoadScene("portugues");
    }

    public void matematica()
    {
        SceneManager.LoadScene("matematica");
    }
    public void ciencias()
    {
        SceneManager.LoadScene("ciencias");
    }
    public void geografia()
    {
        SceneManager.LoadScene("geografia");
    }
}
       
