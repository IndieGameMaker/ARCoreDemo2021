using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GoogleARCore;

public class MeasureMgr : MonoBehaviour
{
    public GameObject marker;
    public Text lengthText;

    private TrackableHit hit;
    private TrackableHitFlags flag = TrackableHitFlags.Default;

    // 탭 카운트 저장
    private int tapCount = 0;
    // 첫번째 탭의 위치(좌표)
    private Vector3 firstPos = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        
    }
}
