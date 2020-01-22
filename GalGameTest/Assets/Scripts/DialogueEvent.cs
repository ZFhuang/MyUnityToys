using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DialogueEvent : MonoBehaviour {
    private static TextAsset _dialogue;

    public void loadDialog(ref TextAsset dialogue)
    {
        _dialogue = dialogue;
    }

    public void startDialog()
    {

    }
}
