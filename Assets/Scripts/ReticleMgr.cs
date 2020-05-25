using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleMgr : MonoBehaviour
{
    //레티클 프리팹을 저장할 변수
    public GameObject reticlePrefab;

    //레이 캐스트 사정거리
    public float sightDist = 45.0f;

    //동적으로 생성할 레티클
    private GameObject reticle;

    //메인 카메라의 Transform 컴포넌트를 저장할 변수
    private Transform camTr;

    //현재 응시하고 있는 게임오브젝트를 저장할 변수
    public static GameObject focusedObj;

    private void Start()
    {
        camTr = transform;
        if (reticlePrefab != null)
        {
            //레티클 인스턴스를 생성
            reticle = Instantiate<GameObject>(reticlePrefab);
        }
    }

    private void Update()
    {
        RaycastHit hit;
        //레이 캐스트를 시각적으로 표현
        Debug.DrawRay(camTr.position, camTr.forward * sightDist, Color.cyan);
        //사정거리까지 레이캐스트
        if (Physics.Raycast(camTr.position, camTr.forward, out hit, sightDist))
        {
            //레이캐스트가 다른 물체에 접촉한 지점으로 레티클을 이동
            reticle.transform.position = hit.point;
            //레티클이 접촉한 물체의 법선벡터 방향으로 회전
            reticle.transform.rotation = Quaternion.LookRotation(hit.normal);
            //레이에 접촉한 게임오브젝트 저장
            focusedObj = hit.collider.gameObject;
        }
        else
        {
            //다른 물체와 접촉이 없을 때 프리팹의 위치
            reticle.transform.position = camTr.position + (camTr.forward * sightDist);
            reticle.transform.rotation = Quaternion.LookRotation(camTr.forward);
            focusedObj = null;
        }
    }
}