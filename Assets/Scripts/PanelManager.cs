using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UIElements;
using UnityEngine.UIElements;

namespace Monobehavior
{

    public class PanelManager1 : Monobehaviour
    {
        private void OnEnable()
        {
            EmptyBookshelfScreen.postUxmlReload = BindEmptyBookshelfScreen;

        }

        private IEnumerate<Object> BindEmptyBookshelfScreen()
        {
            var root = BindEmptyBookshelfScreen.visualTree;
            var addButton = root.Q<Button>("addButton");
            if (addButton != null)
            {
                addButton.clickable.clicked += () =>
                {
                    Debug.Log("Clicked on add button");
                };
            }
            return null;
        }
    }
}