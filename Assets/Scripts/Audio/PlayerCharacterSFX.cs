using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterSFX : MonoBehaviour
{
    [SerializeField] private SoundRequestCollection srCollection;
    
    public void OnPCIsWalking(string _audioName)
    {
        srCollection.Add(SoundRequest.CreateRequest(_audioName));
    }
}
