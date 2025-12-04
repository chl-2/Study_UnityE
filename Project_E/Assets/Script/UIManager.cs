using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject popupPrefab; //스폰해줄 프리팹 변수
    public Transform canvasTransform; //어느 위치에서 스폰할지
    public string TitleText; // 어느 팝업을 띄울지
    public string ContentText;

    public void OpenNoticePopup()
    {
        GameObject newPopup = Instantiate(popupPrefab, canvasTransform);// 생성한 팝업 변수 (스폰하면서 newPopup 변수에 집어넣음)
        Popup popupScript = newPopup.GetComponent<Popup>();// 팝업 스크립트 변수

        popupScript.SetContent(this.TitleText, this.ContentText);// 팝업 내용 설정
    }
}