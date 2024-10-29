using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diccionario : MonoBehaviour
{
    Dictionary<Vector2Int, string> CreateTableDictionary(List<string[]> csvData)
    {
        Dictionary<Vector2Int, string> tableDictionary = new Dictionary<Vector2Int, string>();
        for (int i = 0; i < csvData.Count; i++)
        {
            string[] line = csvData[i];
            for (int j = 0; j < line.Length; j++)
            {
                Vector2Int pos = new Vector2Int(i, j);
                tableDictionary.Add(pos, line[j]);
            }
        }
        return tableDictionary;
    }
}
