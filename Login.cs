using System;

public class Login
{
    public bool login(string u, string p)
    {
        if (u == "username" && p == "pass")
            return true;
        return false;
    }
}
