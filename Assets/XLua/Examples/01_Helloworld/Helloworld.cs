/*
 * Tencent is pleased to support the open source community by making xLua available.
 * Copyright (C) 2016 THL A29 Limited, a Tencent company. All rights reserved.
 * Licensed under the MIT License (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at
 * http://opensource.org/licenses/MIT
 * Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
*/

using UnityEngine;
using XLua;
using XLua.LuaDLL;
using LuaAPI = XLua.LuaDLL.Lua;

namespace XLuaTest
{

    public class Helloworld : MonoBehaviour
    {
        // Use this for initialization
        void Start()
        {
            LuaEnv luaenv = new LuaEnv();
            //luaenv.DoString(" CS.UnityEngine.Debug.Log('hello world')");
            luaenv.DoString("local dataV = CS.UnityEngine.Vector3(5,6,7); local dataV = CS.UnityEngine.Vector3(1,2,3)");
         
            //luaenv.DoString("local dataV = CS.UnityEngine.Vector3(5,6,7); dataV:Normalize();CS.UnityEngine.Debug.Log('hello world')");
            luaenv.Dispose();

            //Test();
        }

        // Update is called once per frame
        void Update()
        {

        }

        void Test()
        {
           var L =  LuaAPI.luaL_newstate();
           for (int i = 1; i <= 5; i++)
           {
               LuaAPI.lua_pushnumber(L, i);
           }

           Debug.Log("Stack is : ");

           LuaAPI.lua_insert(L, 3);

           for (int i = 1; i <= LuaAPI.lua_gettop(L); i++)
           {
               Debug.Log(LuaAPI.lua_tonumber(L, i) + ";");
           }

        }
    }
}
