using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSetter : MonoBehaviour
{
    public AudioSource singing;
    public AudioSource screaming;

    public AudioSource background_music;

    public TimeFlowManager time;
    // Start is called before the first frame update
    void Start()
    {
        if (singing != null)
            singing.Play();
        
        GameObject timeFlow = GameObject.Find("TimeFlowManager");
        GameObject bgm = GameObject.Find("background");
        time = timeFlow.GetComponent<TimeFlowManager>();
        background_music = bgm.GetComponent<AudioSource>();
    }

    private void FixedUpdate() {
        if (time.active){
            
            background_music.pitch = 0.5f;
            if (singing != null)
                singing.pitch = 0.5f;
            if (screaming != null)
                screaming.pitch = 0.5f;
        }else{
            background_music.pitch = 1f;
            if (singing != null)
                singing.pitch = 1f;
            if (screaming != null)
                screaming.pitch = 1f;
        }
    }
    // Update is called once per frame
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "InteractiveObject" || other.gameObject.tag == "Player"){
            if (singing != null)
                singing.Stop();
            if (screaming != null)
                screaming.Play();
        }
    }
}
