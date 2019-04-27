using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dotndestroyaudio : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
