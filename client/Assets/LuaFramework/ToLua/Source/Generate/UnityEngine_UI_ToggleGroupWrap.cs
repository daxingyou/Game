﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_UI_ToggleGroupWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.UI.ToggleGroup), typeof(UnityEngine.EventSystems.UIBehaviour));
		L.RegFunction("NotifyToggleOn", NotifyToggleOn);
		L.RegFunction("UnregisterToggle", UnregisterToggle);
		L.RegFunction("RegisterToggle", RegisterToggle);
		L.RegFunction("AnyTogglesOn", AnyTogglesOn);
		L.RegFunction("ActiveToggles", ActiveToggles);
		L.RegFunction("SetAllTogglesOff", SetAllTogglesOff);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("allowSwitchOff", get_allowSwitchOff, set_allowSwitchOff);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int NotifyToggleOn(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.ToggleGroup obj = (UnityEngine.UI.ToggleGroup)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.ToggleGroup));
			UnityEngine.UI.Toggle arg0 = (UnityEngine.UI.Toggle)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.UI.Toggle));
			obj.NotifyToggleOn(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnregisterToggle(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.ToggleGroup obj = (UnityEngine.UI.ToggleGroup)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.ToggleGroup));
			UnityEngine.UI.Toggle arg0 = (UnityEngine.UI.Toggle)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.UI.Toggle));
			obj.UnregisterToggle(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RegisterToggle(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.ToggleGroup obj = (UnityEngine.UI.ToggleGroup)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.ToggleGroup));
			UnityEngine.UI.Toggle arg0 = (UnityEngine.UI.Toggle)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.UI.Toggle));
			obj.RegisterToggle(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AnyTogglesOn(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.ToggleGroup obj = (UnityEngine.UI.ToggleGroup)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.ToggleGroup));
			bool o = obj.AnyTogglesOn();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ActiveToggles(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.ToggleGroup obj = (UnityEngine.UI.ToggleGroup)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.ToggleGroup));
			System.Collections.Generic.IEnumerable<UnityEngine.UI.Toggle> o = obj.ActiveToggles();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetAllTogglesOff(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.ToggleGroup obj = (UnityEngine.UI.ToggleGroup)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.ToggleGroup));
			obj.SetAllTogglesOff();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_ToString(IntPtr L)
	{
		object obj = ToLua.ToObject(L, 1);

		if (obj != null)
		{
			LuaDLL.lua_pushstring(L, obj.ToString());
		}
		else
		{
			LuaDLL.lua_pushnil(L);
		}

		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_allowSwitchOff(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.ToggleGroup obj = (UnityEngine.UI.ToggleGroup)o;
			bool ret = obj.allowSwitchOff;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index allowSwitchOff on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_allowSwitchOff(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.ToggleGroup obj = (UnityEngine.UI.ToggleGroup)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.allowSwitchOff = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index allowSwitchOff on a nil value" : e.Message);
		}
	}
}

