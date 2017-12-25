using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetManager : MonoBehaviour {

    [SerializeField]
    int selectedEnemy = 0;

    [SerializeField]
    public GameObject target;

    [SerializeField]
    public Image targetImage;

    [SerializeField]
    public TargetCursor cursor;

    [SerializeField]
    List<GameObject> enemyList;

    private void Awake()
    {
        target = GameObject.Find("Target");
        targetImage = target.GetComponent<Image>();
        cursor = target.GetComponent<TargetCursor>();

        enemyList = new List<GameObject>();

        enemyList.Add(GameObject.Find("Enemy1"));
        enemyList.Add(GameObject.Find("Enemy2"));
        enemyList.Add(GameObject.Find("Enemy3"));

    }

    private void Start()
    {
        if (selectedEnemy == 0)
        {
            selectedEnemy = 1;
            ChangeFocus(selectedEnemy);
        }
        
    }

    public void FocusOne()
    {
        selectedEnemy = 1;
        ChangeFocus(selectedEnemy);

    }

    public void FocusTwo()
    {
        selectedEnemy = 2;
        ChangeFocus(selectedEnemy);

    }

    public void FocusThree()
    {
        selectedEnemy = 3;
        ChangeFocus(selectedEnemy);

    }

    public void ChangeFocus(int selected)
    {
        target.transform.position = enemyList[selected - 1].transform.position;

    }

}
