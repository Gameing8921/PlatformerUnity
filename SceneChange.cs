using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class SceneChange : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
       EditorSceneManager.LoadScene("Level_1");
    }
}

