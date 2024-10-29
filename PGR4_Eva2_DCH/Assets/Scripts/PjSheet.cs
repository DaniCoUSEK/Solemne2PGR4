using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PjSheet
{
    public string characterID;
    public string selectedChara;

    public PjSheet(PJSheetStruct pjSheetStruct)
    {
        characterID = pjSheetStruct.characterID;
        selectedChara = pjSheetStruct.selectedChara;
    }
}

public struct PJSheetStruct
{
    public string characterID;
    public string selectedChara;

    public PJSheetStruct(string characterID, string selectedChara)
    {
        this.characterID = characterID;
        this.selectedChara = selectedChara;
    }
}
