using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
  public TextMeshProUGUI labelText;
  public static UIManager Instance;

  private void Awake()
  {
    if (Instance != null)
    {
      Destroy(gameObject);
      return;
    }
    else
    {
      Instance = this;
      DontDestroyOnLoad(gameObject);
    }
    
  }
  void Start()
  {
    labelText.text = "I am a";
  }
}
