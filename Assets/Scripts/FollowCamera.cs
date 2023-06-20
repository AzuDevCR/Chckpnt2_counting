using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Vector3 camPosOffset = new Vector3(21.13814f, 4.69099f, -0.2345347f);
    //[SerializeField] GameObject sphere;

    void LateUpdate()
    {
        
        transform.position = GameObject.FindWithTag("sphere").transform.position + camPosOffset;
        
    }
}
