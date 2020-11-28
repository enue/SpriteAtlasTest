using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class AtlasLoader : MonoBehaviour
{
    [SerializeField]
    SpriteAtlas atlas = default;

    void OnEnable()
    {
        SpriteAtlasManager.atlasRequested += OnAtlasRequested;
    }
    void OnDisable()
    {
        SpriteAtlasManager.atlasRequested -= OnAtlasRequested;
    }

    void OnAtlasRequested(string tag, System.Action<SpriteAtlas> callback)
    {
        if (atlas.tag == tag)
        {
            callback(atlas);
        }
    }
}
