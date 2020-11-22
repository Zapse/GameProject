using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine; 

//here we make camerashake what we peform when player attacks and hits target. You need to have Cinemachine for your project so this script can work.
public class CameraShake : MonoBehaviour
{
    public static CameraShake Instance {get; private set;} //lets use static because it makes thing easyer for us

    private CinemachineVirtualCamera cinemachineVirtualCamera;
    private float shakeTimer;

    private void Awake()
    {
        Instance = this;
        cinemachineVirtualCamera = GetComponent<CinemachineVirtualCamera>();
    }

    public void ShakeCamera(float intensity, float time) //here is function to shake camera, lets use intensity for how "much" we want to shake it and time for how long.
    {
        CinemachineBasicMultiChannelPerlin cinemachineBasicMultiChannelPerlin =
         cinemachineVirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

        cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = intensity; 
        shakeTimer = time;
    }

    private void Update()
    {
        if(shakeTimer > 0){
            shakeTimer -= Time.deltaTime;
                if (shakeTimer <= 0f){
                    //timer over
                    CinemachineBasicMultiChannelPerlin cinemachineBasicMultiChannelPerlin = cinemachineVirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

                    cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = 0f;
                }
        }
    }
}
