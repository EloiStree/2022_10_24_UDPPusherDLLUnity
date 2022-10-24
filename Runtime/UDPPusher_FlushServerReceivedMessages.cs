using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UDPPusher_FlushServerReceivedMessages : MonoBehaviour
{
    public UDPPusher_Server m_serverObserved;
    public Eloi.PrimitiveUnityEvent_String m_onMessageReceived;
    void Update()
    {
        m_serverObserved.m_server.FlushReceivedMessages(out List<string> received);
        foreach (var item in received)
        {
            m_onMessageReceived.Invoke(item);
        }

    }
}
