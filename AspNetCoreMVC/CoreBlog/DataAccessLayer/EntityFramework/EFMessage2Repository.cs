﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFMessage2Repository : GenericRepository<Message2>, IMessage2DAL
    {
        public List<Message2> GetListWithMessageByWriter(int id)
        {
            using (var _context=new Context())
            {
                return _context.Message2s.Include(x => x.SenderUser).Where(a => a.Receiver == id).ToList();
            }
        }
    }
}
