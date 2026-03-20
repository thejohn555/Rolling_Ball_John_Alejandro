using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource sfxSource;
    [SerializeField] private AudioClip[] soundsSource;
    
    
    public static AudioManager Instance{ get; private set; }

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void PlaySound(int index)
    {
        sfxSource.PlayOneShot(soundsSource[index]);
    }
}
