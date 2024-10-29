using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class ResourcesScript : MonoBehaviour
{
    public static string selectedChara = "0";
    public Image charaImg;
    public Sprite defaultImage;

    public void LoadImages()
    {
        string path = "Sprites/" + selectedChara;
        Sprite sprite = Resources.Load<Sprite>(path);
        if (sprite == null)
        {
            sprite = defaultImage;
        }
        charaImg.sprite = sprite;
        Debug.Log(path);
    }
    private void Start()
    {
        LoadImages();
    }
    public void Change1()
    {
        selectedChara = "0";
    }
    public void Change2()
    {
        selectedChara = "1";
    }
    public void Change3()
    {
        selectedChara = "2";
    }
}
