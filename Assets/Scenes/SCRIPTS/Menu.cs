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
    public void Geografia()
    {
        SceneManager.LoadScene("GeografiaInicio");
    } 
    public void fase1G()
    {
        SceneManager.LoadScene("fase1G");
    } 
    public void IntroducaoING()
    {
        SceneManager.LoadScene("IntroducaoING");
    } 
    public void Ingles1()
    {
        SceneManager.LoadScene("Ingles1");
    } public void fase1ING()
    {
        SceneManager.LoadScene("fase1ING");
    } public void fase1ING2()
    {
        SceneManager.LoadScene("fase1ING2");
    } 
    public void fase1ING1()
    {
        SceneManager.LoadScene("fase1ING1");
    }
    public void fase1ING3()
    {
        SceneManager.LoadScene("fase1ING3");
    } 
    public void fase1ING4()
    {
        SceneManager.LoadScene("fase1ING4");
    } public void fase1ING5()
    {
        SceneManager.LoadScene("fase1ING5");
    } public void fase1ING6()
    {
        SceneManager.LoadScene("fase1ING6");
    } 
    public void fase1ING7()
    {
        SceneManager.LoadScene("fase1ING7");
    } public void fase1ING8()
    {
        SceneManager.LoadScene("fase1ING8");
    } public void fase1ING9()
    {
        SceneManager.LoadScene("fase1ING9");
    } 
    public void fase2G()
    {
        SceneManager.LoadScene("fase2G");
    }
    public void fase3G()
    {
        SceneManager.LoadScene("fase3G");
    } 
    public void fase4G()
    {
        SceneManager.LoadScene("fase4G");
    }public void fase5G()
    {
        SceneManager.LoadScene("fase5G");
    }
    public void introducaoP()
    {
        SceneManager.LoadScene("introducaoP");
    } 
    public void introducaoM()
    {
        SceneManager.LoadScene("introducaoM");
    }
    public void introducaoG()
    {
        SceneManager.LoadScene("introducaoG");
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
    public void fase1M()
    {
        SceneManager.LoadScene("fase1M");
    }
    public void fase2M()
    {
        SceneManager.LoadScene("fase2M");
    }
    public void fase3M()
    {
        SceneManager.LoadScene("fase3M");
    }
    public void fase4M()
    {
        SceneManager.LoadScene("fase4M");
    }
     public void fase5M()
    {
        SceneManager.LoadScene("fase5M");
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