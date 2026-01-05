using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CloseWindow : MonoBehaviour
{
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Escape))
        StartCoroutine(end());
  }
    IEnumerator end()
    {
        //音を鳴らす
        yield return null;
        #if UNITY_EDITOR
                    UnityEditor.EditorApplication.isPlaying = false;//ゲームプレイ終了
        #else
                    Application.Quit();//ゲームプレイ終了
        #endif

    }
}