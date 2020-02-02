using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private UnityEngine.UI.Text gui = null;
    public StageManager stage;

    public int saved = 0;
    public int deaths = 0;
    public float time_left = 5.0f;

    private bool finished;

    // Start is called before the first frame update
    void Start()
    {
        // accede al texto
        gui = this.GetComponent<Text>();
        gui.text = "";
        finished = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        string t = "";

        // Tiempo
        if (!finished) time_left -= Time.deltaTime;
        if(time_left < 0.0f)
        {
            time_left = 0.0f;
            finished = true;
            stage.goToNewScene();
        }

        t += time_left.ToString("000.00");
        t += "s";
        


        gui.text = t;
    }
}
