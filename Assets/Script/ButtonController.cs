using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private Btn_PosData posData;

    private void Start()
    {
        posData = FindObjectOfType<Btn_PosData>();
    }

    public void SelectSymbol()
    {
        if(!posData.isSelected)
        {
            posData.firstBtnPos = this.gameObject.transform.position;
            posData.firstBtn = this.gameObject;
            posData.isSelected = true;
        }else
        {
            posData.secondBtnPos = this.gameObject.transform.position;
            posData.secondBtn = this.gameObject;
            posData.isSelected = false;

            MovingItem();
        }
    }

    private void MovingItem()
    {
        float distance = Vector3.Distance(posData.firstBtnPos,posData.secondBtnPos);

        // int firstBtnIndex = posData.firstBtn.transform.GetSiblingIndex();
        // int secondBtnIndex = posData.secondBtn.transform.GetSiblingIndex();

        
        if((posData.firstBtnPos.x - posData.secondBtnPos.x) > 75f || (posData.secondBtnPos.x - posData.firstBtnPos.x) > 75f )
        {
            return;
        } 

        if((posData.firstBtnPos.y - posData.secondBtnPos.y) > 56f || (posData.secondBtnPos.y - posData.firstBtnPos.y) > 56f )
        {
            return;
        }

        if(distance > 93f)
        {
            return;
        }

        posData.firstBtn.transform.position = posData.secondBtnPos;
        // posData.firstBtn.transform.SetSiblingIndex(secondBtnIndex);

        posData.secondBtn.transform.position = posData.firstBtnPos;
        // posData.secondBtn.transform.SetSiblingIndex(firstBtnIndex);
    }
}
