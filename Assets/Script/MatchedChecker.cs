using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchedChecker : MonoBehaviour
{
    public List<GameObject> symbolList = new List<GameObject>();

    private void OnTriggerEnter2D(Collider2D _symbol)
    {
        if(_symbol.gameObject.tag == "Tile") return;

        symbolList.Add(_symbol.gameObject);
    }
}
