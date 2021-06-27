using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Level
{

    public class LevelManager : MonoBehaviour
    {
       
        int Turkce = 1;
        int Ing = 1;
        int Deutch = 1;
        int Francais = 1;
        public LevelScript levelScript;
        public Button[] buttons;
        public TypeSelectScript tSS;
        public void Start()
        {
            //levelUnlock = PlayerPrefs.GetInt("levelUnlock", 1);
            
            
        }
        public void SaveSystemFile(int k)
        {
            
            Debug.Log(k);
            switch (k)
            {
                case 0:
                    Turkce = PlayerPrefs.GetInt("Turkce");
                    LevelUnlock(Turkce);
                    break;
                case 1:
                    Ing = PlayerPrefs.GetInt("Ing");
                    Debug.Log("leveller açıldı");
                    LevelUnlock(Ing);
                    break;
                case 2:
                    Deutch = PlayerPrefs.GetInt("Deutch");
                    LevelUnlock(Deutch);
                    break;
                case 3:
                    Francais = PlayerPrefs.GetInt("Francais");
                    LevelUnlock(Francais);
                    break;
            }
            
        }
        // Update is called once per frame
        void Update()
        {
        
        }
        public void LevelUnlock(int level)
        {
        
            for (int i = 0; i < buttons.Length; i++)
            {
                if (i < buttons.Length)
                {
                    buttons[i].interactable = false;
                }
            }
            for (int i = 0; i < level; i++)
            {
                if (i < buttons.Length) { buttons[i].interactable = true; }
            }
        }
    }
}
