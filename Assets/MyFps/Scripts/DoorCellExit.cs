using UnityEngine;

namespace Myfps
{
    public class DoorCellExit : Interactive
    {
        private Animator Door;
        public AudioSource Audio;
        private string loadtoScene = "MainScene02";
        public SceneFader fader;

        public AudioSource bgm01;
        private Collider m_collider;
        // Start is called before the first frame update
        void Start()
        {
            Door = GetComponent<Animator>();
            m_collider = GetComponent<BoxCollider>();
        }
        protected override void DoAction()
        {
            keyText.text = "[E]";
            actionText.text = "Open the Door";
            if (Input.GetKeyDown(KeyCode.E))    //여는 키
            {
                //Debug.Log("Open the Door");
                Door.SetBool("IsOpen", true);
                Audio.Play();
                keyText.text = "";
                actionText.text = "";
                m_collider.enabled = false;
                ChangeScene();
            }
        }
        private void ChangeScene()
        {
            bgm01.Stop();
            fader.FadeTo(loadtoScene);
        }
    }
}