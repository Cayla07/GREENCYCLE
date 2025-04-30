using System;

namespace GREENCYCLE.Classes
{
    public abstract class InformationClass
    {
 
    }

    public class UserLoginInfo : InformationClass
    {
        public string UserEmail { get; set; }
    }

    public class AdminLoginInfo : InformationClass
    {
        public string AdminEmail { get; set; }
    }
}