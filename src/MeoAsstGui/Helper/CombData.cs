// MeoAsstGui - A part of the MeoAssistantArknights project
// Copyright (C) 2021 MistEO and Contributors
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY

namespace MeoAsstGui
{
    public class GenericCombData<ValueType>
    {
        public string Display { get; set; }
        public ValueType Value { get; set; }
    }

    public class CombData : GenericCombData<string>
    {
    }
}
