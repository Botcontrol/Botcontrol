using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CheckResponseContract
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract]
    public interface ICheckControlCotract
    {
        [OperationContract]
        List<CheckResponse> GetData();

    }

     [DataContract]
    public class CheckResponse
    {   
        [DataMember]
        public string FolderName { get; set; }

        [DataMember]
        public TimeSpan CheckTime { get; set; }
       
        [DataMember]
        public string CodeNumber { get; set; }
     
        public CheckResponse(string folderName, TimeSpan checkTime, string codeNumber)
        {
            FolderName = folderName;
            CheckTime = checkTime;
            CodeNumber = codeNumber;
        }
    }
    
}
