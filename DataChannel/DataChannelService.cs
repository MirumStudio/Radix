using Radix.Service;
using Radix.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radix.DataChannel
{
    public class DataChannelService : ServiceBase
    {
        public static string Param { get; set; }
        private List<DataChannel> mDataChannelList; 

        protected override void Init()
        {
            mDataChannelList = new List<DataChannel>();

            List<Type> DataChannelType = GetAllDataChannelType();
            //DataChannelType.ForEach(CreateService);
        }

        protected override void Dispose()
        {
            
        }

        static public DataChannel Get<T>() where T : DataChannel
        {
            return null;
        }

        private List<Type> GetAllDataChannelType()
        {
            return TypeUtility.GetAllTypeFromNamespace(typeof(DataChannel), "Radix");
        }
    }
}
