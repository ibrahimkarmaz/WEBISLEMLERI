﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDAL _messageDAL;

        public MessageManager(IMessageDAL messageDAL)
        {
            _messageDAL = messageDAL;
        }

        public Message GetById(int id)
        {
            return _messageDAL.GetById(id);
        }

        public List<Message> GetInboxListByWriter(string p)
        {
            return _messageDAL.GetListAll(x => x.Receiver == p);
        }

        public List<Message> GetList()
        {
            return _messageDAL.GetListAll();
        }

        public void TAdd(Message t)
        {
            _messageDAL.Insert(t);
        }

        public void TDelete(Message t)
        {
            _messageDAL.Delete(t);
        }

        public void TUpdate(Message t)
        {
            _messageDAL.Update(t);
        }
    }
}
