using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private AudioSource player; //Refer�ncia ao componente AudioSource
    [SerializeField] private AudioClip som; //Arquivo (Clip) de �udio a ser reproduzido

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GetComponent<AudioSource>(); //Guarda a refer�ncia do AudioSource
    }

    public void Jogar()
    {
        TocarSom(); //Chama a fun��o para tocar o som
        Invoke("Escolha", 1f); //Chama a fun��o SelecionaPersonagens ap�s 1 segundo
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
    public void fase0P2()
    {
        SceneManager.LoadScene("fase0P2");
    } public void fase0P3()
    {
        SceneManager.LoadScene("fase0P3");
    }
    public void portugues()
    {
        SceneManager.LoadScene("portugues");
    }
    public void Derrota()
    {
        SceneManager.LoadScene("Derrota");
    }   
    public void Vitoria()
    {
        SceneManager.LoadScene("Vitoria");
    }

    private void TocarSom()
    {
        player.PlayOneShot(som);
    }

}