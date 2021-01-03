using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 研招网系统.BLL
{
    interface IUserManager
    {
        Task Register(string name,string password);
        Task<bool> Login(Guid id, string password);
        Task ChangePassword(Guid id, string pwd, string newpwd);
    }
    interface IStuManager : IUserManager
    {
        Task ChangeInformation(string major, string colleges, string area, Guid schoolid);

    }
}
