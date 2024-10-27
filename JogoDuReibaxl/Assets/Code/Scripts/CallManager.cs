using System.Collections;
using Resources.Code.Scripts.DesignPatterns.Singleton;
using UnityEngine;

namespace Code.Scripts
{
    public class CallManager : Singleton<CallManager>
    {
        public AudioSource audioSource;
        public bool IsRinging = true;
        public bool IsAnswering;
        
        [SerializeField] public GameObject callScreen;

        private void Start()
        {
            IsRinging = true;
            IsAnswering = false;
        }
    
        public void PickUp()
        {
            GameManager.Instance.PickUpCall();
            audioSource.Stop();
            IsRinging = false; 
            
            callScreen.SetActive(false);
        }
    
        public void Call()
        {
            audioSource.Play();
            StartCoroutine(StartCalling());
            Debug.Log("Calling...");
        }
        

        IEnumerator StartCalling()
        {
            IsRinging = true;
            callScreen.SetActive(true);
            yield return new WaitForSeconds(audioSource.clip.length);
        
            if (IsRinging)
            {
            
                Debug.Log("Hang up!");
                HangUp();
                IsRinging = false;
                
                callScreen.SetActive(false);
            }
        }
    
        public void HangUp()
        {
            GameManager.Instance.DismissCall();
        }

    
    }
}
