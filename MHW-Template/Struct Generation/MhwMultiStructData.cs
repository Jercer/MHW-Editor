﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using MHW_Template.Models;

namespace MHW_Template.Struct_Generation {
    public class MhwMultiStructData {
        public readonly List<StructData> structs;
        public readonly string           ext;
        public readonly string           encryptionKey;

        public MhwMultiStructData(List<StructData> structs, string ext, string encryptionKey = null) {
            this.structs       = structs;
            this.ext           = ext;
            this.encryptionKey = encryptionKey;
        }

        public class StructData {
            public readonly string      name; // Leave so generation can 'copy' from another type and just change the name.
            public readonly List<Entry> entries;
            public readonly uint        fixedSizeCount; // If we know the number of times the struct repeats. Anything > 0 is handled automatically. If 0 you have to implement the GetCount method.
            public readonly bool        hidden;
            public readonly bool        showVertically; // Show the struct as a vertical list of stuff?
            public readonly bool        canAddRows;
            public readonly ArrayLink   _010Link;
            public readonly bool        customSaveLoad;
            public readonly string      uniqueIdFormula;
            public readonly string      description;
            public readonly bool        customCount; // If not 010 link, and we need to calculate the count in code, set to true.

            public StructData(string      name,
                              List<Entry> entries,
                              uint        fixedSizeCount  = 0,
                              bool        hidden          = false,
                              bool        showVertically  = false,
                              bool        canAddRows      = false,
                              ArrayLink   _010Link        = null,
                              bool        customSaveLoad  = false,
                              string      uniqueIdFormula = null,
                              string      description     = null,
                              bool        customCount     = false) {
                this.name            = name;
                this.entries         = entries;
                this.fixedSizeCount  = fixedSizeCount;
                this.hidden          = hidden;
                this.showVertically  = showVertically;
                this.canAddRows      = canAddRows;
                this._010Link        = _010Link;
                this.customSaveLoad  = customSaveLoad;
                this.uniqueIdFormula = uniqueIdFormula;
                this.description     = description;
                this.customCount     = customCount;
            }

            public string SafeName   => Regex.Replace(name.Replace("+", "Plus"), @"[^\w\d]+", "_");
            public bool   Has010Link => _010Link != null;
        }

        public class Entry {
            public readonly string          name;
            public readonly Type            type;
            public readonly Type            enumReturn;
            public readonly bool            readOnly;
            public readonly string          valueString; // Used mostly for clamping the value.
            public readonly string          accessLevel;
            public readonly DataSourceType? dataSourceType;
            public readonly string[]        extraOnPropertyChanged;
            public readonly string          dataSourceCustomSorter;
            public readonly bool            createPercentField;
            public readonly int             arrayCount; // If the type is an array, set the count;
            public readonly bool            isNullTerminatedString;
            public readonly string          condition; // Condition to read/write.
            public readonly StructData      subStruct;
            public readonly bool            overrideSortIndex;
            public readonly bool            showAsHex;

            public Entry(string          name, Type type, bool readOnly = false,
                         Type            enumReturn             = null,
                         string          valueString            = "value",
                         string          accessLevel            = "public",
                         DataSourceType? dataSourceType         = null,
                         string[]        extraOnPropertyChanged = null,
                         string          dataSourceCustomSorter = "ButtonSorter",
                         bool            createPercentField     = false,
                         int             arrayCount             = -1,
                         bool            isNullTerminatedString = false,
                         string          condition              = null,
                         StructData      subStruct              = null,
                         bool            overrideSortIndex      = false,
                         bool            showAsHex              = false) {
                this.name                   = name;
                this.type                   = type;
                this.readOnly               = readOnly;
                this.valueString            = valueString;
                this.accessLevel            = accessLevel;
                this.enumReturn             = enumReturn;
                this.dataSourceType         = dataSourceType;
                this.extraOnPropertyChanged = extraOnPropertyChanged;
                this.dataSourceCustomSorter = dataSourceCustomSorter;
                this.createPercentField     = createPercentField;
                this.arrayCount             = arrayCount;
                this.isNullTerminatedString = isNullTerminatedString;
                this.condition              = condition;
                this.subStruct              = subStruct;
                this.overrideSortIndex      = overrideSortIndex;
                this.showAsHex              = showAsHex;
            }

            public string SafeName     => Regex.Replace(name.Replace("+", "Plus"), @"[^\w\d]+", "_");
            public bool   HasSubStruct => subStruct != null;
        }

        public class ArrayLink {
            public readonly StructData @struct;
            public readonly Entry      entry;

            public ArrayLink(StructData @struct, Entry entry) {
                this.@struct = @struct;
                this.entry   = entry;
            }
        }
    }

    public static class MhwMultiStructDataExtensions {
        public static T Out<T>(this T @in, out T x) => x = @in;
    }
}