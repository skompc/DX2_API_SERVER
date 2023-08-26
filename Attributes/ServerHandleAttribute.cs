using System;

namespace Dx2_API_SERVER.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class ServerHandleAttribute : Attribute
    {
        public string[] Urls;
        public string[] Types;

        public ServerHandleAttribute(params string[] _urls)
        {
            Urls = _urls;
            Types = new string[0];
        }
    }
}
