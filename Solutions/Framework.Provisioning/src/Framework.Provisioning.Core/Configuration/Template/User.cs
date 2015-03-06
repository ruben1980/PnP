﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Framework.Provisioning.Core.Configuration.Template
{
    /// <summary>
    /// Domain Object that defines a User in the Site Template
    /// </summary>
    public partial class User
    {
        [XmlAttribute]
        public string Name { get; set; }
    }
}
