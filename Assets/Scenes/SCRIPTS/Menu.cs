using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private AudioSource player; //Referência ao componente AudioSource
    [SerializeField] private AudioClip som; //Arquivo (Clip) de áudio a ser reproduzido

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GetComponent<AudioSource>(); //Guarda a referência do AudioSource
    }

    public void Jogar()
    {
        TocarSom(); //Chama a função para tocar o som
        Invoke("Escolha", 1f); //Chama a função SelecionaPersonagens após 1 segundo
    }

    public void Creditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void TelaInicial()
    {
        SceneManager.LoadScene("TelaInicial");
    }

    public void Escolha()
    {
        SceneManager.LoadScene("Escolha");
    }

    public void matematica()
    {
        SceneManager.LoadScene("matematica");
    } 
    public void matematicaEscolha()
    {
        SceneManager.LoadScene("matematicaEscolha");
    }
    public void Fase0M()
    {
        SceneManager.LoadScene("Fase0M");
    }        
    public void Fase1M()
    {
        SceneManager.LoadScene("Fase1M");
    }   
    public void Fase2M()
    {
        SceneManager.LoadScene("Fase2M");
    }    
    public void Fase3M()
    {
        SceneManager.LoadScene("Fase3M");
    }

    public void Pergunta1()
    {
        SceneManager.LoadScene("Pergunta1");
    }
    public void PortuguesEscolha()
    {
        SceneManager.LoadScene("PortuguesEscolha");
    }

    public void fase0P()
    {
        SceneManager.LoadScene("fase0P");
    }
    public void fase0P1()
    {
        SceneManager.LoadScene("fase0P1");
    }
    public void portugues   ()
    {
        SceneManager.LoadScene("portugues");
    }
    public void Obrigado()
    {
        SceneManager.LoadScene("Obrigado");
    }

    private void TocarSom()
    {
        player.PlayOneShot(som);
    }

}