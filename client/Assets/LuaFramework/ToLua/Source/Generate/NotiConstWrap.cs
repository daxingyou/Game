﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class NotiConstWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(NotiConst), typeof(System.Object));
		L.RegFunction("New", _CreateNotiConst);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("START_UP", get_START_UP, null);
		L.RegVar("DISPATCH_MESSAGE", get_DISPATCH_MESSAGE, null);
		L.RegVar("UPDATE_LOADING", get_UPDATE_LOADING, null);
		L.RegVar("UPDATE_MESSAGE", get_UPDATE_MESSAGE, null);
		L.RegVar("UPDATE_EXTRACT", get_UPDATE_EXTRACT, null);
		L.RegVar("UPDATE_DOWNLOAD", get_UPDATE_DOWNLOAD, null);
		L.RegVar("UPDATE_PROGRESS", get_UPDATE_PROGRESS, null);
		L.RegVar("UPDATE_FINISH", get_UPDATE_FINISH, null);
		L.RegVar("UPDATE_TIMEOUT", get_UPDATE_TIMEOUT, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateNotiConst(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				NotiConst obj = new NotiConst();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: NotiConst.New");
			}
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
	static int get_START_UP(IntPtr L)
	{
		LuaDLL.lua_pushstring(L, NotiConst.START_UP);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_DISPATCH_MESSAGE(IntPtr L)
	{
		LuaDLL.lua_pushstring(L, NotiConst.DISPATCH_MESSAGE);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_UPDATE_LOADING(IntPtr L)
	{
		LuaDLL.lua_pushstring(L, NotiConst.UPDATE_LOADING);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_UPDATE_MESSAGE(IntPtr L)
	{
		LuaDLL.lua_pushstring(L, NotiConst.UPDATE_MESSAGE);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_UPDATE_EXTRACT(IntPtr L)
	{
		LuaDLL.lua_pushstring(L, NotiConst.UPDATE_EXTRACT);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_UPDATE_DOWNLOAD(IntPtr L)
	{
		LuaDLL.lua_pushstring(L, NotiConst.UPDATE_DOWNLOAD);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_UPDATE_PROGRESS(IntPtr L)
	{
		LuaDLL.lua_pushstring(L, NotiConst.UPDATE_PROGRESS);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_UPDATE_FINISH(IntPtr L)
	{
		LuaDLL.lua_pushstring(L, NotiConst.UPDATE_FINISH);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_UPDATE_TIMEOUT(IntPtr L)
	{
		LuaDLL.lua_pushstring(L, NotiConst.UPDATE_TIMEOUT);
		return 1;
	}
}

