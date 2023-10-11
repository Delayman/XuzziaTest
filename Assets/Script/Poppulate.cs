using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Poppulate : MonoBehaviour
{
    [SerializeField]private List<Button> symbolBtn = new List<Button>();
    [SerializeField]private List<GameObject> tileList = new List<GameObject>();

    private List<Vector3> spawnLocation = new List<Vector3>();

    private void Start()
    {
        foreach(GameObject tile in tileList)
        {
            PoppulateItem(tile);
        }

    }

    private void PoppulateItem(GameObject _tile)
    {
        spawnLocation.Add(_tile.gameObject.GetComponent<RectTransform>().localPosition); 

        int rndSymbol = Random.Range(0, symbolBtn.Count);

        var symbolInstantiate = Instantiate(symbolBtn[rndSymbol], _tile.gameObject.GetComponent<RectTransform>().position, Quaternion.identity);

        symbolInstantiate.transform.parent = this.gameObject.transform;
    }

    public void Test()
    {
        Debug.Log($"test");
    }
}
