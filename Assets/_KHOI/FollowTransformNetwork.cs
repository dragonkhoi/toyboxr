using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTransformNetwork : MonoBehaviour
{
    private Transform toFollow;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void SetTransform(Transform t)
    {
        toFollow = t;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = toFollow.position;
        transform.rotation = toFollow.rotation;
    }
}
