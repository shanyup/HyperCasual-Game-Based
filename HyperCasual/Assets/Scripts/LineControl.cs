using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineControl : MonoBehaviour
{
    public Transform characterPos;
    public Transform midLanePos;
    public Transform rightLanePos;
    public Transform leftLanePos;
    private void Start()
    {
        characterPos = FindObjectOfType<Ch_Movement>().gameObject.transform;
    }

    private void Update()
    {
        midLanePos.position = new Vector3(midLanePos.position.x,midLanePos.position.y,characterPos.position.z);
        rightLanePos.position = new Vector3(rightLanePos.position.x,rightLanePos.position.y,characterPos.position.z);
        leftLanePos.position = new Vector3(leftLanePos.position.x,leftLanePos.position.y,characterPos.position.z);
    }
}
