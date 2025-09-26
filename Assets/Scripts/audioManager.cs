using UnityEngine;

public class audioManager : MonoBehaviour
{
    [Header("--------Music--------")]
    [SerializeField] AudioSource music;
    [SerializeField] AudioSource sfx;

    [Header("")]
    public AudioClip click;
    public AudioClip dead;
    public AudioClip song;
    public AudioClip bounce;
    public static audioManager instance;

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    void Start()
    {
        music.clip = song;
        music.Play();
    }

    public void SFX(AudioClip clip)
    {
        sfx.PlayOneShot(clip);
    }
}
