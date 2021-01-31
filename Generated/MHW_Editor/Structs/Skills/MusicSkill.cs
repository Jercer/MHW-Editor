using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using MHW_Editor.Assets;
using MHW_Editor.Controls.Models;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Structs.Skills {
    public partial class MusicSkill {
        public override string EncryptionKey => "qm7psvaMXQoay7kARXpNPcLNWqsbqcOyI4lqHtxFh26HSuE6RHNq7J4e";

        public partial class Header : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Header";

            protected uint Magic_1_raw;
            public const string Magic_1_displayName = "Magic 1";
            public const int Magic_1_sortIndex = 50;
            [SortOrder(Magic_1_sortIndex)]
            [DisplayName(Magic_1_displayName)]
            [IsReadOnly]
            public virtual uint Magic_1 {
                get => Magic_1_raw;
                set {
                    if (Magic_1_raw == value) return;
                    Magic_1_raw = value;
                    ChangedItems.Add(nameof(Magic_1));
                    OnPropertyChanged(nameof(Magic_1));
                }
            }

            protected ushort Magic_2_raw;
            public const string Magic_2_displayName = "Magic 2";
            public const int Magic_2_sortIndex = 100;
            [SortOrder(Magic_2_sortIndex)]
            [DisplayName(Magic_2_displayName)]
            [IsReadOnly]
            public virtual ushort Magic_2 {
                get => Magic_2_raw;
                set {
                    if (Magic_2_raw == value) return;
                    Magic_2_raw = value;
                    ChangedItems.Add(nameof(Magic_2));
                    OnPropertyChanged(nameof(Magic_2));
                }
            }

            protected uint Entry_Count_raw;
            public const string Entry_Count_displayName = "Entry Count";
            public const int Entry_Count_sortIndex = 150;
            [SortOrder(Entry_Count_sortIndex)]
            [DisplayName(Entry_Count_displayName)]
            [IsReadOnly]
            public virtual uint Entry_Count {
                get => Entry_Count_raw;
                set {
                    if (Entry_Count_raw == value) return;
                    Entry_Count_raw = value;
                    ChangedItems.Add(nameof(Entry_Count));
                    OnPropertyChanged(nameof(Entry_Count));
                }
            }

            public const int lastSortIndex = 200;

            public static ObservableMhwStructCollection<Header> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Header>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Header LoadData(BinaryReader reader, ulong i) {
                var data = new Header();
                data.Index = i;
                data.Magic_1_raw = reader.ReadUInt32();
                data.Magic_2_raw = reader.ReadUInt16();
                data.Entry_Count_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Magic_1_raw);
                writer.Write(Magic_2_raw);
                writer.Write(Entry_Count_raw);
            }
        }

        public partial class Entries : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Entries";
            public override string UniqueId => $"{Song_Id_Raw}";

            protected uint Song_Id_Raw_raw;
            public const string Song_Id_Raw_displayName = "Song Id Raw";
            public const int Song_Id_Raw_sortIndex = 50;
            [SortOrder(Song_Id_Raw_sortIndex)]
            [DisplayName(Song_Id_Raw_displayName)]
            [IsReadOnly]
            public virtual uint Song_Id_Raw {
                get => Song_Id_Raw_raw;
                set {
                    if (Song_Id_Raw_raw == value) return;
                    Song_Id_Raw_raw = value;
                    ChangedItems.Add(nameof(Song_Id_Raw));
                    OnPropertyChanged(nameof(Song_Id_Raw));
                }
            }

            protected int Note_1_raw;
            public const string Note_1_displayName = "Note 1";
            public const int Note_1_sortIndex = 100;
            [SortOrder(Note_1_sortIndex)]
            [DisplayName(Note_1_displayName)]
            public virtual MHW_Template.Weapons.NoteColorWithDisabled Note_1 {
                get => (MHW_Template.Weapons.NoteColorWithDisabled) Note_1_raw;
                set {
                    if ((MHW_Template.Weapons.NoteColorWithDisabled) Note_1_raw == value) return;
                    Note_1_raw = (int) value;
                    ChangedItems.Add(nameof(Note_1));
                    OnPropertyChanged(nameof(Note_1));
                }
            }

            protected int Note_2_raw;
            public const string Note_2_displayName = "Note 2";
            public const int Note_2_sortIndex = 150;
            [SortOrder(Note_2_sortIndex)]
            [DisplayName(Note_2_displayName)]
            public virtual MHW_Template.Weapons.NoteColorWithDisabled Note_2 {
                get => (MHW_Template.Weapons.NoteColorWithDisabled) Note_2_raw;
                set {
                    if ((MHW_Template.Weapons.NoteColorWithDisabled) Note_2_raw == value) return;
                    Note_2_raw = (int) value;
                    ChangedItems.Add(nameof(Note_2));
                    OnPropertyChanged(nameof(Note_2));
                }
            }

            protected int Note_3_raw;
            public const string Note_3_displayName = "Note 3";
            public const int Note_3_sortIndex = 200;
            [SortOrder(Note_3_sortIndex)]
            [DisplayName(Note_3_displayName)]
            public virtual MHW_Template.Weapons.NoteColorWithDisabled Note_3 {
                get => (MHW_Template.Weapons.NoteColorWithDisabled) Note_3_raw;
                set {
                    if ((MHW_Template.Weapons.NoteColorWithDisabled) Note_3_raw == value) return;
                    Note_3_raw = (int) value;
                    ChangedItems.Add(nameof(Note_3));
                    OnPropertyChanged(nameof(Note_3));
                }
            }

            protected int Note_4_raw;
            public const string Note_4_displayName = "Note 4";
            public const int Note_4_sortIndex = 250;
            [SortOrder(Note_4_sortIndex)]
            [DisplayName(Note_4_displayName)]
            public virtual MHW_Template.Weapons.NoteColorWithDisabled Note_4 {
                get => (MHW_Template.Weapons.NoteColorWithDisabled) Note_4_raw;
                set {
                    if ((MHW_Template.Weapons.NoteColorWithDisabled) Note_4_raw == value) return;
                    Note_4_raw = (int) value;
                    ChangedItems.Add(nameof(Note_4));
                    OnPropertyChanged(nameof(Note_4));
                }
            }

            public const int lastSortIndex = 300;

            public static ObservableMhwStructCollection<Entries> LoadData(BinaryReader reader, ObservableMhwStructCollection<Header> lastStruct) {
                var list = new ObservableMhwStructCollection<Entries>();
                var countTarget = (Header) lastStruct.Last();
                var count = (ulong) countTarget.Entry_Count;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Entries LoadData(BinaryReader reader, ulong i) {
                var data = new Entries();
                data.Index = i;
                data.Song_Id_Raw_raw = reader.ReadUInt32();
                data.Note_1_raw = reader.ReadInt32();
                data.Note_2_raw = reader.ReadInt32();
                data.Note_3_raw = reader.ReadInt32();
                data.Note_4_raw = reader.ReadInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Song_Id_Raw_raw);
                writer.Write(Note_1_raw);
                writer.Write(Note_2_raw);
                writer.Write(Note_3_raw);
                writer.Write(Note_4_raw);
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var Header_ = new MhwStructDataContainer<Header>(Header.LoadData(reader), typeof(Header));
            data.AddLast(Header_);
            var Entries_ = new MhwStructDataContainer<Entries, Header>(Entries.LoadData(reader, Header_.list), typeof(Entries));
            Entries_.SetCountTargetToUpdate(Header_, -1, "Entry_Count");
            data.AddLast(Entries_);
        }
    }
}