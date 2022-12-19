using System;

public class User
{
    public string username;
    public string password;
    public User(string un, string pw)
    {
        username = un;
        password = pw;
    }
}


public class Master : User
{
    public Master(string un, string pw) : base(un, pw)
    {
        username = un;
        password = pw;
    }
}


public class Guest : User
{
    public Guest(string un, string pw) : base(un, pw)
    {
        username = un;
        password = pw;
    }
}
