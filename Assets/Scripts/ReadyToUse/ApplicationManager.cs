using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ReadyToUse
{
    public class ApplicationManager : MonoBehaviour
    {
        private void Awake()
        {
            FXManager.Initialize();
        }
    }
}