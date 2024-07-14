 
using System.Collections.Generic;
using System.ComponentModel;
using SLZ.Marrow;
using UnityEngine;
using SLZ.Marrow.Warehouse;

namespace UnityEditor.AddressableAssets.Settings.GroupSchemas
{
    [DisplayName("Pallet Settings")]
    public class PalletGroupSchema : AddressableAssetGroupSchema
    {
        [SerializeField]
        Pallet _pallet;
        public Pallet Pallet
        {
            get
            {
                return _pallet;
            }

            set
            {
                _pallet = value;
                SetDirty(true);
            }
        }

        [SerializeField]
        MarrowSettings _marrowGame;
        public MarrowSettings MarrowGame
        {
            get
            {
                return _marrowGame;
            }

            set
            {
                _marrowGame = value;
                SetDirty(true);
            }
        }

        public override void OnGUIMultiple(List<AddressableAssetGroupSchema> otherSchemas)
        {
            var so = new SerializedObject(this);
            SerializedProperty prop;
            prop = so.FindProperty("_pallet");
            ShowMixedValue(prop, otherSchemas, typeof(Pallet), "_pallet");
            EditorGUI.BeginChangeCheck();
            Pallet newPallet = (Pallet)EditorGUILayout.ObjectField(prop.displayName, Pallet, typeof(Pallet), false);
            if (EditorGUI.EndChangeCheck())
            {
                Pallet = newPallet;
                foreach (var s in otherSchemas)
                    (s as PalletGroupSchema).Pallet = Pallet;
            }

            prop = so.FindProperty("_marrowGame");
            ShowMixedValue(prop, otherSchemas, typeof(Pallet), "_marrowGame");
            EditorGUI.BeginChangeCheck();
            MarrowSettings newMarrowGame = (MarrowSettings)EditorGUILayout.ObjectField(prop.displayName, MarrowGame, typeof(MarrowSettings), false);
            if (EditorGUI.EndChangeCheck())
            {
                MarrowGame = newMarrowGame;
                foreach (var s in otherSchemas)
                    (s as PalletGroupSchema).MarrowGame = MarrowGame;
            }

            EditorGUI.showMixedValue = false;
            so.ApplyModifiedProperties();
        }
    }
}