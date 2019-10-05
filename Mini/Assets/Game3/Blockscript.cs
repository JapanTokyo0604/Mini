using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blockscript : MonoBehaviour
{

    public GameObject block;

    private void OnCollisionEnter(Collision collision)
    {

            Destroy(block);
            Play1_Game3.addScore();
            Play1_Game3.addDesBlock();
    }

}
