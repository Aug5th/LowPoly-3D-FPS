using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AmmoText : MyMonoBehaviour
{
    [SerializeField] private TextMeshProUGUI ammoText;
    protected override void LoadComponents()
    {
        ammoText = GetComponent<TextMeshProUGUI>();
        base.LoadComponents();
    }

    private string GetAmmoTextString(int currentTapeAmmo, int currentAmmo)
    {
        return currentTapeAmmo.ToString() + " / " + currentAmmo.ToString();
    }

    public void UpdateAmmoText(int currentTapeAmmo, int currentAmmo)
    {
        ammoText.text = GetAmmoTextString(currentTapeAmmo, currentAmmo);
    }
}
