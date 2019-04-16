using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class ButtonClick2 : MonoBehaviour
{

    public GameObject Auto;
    public GameObject Soft;

    // Use this for initialization
    //void Start()
    //{
    //    Auto.SetActive(false);
   //     Soft.SetActive(true);
    //}

    // Update is called once per frame
    //void Update () {

    //}

    public void OnMouseDown()
    {
        Auto.SetActive(true);
        Soft.SetActive(false);
    }
}
