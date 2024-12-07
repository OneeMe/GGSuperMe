/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) 2024 PICO Developer
// SPDX-License-Identifier: MIT
////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace GGSuperMe.Runtime.UI
{
    public class MainMenu : MonoBehaviour
    {
        [Header("Main Page")]
        public PaintShootPage PaintShootPage;
        public DebugMainPage DebugMainPage;

        [Header("Activity Buttons")]
        public Toggle PaintShootButton;
        public Toggle DebugMainPageButton;

        private Vector3 _cameraPosition;

        public event Action OnClose;

        private void Awake()
        {
            this.gameObject.SetActive(false);
        }

        public void Open()
        {
            gameObject.SetActive(true);
            if (Camera.main != null)
            {
                var mainCameraTransform = Camera.main.transform;
                var cameraPos = mainCameraTransform.position;
                var targetPos = cameraPos + mainCameraTransform.forward * 0.8f;
                gameObject.transform.position = targetPos;
                var directionToTarget = targetPos - cameraPos;
                var orientation = Quaternion.LookRotation(directionToTarget);
                gameObject.transform.rotation = orientation;
            }
        }

        public void Close()
        {
            gameObject.SetActive(false);
            OnClose?.Invoke();
        }

        private void OnEnable()
        {
            _cameraPosition = Camera.main.transform.position;
            PaintShootButton.onValueChanged.AddListener(OnPaintShoot);
            DebugMainPageButton.onValueChanged.AddListener(OnDebugMainPage);
            CheckIfDeActive().Forget();
        }

        private void OnDisable()
        {
            DebugMainPageButton.onValueChanged.RemoveListener(OnDebugMainPage);
            PaintShootButton.onValueChanged.RemoveListener(OnPaintShoot);
        }

        private void OnPaintShoot(bool isOn)
        {
            if (isOn)
            {
                PaintShootPage.TogglePage();
            }
        }

        private void OnDebugMainPage(bool isOn)
        {
            if (isOn)
            {
                DebugMainPage.Open();
            }
        }

        private async UniTaskVoid CheckIfDeActive()
        {
            while (true)
            {
                await UniTask.Delay(1000);
                var mainCameraPos = Camera.main.transform.position;
                var dis = Vector3.Distance(_cameraPosition, mainCameraPos);
                if (dis > 2f)
                {
                    Close();
                    break;
                }
            }
        }
    }
}
