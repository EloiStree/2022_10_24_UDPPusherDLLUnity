using System.Collections;
using System.Collections.Generic;
using UDPPusherOmiDLL;
using UnityEngine;

public class UDPPusher_Client : MonoBehaviour
{
    public string m_address = UDPPusherDefault.m_defaultIpAddress ;
    public int m_port = UDPPusherDefault.m_defaultIpPort;
    public IUdpMessagePusher m_pusherConnection;

    void Awake()
    {

        UdpMessagePusherBuilder.Connect(m_address, m_port, out m_pusherConnection);
    }
   


    public void PushCommandLine(string commandLine) {
        m_pusherConnection.PushCommandLine(commandLine);
    }
    public void PushBooleanSwitch(string booleanName)
    {
        m_pusherConnection.PushCommandLine_SwitchBoolean(booleanName);
    }
    public void PushBooleanSet(string booleanName, bool newValue)
    {
        m_pusherConnection.PushCommandLine_SetBoolean(booleanName, newValue);
    }

}
