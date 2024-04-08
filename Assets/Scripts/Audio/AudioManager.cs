using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private SoundRequestCollection srCollection;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClipLibrary audioClipLibrary;

    private void Start()
    {
        srCollection.OnAdd += OnSoundRequest;
    }

    private void OnSoundRequest(SoundRequest request)
    {
        AudioClip tmp;
        audioClipLibrary.audioClipDictionary.TryGetValue(request.AudioClipName, out tmp);

        int rnd = 0;

        if (tmp.audioClip.Length > 0)
            rnd = UnityEngine.Random.Range(0, tmp.audioClip.Length);

        audioSource.PlayOneShot(tmp.audioClip[rnd], tmp.volume);
        
        //audioSource.clip = tmp.audioClip[0];
        //audioSource.volume = tmp.volume;
        //audioSource.Play();
    }
}
