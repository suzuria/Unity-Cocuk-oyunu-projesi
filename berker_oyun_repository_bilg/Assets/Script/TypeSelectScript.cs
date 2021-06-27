using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Level;
public class TypeSelectScript : MonoBehaviour
{
    
    public List<TypeSelectObject> questTypeS;
    public int a;
    public GameObject levelSelect;
    public GameObject typeSelect;
    
    public QuizManager qMM;
    public int type;
    public LevelScript lVS;
  
    public void TypeSelectButton(int typeNo)
    {
        type = typeNo;
        levelSelect.GetComponent<LevelManager>().SaveSystemFile(typeNo);
        switch (typeNo)
        {
            case 0:
                for (int i = 0; i < questTypeS[typeNo].levelSelect.Count; i++)
                {
                    qMM.questionsSelectSysyem.Add(questTypeS[typeNo].levelSelect[i]);
                }
                break;
            case 1:
                for (int i = 0; i < questTypeS[typeNo].levelSelect.Count; i++)
                {
                    qMM.questionsSelectSysyem.Add(questTypeS[typeNo].levelSelect[i]);
                }
                break;
            case 2:
                for (int i = 0; i < questTypeS[typeNo].levelSelect.Count; i++)
                {
                    qMM.questionsSelectSysyem.Add(questTypeS[typeNo].levelSelect[i]);
                }
                break;
            case 3:
                for (int i = 0; i < questTypeS[typeNo].levelSelect.Count; i++)
                {
                    qMM.questionsSelectSysyem.Add(questTypeS[typeNo].levelSelect[i]);
                }
                break;

        }
        levelSelect.SetActive(true);
        typeSelect.SetActive(false);
        
        
    }
}
