﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational
{
    public class Singleton

    {
        private static Singleton _instance;

        // Constructor is 'protected'

        protected Singleton()
        {
        }

        public static Singleton Instance()
        {
            // Uses lazy initialization.

            // Note: this is not thread safe.

            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    }
}
