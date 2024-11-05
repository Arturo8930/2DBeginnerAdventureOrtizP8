using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;



public class UIHandler : MonoBehaviour
{
    private VisualElement m_Healthbar;


    //Start is called before the first frame update
    void Start()
    {
        UIDocument uiDocument = GetComponent<UIDocument>();
        m_Healthbar = uiDocument.rootVisualElement.Q<VisualElement>("HealthBar");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
