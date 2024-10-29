using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TranslateCSV : MonoBehaviour
{
    public static bool english = true;
    public static bool spanish = false;
    public TextAsset csvFile;

    void Start()
    {
        CheckCSVFile();
    }
    public void CheckCSVFile()
    {
        if (csvFile != null)
        {
            List<string[]> data = ReadCSVFile(csvFile.text);
            TextMeshProUGUI[] texts = FindObjectsOfType<TextMeshProUGUI>();
            UpdateText(texts, data);
        }
        else
        {
            Debug.LogError("No CSV file found");
        }
    }
    public List<string[]> ReadCSVFile(string csvText)
    {
        List<string[]> data = new List<string[]>();

        string[] lines = csvText.Split('\n');

        foreach (string line in lines)
        {
            string[] values = line.Split(',');
            data.Add(values);
        }
        return data;
    }
    void UpdateText(TextMeshProUGUI[] texts, List<string[]> data)
    {
        foreach(TextMeshProUGUI textComponent in texts)
        {
            string wordToFind = textComponent.text;
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i][0] == wordToFind)
                {
                    if (english && data[i].Length > 1)
                    {
                        textComponent.text = data[i][1];
                    }
                    else if (spanish && data[i].Length > 2)
                    {
                        textComponent.text = data[i][2];
                    }
                    break;
                }
            }
        }
    }
    public void ChangeLanguage()
    {
        english =! english;
        spanish =! spanish;
        SceneManager.LoadScene(0);
    }
}
