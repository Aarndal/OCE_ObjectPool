using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class AudioClip
{
    public string audioName;
    public UnityEngine.AudioClip[] audioClip;
    [Range(0,1)]
    public float volume;
}
