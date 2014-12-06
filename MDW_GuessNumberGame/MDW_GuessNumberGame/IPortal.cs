using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace GameContract
{
    [ServiceContract(Namespace = "GameContract", CallbackContract = typeof(IPortalCallBack))]
    public interface IPortal
    {
    [OperationContract]
    bool UserRegister(string userID, string passWord);
    }

    public interface IPortalCallBack
   {
    [OperationContract]
    void UserLogin(string userID, string passWord);

    [OperationContract]
    bool UserRegister(string userID, string passWord);
   }
}
