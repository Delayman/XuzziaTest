using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveVerticalMatched : MonoBehaviour
{
    public GameObject mover;

    private void FixedUpdate()
    {
        mover.transform.position += Vector3.down*15;
    }
}
