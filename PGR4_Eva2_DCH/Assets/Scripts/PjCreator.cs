using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Drawing;
using Unity.VisualScripting;
using System.IO;


public class PjCreator : MonoBehaviour
{
    public string characterID;
    public string selectedChara;
    private void Awake()
    {

    }
    public void Save()
    {
        JSONSaveSys saveSystem = new JSONSaveSys();
        PJSheetStruct pJSheetStruct = new PJSheetStruct(characterID, selectedChara);
        saveSystem.Save(pJSheetStruct, characterID);
    }
    //public void Load()
    //{
    //    JSONSaveSys saveSystem = new JSONSaveSys();
    //    PjSheet pjSheet = saveSystem.Load(characterID);
    //    characterID = pjSheet.characterID;
    //    selectedChara = pjSheet.selectedChara;
    //}
}
