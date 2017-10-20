﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class PaymentManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(PaymentManager), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("GA_Pay", GA_Pay);
		L.RegFunction("HasWXInstalled", HasWXInstalled);
		L.RegFunction("OpenWXLogin", OpenWXLogin);
		L.RegFunction("OpenAlipay", OpenAlipay);
		L.RegFunction("BPay", BPay);
		L.RegFunction("OpenWXPay", OpenWXPay);
		L.RegFunction("OpenAppStorePay", OpenAppStorePay);
		L.RegFunction("WXShareUrl", WXShareUrl);
		L.RegFunction("WXSharePic", WXSharePic);
		L.RegFunction("FinishAppStorePay", FinishAppStorePay);
		L.RegFunction("CheckOldAppPay", CheckOldAppPay);
		L.RegFunction("YsdkGuestLogin", YsdkGuestLogin);
		L.RegFunction("OpenYsdkPay", OpenYsdkPay);
		L.RegFunction("GetYsdkLoginInfo", GetYsdkLoginInfo);
		L.RegFunction("OpenBaiduLogin", OpenBaiduLogin);
		L.RegFunction("OpenBaiduPay", OpenBaiduPay);
		L.RegFunction("UCLogin", UCLogin);
		L.RegFunction("UCLogout", UCLogout);
		L.RegFunction("UCPay", UCPay);
		L.RegFunction("UCSubmitRoleData", UCSubmitRoleData);
		L.RegFunction("XiaoMiLogin", XiaoMiLogin);
		L.RegFunction("XiaoMiLogout", XiaoMiLogout);
		L.RegFunction("XiaoMiPay", XiaoMiPay);
		L.RegFunction("onXiaoMiLoginSucc", onXiaoMiLoginSucc);
		L.RegFunction("TianTianLogin", TianTianLogin);
		L.RegFunction("TianTianLogout", TianTianLogout);
		L.RegFunction("TianTianPay", TianTianPay);
		L.RegFunction("InitUcSingle", InitUcSingle);
		L.RegFunction("UcSinglePay", UcSinglePay);
		L.RegFunction("UcExit", UcExit);
		L.RegFunction("OpenVivoPay", OpenVivoPay);
		L.RegFunction("OpenLenovoPay", OpenLenovoPay);
		L.RegFunction("BaiduSinglePay", BaiduSinglePay);
		L.RegFunction("BaiduExit", BaiduExit);
		L.RegFunction("HuaweiLogin", HuaweiLogin);
		L.RegFunction("HuaweiTTLogin", HuaweiTTLogin);
		L.RegFunction("HuaweiPay", HuaweiPay);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GA_Pay(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			double arg0 = (double)LuaDLL.luaL_checknumber(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			double arg2 = (double)LuaDLL.luaL_checknumber(L, 3);
			PaymentManager.GA_Pay(arg0, arg1, arg2);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HasWXInstalled(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			bool o = PaymentManager.HasWXInstalled();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OpenWXLogin(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaFunction arg0 = ToLua.CheckLuaFunction(L, 1);
			PaymentManager.OpenWXLogin(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OpenAlipay(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			string arg0 = ToLua.CheckString(L, 1);
			LuaFunction arg1 = ToLua.CheckLuaFunction(L, 2);
			PaymentManager.OpenAlipay(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int BPay(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			PaymentManager.BPay(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OpenWXPay(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			string arg0 = ToLua.CheckString(L, 1);
			LuaFunction arg1 = ToLua.CheckLuaFunction(L, 2);
			PaymentManager.OpenWXPay(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OpenAppStorePay(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			string arg0 = ToLua.CheckString(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			LuaFunction arg2 = ToLua.CheckLuaFunction(L, 3);
			PaymentManager.OpenAppStorePay(arg0, arg1, arg2);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WXShareUrl(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 7);
			PaymentManager obj = (PaymentManager)ToLua.CheckObject(L, 1, typeof(PaymentManager));
			string arg0 = ToLua.CheckString(L, 2);
			string arg1 = ToLua.CheckString(L, 3);
			string arg2 = ToLua.CheckString(L, 4);
			string arg3 = ToLua.CheckString(L, 5);
			bool arg4 = LuaDLL.luaL_checkboolean(L, 6);
			LuaFunction arg5 = ToLua.CheckLuaFunction(L, 7);
			obj.WXShareUrl(arg0, arg1, arg2, arg3, arg4, arg5);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WXSharePic(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 6);
			PaymentManager obj = (PaymentManager)ToLua.CheckObject(L, 1, typeof(PaymentManager));
			string arg0 = ToLua.CheckString(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			int arg2 = (int)LuaDLL.luaL_checknumber(L, 4);
			bool arg3 = LuaDLL.luaL_checkboolean(L, 5);
			LuaFunction arg4 = ToLua.CheckLuaFunction(L, 6);
			obj.WXSharePic(arg0, arg1, arg2, arg3, arg4);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FinishAppStorePay(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			PaymentManager.FinishAppStorePay(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CheckOldAppPay(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaFunction arg0 = ToLua.CheckLuaFunction(L, 1);
			PaymentManager.CheckOldAppPay(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int YsdkGuestLogin(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaFunction arg0 = ToLua.CheckLuaFunction(L, 1);
			PaymentManager.YsdkGuestLogin(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OpenYsdkPay(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			string arg0 = ToLua.CheckString(L, 1);
			LuaFunction arg1 = ToLua.CheckLuaFunction(L, 2);
			PaymentManager.OpenYsdkPay(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetYsdkLoginInfo(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			string o = PaymentManager.GetYsdkLoginInfo();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OpenBaiduLogin(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaFunction arg0 = ToLua.CheckLuaFunction(L, 1);
			PaymentManager.OpenBaiduLogin(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OpenBaiduPay(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 5);
			string arg0 = ToLua.CheckString(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			long arg2 = (long)LuaDLL.luaL_checknumber(L, 3);
			string arg3 = ToLua.CheckString(L, 4);
			LuaFunction arg4 = ToLua.CheckLuaFunction(L, 5);
			PaymentManager.OpenBaiduPay(arg0, arg1, arg2, arg3, arg4);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UCLogin(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaFunction arg0 = ToLua.CheckLuaFunction(L, 1);
			PaymentManager.UCLogin(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UCLogout(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaFunction arg0 = ToLua.CheckLuaFunction(L, 1);
			PaymentManager.UCLogout(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UCPay(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			PaymentManager.UCPay(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UCSubmitRoleData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			string arg0 = ToLua.CheckString(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			long arg2 = (long)LuaDLL.luaL_checknumber(L, 3);
			long arg3 = (long)LuaDLL.luaL_checknumber(L, 4);
			PaymentManager.UCSubmitRoleData(arg0, arg1, arg2, arg3);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int XiaoMiLogin(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaFunction arg0 = ToLua.CheckLuaFunction(L, 1);
			PaymentManager.XiaoMiLogin(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int XiaoMiLogout(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaFunction arg0 = ToLua.CheckLuaFunction(L, 1);
			PaymentManager.XiaoMiLogout(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int XiaoMiPay(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 5);
			string arg0 = ToLua.CheckString(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			string arg2 = ToLua.CheckString(L, 3);
			string arg3 = ToLua.CheckString(L, 4);
			LuaFunction arg4 = ToLua.CheckLuaFunction(L, 5);
			PaymentManager.XiaoMiPay(arg0, arg1, arg2, arg3, arg4);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int onXiaoMiLoginSucc(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			PaymentManager obj = (PaymentManager)ToLua.CheckObject(L, 1, typeof(PaymentManager));
			string arg0 = ToLua.CheckString(L, 2);
			obj.onXiaoMiLoginSucc(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TianTianLogin(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaFunction arg0 = ToLua.CheckLuaFunction(L, 1);
			PaymentManager.TianTianLogin(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TianTianLogout(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaFunction arg0 = ToLua.CheckLuaFunction(L, 1);
			PaymentManager.TianTianLogout(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TianTianPay(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 5);
			double arg0 = (double)LuaDLL.luaL_checknumber(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			string arg2 = ToLua.CheckString(L, 3);
			string arg3 = ToLua.CheckString(L, 4);
			LuaFunction arg4 = ToLua.CheckLuaFunction(L, 5);
			PaymentManager.TianTianPay(arg0, arg1, arg2, arg3, arg4);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InitUcSingle(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaFunction arg0 = ToLua.CheckLuaFunction(L, 1);
			PaymentManager.InitUcSingle(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UcSinglePay(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 5);
			string arg0 = ToLua.CheckString(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			string arg2 = ToLua.CheckString(L, 3);
			string arg3 = ToLua.CheckString(L, 4);
			LuaFunction arg4 = ToLua.CheckLuaFunction(L, 5);
			PaymentManager.UcSinglePay(arg0, arg1, arg2, arg3, arg4);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UcExit(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			PaymentManager.UcExit();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OpenVivoPay(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 7);
			string arg0 = ToLua.CheckString(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			string arg2 = ToLua.CheckString(L, 3);
			string arg3 = ToLua.CheckString(L, 4);
			string arg4 = ToLua.CheckString(L, 5);
			int arg5 = (int)LuaDLL.luaL_checknumber(L, 6);
			LuaFunction arg6 = ToLua.CheckLuaFunction(L, 7);
			PaymentManager.OpenVivoPay(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OpenLenovoPay(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 5);
			string arg0 = ToLua.CheckString(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			int arg2 = (int)LuaDLL.luaL_checknumber(L, 3);
			float arg3 = (float)LuaDLL.luaL_checknumber(L, 4);
			string arg4 = ToLua.CheckString(L, 5);
			PaymentManager.OpenLenovoPay(arg0, arg1, arg2, arg3, arg4);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int BaiduSinglePay(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 5);
			string arg0 = ToLua.CheckString(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			string arg2 = ToLua.CheckString(L, 3);
			string arg3 = ToLua.CheckString(L, 4);
			int arg4 = (int)LuaDLL.luaL_checknumber(L, 5);
			PaymentManager.BaiduSinglePay(arg0, arg1, arg2, arg3, arg4);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int BaiduExit(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			PaymentManager.BaiduExit();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HuaweiLogin(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			bool arg0 = LuaDLL.luaL_checkboolean(L, 1);
			LuaFunction arg1 = ToLua.CheckLuaFunction(L, 2);
			PaymentManager.HuaweiLogin(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HuaweiTTLogin(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			LuaFunction arg1 = ToLua.CheckLuaFunction(L, 2);
			PaymentManager.HuaweiTTLogin(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HuaweiPay(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 5);
			string arg0 = ToLua.CheckString(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			string arg2 = ToLua.CheckString(L, 3);
			string arg3 = ToLua.CheckString(L, 4);
			string arg4 = ToLua.CheckString(L, 5);
			PaymentManager.HuaweiPay(arg0, arg1, arg2, arg3, arg4);
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
}
