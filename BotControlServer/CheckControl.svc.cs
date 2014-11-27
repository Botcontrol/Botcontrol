using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BotControlServer
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "CheckControl" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы CheckControl.svc или CheckControl.svc.cs в обозревателе решений и начните отладку.
    public class CheckControl : ICheckControl
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
