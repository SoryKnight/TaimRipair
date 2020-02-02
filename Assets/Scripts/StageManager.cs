using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StageManager : MonoBehaviour
{    


    private static string currentStage;

    private static string nextStage;

    public enum Verdict {Lose, Win};
    public Verdict theVerdict = Verdict.Win;


    void Start()
    {
    }
    public void ChangeScene(string a) {

        // LoadScene(a);
        
        SceneManager.LoadScene(a);

    }

    public void setVerdictLose(){
        theVerdict = Verdict.Lose;
    }

    public void setVerdictWin(){
        theVerdict = Verdict.Win;
    }

    public void goToNewScene(){
        if (theVerdict == Verdict.Win){
            if (currentStage == "OutsideScene"){
                nextStage = "SceneHouse";
            }else{
                nextStage = "OutsideScene";
            }
            
            ChangeScene("Resume");
        }else if (theVerdict == Verdict.Lose){
            ChangeScene("Resume");

        }
    }

    public void setNextStage(string st){
        nextStage = st;
    }

    public void setCurrentStage(string st){
        currentStage = st;
    }

    public string selectSceneByStage(int stageIndex){
        if (stageIndex == 1) {
            return "OutsideScene";
        }
        else{
            return "SceneHouse";
        } 
    }

    public void RewindScene(){
        ChangeScene(currentStage);
    }

    public void TitleScene(){
        ChangeScene("Menu");
    }

    public void Nextscene(){
        if (nextStage != null)
            ChangeScene(nextStage);
    }
}
