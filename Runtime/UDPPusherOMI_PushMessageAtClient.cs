using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UDPPusherOMI_PushMessageAtClient : MonoBehaviour
{

    [TextArea(0,10)]
    public string m_textToSendAsLines;

    public Eloi.PrimitiveUnityEvent_String m_linePushed;

    [ContextMenu("Push")]
    public void Push() {
        foreach (var item in m_textToSendAsLines.Split('\n'))
        {
            m_linePushed.Invoke(item);
        }
    }


}
