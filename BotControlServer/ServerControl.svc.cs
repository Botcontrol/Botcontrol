using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using CheckResponseContract;

namespace BotControlServer
{
    
    public class ServerCheckControl : ICheckControlCotract
    {
        public List<CheckResponse> GetData()
        {
           return new List<CheckResponse>
           {
               new CheckResponse("Quik",new TimeSpan(10,10,10),"0"),
               new CheckResponse("MT5",new TimeSpan(11,11,11),"2")
           };
        }
    }
}
