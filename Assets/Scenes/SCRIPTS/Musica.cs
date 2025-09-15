using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static MusicManager instance;

    [Header("Configura��es de �udio")]
    public AudioClip backgroundMusic;
    public AudioSource audioSource;

    [Range(0f, 1f)]
    public float volume = 0.7f;

    [Header("Configura��es de Fade")]
    public bool useFadeIn = true;
    public float fadeInDuration = 2f;

    void Awake()
    {
        // Implementar padr�o Singleton
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        // Configurar AudioSource se n�o estiver atribu�do
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
            if (audioSource == null)
            {
                audioSource = gameObject.AddComponent<AudioSource>();
            }
        }

        // Configurar propriedades do AudioSource
        audioSource.clip = backgroundMusic;
        audioSource.volume = volume;
        audioSource.loop = true;
        audioSource.playOnAwake = false;
    }

    void Start()
    {
        PlayMusic();
    }

    public void PlayMusic()
    {
        if (backgroundMusic == null)
        {
            Debug.LogWarning("Nenhuma m�sica atribu�da ao MusicManager");
            return;
        }

        if (useFadeIn)
        {
            StartCoroutine(FadeInMusic());
        }
        else
        {
            audioSource.Play();
        }
    }

    public void StopMusic()
    {
        audioSource.Stop();
    }

    public void PauseMusic()
    {
        audioSource.Pause();
    }

    public void ResumeMusic()
    {
        audioSource.UnPause();
    }

    public void ChangeMusic(AudioClip newMusic, bool fadeTransition = true)
    {
        if (fadeTransition)
        {
            StartCoroutine(TransitionToNewMusic(newMusic));
        }
        else
        {
            audioSource.Stop();
            audioSource.clip = newMusic;
            audioSource.Play();
        }
    }

    public void SetVolume(float newVolume)
    {
        volume = Mathf.Clamp01(newVolume);
        audioSource.volume = volume;
    }

    private System.Collections.IEnumerator FadeInMusic()
    {
        audioSource.volume = 0f;
        audioSource.Play();

        float timer = 0f;
        while (timer < fadeInDuration)
        {
            timer += Time.deltaTime;
            audioSource.volume = Mathf.Lerp(0f, volume, timer / fadeInDuration);
            yield return null;
        }

        audioSource.volume = volume;
    }

    private System.Collections.IEnumerator TransitionToNewMusic(AudioClip newMusic)
    {
        // Fade out da m�sica atual
        float originalVolume = audioSource.volume;
        float timer = 0f;

        while (timer < fadeInDuration)
        {
            timer += Time.deltaTime;
            audioSource.volume = Mathf.Lerp(originalVolume, 0f, timer / fadeInDuration);
            yield return null;
        }

        // Trocar a m�sica
        audioSource.Stop();
        audioSource.clip = newMusic;
        audioSource.volume = 0f;
        audioSource.Play();

        // Fade in da nova m�sica
        timer = 0f;
        while (timer < fadeInDuration)
        {
            timer += Time.deltaTime;
            audioSource.volume = Mathf.Lerp(0f, volume, timer / fadeInDuration);
            yield return null;
        }

        audioSource.volume = volume;
    }
}