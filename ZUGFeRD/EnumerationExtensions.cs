﻿/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 * 
 *   http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using System;

namespace s2industries.ZUGFeRD
{
    internal static class EnumerationExtensions
    {
        internal static string AsString<T>(this T value) where T : Enum
        {
            return Enum.GetName(typeof(T), value);
        }

        internal static T AsEnum<T>(this int value) where T : Enum
        {
            if (Enum.IsDefined(typeof(T), value))
            {
                return (T)Enum.ToObject(typeof(T), value);
            }
            else
            {
                throw new ArgumentException($"{value} is not a valid value for enum {typeof(T).Name}");
            }
        }

        internal static int AsInt<T>(this T value) where T : Enum
        {
            return (int)(object)value;
        }
    }
}