using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Audio/Audio Clip Library", fileName = "newAudioClipLibrary")]
public class AudioClipLibrary : ScriptableObject
{
    public AudioClip[] audioClips;
    public Dictionary<string, AudioClip> audioClipDictionary;

    private void OnEnable()
    {
        audioClipDictionary = new Dictionary<string, AudioClip>();

        foreach (var audioClip in audioClips)
        {
            audioClipDictionary.Add(audioClip.audioName, audioClip);
        }
    }
}
