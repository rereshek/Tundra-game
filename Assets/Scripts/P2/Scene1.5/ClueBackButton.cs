﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class ClueBackButton : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene(10);
    }
}

