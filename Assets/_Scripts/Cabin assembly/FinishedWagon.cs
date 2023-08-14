using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishedWagon : ParentObjectsOnPlace
{
    public bool IsPlatformPlaced;
    private bool IsParented;
    private void Start()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;

    }
    private void FixedUpdate()
    {
        if (IsPlatformPlaced && !IsParented)
        {
            Taskbar.singleton.PrintText("��������� ����� �� �������");
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            gameObject.GetComponent<MeshCollider>().enabled = true;
        }
    }
    public override void OnReleaseObject(GameObject other)
    {
        base.OnReleaseObject(other);
        IsParented = true;
        OnVagonDone();
    }

    void OnVagonDone()
    {
        Debug.Log("Vagon is done!!!");
        Taskbar.singleton.PrintText("��������� ����� � ������ �������� ���������!");
    }
}
