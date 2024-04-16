using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class LoadingEventBus : MonoBehaviour
{
    private void Awake()
    {
        Container.Initialize();
    }
}
