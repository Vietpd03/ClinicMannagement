using QLPM.Common.BLL;
using QLPM.Common.Rsp;
using QLPM.DAL.Models;
using QLPM.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPM.DAL.Repositories;

namespace QLPM.BLL.Services
{
    public class UserService
    {
        private readonly UserRepository _repository;

        public UserService(UserRepository repository)
        {
            _repository = repository;
        }

        public SingleRsp GetAllUsers()
        {
            var res = new SingleRsp();
            res.Data = _repository.GetAll();
            return res;
        }

        public SingleRsp GetUserById(int id)
        {
            var res = new SingleRsp();
            res.Data = _repository.GetById(id);
            return res;
        }

        public SingleRsp CreateUser(User user)
        {
            var res = new SingleRsp();
            _repository.Create(user);
            res.Data = user;
            return res;
        }

        public SingleRsp UpdateUser(User user)
        {
            var res = new SingleRsp();
            _repository.Update(user);
            res.Data = user;
            return res;
        }

        public SingleRsp DeleteUser(int id)
        {
            var res = new SingleRsp();
            _repository.Delete(id);
            return res;
        }
    }
}
