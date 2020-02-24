﻿using System.Collections.Generic;
using MHW_Template;

namespace MHW_Generator {
    public static partial class Program {
        private static void GenCommonPl() {
            GenPlItemParam();
        }

        private static void GenPlItemParam() {
            GeneratePlDataProps("MHW_Editor.PlData", "PlItemParam", new MhwStructData { // .plip
                size = 512,
                offsetInitial = 0,
                entryCountOffset = -1,
                uniqueIdFormula = "0",
                encryptionKey = EncryptionKeys.PL_PARAM_KEY,
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Unk1", 8, typeof(float)),
                    new MhwStructData.Entry("Potion Power", 12, typeof(uint)),
                    new MhwStructData.Entry("Unk2", 16, typeof(float)),
                    new MhwStructData.Entry("Unk3", 20, typeof(float)),
                    new MhwStructData.Entry("Unk4", 24, typeof(float)),
                    new MhwStructData.Entry("Mega Potion Power", 28, typeof(uint)),
                    new MhwStructData.Entry("Unk5", 32, typeof(float)),
                    new MhwStructData.Entry("Unk6", 36, typeof(float)),
                    new MhwStructData.Entry("Unk7", 40, typeof(float)),
                    new MhwStructData.Entry("Nutrients Power", 44, typeof(byte)),
                    new MhwStructData.Entry("Mega Nutrients Power", 45, typeof(byte)),
                    new MhwStructData.Entry("Unk9", 46, typeof(byte)),
                    new MhwStructData.Entry("Mega Dash Juice Stamina Power", 47, typeof(float)),
                    new MhwStructData.Entry("Dash Juice Stamina Power", 51, typeof(float)),
                    new MhwStructData.Entry("Both Dash Juice Duration", 55, typeof(ushort)),
                    new MhwStructData.Entry("Both Dash Juice Power", 57, typeof(byte)),
                    new MhwStructData.Entry("Immunizer Power", 58, typeof(float)),
                    new MhwStructData.Entry("Immunizer Duration", 62, typeof(ushort)),
                    new MhwStructData.Entry("Astera Jerky Power", 64, typeof(float)),
                    new MhwStructData.Entry("Astera Jerky Duration", 68, typeof(ushort)),
                    new MhwStructData.Entry("Herbal Medicine Power", 70, typeof(ushort)),
                    new MhwStructData.Entry("Sushifish Scale Power", 72, typeof(uint)),
                    new MhwStructData.Entry("Great Sushifish Scale Power", 76, typeof(uint)),
                    new MhwStructData.Entry("Great Sushifish Scale Duration", 80, typeof(float)),
                    new MhwStructData.Entry("Cool Drink Duration", 84, typeof(ushort)),
                    new MhwStructData.Entry("Hot Drink Duration", 86, typeof(ushort)),
                    new MhwStructData.Entry("Might Seed Duration", 88, typeof(ushort)),
                    new MhwStructData.Entry("Might Seed Power", 90, typeof(ushort)),
                    new MhwStructData.Entry("Might Pill Duration", 92, typeof(ushort)),
                    new MhwStructData.Entry("Might Pill Power", 94, typeof(ushort)),
                    new MhwStructData.Entry("Adamant Seed Duration", 96, typeof(ushort)),
                    new MhwStructData.Entry("Adamant Seed Power", 98, typeof(ushort)),
                    new MhwStructData.Entry("Adamant Pill Duration", 100, typeof(ushort)),
                    new MhwStructData.Entry("Adamant Pill Power", 102, typeof(float)),
                    new MhwStructData.Entry("Demondrug Power", 106, typeof(byte)),
                    new MhwStructData.Entry("Mega Demondrug Power", 107, typeof(byte)),
                    new MhwStructData.Entry("Armorskin Power", 108, typeof(byte)),
                    new MhwStructData.Entry("Mega Armorskin Power", 109, typeof(byte)),
                    new MhwStructData.Entry("Herbal Powder Power", 110, typeof(ushort)),
                    new MhwStructData.Entry("Lifepowder Power", 112, typeof(ushort)),
                    new MhwStructData.Entry("Dust of Life Power", 114, typeof(ushort)),
                    new MhwStructData.Entry("Unk16", 116, typeof(ushort)),
                    new MhwStructData.Entry("Demon Powder Power", 118, typeof(ushort)),
                    new MhwStructData.Entry("Demon Powder Duration", 120, typeof(ushort)),
                    new MhwStructData.Entry("Hardshell Powder Power", 122, typeof(ushort)),
                    new MhwStructData.Entry("Hardshell Powder Duration", 124, typeof(ushort)),
                    new MhwStructData.Entry("Unk17", 126, typeof(ushort)),
                    new MhwStructData.Entry("Unk18", 128, typeof(ushort)),
                    new MhwStructData.Entry("Unk19", 130, typeof(ushort)),
                    new MhwStructData.Entry("Unk20", 132, typeof(ushort)),
                    new MhwStructData.Entry("Ration Power", 134, typeof(ushort)),
                    new MhwStructData.Entry("Well Done Steak Multiplier", 136, typeof(uint)),
                    new MhwStructData.Entry("Unk22", 140, typeof(float)),
                    new MhwStructData.Entry("Unk23", 144, typeof(float)),
                    new MhwStructData.Entry("Unk24", 148, typeof(float)),
                    new MhwStructData.Entry("Unk25", 152, typeof(ushort)),
                    new MhwStructData.Entry("Unk26", 154, typeof(short)),
                    new MhwStructData.Entry("Unk27", 156, typeof(byte)),
                    new MhwStructData.Entry("Unk28", 157, typeof(float)),
                    new MhwStructData.Entry("Unk29", 161, typeof(float)),
                    new MhwStructData.Entry("Unk30", 165, typeof(float)),
                    new MhwStructData.Entry("Unk31", 169, typeof(float)),
                    new MhwStructData.Entry("Unk32", 173, typeof(float)),
                    new MhwStructData.Entry("Unk33", 177, typeof(float)),
                    new MhwStructData.Entry("Unk34", 181, typeof(float)),
                    new MhwStructData.Entry("Unk35", 185, typeof(float)),
                    new MhwStructData.Entry("Unk36", 189, typeof(float)),
                    new MhwStructData.Entry("Unk37", 193, typeof(float)),
                    new MhwStructData.Entry("Unk38", 197, typeof(float)),
                    new MhwStructData.Entry("Unk39", 201, typeof(uint)),
                    new MhwStructData.Entry("Unk40", 205, typeof(uint)),
                    new MhwStructData.Entry("Unk41", 209, typeof(uint)),
                    new MhwStructData.Entry("Unk42", 213, typeof(byte)),
                    new MhwStructData.Entry("Unk43", 214, typeof(byte)),
                    new MhwStructData.Entry("Unk44", 215, typeof(byte)),
                    new MhwStructData.Entry("Powertalon Power", 216, typeof(byte)),
                    new MhwStructData.Entry("Powercharm Power", 217, typeof(byte)),
                    new MhwStructData.Entry("Armortalon Power", 218, typeof(byte)),
                    new MhwStructData.Entry("Armorcharm Power", 219, typeof(byte)),
                    new MhwStructData.Entry("Unk49", 220, typeof(byte)),
                    new MhwStructData.Entry("Unk50", 221, typeof(float)),
                    new MhwStructData.Entry("Unk51", 225, typeof(float)),
                    new MhwStructData.Entry("Unk52", 229, typeof(float)),
                    new MhwStructData.Entry("Unk53", 233, typeof(float)),
                    new MhwStructData.Entry("Unk54", 237, typeof(float)),
                    new MhwStructData.Entry("Unk55", 241, typeof(float)),
                    new MhwStructData.Entry("Unk56", 245, typeof(float)),
                    new MhwStructData.Entry("Unk57", 249, typeof(float)),
                    new MhwStructData.Entry("Unk58", 253, typeof(float)),
                    new MhwStructData.Entry("Unk59", 257, typeof(float)),
                    new MhwStructData.Entry("Unk60", 261, typeof(float)),
                    new MhwStructData.Entry("Unk61", 265, typeof(float)),
                    new MhwStructData.Entry("Unk62", 269, typeof(float)),
                    new MhwStructData.Entry("Unk63", 273, typeof(float)),
                    new MhwStructData.Entry("Unk64", 277, typeof(float)),
                    new MhwStructData.Entry("Unk65", 281, typeof(float)),
                    new MhwStructData.Entry("Unk66", 285, typeof(float)),
                    new MhwStructData.Entry("Unk67", 289, typeof(float)),
                    new MhwStructData.Entry("Unk68", 293, typeof(float)),
                    new MhwStructData.Entry("Unk69", 297, typeof(float)),
                    new MhwStructData.Entry("Unk70", 301, typeof(float)),
                    new MhwStructData.Entry("Unk71", 305, typeof(float)),
                    new MhwStructData.Entry("Unk72", 309, typeof(float)),
                    new MhwStructData.Entry("Unk73", 313, typeof(float)),
                    new MhwStructData.Entry("Unk74", 317, typeof(float)),
                    new MhwStructData.Entry("Unk75", 321, typeof(float)),
                    new MhwStructData.Entry("Unk76", 325, typeof(float)),
                    new MhwStructData.Entry("Unk77", 329, typeof(float)),
                    new MhwStructData.Entry("Unk78", 337, typeof(float)),
                    new MhwStructData.Entry("Unk79", 341, typeof(float)),
                    new MhwStructData.Entry("Unk80", 345, typeof(float)),
                    new MhwStructData.Entry("Unk81", 349, typeof(float)),
                    new MhwStructData.Entry("Unk82", 353, typeof(float)),
                    new MhwStructData.Entry("Unk83", 357, typeof(float)),
                    new MhwStructData.Entry("Unk84", 361, typeof(float)),
                    new MhwStructData.Entry("Unk85", 365, typeof(float)),
                    new MhwStructData.Entry("Unk86", 369, typeof(float)),
                    new MhwStructData.Entry("Unk87", 373, typeof(float)),
                    new MhwStructData.Entry("Unk88", 377, typeof(float)),
                    new MhwStructData.Entry("Unk89", 381, typeof(float)),
                    new MhwStructData.Entry("Unk90", 385, typeof(float)),
                    new MhwStructData.Entry("Unk91", 389, typeof(float)),
                    new MhwStructData.Entry("Unk92", 393, typeof(float)),
                    new MhwStructData.Entry("Unk93", 397, typeof(float)),
                    new MhwStructData.Entry("Unk94", 401, typeof(float)),
                    new MhwStructData.Entry("Unk95", 405, typeof(float)),
                    new MhwStructData.Entry("Unk96", 409, typeof(float)),
                    new MhwStructData.Entry("Unk97", 413, typeof(float)),
                    new MhwStructData.Entry("Unk98", 417, typeof(float)),
                    new MhwStructData.Entry("Unk99", 417, typeof(float)),
                    new MhwStructData.Entry("Unk100", 421, typeof(float)),
                    new MhwStructData.Entry("Unk101", 425, typeof(float)),
                    new MhwStructData.Entry("Unk102", 429, typeof(float)),
                    new MhwStructData.Entry("Unk103", 433, typeof(float)),
                    new MhwStructData.Entry("Unk104", 437, typeof(float)),
                    new MhwStructData.Entry("Unk105", 441, typeof(float)),
                    new MhwStructData.Entry("Unk106", 445, typeof(byte)),
                    new MhwStructData.Entry("Getting lost here.", 446, typeof(byte)),
                    new MhwStructData.Entry("Some ints now?", 447, typeof(byte)),
                    new MhwStructData.Entry("Unk107", 448, typeof(byte)),
                    new MhwStructData.Entry("Unk108", 449, typeof(byte)),
                    new MhwStructData.Entry("Skipping last 62 for now.", 450, typeof(float))
                }
            });
        }

        public static void GeneratePlDataProps(string @namespace, string className, MhwStructData structData) {
            GenerateItemProps(@namespace, className, structData);

            WriteResult($"{Global.GENERATED_ROOT}\\{@namespace.Replace(".", "\\")}", @namespace, $"{className}Internal", new PlDataItemTemplate {
                Session = new Dictionary<string, object> {
                    {"_namespace", @namespace},
                    {"className", className},
                    {"structData", structData}
                }
            });
        }
    }
}