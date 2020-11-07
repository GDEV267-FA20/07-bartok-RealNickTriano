using UnityEngine;

using System.Collections;


public class TurnLight : MonoBehaviour
{
    [Header("Set in Inspector")]

    public Vector3 lightOffset = new Vector3(-1,0,0);

    void Update()
    {

        transform.position = Vector3.back * 3;                                 // a



        if (Bartok.CURRENT_PLAYER == null)
        {                                 // b

            return;

        }



        transform.position += Bartok.CURRENT_PLAYER.handSlotDef.pos;
        transform.position += lightOffset;

    }

}