using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;


[LuaCallCSharp]
public class TestAsClass
{
    public string x;
    public int y;

    public TestAsClass(string x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void Test1()
    {
    }

}


[LuaCallCSharp]
public class TestAslstClass
{
    public List<Vector3> lstVec;

    public TestAslstClass()
    {
    }

    public Vector3 getVector(int index)
    {
        return lstVec[index];
    }

}

public class Lua2CS : MonoBehaviour
{
    // Start is called before the first frame update
    public TextAsset luaScript;

    private readonly LuaEnv _luaEnv = new LuaEnv();
    void Start()
    {
        _luaEnv.DoString(luaScript.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
