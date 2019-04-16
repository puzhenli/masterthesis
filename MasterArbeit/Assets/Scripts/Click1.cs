using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Click1 : MonoBehaviour
{

    public Camera cam;

    //private Vector3 mousePosition;
   // private Vector3 objPosition;
    //private bool distance;
   // private bool ifblock;

    public GameObject auto;
    public GameObject soft;
    public GameObject sephere;
    private Renderer rendbird;
    private Renderer rendcloud;
    public GameObject bird;
    public GameObject cloud;

    // Use this for initialization
    void Start()
    {
        auto.SetActive(true);
        soft.SetActive(false);
        sephere.SetActive(false);

        //ifblock = false;
        Debug.Log("begin 1");
        bird.SetActive(true);
        cloud.SetActive(true);
        rendbird = bird.GetComponent<Renderer>();
        rendcloud = cloud.GetComponent<Renderer>();
        rendbird.enabled = false;
        rendcloud.enabled = false;
    }

    /*void OnEnable()
    {
        objPosition = cam.WorldToScreenPoint(auto.transform.position);
        distance = CheckDistance(objPosition, Input.mousePosition);
        if (distance == true)
        {
            ifblock = true;
            //Debug.Log("is blocked click1");
        }
        else
        {
            ifblock = false;
        }
    }*/

    // Update is called once per frame
    void Update()
    {
        /*if (ifblock == true)
        {
            objPosition = cam.WorldToScreenPoint(auto.transform.position);
            distance = CheckDistance(objPosition, Input.mousePosition);
            if (distance == false)
            {
                ifblock = false;
            }
        }
        else
        {
            objPosition = cam.WorldToScreenPoint(auto.transform.position);
            distance = CheckDistance(objPosition, Input.mousePosition);
            if (distance == true)
            {
                soft.SetActive(true);
                //Debug.Log("swithced");
                sephere.SetActive(true);
                auto.SetActive(false);
                rendbird.enabled = true;
                rendcloud.enabled = true;

            }
        }*/

        OVRInput.Update();

        if (OVRInput.Get(OVRInput.Button.Two) == true)
        {
            soft.SetActive(true);
            //Debug.Log("swithced");
            sephere.SetActive(true);
            auto.SetActive(false);
            rendbird.enabled = true;
            rendcloud.enabled = true;
        }
    }

   /* bool CheckDistance(Vector3 a, Vector3 b)
    {
        bool on;
        float dis = Mathf.Sqrt(Mathf.Pow((a.x - b.x), 2) + Mathf.Pow((a.y - b.y), 2));
        if (dis < 40f)
        {
            on = true;
        }
        else
        {
            on = false;
        }
        return on;
    }*/
}
