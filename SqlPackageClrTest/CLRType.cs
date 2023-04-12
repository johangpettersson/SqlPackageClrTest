using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;


[Serializable]
[Microsoft.SqlServer.Server.SqlUserDefinedType(Format.Native, IsByteOrdered = true)]
public struct CLRType: INullable
{
    public override string ToString()
    {
        // Replace with your own code
        return string.Empty;
    }
    
    public bool IsNull
    {
        get
        {
            // Put your code here
            return _null;
        }
    }
    
    public static CLRType Null
    {
        get
        {
            CLRType h = new CLRType();
            h._null = true;
            return h;
        }
    }
    
    public static CLRType Parse(SqlString s)
    {
        if (s.IsNull)
            return Null;
        CLRType u = new CLRType();
        // Put your code here
        return u;
    }
    
    // This is a place-holder method
    public string Method1()
    {
        // Put your code here
        return string.Empty;
    }
    
    // This is a place-holder static method
    public static SqlString Method2()
    {
        // Put your code here
        return new SqlString("");
    }
    
    // This is a place-holder member field
    public int _var1;
 
    //  Private member
    private bool _null;
}