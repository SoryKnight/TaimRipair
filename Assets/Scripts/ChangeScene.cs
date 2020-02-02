using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
    public Image blackFadeIn;
    public StageManager stage;
    
    // Start is called before the first frame update
    void Start()
    {
        blackFadeIn.canvasRenderer.SetAlpha(0.0f);
    }

    public void ChangeScenes(string a)
    {
        SceneManager.LoadScene(a);
    }

    public void StartScene()
    {
        StartCoroutine(fadeInOnStart());
    }

    IEnumerator fadeInOnStart()
    {
        blackFadeIn.CrossFadeAlpha(1.0f,2.0f,false);
        yield return new WaitForSeconds(2.0f);
        int scene = Random.Range(0, 1);
        string sceneString = stage.selectSceneByStage(scene);
        stage.setCurrentStage(sceneString);
        stage.ChangeScene(sceneString);
        blackFadeIn.CrossFadeAlpha(0, 2.0f, false);
    }

    public void NextScene()
    {
        StartCoroutine(fadeInToMenu());
    }

    IEnumerator fadeInToMenu()
    {
        blackFadeIn.CrossFadeAlpha(1.0f,2.0f,false);
        yield return new WaitForSeconds(2.0f);
        
        stage.ChangeScene("Menu");
        blackFadeIn.CrossFadeAlpha(0, 2.0f, false);
    }

}
