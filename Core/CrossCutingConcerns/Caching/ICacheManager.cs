﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCutingConcerns.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key);
        object Get(string key);
        void Add(string key,object value,int duration);
        void Remove(string key);
        bool IsAdd(string key); 
        void RemoveByPattern(string pattern);
    }
}
