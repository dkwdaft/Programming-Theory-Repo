using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
   public void Play()
   {
       SceneManager.LoadScene(1);
   }

    // Update is called once per frame
    public void Quit()
    {
        #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
        #else
        Application.Quit();
        #endif
        
    }
}