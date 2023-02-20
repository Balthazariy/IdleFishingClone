using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Balthazariy.IdleFishinClone.Utilities
{
    public static class InternalTools
    {
        private static Camera _camera;
        public static Camera Camera
        {
            get
            {
                if (_camera == null)
                    _camera = Camera.main;
                return _camera;
            }
        }

        private static PointerEventData _currentPositionEventData;
        private static List<RaycastResult> _results;
        public static bool IsOverUI()
        {
            _currentPositionEventData = new PointerEventData(EventSystem.current)
            {
                position = Input.mousePosition
            };
            _results = new List<RaycastResult>();
            EventSystem.current.RaycastAll(_currentPositionEventData, _results);
            return _results.Count > 0;
        }

        public static Vector2 GetWorldPositionOfCanvasElement(RectTransform element)
        {
            RectTransformUtility.ScreenPointToWorldPointInRectangle(element, element.position, Camera, out var result);
            return result;
        }

        public static void DeleteAllChilds(this Transform parent)
        {
            foreach (Transform child in parent)
            {
                MonoBehaviour.Destroy(child.gameObject);
            }
        }
    }
}