using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click2 : MonoBehaviour
{
    public Camera cam1;

    //private Vector3 mousePosition;
    //private Vector3 objPosition1;
    //private bool distance1;
    //private bool ifblock1;

    public GameObject auto1;
    public GameObject soft1;
    public GameObject sephere1;
    private Renderer rendbird1;
    private Renderer rendcloud1;
    public GameObject bird1;
    public GameObject cloud1;
    public GameObject carmodel1;

    // Use this for initialization
    //void Start()
    //{       
    //}

    /*void OnEnable()
    {
        //Debug.Log("click2 begin");
        objPosition1 = cam1.WorldToScreenPoint(soft1.transform.position);
        distance1 = CheckDistance1(objPosition1, Input.mousePosition);
        if (distance1 == true)
        {
            ifblock1 = true;
            //Debug.Log("is blocked click2");
        }
        else
        { 
            ifblock1 = false;
        }
    }*/
    
    // Update is called once per frame
    void Update()
    {
        /*if (ifblock1 == true)
        {
            objPosition1 = cam1.WorldToScreenPoint(soft1.transform.position);
            distance1 = CheckDistance1(objPosition1, Input.mousePosition);
            if (distance1 == false)
            {
                ifblock1 = false;
            }
        }
        else
        {
            objPosition1 = cam1.WorldToScreenPoint(soft1.transform.position);
            distance1 = CheckDistance1(objPosition1, Input.mousePosition);
            if (distance1 == true)
            {
                auto1.SetActive(true);
                //Debug.Log("swithced back");
                sephere1.SetActive(false);
                soft1.SetActive(false);
                carmodel1.SetActive(true);
                rendbird1 = bird1.GetComponent<Renderer>();
                rendcloud1 = cloud1.GetComponent<Renderer>();
                rendbird1.enabled = false;
                rendcloud1.enabled = false;
            }
        }*/
        OVRInput.Update();

        if (OVRInput.Get(OVRInput.Button.One) == true)
        {
            auto1.SetActive(true);
            //Debug.Log("swithced back");
            sephere1.SetActive(false);
            soft1.SetActive(false);
            carmodel1.SetActive(true);
            rendbird1 = bird1.GetComponent<Renderer>();
            rendcloud1 = cloud1.GetComponent<Renderer>();
            rendbird1.enabled = false;
            rendcloud1.enabled = false;
        }
    }

    /*bool CheckDistance1(Vector3 a, Vector3 b)
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
