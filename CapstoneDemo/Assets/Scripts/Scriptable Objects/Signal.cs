﻿using System.Collections;
using System.Collections.Generic;
//using NUnit.Framework;
using UnityEngine;


    // Start is called before the first frame update
    [CreateAssetMenu]
    public class Signal : ScriptableObject
    {
        public List<SignalListener> listeners = new List<SignalListener>();

        public void Raise()
        {
            for (int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].OnSignalRaised();
            }
        }

        public void RegisterListener(SignalListener listener)
        {
            listeners.Add(listener);
        }

        public void DeRegisterListener(SignalListener listener)
        {
            listeners.Remove(listener);
        }
        
    }
