using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;

public class TouchMgr : MonoBehaviour
{
    //AR 카메라
    private Camera arCamera;
    //생성할 캐릭터
    public GameObject mummy;

    //RaycastHit 유사한 구조체
    private TrackableHit hit;

    void Start()
    {
        arCamera = Camera.main;        
    }

    void Update()
    {
        if (Input.touchCount == 0) return;

        Touch touch = Input.GetTouch(0);
        //검출대상
        TrackableHitFlags filter = TrackableHitFlags.Default;
        if (touch.phase == TouchPhase.Began
            && Frame.Raycast(touch.position.x, touch.position.y, filter, out hit))
        {
            //앵커 생성(Anchor)
            var anchor = hit.Trackable.CreateAnchor(hit.Pose);
            Instantiate(mummy, hit.Pose.position, hit.Pose.rotation, anchor.transform);
        }
        
    }
}
