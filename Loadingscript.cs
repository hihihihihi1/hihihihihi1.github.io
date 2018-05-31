using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadingscript : MonoBehaviour {
    public void loadLevel()
    {
        //Debug.Log("Function was called");
        
        SceneManager.LoadScene("flight sim");
    }


}
