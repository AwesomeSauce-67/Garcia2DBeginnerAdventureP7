using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
public class UIHandler : MonoBehaviour
{
    private VisualElement m_Healthbar;
    public static UIHandler instance { get; private set; }
    public float displayTime = 4.0f;
    private VisualElement m_NonPlayerDialouge;
    private float m_TimerDisplay;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        UIDocument uidocument=GetComponent<UIDocument>();
        m_Healthbar = uidocument.rootVisualElement.Q<VisualElement>("HealthBar");
        SetHealthValue(1.0f);

        m_NonPlayerDialouge = uidocument.rootVisualElement.Q<VisualElement>("NPCDialouge");
        m_NonPlayerDialouge.style.display = DisplayStyle.None;
        m_TimerDisplay = -1.0f;
    }

    public void SetHealthValue(float percentage)
    {
        m_Healthbar.style.width=Length.Percent(100*percentage);
    }
    private void Update()
    {

        if (m_TimerDisplay > 0);
        {
            m_TimerDisplay -= Time.deltaTime;
            if(m_TimerDisplay < 0)
            {
                m_NonPlayerDialouge.style.display=DisplayStyle.None;
            }
        }
    }
    public void DisplayDialouge()
    {
        m_NonPlayerDialouge.style.display = DisplayStyle.Flex;
        m_TimerDisplay = displayTime;
    }
}
