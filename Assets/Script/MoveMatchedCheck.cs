using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMatchedCheck : MonoBehaviour
{
    public GameObject mover;

    private void FixedUpdate()
    {
        mover.transform.position += Vector3.right*25;
    }
}
