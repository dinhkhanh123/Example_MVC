using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reference : MonoBehaviour
{
   public static Dictionary<string,List<Action>> eventData = new Dictionary<string,List<Action>>();

    public static void On(string eventKey, Action method)
    {
        if (!eventData.ContainsKey(eventKey))
        {
            eventData.Add(eventKey, new List<Action>());

            eventData[eventKey].Add(method); // Thêm ph??ng th?c vào danh sách
        }
       
    }

    public static void Emit(string eventKey)
    {
        if (eventData.ContainsKey(eventKey))
        {
            for(int i = 0; i < eventData[eventKey].Count; i++)
            {
                eventData[eventKey][i].Invoke();
            }
        }
    }
}
