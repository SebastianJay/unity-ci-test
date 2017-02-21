using System;
using System.Reflection;
using UnityEngine;

public class TestHelper
{
	public static void AddMonoBehaviourAndInit<T>(GameObject o) where T : MonoBehaviour
	{
		o.AddComponent<T> ();
		ExecAwakeStartUpdate (o.GetComponent<T> ());
	}

	public static void ExecAwakeStartUpdate(MonoBehaviour mb)
	{
		ExecMethod (mb, "Awake", null);
		ExecMethod (mb, "Start", null);
		ExecMethod (mb, "Update", null);
	}

	public static void ExecMethod(MonoBehaviour mb, string name, object[] args)
	{
		Type t = mb.GetType();
		MethodInfo mi = t.GetMethod (name, BindingFlags.NonPublic | BindingFlags.Instance);
		try {
			mi.Invoke (mb, args);
		} catch(TargetInvocationException) {
		} catch(NullReferenceException) {
		}
	}
}
