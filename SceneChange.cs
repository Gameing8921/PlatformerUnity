using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string Scene = "Level_1";

    void OnCollisionEnter(Collision collision)
    {
       EditorSceneManager.LoadScene(Scene);
    }
}

