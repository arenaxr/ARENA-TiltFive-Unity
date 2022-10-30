using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ArenaUnity;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
#if !UNITY_EDITOR
        ArenaClientScene.Instance.ConnectArena();
#endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
