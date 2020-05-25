using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.XR.WSA.Input;

public class GestureMgr : MonoBehaviour
{
    private GestureRecognizer recognizer;

    private void Awake()
    {
        recognizer = new GestureRecognizer();
        recognizer.TappedEvent += (InteractionSourceKind source, int tapCount, Ray headRay) =>
        {
            if (ReticleMgr.focusedObj != null)
            {//레티클로 응시하고 있는 게임오브젝트에 메시지 전달
                ReticleMgr.focusedObj.SendMessage("OnTapped", SendMessageOptions.DontRequireReceiver);
            }
        };
        //이벤트 감지를 시작
        recognizer.StartCapturingGestures();
    }

    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        GameObject prevObject = ReticleMgr.focusedObj;
        //계속 같은 게임오브젝트를 응시하지 않을 때 제스쳐 초기화
        if (ReticleMgr.focusedObj != prevObject)
        {
            recognizer.CancelGestures();
            recognizer.StartCapturingGestures();
        }
    }
}