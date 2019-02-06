using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartScript : MonoBehaviour {

    // Use this for initialization


    public void SceneChange(int sceneIndex)//Index of scene
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
