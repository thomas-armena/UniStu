using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CharacterAppearance
{
    public int Head { get; set; }
    public int Body { get; set; }
    public string Url { get; set; }

    public CharacterAppearance(int head=0, int body=0)
    {
        Head = head;
        Body = body;
    }

}
