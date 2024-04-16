using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static GameEvents;

public class SampleScript : MonoBehaviour
{
    private EventBus _eventBus;


    private void Awake()
    {
        _eventBus = ServiceLocator.Instance.Resolve<EventBus>();  // Get EventBus


        _eventBus.Subscribe<GameEvents.OnLevelLoaded>(OnLevelLoaded);  // Subscribe To Event


        _eventBus.Unsubscribe<GameEvents.OnLevelLoaded>(OnLevelLoaded);  // Subscribe To Event


        _eventBus.Fire(new GameEvents.OnLevelLoaded());  // Fire Event
    }
}
