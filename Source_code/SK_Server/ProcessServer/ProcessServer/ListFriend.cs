﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Friend;

namespace ProcessServer
{
    class ListFriend
    {
        private List<friend> listFriend;
        public string Name { get; set; }
        public ListFriend()
        {
            listFriend = new List<friend>();
        }
        public List<byte[]> getFriend()
        {
            List<byte[]> data = new List<byte[]>();
            foreach(friend i in listFriend)
            {             
                data.Add(SerializeData(i));               
            }    
            return data;
        }
        public void setFriend(int id)
        {         
            DB_Model db = new DB_Model();
            var liststt = from p in db.Box_chat where p.Id == id select new {p.STT };

            foreach(var i in liststt)
            {
                if(i.STT %2 !=0)
                {
                    Box_chat bc = db.Box_chat.Find(i.STT + 1);
                    Person FR = db.Person.Find(bc.Id);
                    friend fr = new friend(FR.Id, FR.Ipaddress, FR.Full_name);
                    listFriend.Add(fr);
                }
                else
                {
                    Box_chat bc = db.Box_chat.Find(i.STT - 1);
                    Person FR = db.Person.Find(bc.Id);
                    friend fr = new friend(FR.Id, FR.Ipaddress, FR.Full_name);
                    listFriend.Add(fr);
                }                                 
            }    
        }
        public byte[] SerializeData(object fr)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf1 = new BinaryFormatter();
            bf1.Serialize(ms,fr);
            return ms.ToArray();
        }

    }
}
