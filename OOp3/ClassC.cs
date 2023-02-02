﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP3
{
    internal class ClassC: Student
    {
        public readonly string Literature = "Mon Van";
        public readonly string History = "Mon Su";
        public readonly string Geography = "Mon Dia ly";
        public ClassC(string id, string name, string adress, string priority) : base(id, name, adress, priority)
        {
        }
        public override String ToString()
        {
            return $"**Khoi A:\nID: {id} \n Ten hoc sinh : {name}\n Dia chi: {address}\n Muc uu tien: {priority} \n Mon thi: {Literature}, {History}, {Geography}";
        }
    }
}
