using Business.Service;
using DataLayer.Abstratcs;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Content
{
    public class MessageManager : IGenericService<Message>, IMessageService
    {
        private readonly IMessage _message;
        MessageManager(IMessage message)
        {
            _message = message;
        }        
        public void TAdd(Message t)
        {
            _message.Add(t);
        }

        public List<Message> TGetAll()
        {
            throw new NotImplementedException();
        }

        public Message TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TRemove(Message t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Message t)
        {
            throw new NotImplementedException();
        }
    }
}
