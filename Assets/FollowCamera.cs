using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    //Cam position should be same as rover
    [SerializeField] GameObject roverToFollow;
    // Update is called once per frame but at the end
    void LateUpdate()
    {
        transform.position = roverToFollow.transform.position + new Vector3 (0, 0, -6f);
    }
}
