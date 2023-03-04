using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptSkills : MonoBehaviour
{
    public EnemyScript peremenaja;
    public bool usingskillDow = false;

    void Update()
    {
        if (peremenaja == true)
        {
            usingskillDow = true;
        }
    }
}
