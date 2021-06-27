using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace Level
{
    public class LevelScript : MonoBehaviour
    {
        public GameObject quizManager;
        public GameObject lLManager;
        public TypeSelectScript tSC;
        public int k;

        public void Pass(int currentLevel)
        {
            k = tSC.type;
            Debug.Log(k+""+currentLevel+1);
            switch (k)
            {
                case 0:
                    if (currentLevel >= PlayerPrefs.GetInt("Turkce"))
                    {
                        //PlayerPrefs.SetInt("levelUnlock", currentLevel + 1);
                        PlayerPrefs.SetInt("Turkce", currentLevel + 1);
                    }
                    
                    break;
                case 1:
                    if (currentLevel >= PlayerPrefs.GetInt("Ing"))
                    {
                        //PlayerPrefs.SetInt("levelUnlock", currentLevel + 1);
                       
                        PlayerPrefs.SetInt("Ing", currentLevel + 1);
                        Debug.Log(k+" leveller yenilendi "+currentLevel);
                    }
                    break;
                case 2:
                    if (currentLevel >= PlayerPrefs.GetInt("Deutch"))
                    {
                        //PlayerPrefs.SetInt("levelUnlock", currentLevel + 1);
                        
                        PlayerPrefs.SetInt("Deutch", currentLevel + 1);
                    }
                    break;
                case 3:
                    if (currentLevel >= PlayerPrefs.GetInt("Francais"))
                    {
                        //PlayerPrefs.SetInt("levelUnlock", currentLevel + 1);
                        
                        PlayerPrefs.SetInt("Francais", currentLevel + 1);
                    }
                    break;
            }
            
        
        }
        private void Update()
        {
            if (Input.GetKey(KeyCode.Q))
            {
                PlayerPrefs.SetInt("Turkce", 1);
                PlayerPrefs.SetInt("Ing", 1);
                PlayerPrefs.SetInt("Deutch", 1);
                PlayerPrefs.SetInt("Francais", 1);
                //PlayerPrefs.SetInt("levelUnlock", 1);
                //switch (k)
                //{
                //    case 0:
                //        PlayerPrefs.SetInt("Turkce", 1);
                //        break;
                //    case 1:
                //        PlayerPrefs.SetInt("Ing", 1);
                //        break;
                //    case 2:
                //        PlayerPrefs.SetInt("Deutch", 1);
                //        break;
                //    case 3:
                //        PlayerPrefs.SetInt("Francais", 1);
                //        break;
                //}
                Debug.Log("Level Sıfırlandı");
                lLManager.GetComponent<LevelManager>().Start();
            }
            if (Input.GetKey(KeyCode.T))
            {
                PlayerPrefs.SetInt("Turkce", 4);
                PlayerPrefs.SetInt("Ing", 4);
                PlayerPrefs.SetInt("Deutch", 4);
                PlayerPrefs.SetInt("Francais", 4);
                Debug.Log("Leveller acildi");
                lLManager.GetComponent<LevelManager>().Start();
            }
        }
    }

}
