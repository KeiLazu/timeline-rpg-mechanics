using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetAgent : MonoBehaviour {

    [SerializeField]
    TargetManager targetManager;

    [SerializeField]
    Image targetImage;

    public int ID;

    private void Awake()
    {
        targetManager = GameObject.Find("TargetManagerHolder").GetComponent<TargetManager>();
        targetImage = targetManager.targetImage;
        
    }

    private void Start()
    {
        if (targetImage == null)
        {
            targetImage = GameObject.Find("Target").GetComponent<Image>();

        } 
    }

    public void Targeted()
    {
        switch (ID)
        {
            case 1:
                targetManager.FocusOne();
                break;

            case 2:
                targetManager.FocusTwo();
                break;

            case 3:
                targetManager.FocusThree();
                break;

            default:
                Debug.Log("wait wut? null id? check target agent please");
                break;
        }

    }

}
