using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAppearanceController : MonoBehaviour
{
    public GameObject headObject;
    public GameObject bodyObject;
    public Sprite[] headSprites;
    public Sprite[] bodySprites;
    public Sprite uploadedHead;

    void Start()
    {
        uploadedHead = Resources.Load<Sprite>(GameData.Instance.CharacterAppearance.Url);
    }


    void Update()
    {
        SpriteRenderer headSpriteRenderer = this.headObject.GetComponent<SpriteRenderer>();
        SpriteRenderer bodySpriteRenderer = this.bodyObject.GetComponent<SpriteRenderer>();
        headSpriteRenderer.sprite = this.headSprites[GameData.Instance.CharacterAppearance.Head];
        bodySpriteRenderer.sprite = this.bodySprites[GameData.Instance.CharacterAppearance.Body];
    }

}
