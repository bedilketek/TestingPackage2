
using UnityEditor;
using UnityEngine;

namespace RomDev.TestingPackageSpace2
{
    [CustomEditor(typeof(TestingCookies))]
    public class TestingCookiesEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            TestingCookies testingCookies = (TestingCookies)target;
            if(GUILayout.Button("Print"))
            {
                testingCookies.TestPrint();
            }
        }
    }
}

