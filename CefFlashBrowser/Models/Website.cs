﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CefFlashBrowser.Models
{
    class Website
    {
        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException();
                else
                    _name = value;
            }
        }

        private string _url;

        public string Url
        {
            get => _url;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException();
                else
                    _url = value;
            }
        }

        public Website(string name, string url)
        {
            Name = name;
            Url = url;
        }

        public static bool operator ==(Website left, Website right)
        {
            return left.Name == right.Name && left.Url == right.Url;
        }

        public static bool operator !=(Website left, Website right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}