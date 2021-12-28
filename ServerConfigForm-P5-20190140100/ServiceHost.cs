using System;

namespace ServerConfigForm_P5_20190140100
{
    public class ServiceHost
    {
        private Type type;

        public ServiceHost(Type type)
        {
            this.type = type;
        }

        internal int Close()
        {
            return 0;
        }

        internal int Open()
        {
            return 0;
        }
    }
}