﻿using System;
using System.Collections.Generic;

namespace WinFormsMvp
{
    public class AppState : IAppState
    {
        readonly IDictionary<string, dynamic> _items;

        public AppState()
        {
            _items = new Dictionary<string, dynamic>(StringComparer.Ordinal);
        }

        public void AddItem<T>(string key, T item)
        {
            if(string.IsNullOrWhiteSpace(key))
                throw new ArgumentNullException("key", "The key cannot be either null, or an empty string.");
            _items.Add(key, item);
        }

        public void Clear()
        {
            _items.Clear();
        }

        public T GetItem<T>(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentNullException("key", "The key cannot be either null, or an empty string.");

            return _items[key];
        }

        public bool HasItem(string key)
        {
            return _items.ContainsKey(key);
        }


        public void RemoveItem<T>(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentNullException("key", "The key cannot be either null, or an empty string.");

            if(HasItem(key))
                _items.Remove(key);
            else
                throw new KeyNotFoundException(string.Format("There is no key with a value of {0} in AppState.", key));
        }
    }
}
