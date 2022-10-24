using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UDPPusherOMI_FlushServerReceivedMessages : MonoBehaviour
{
    public UDPPusherOMI_Server m_serverObserved;
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
