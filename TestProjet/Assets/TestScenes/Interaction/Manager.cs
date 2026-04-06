using TMPro;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class Manager : MonoBehaviour
{
    public TMP_Text hpTextDisplay;
    private int HP;
    public TMP_Text energyTextDisplay;
    private int Energy;

    public int getHP()
    {
        return HP;
    }
    public int getEnergy()
    {
        return Energy;
    }

    public void setHP(int HP)
    {
        this.HP = HP;
        hpTextDisplay.text = HP+"";
    }

    public void setEnergy(int energy)
    {
        this.Energy = energy;
        energyTextDisplay.text = energy + "%";
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
