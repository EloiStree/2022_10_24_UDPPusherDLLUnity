using System.Collections;
using System.Collections.Generic;
using UDPPusherOmiDLL;
using UnityEngine;

public class UDPPusher_Server : MonoBehaviour
{
    public System.Threading.ThreadPriority m_priority = System.Threading.ThreadPriority.Normal;
    public int m_portId = UDPPusherDefault.m_defaultIpPort;
    public IUdpMessageReceiver m_server;
    public bool m_autoLaunchAtAwake=false;
    void Awake()
    {
        if (m_autoLaunchAtAwake)
        {
            LaunchServer();
        }
    }

    [ContextMenu("LaunchServer")]
    public void LaunchServer() {

        if (m_server != null)
            m_server.KillAndDisposeTheThread();
        UdpMessagePusherBuilder.CreateServer(m_priority, m_portId, out m_server);
    }

    private void OnDestroy()
    {
        if(m_server!=null)
        m_server.KillAndDisposeTheThread();
    }
    private void OnDisable()
    {
        if (m_server != null)
            m_server.KillAndDisposeTheThread();
    }
}
