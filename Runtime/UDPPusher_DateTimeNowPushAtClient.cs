using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UDPPusher_DateTimeNowPushAtClient : MonoBehaviour
{
    public Eloi.PrimitiveUnityEvent_String m_linePushed;
    [ContextMenu("Push")]
    public void Push()
    {
        m_linePushed.Invoke(DateTime.Now.ToString());
    }
}
