using System;
using System.Collections.Generic;
using UnityEngine;

public class SpriteLibrary : MonoBehaviour 
{
    public ObjectSprite[] objectSprites = null;
    private static List<ObjectSprite> objectSpriteList = new List<ObjectSprite>();

    private void Awake()
    {
        InitializeSpriteList(objectSprites);
    }

    private static void InitializeSpriteList(ObjectSprite[] _sprites) 
    {
        foreach (ObjectSprite sprite in _sprites)
            objectSpriteList.Add(sprite);
    }

    public static Sprite Get(string _name) 
    {
        if (_name == null || _name == "")
            return null;

        foreach (ObjectSprite sprite in objectSpriteList) 
        {
            if (sprite.name == _name)
                return sprite.sprite;
        }
        Debug.LogWarning($"No Sprites was found as {_name}");
        return null;
    }
}

[Serializable]
public struct ObjectSprite 
{
    public Sprite sprite;
    public string name;
}