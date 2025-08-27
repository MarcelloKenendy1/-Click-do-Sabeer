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

    public void Pergunta1()
    {
        SceneManager.LoadScene("Pergunta1");
    }
    public void artefato()
    {
        SceneManager.LoadScene("artefato");
    }

    public void Espada()
    {
        SceneManager.LoadScene("Espada");
    }
    public void Espada1()
    {
        SceneManager.LoadScene("Espada1");
    }
    public void Espada2()
    {
        SceneManager.LoadScene("Espada2");
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