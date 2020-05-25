using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Windows.Speech;
using UnityEngine.UI;

public class VoiceMgr2 : MonoBehaviour
{
    public Button agent;

    public Button captureUI;

    public Button snapUI;
    public Button cancelUI;
    public Button saveUI;
    public Button deleteUI;

    //보이스 명령을 인식하는 클래스
    private KeywordRecognizer keyRecog;

    //명령어에 따라 호출할 메소드를 연결할 델리게이트 선언
    private delegate void KeywordAction(PhraseRecognizedEventArgs args);

    //인식할 명령어와 호출할 메스드들을 저장할 딕셔너리
    private Dictionary<string, KeywordAction> keywordCollection;

    // Use this for initialization
    private void Start()
    {
        //딕셔너리 생성
        keywordCollection = new Dictionary<string, KeywordAction>();
        //보이스 명령어 및 메소드 등록
        keywordCollection.Add("tap", TapMenu);

        keywordCollection.Add("capture", CaptureMenu);
        keywordCollection.Add("take", TakeShotMenu);
        keywordCollection.Add("cancel", CancelMenu);
        keywordCollection.Add("save", SaveMenu);
        keywordCollection.Add("delete", DeleteMenu);
        //보이스 명령인식 클래스에 명령어 등록
        keyRecog = new KeywordRecognizer(keywordCollection.Keys.ToArray());
        //명령어 파싱이 완료된 후 호출할 메소드 연결
        keyRecog.OnPhraseRecognized += KeywordRecognized;
        //보이스 명령어 인식 동작시작
        keyRecog.Start();
    }

    // Update is called once per frame
    private void Update()
    {
    }

    //"tap" 키워드에 반응할 메소드
    private void TapMenu(PhraseRecognizedEventArgs args)
    {
        if (ReticleMgr.focusedObj != null)
        {
            agent.GetComponent<Button>().onClick.Invoke();
        }
    }

    //"capture" 키워드에 반응할 메소드
    private void CaptureMenu(PhraseRecognizedEventArgs args)
    {
        if (ReticleMgr.focusedObj != null)
        {
            captureUI.GetComponent<Button>().onClick.Invoke();
        }
    }

    //"sajin" 키워드에 반응할 메소드
    private void TakeShotMenu(PhraseRecognizedEventArgs args)
    {
        if (ReticleMgr.focusedObj != null)
        {
            snapUI.GetComponent<Button>().onClick.Invoke();
        }
    }

    //"cancel" 키워드에 반응할 메소드
    private void CancelMenu(PhraseRecognizedEventArgs args)
    {
        if (ReticleMgr.focusedObj != null)
        {
            cancelUI.GetComponent<Button>().onClick.Invoke();
        }
    }

    //"save" 키워드에 반응할 메소드
    private void SaveMenu(PhraseRecognizedEventArgs args)
    {
        if (ReticleMgr.focusedObj != null)
        {
            saveUI.GetComponent<Button>().onClick.Invoke();
        }
    }

    //"delete" 키워드에 반응할 메소드
    private void DeleteMenu(PhraseRecognizedEventArgs args)
    {
        if (ReticleMgr.focusedObj != null)
        {
            deleteUI.GetComponent<Button>().onClick.Invoke();
        }
    }

    private void KeywordRecognized(PhraseRecognizedEventArgs args)
    {
        KeywordAction kAction;
        //파싱으로 넘어온 텍스트로 호출할 메소드 추출
        if (keywordCollection.TryGetValue(args.text, out kAction))
        {
            //메소드 호출
            kAction.Invoke(args);
        }
    }
}