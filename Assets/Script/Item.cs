using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;
using UnityEngine.Events;

public class Item : MonoBehaviour
{
    [Header("�A�C�e�����E��ꂽ���̃C�x���g")]
    public UnityEvent onPickUp;
    /// <summary>
    /// �E��ꂽ���Ă΂��
    /// </summary>
    public void PickUp()
    {
        print("�E��ꂽ�I");
        onPickUp.Invoke();
        Destroy(gameObject);
    }
    public void GetItem()
    {

    }
}