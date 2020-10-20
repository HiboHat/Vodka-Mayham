using UnityEngine;
using System;
using System.Collections.Generic;

public class Timer
{
    private float time;
    private string functionName;
    private Action action;
    private GameObject gameObject;

    private static List<Timer> timerList;
    private static GameObject timerObject;

    private Timer(Action action, float time, GameObject gameObject, string functionName)
    {
        this.action = action;
        this.time = time;
        this.gameObject = gameObject;
        this.functionName = functionName;
    }

    private static void Instanciate()
    {
        if (!timerObject)
        {
            timerObject = new GameObject("TimerObject");
            timerList = new List<Timer>();
        }
    }

    private void UpdateAction()
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            action();
            DestroyTimer();
        }
    }
    
    public static void StopTimer(string funtionName)
    {
        Instanciate();
        for(int i = 0; i < timerList.Count; i++)
            if (timerList[i].functionName == funtionName)
                timerList[i].DestroyTimer();
    }

    private static void RemoveTimer(Timer timer)
    {
        timerList.Remove(timer);
    }

    private void DestroyTimer()
    {
        UnityEngine.Object.Destroy(gameObject);
        RemoveTimer(this);
    }

    public static Timer StartFunction(Action action, float time, string functionName = "UNNAMED")
    {
        Instanciate();
        GameObject gameObject = new GameObject("FuntionTimer", typeof(DummyTimer));
        Timer timer = new Timer(action, time, gameObject, functionName);
        gameObject.GetComponent<DummyTimer>().OnUpdate = timer.UpdateAction;
        timerList.Add(timer);
        return timer;
    }

    private class DummyTimer : MonoBehaviour
    {
        public Action OnUpdate;
        void Update()
        {
            OnUpdate?.Invoke();
        }
    }

}
