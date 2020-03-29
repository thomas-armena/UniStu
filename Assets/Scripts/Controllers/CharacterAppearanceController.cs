﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAppearanceController : MonoBehaviour
{
    public GameObject headObject;
    public GameObject bodyObject;
    public Sprite[] headSprites;
    public Sprite[] bodySprites;

    void Start()
    {
        SpriteRenderer headSpriteRenderer = this.headObject.GetComponent<SpriteRenderer>();
        SpriteRenderer bodySpriteRenderer = this.bodyObject.GetComponent<SpriteRenderer>();
        headSpriteRenderer.sprite = this.headSprites[GameData.instance.characterAppearance.bodySprite];
        bodySpriteRenderer.sprite = this.bodySprites[GameData.instance.characterAppearance.bodySprite];
    }

    void Update()
    {

    }

}