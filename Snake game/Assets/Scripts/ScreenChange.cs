﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenChange : MonoBehaviour
{
    public void change()
    {
        SceneManager.LoadScene("GameScene");
    }
}
