using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class CarEngine : MonoBehaviour
{

    public Transform path;
    public float maxSteerAngle = 45f;
    public WheelCollider wheelFL;
    public WheelCollider wheelFR;
    public float maxMotorTorque = 80f;
    public float currentSpeed;
    public float maxSpeed = 120f;
    public TextMesh speedText;

    private List<Transform> nodes;
    private int currentNode = 0;

    // Use this for initialization
    void Start()
    {
        Transform[] pathTransforms = path.GetComponentsInChildren<Transform>();
        nodes = new List<Transform>();

        for (int i = 0; i < pathTransforms.Length; i++)
        {
            if (pathTransforms[i] != path.transform)
            {
                nodes.Add(pathTransforms[i]);
            }
        }

        ShowSpeedText();
}

    // Update is called once per frame
    private void FixedUpdate()
    {
        ApplySteer();
        Drive();
        CheckwaypointDistance();
    }

    private void ApplySteer()
    {
        Vector3 relativeVector = transform.InverseTransformPoint(nodes[currentNode].position);
        //print(relativeVector);
        float newSteer = (relativeVector.x / relativeVector.magnitude) * maxSteerAngle;
        wheelFL.steerAngle = newSteer;
        wheelFR.steerAngle = newSteer;
    }

    private void Drive()
    {
        currentSpeed = 2 * Mathf.PI * wheelFL.radius * wheelFL.rpm * 60 / 1000;
        if (currentSpeed < maxSpeed)
        {
            wheelFL.motorTorque = maxMotorTorque;
            wheelFR.motorTorque = maxMotorTorque;
        }
        else
        {
            wheelFL.motorTorque = 0;
            wheelFR.motorTorque = 0;
        }

        ShowSpeedText();
    }

    private void CheckwaypointDistance()
    {
        if (Vector3.Distance(transform.position, nodes[currentNode].position) < 10f)
        {
            if (currentNode != nodes.Count - 1)
            {
                currentNode++;
            }
        }
    }

    void ShowSpeedText()
    {
        speedText = GameObject.Find("Speed Text").GetComponent<TextMesh>();
        speedText.text = "Speed: " + Mathf.Round(currentSpeed).ToString() + "km/h";
    }
}