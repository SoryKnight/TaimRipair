using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour{
    // Start is called before the first frame update
    public GameObject audio;

    void Start(){

        DontDestroyOnLoad(audio);
    }
    public void ChangeScene(string a) {

        SceneManager.LoadScene(a);

    }
}

