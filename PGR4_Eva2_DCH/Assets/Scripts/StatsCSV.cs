using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StatsCSV : MonoBehaviour
{
    public static int characterID;
    public int character;
    //public int currentValue;
    public TextAsset csvFile;

    public ResourcesScript resourcesScript;

    //[SerializeField] TMPro.TMP_Dropdown savedCharacterData;

    void Start()
    {
        CheckCSVFile();
        //resourcesScript.selectedChara = characterID.ToString();
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
        foreach (TextMeshProUGUI textComponent in texts)
        {
            string wordToFind = textComponent.text;
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i][0] == wordToFind)
                {
                    if (characterID == 0 && data[i].Length > 1)
                    {
                        textComponent.text = data[i][1];
                    }
                    else if (characterID == 1 && data[i].Length > 2)
                    {
                        textComponent.text = data[i][2];
                    }
                    else if (characterID == 2 && data[i].Length > 3)
                    {
                        textComponent.text = data[i][3];
                    }
                    break;
                }
            }
        }
    }
    public void Change1()
    {
        characterID = 0;
        //resourcesScript.selectedChara = characterID.ToString();
        //savedCharacterData.value = characterID;
        CheckCSVFile();
        SceneManager.LoadScene(0);
    }
    public void Change2()
    {
        characterID = 1;
        //resourcesScript.selectedChara = characterID.ToString();
        CheckCSVFile();
        SceneManager.LoadScene(0);
    }
    public void Change3()
    {
        characterID = 2;
        //resourcesScript.selectedChara = characterID.ToString();
        CheckCSVFile();
        SceneManager.LoadScene(0);
    }
}
