using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel : MonoBehaviour
{
    public Button SelectedButton;

    private void OnEnable()
    {
        ResetSelection();
    }

    public virtual void ResetSelection()
    {
        SelectedButton.Select();
    }

    public void Show()
    {
        this.gameObject.SetActive(true);
    }

    public void Hide()
    {
        this.gameObject.SetActive(false);
    }
}
