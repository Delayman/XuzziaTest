using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WallMatched : MonoBehaviour
{
    private Vector3 startPos;
    private List<MatchedChecker> checkers = new List<MatchedChecker>();

    private void Start() 
    {
        startPos = this.transform.position;
        checkers.AddRange(this.GetComponentsInChildren<MatchedChecker>());

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "MatchWall")
        {
            this.transform.position = startPos;

            foreach(var checker in checkers)
            {
                checker.symbolList.Clear();
            }
        }
    }
}
