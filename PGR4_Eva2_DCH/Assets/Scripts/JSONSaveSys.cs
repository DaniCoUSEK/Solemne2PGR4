using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class JSONSaveSys
{
    public const string pjSheetKey = "pjSheetKey";

    public void Save(PJSheetStruct pjSheetStruct, string key)
    {
        PjSheet pjSheet = new PjSheet(pjSheetStruct);
        string data = JsonUtility.ToJson(pjSheet);
        string path = Path.Combine(Application.streamingAssetsPath, key);
        try
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(data);
            }
        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
        }
    }
    public void Load(string key)
    {
        string path = Path.Combine(Application.streamingAssetsPath, key);
        try
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string data = sr.ReadToEnd();
                PjSheet pjSheet = JsonUtility.FromJson<PjSheet>(data);
            }
        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
        }
    }
}
