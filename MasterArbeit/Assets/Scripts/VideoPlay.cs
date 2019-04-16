using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlay : MonoBehaviour {

    private VideoPlayer videoPlayer;
    private int videoClipIndex;

    public VideoClip[] videoClips;
    public GameObject carmodel;

    void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    // Use this for initialization
    void Start () {
        videoPlayer.clip = videoClips[0];
    }

    /*void OnEnable()
    {
        videoPlayer.clip = videoClips[0];
    }*/

    // Update is called once per frame
    void Update () {

        OVRInput.Update();

        if (videoClipIndex == 0)
        {
            carmodel.SetActive(false);
        }
        else
        {
            carmodel.SetActive(true);
        }

        
        if (OVRInput.Get(OVRInput.Button.Three) == true)
        {
            SetNextClip();
        }

        /*if (Input.GetKeyDown(KeyCode.Space)) {
            SetNextClip();
        }*/

        
    }

    public void SetNextClip()
    {
        videoClipIndex++;

        if (videoClipIndex >= videoClips.Length)
        {
            videoClipIndex = videoClipIndex % videoClips.Length;
        }

        videoPlayer.clip = videoClips[videoClipIndex];
        videoPlayer.Play();


    }
}
