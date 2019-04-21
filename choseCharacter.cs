using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choseCharacter : MonoBehaviour
{
    public characterSelect cs;
    public manager mg;
    public int characterNumber;
    public int characterNumber2;
    public int stageNumber;
    public int stageNumber2;

    void Start()
    {
        mg = GameObject.Find("manager").GetComponent<manager>();
    }

    void OnTriggerStay2D (Collider2D col)
    {
        if (col.gameObject.CompareTag("1") && Input.GetKey(KeyCode.U) && !cs.ready1){
            if (mg.selection1 == 0) {
                mg.selection1 = characterNumber;
            }
            mg.stageSelection1 = stageNumber;
            cs.ready1 = true;
            cs.canMove1 = false;
        }    
        if(col.gameObject.CompareTag("2") && Input.GetKey(KeyCode.Q) && !cs.ready2)
        {
            if (mg.selection2 == 0)
            {
                mg.selection2 = characterNumber2;
            }
            mg.stageSelection2 = stageNumber2;
            cs.ready2 = true;
            cs.canMove2 = false;
        }  
    }
}
