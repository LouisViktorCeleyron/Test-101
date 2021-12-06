using UnityEngine;
using Cinemachine;

public class lanceCam : MonoBehaviour
{
    public CinemachineDollyCart cdc;
    private void Start()
    {
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Backspace))
        {
            cdc.m_Speed = 1;    
        }
    }
}
