using UnityEngine;
using UnityEngine.SceneManagement;

namespace Myfps
{
    public class GameOverUI : MonoBehaviour
    {
        #region Variables
        public SceneFader fader;
        [SerializeField]private string loadtoScene = "PlayScene";
        #endregion
        private void Start()
        {
            //마우스 커서 상태 설정
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            //페이드인 효과
            fader.FromFade();
        }
        public void Retry()
        {
            fader.FadeTo(loadtoScene);
        }
        public void Menu()
        {
            Debug.Log("GotoMenu");
        }

    }
}