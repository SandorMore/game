using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleFlashExample : MonoBehaviour
{
    [SerializeField] private SimpleFlash flashEffect;
    [SerializeField] private KeyCode flashKey;

    private void Update()
    {
        if (Input.GetKeyDown(flashKey))
        {
            flashEffect.Flash();
        }
    }
}
