using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    [Header("Música")]
    public AudioSource musicBackground;  // Loop, siempre reproduce
    public AudioSource musicSpace;       // Loop, solo durante Space

    [Header("SFX - clips")]
    public AudioClip clipBallSpawn;
    public AudioClip clipBallHitPeg;
    public AudioClip clipBallEnterZone;

    // Un solo AudioSource para todos los SFX (PlayOneShot permite superponerlos)
    private AudioSource sfxSource;
    // Source dedicado para pegs: permite cambiar pitch sin afectar otros SFX
    private AudioSource pegSfxSource;

    [Header("Variación de pitch en pegs")]
    [Range(0f, 0.5f)] public float pegPitchVariation = 0.15f;

    [Header("Volumen SFX")]
    [Range(0f, 2f)] public float scoreVolume = 1.5f;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        sfxSource = gameObject.AddComponent<AudioSource>();
        pegSfxSource = gameObject.AddComponent<AudioSource>();
    }

    void Start()
    {
        if (musicBackground != null)
        {
            musicBackground.loop = true;
            musicBackground.Play();
        }

        if (musicSpace != null)
        {
            musicSpace.loop = true;
            musicSpace.Stop();
        }
    }

    // --- SFX ---

    public void PlayBallSpawn()
    {
        if (clipBallSpawn != null)
            sfxSource.PlayOneShot(clipBallSpawn);
    }

    public void PlayBallHitPeg()
    {
        if (clipBallHitPeg == null) return;
        pegSfxSource.pitch = 1f + Random.Range(-pegPitchVariation, pegPitchVariation);
        pegSfxSource.PlayOneShot(clipBallHitPeg);
    }

    public void PlayBallEnterZone()
    {
        if (clipBallEnterZone != null)
            sfxSource.PlayOneShot(clipBallEnterZone, scoreVolume);
    }

    // --- Música Space ---

    // Silencia el background (sin detenerlo) y arranca la música Space
    public void StartSpaceMusic()
    {
        if (musicBackground != null)
            musicBackground.volume = 0f;

        if (musicSpace != null)
            musicSpace.Play();
    }

    // Para la música Space y devuelve el volumen al background
    public void StopSpaceMusic()
    {
        if (musicSpace != null)
            musicSpace.Stop();

        if (musicBackground != null)
            musicBackground.volume = 1f;
    }
}
