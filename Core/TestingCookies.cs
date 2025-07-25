using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
#if ROMDEV_TESTINGPACKAGE_INSTALLED
using RomDev.TestingPackageSpace;
#endif
namespace RomDev.TestingPackageSpace2
{
    public class TestingCookies : MonoBehaviour
    {
#if ROMDEV_TESTINGPACKAGE_INSTALLED
        public TestingPackage2 testingPackage;
#endif
        public void TestPrint()
        {
#if ROMDEV_TESTINGPACKAGE_INSTALLED
            Debug.Log("Testing package is installed");
#else
            Debug.Log("Testing package is not installed");
#endif
        }
    }
}

