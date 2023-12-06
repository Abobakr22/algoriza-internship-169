﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Core.Consts
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Gender
    {
       Female = 0 ,
       Male = 1
    }

}
