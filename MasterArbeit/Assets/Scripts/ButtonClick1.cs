using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class ButtonClick1 : MonoBehaviour
{

    public GameObject Auto;
    public GameObject Soft;
    public GameObject Sephere;

    // Use this for initialization
    void Awake()
    {
        Auto.SetActive(true);
        Soft.SetActive(true);
        Sephere.SetActive(true);
    }

    // Update is called once per frame
    void Update () {
        Soft.SetActive(false);
        Sephere.SetActive(false);
        //OnMouseDown();
    }

    public void OnMouseDown()
    {
        Auto.SetActive(false);
        Soft.SetActive(true);
        Sephere.SetActive(true);
    }
}
