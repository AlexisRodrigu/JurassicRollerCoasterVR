﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class PowerUp : MonoBehaviour
{
    [Header("Carrito")]
    public CinemachineDollyCart carrito;
    [Range(5f,25f)] public float speedUp = 10f;
    [Range(1f, 5f)] public float speedNormal = 5f;
    

    private static PowerUp instance = null;

    // Game Instance Singleton
    public static PowerUp Instance
    {
        get
        {
            return instance;
        }
    }

    private void Awake()
    {
        // if the singleton hasn't been initialized yet
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }

        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {
      
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
    public void Acelerar()
    {
        carrito.m_Speed = speedUp;
        Debug.Log("Aceleras krnal");
    }
    public void VelNormal()
    {
        carrito.m_Speed = speedNormal;
    }
}
