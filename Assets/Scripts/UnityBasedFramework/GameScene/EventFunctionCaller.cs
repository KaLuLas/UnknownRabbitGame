﻿#region FILE HEADER
// Filename: EventFunctionCaller.cs
// Author: Kalulas
// Create: 2022-06-19
// Description:
#endregion

using Framework.GameScene;
using UnityEngine.ResourceManagement.Util;

namespace UnityBasedFramework.GameScene
{
    public abstract class EventFunctionCaller : ComponentSingleton<EventFunctionCaller>, IEventFunctionCaller
    {
        public abstract void OnCallerAwake();
        public abstract void OnCallerStart();
        public abstract void OnCallerUpdate();
        public abstract void OnCallerDestroy();
        
        
        private void Awake()
        {
            OnCallerAwake();
        }

        private void Start()
        {
            OnCallerStart();
        }

        private void Update()
        {
            OnCallerUpdate();
        }

        private void OnDestroy()
        {
            OnCallerDestroy();
        }
    }
}