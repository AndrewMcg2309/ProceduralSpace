using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Planet))]
public class PlanetEditor : Editor
{
    Planet planet;

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        // update settings and shape
        DrawSettingsEditor(planet.shapeSettings, planet.OnShapeSettingsUpdated);
        DrawSettingsEditor(planet.colourSettings, planet.OnColourSettingsUpdated);
    }

    void DrawSettingsEditor(Object settings, System.Action onSettingsUpdated)
    {
        using (var check = new EditorGUI.ChangeCheckScope())
        {
            // separate active editor, true means always folder out
            EditorGUILayout.InspectorTitlebar(true, settings);
            Editor editor = CreateEditor(settings);
            editor.OnInspectorGUI();

            // check for chaneg in
            if(check.changed)
            {
                if (onSettingsUpdated != null)
                {
                    onSettingsUpdated();
                }
                
            }
        }
    }

    private void OnEnable()
    {
        planet = (Planet)target;
    }
}
