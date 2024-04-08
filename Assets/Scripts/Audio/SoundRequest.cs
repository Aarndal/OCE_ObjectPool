using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundRequest
{
    public string AudioClipName { get; set; }
    public Vector3 Position { get; set; }
    public Transform ParentObject { get; set; }
    public bool Is2D { get; set; }

    private SoundRequest(string _audioClipName, Vector3 _position, Transform _parentObject, bool _is2D)
    {
        AudioClipName = _audioClipName;
        Position = _position;
        ParentObject = _parentObject;
        Is2D = _is2D;
    }

    public static SoundRequest CreateRequest(string _audioClipName)
    {
        return new SoundRequest(_audioClipName , Vector3.zero, null, true);
    }
}
