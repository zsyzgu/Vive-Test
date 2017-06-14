using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataCollect : MonoBehaviour {
    public GameObject head;
    public GameObject leftHand;
    public GameObject rightHand;

    private StreamWriter sw;

	void Start()
    {
        sw = File.CreateText("data.txt");
    }

    void OnDestroy()
    {
        sw.Close();
    }
	
	void Update() {
        Vector3 headPosition = new Vector3();
        Vector3 headRotation = new Vector3();
        Vector3 leftHandPosition = new Vector3();
        Vector3 leftHandRotation = new Vector3();
        Vector3 rightHandPosition = new Vector3();
        Vector3 rightHandRotation = new Vector3();

        if (head != null)
        {
            headPosition = head.transform.position;
            headRotation = head.transform.eulerAngles;
        }

        if (leftHand != null)
        {
            leftHandPosition = leftHand.transform.position;
            leftHandRotation = leftHand.transform.eulerAngles;
        }

        if (rightHand != null)
        {
            rightHandPosition = rightHand.transform.position;
            rightHandRotation = rightHand.transform.eulerAngles;
        }

        sw.Write(headPosition.x + " " + headPosition.y + " " + headPosition.z + " ");
        sw.Write(headRotation.x + " " + headRotation.y + " " + headRotation.z + " ");
        sw.Write(leftHandPosition.x + " " + leftHandPosition.y + " " + leftHandPosition.z + " ");
        sw.Write(leftHandRotation.x + " " + leftHandRotation.y + " " + leftHandRotation.z + " ");
        sw.Write(rightHandPosition.x + " " + rightHandPosition.y + " " + rightHandPosition.z + " ");
        sw.Write(rightHandRotation.x + " " + rightHandRotation.y + " " + rightHandRotation.z + " ");
        sw.WriteLine();
    }
}
