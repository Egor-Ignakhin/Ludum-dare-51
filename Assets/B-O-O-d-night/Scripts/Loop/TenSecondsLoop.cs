using System;
using System.Collections;
using UnityEngine;

public class TenSecondsLoop : MonoBehaviour
{
    public static event Action ValueChanged;
    public static float Timer { get; set; }

    private IEnumerator Start()
    {
        Timer = 0;
        while (true)
        {
            Timer += Time.deltaTime;
            ValueChanged?.Invoke();

            if (Timer > 10f)
            {
                print("new cycle");
                Timer = 0;
            }

            yield return null;
        }
    }
}