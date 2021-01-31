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

namespace MHW_Editor.Structs.PlData {
    public partial class ScoutflyData {
        public override string EncryptionKey => null;

        public partial class Scoutfly_Params_1_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Scoutfly Params (1)";

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

            [DisplayName("Offset")]
            public long Magic_1_offset { get; private set; }

            protected char[] GIP_raw;
            public const string GIP_displayName = "GIP";
            public const int GIP_sortIndex = 100;
            [SortOrder(GIP_sortIndex)]
            [DisplayName(GIP_displayName)]
            [IsReadOnly]
            public virtual string GIP {
                get => (string) new string(GIP_raw);
                set {
                    if ((string) new string(GIP_raw) == value) return;
                    GIP_raw = (char[]) value.ToCharArray(0, 3);
                    ChangedItems.Add(nameof(GIP));
                    OnPropertyChanged(nameof(GIP));
                }
            }

            [DisplayName("Offset")]
            public long GIP_offset { get; private set; }

            protected uint Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 150;
            [SortOrder(Unk_1_sortIndex)]
            [DisplayName(Unk_1_displayName)]
            public virtual uint Unk_1 {
                get => Unk_1_raw;
                set {
                    if (Unk_1_raw == value) return;
                    Unk_1_raw = value;
                    ChangedItems.Add(nameof(Unk_1));
                    OnPropertyChanged(nameof(Unk_1));
                }
            }

            [DisplayName("Offset")]
            public long Unk_1_offset { get; private set; }

            protected uint Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 200;
            [SortOrder(Unk_2_sortIndex)]
            [DisplayName(Unk_2_displayName)]
            public virtual uint Unk_2 {
                get => Unk_2_raw;
                set {
                    if (Unk_2_raw == value) return;
                    Unk_2_raw = value;
                    ChangedItems.Add(nameof(Unk_2));
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            [DisplayName("Offset")]
            public long Unk_2_offset { get; private set; }

            protected uint Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 250;
            [SortOrder(Unk_3_sortIndex)]
            [DisplayName(Unk_3_displayName)]
            public virtual uint Unk_3 {
                get => Unk_3_raw;
                set {
                    if (Unk_3_raw == value) return;
                    Unk_3_raw = value;
                    ChangedItems.Add(nameof(Unk_3));
                    OnPropertyChanged(nameof(Unk_3));
                }
            }

            [DisplayName("Offset")]
            public long Unk_3_offset { get; private set; }

            protected uint Unk_4_raw;
            public const string Unk_4_displayName = "Unk 4";
            public const int Unk_4_sortIndex = 300;
            [SortOrder(Unk_4_sortIndex)]
            [DisplayName(Unk_4_displayName)]
            public virtual uint Unk_4 {
                get => Unk_4_raw;
                set {
                    if (Unk_4_raw == value) return;
                    Unk_4_raw = value;
                    ChangedItems.Add(nameof(Unk_4));
                    OnPropertyChanged(nameof(Unk_4));
                }
            }

            [DisplayName("Offset")]
            public long Unk_4_offset { get; private set; }

            protected uint Unk_5_raw;
            public const string Unk_5_displayName = "Unk 5";
            public const int Unk_5_sortIndex = 350;
            [SortOrder(Unk_5_sortIndex)]
            [DisplayName(Unk_5_displayName)]
            public virtual uint Unk_5 {
                get => Unk_5_raw;
                set {
                    if (Unk_5_raw == value) return;
                    Unk_5_raw = value;
                    ChangedItems.Add(nameof(Unk_5));
                    OnPropertyChanged(nameof(Unk_5));
                }
            }

            [DisplayName("Offset")]
            public long Unk_5_offset { get; private set; }

            protected uint Unk_6_raw;
            public const string Unk_6_displayName = "Unk 6";
            public const int Unk_6_sortIndex = 400;
            [SortOrder(Unk_6_sortIndex)]
            [DisplayName(Unk_6_displayName)]
            public virtual uint Unk_6 {
                get => Unk_6_raw;
                set {
                    if (Unk_6_raw == value) return;
                    Unk_6_raw = value;
                    ChangedItems.Add(nameof(Unk_6));
                    OnPropertyChanged(nameof(Unk_6));
                }
            }

            [DisplayName("Offset")]
            public long Unk_6_offset { get; private set; }

            protected uint Unk_7_raw;
            public const string Unk_7_displayName = "Unk 7";
            public const int Unk_7_sortIndex = 450;
            [SortOrder(Unk_7_sortIndex)]
            [DisplayName(Unk_7_displayName)]
            public virtual uint Unk_7 {
                get => Unk_7_raw;
                set {
                    if (Unk_7_raw == value) return;
                    Unk_7_raw = value;
                    ChangedItems.Add(nameof(Unk_7));
                    OnPropertyChanged(nameof(Unk_7));
                }
            }

            [DisplayName("Offset")]
            public long Unk_7_offset { get; private set; }

            protected uint Unk_8_raw;
            public const string Unk_8_displayName = "Unk 8";
            public const int Unk_8_sortIndex = 500;
            [SortOrder(Unk_8_sortIndex)]
            [DisplayName(Unk_8_displayName)]
            public virtual uint Unk_8 {
                get => Unk_8_raw;
                set {
                    if (Unk_8_raw == value) return;
                    Unk_8_raw = value;
                    ChangedItems.Add(nameof(Unk_8));
                    OnPropertyChanged(nameof(Unk_8));
                }
            }

            [DisplayName("Offset")]
            public long Unk_8_offset { get; private set; }

            protected uint Unk_9_raw;
            public const string Unk_9_displayName = "Unk 9";
            public const int Unk_9_sortIndex = 550;
            [SortOrder(Unk_9_sortIndex)]
            [DisplayName(Unk_9_displayName)]
            public virtual uint Unk_9 {
                get => Unk_9_raw;
                set {
                    if (Unk_9_raw == value) return;
                    Unk_9_raw = value;
                    ChangedItems.Add(nameof(Unk_9));
                    OnPropertyChanged(nameof(Unk_9));
                }
            }

            [DisplayName("Offset")]
            public long Unk_9_offset { get; private set; }

            protected uint Unk_10_raw;
            public const string Unk_10_displayName = "Unk 10";
            public const int Unk_10_sortIndex = 600;
            [SortOrder(Unk_10_sortIndex)]
            [DisplayName(Unk_10_displayName)]
            public virtual uint Unk_10 {
                get => Unk_10_raw;
                set {
                    if (Unk_10_raw == value) return;
                    Unk_10_raw = value;
                    ChangedItems.Add(nameof(Unk_10));
                    OnPropertyChanged(nameof(Unk_10));
                }
            }

            [DisplayName("Offset")]
            public long Unk_10_offset { get; private set; }

            protected uint Unk_11_raw;
            public const string Unk_11_displayName = "Unk 11";
            public const int Unk_11_sortIndex = 650;
            [SortOrder(Unk_11_sortIndex)]
            [DisplayName(Unk_11_displayName)]
            public virtual uint Unk_11 {
                get => Unk_11_raw;
                set {
                    if (Unk_11_raw == value) return;
                    Unk_11_raw = value;
                    ChangedItems.Add(nameof(Unk_11));
                    OnPropertyChanged(nameof(Unk_11));
                }
            }

            [DisplayName("Offset")]
            public long Unk_11_offset { get; private set; }

            protected float Unk_12_raw;
            public const string Unk_12_displayName = "Unk 12";
            public const int Unk_12_sortIndex = 700;
            [SortOrder(Unk_12_sortIndex)]
            [DisplayName(Unk_12_displayName)]
            public virtual float Unk_12 {
                get => Unk_12_raw;
                set {
                    if (Unk_12_raw == value) return;
                    Unk_12_raw = value;
                    ChangedItems.Add(nameof(Unk_12));
                    OnPropertyChanged(nameof(Unk_12));
                }
            }

            [DisplayName("Offset")]
            public long Unk_12_offset { get; private set; }

            protected float Unk_13_raw;
            public const string Unk_13_displayName = "Unk 13";
            public const int Unk_13_sortIndex = 750;
            [SortOrder(Unk_13_sortIndex)]
            [DisplayName(Unk_13_displayName)]
            public virtual float Unk_13 {
                get => Unk_13_raw;
                set {
                    if (Unk_13_raw == value) return;
                    Unk_13_raw = value;
                    ChangedItems.Add(nameof(Unk_13));
                    OnPropertyChanged(nameof(Unk_13));
                }
            }

            [DisplayName("Offset")]
            public long Unk_13_offset { get; private set; }

            protected float Unk_14_raw;
            public const string Unk_14_displayName = "Unk 14";
            public const int Unk_14_sortIndex = 800;
            [SortOrder(Unk_14_sortIndex)]
            [DisplayName(Unk_14_displayName)]
            public virtual float Unk_14 {
                get => Unk_14_raw;
                set {
                    if (Unk_14_raw == value) return;
                    Unk_14_raw = value;
                    ChangedItems.Add(nameof(Unk_14));
                    OnPropertyChanged(nameof(Unk_14));
                }
            }

            [DisplayName("Offset")]
            public long Unk_14_offset { get; private set; }

            protected float Unk_15_raw;
            public const string Unk_15_displayName = "Unk 15";
            public const int Unk_15_sortIndex = 850;
            [SortOrder(Unk_15_sortIndex)]
            [DisplayName(Unk_15_displayName)]
            public virtual float Unk_15 {
                get => Unk_15_raw;
                set {
                    if (Unk_15_raw == value) return;
                    Unk_15_raw = value;
                    ChangedItems.Add(nameof(Unk_15));
                    OnPropertyChanged(nameof(Unk_15));
                }
            }

            [DisplayName("Offset")]
            public long Unk_15_offset { get; private set; }

            protected float Unk_16_raw;
            public const string Unk_16_displayName = "Unk 16";
            public const int Unk_16_sortIndex = 900;
            [SortOrder(Unk_16_sortIndex)]
            [DisplayName(Unk_16_displayName)]
            public virtual float Unk_16 {
                get => Unk_16_raw;
                set {
                    if (Unk_16_raw == value) return;
                    Unk_16_raw = value;
                    ChangedItems.Add(nameof(Unk_16));
                    OnPropertyChanged(nameof(Unk_16));
                }
            }

            [DisplayName("Offset")]
            public long Unk_16_offset { get; private set; }

            protected float Unk_17_raw;
            public const string Unk_17_displayName = "Unk 17";
            public const int Unk_17_sortIndex = 950;
            [SortOrder(Unk_17_sortIndex)]
            [DisplayName(Unk_17_displayName)]
            public virtual float Unk_17 {
                get => Unk_17_raw;
                set {
                    if (Unk_17_raw == value) return;
                    Unk_17_raw = value;
                    ChangedItems.Add(nameof(Unk_17));
                    OnPropertyChanged(nameof(Unk_17));
                }
            }

            [DisplayName("Offset")]
            public long Unk_17_offset { get; private set; }

            protected float Unk_18_raw;
            public const string Unk_18_displayName = "Unk 18";
            public const int Unk_18_sortIndex = 1000;
            [SortOrder(Unk_18_sortIndex)]
            [DisplayName(Unk_18_displayName)]
            public virtual float Unk_18 {
                get => Unk_18_raw;
                set {
                    if (Unk_18_raw == value) return;
                    Unk_18_raw = value;
                    ChangedItems.Add(nameof(Unk_18));
                    OnPropertyChanged(nameof(Unk_18));
                }
            }

            [DisplayName("Offset")]
            public long Unk_18_offset { get; private set; }

            protected float Unk_19_raw;
            public const string Unk_19_displayName = "Unk 19";
            public const int Unk_19_sortIndex = 1050;
            [SortOrder(Unk_19_sortIndex)]
            [DisplayName(Unk_19_displayName)]
            public virtual float Unk_19 {
                get => Unk_19_raw;
                set {
                    if (Unk_19_raw == value) return;
                    Unk_19_raw = value;
                    ChangedItems.Add(nameof(Unk_19));
                    OnPropertyChanged(nameof(Unk_19));
                }
            }

            [DisplayName("Offset")]
            public long Unk_19_offset { get; private set; }

            protected float Unk_20_raw;
            public const string Unk_20_displayName = "Unk 20";
            public const int Unk_20_sortIndex = 1100;
            [SortOrder(Unk_20_sortIndex)]
            [DisplayName(Unk_20_displayName)]
            public virtual float Unk_20 {
                get => Unk_20_raw;
                set {
                    if (Unk_20_raw == value) return;
                    Unk_20_raw = value;
                    ChangedItems.Add(nameof(Unk_20));
                    OnPropertyChanged(nameof(Unk_20));
                }
            }

            [DisplayName("Offset")]
            public long Unk_20_offset { get; private set; }

            protected float Unk_21_raw;
            public const string Unk_21_displayName = "Unk 21";
            public const int Unk_21_sortIndex = 1150;
            [SortOrder(Unk_21_sortIndex)]
            [DisplayName(Unk_21_displayName)]
            public virtual float Unk_21 {
                get => Unk_21_raw;
                set {
                    if (Unk_21_raw == value) return;
                    Unk_21_raw = value;
                    ChangedItems.Add(nameof(Unk_21));
                    OnPropertyChanged(nameof(Unk_21));
                }
            }

            [DisplayName("Offset")]
            public long Unk_21_offset { get; private set; }

            protected float Unk_22_raw;
            public const string Unk_22_displayName = "Unk 22";
            public const int Unk_22_sortIndex = 1200;
            [SortOrder(Unk_22_sortIndex)]
            [DisplayName(Unk_22_displayName)]
            public virtual float Unk_22 {
                get => Unk_22_raw;
                set {
                    if (Unk_22_raw == value) return;
                    Unk_22_raw = value;
                    ChangedItems.Add(nameof(Unk_22));
                    OnPropertyChanged(nameof(Unk_22));
                }
            }

            [DisplayName("Offset")]
            public long Unk_22_offset { get; private set; }

            protected float Unk_23_raw;
            public const string Unk_23_displayName = "Unk 23";
            public const int Unk_23_sortIndex = 1250;
            [SortOrder(Unk_23_sortIndex)]
            [DisplayName(Unk_23_displayName)]
            public virtual float Unk_23 {
                get => Unk_23_raw;
                set {
                    if (Unk_23_raw == value) return;
                    Unk_23_raw = value;
                    ChangedItems.Add(nameof(Unk_23));
                    OnPropertyChanged(nameof(Unk_23));
                }
            }

            [DisplayName("Offset")]
            public long Unk_23_offset { get; private set; }

            protected float Unk_24_raw;
            public const string Unk_24_displayName = "Unk 24";
            public const int Unk_24_sortIndex = 1300;
            [SortOrder(Unk_24_sortIndex)]
            [DisplayName(Unk_24_displayName)]
            public virtual float Unk_24 {
                get => Unk_24_raw;
                set {
                    if (Unk_24_raw == value) return;
                    Unk_24_raw = value;
                    ChangedItems.Add(nameof(Unk_24));
                    OnPropertyChanged(nameof(Unk_24));
                }
            }

            [DisplayName("Offset")]
            public long Unk_24_offset { get; private set; }

            protected float Unk_25_raw;
            public const string Unk_25_displayName = "Unk 25";
            public const int Unk_25_sortIndex = 1350;
            [SortOrder(Unk_25_sortIndex)]
            [DisplayName(Unk_25_displayName)]
            public virtual float Unk_25 {
                get => Unk_25_raw;
                set {
                    if (Unk_25_raw == value) return;
                    Unk_25_raw = value;
                    ChangedItems.Add(nameof(Unk_25));
                    OnPropertyChanged(nameof(Unk_25));
                }
            }

            [DisplayName("Offset")]
            public long Unk_25_offset { get; private set; }

            protected float Unk_26_raw;
            public const string Unk_26_displayName = "Unk 26";
            public const int Unk_26_sortIndex = 1400;
            [SortOrder(Unk_26_sortIndex)]
            [DisplayName(Unk_26_displayName)]
            public virtual float Unk_26 {
                get => Unk_26_raw;
                set {
                    if (Unk_26_raw == value) return;
                    Unk_26_raw = value;
                    ChangedItems.Add(nameof(Unk_26));
                    OnPropertyChanged(nameof(Unk_26));
                }
            }

            [DisplayName("Offset")]
            public long Unk_26_offset { get; private set; }

            protected float Unk_27_raw;
            public const string Unk_27_displayName = "Unk 27";
            public const int Unk_27_sortIndex = 1450;
            [SortOrder(Unk_27_sortIndex)]
            [DisplayName(Unk_27_displayName)]
            public virtual float Unk_27 {
                get => Unk_27_raw;
                set {
                    if (Unk_27_raw == value) return;
                    Unk_27_raw = value;
                    ChangedItems.Add(nameof(Unk_27));
                    OnPropertyChanged(nameof(Unk_27));
                }
            }

            [DisplayName("Offset")]
            public long Unk_27_offset { get; private set; }

            protected float Unk_28_raw;
            public const string Unk_28_displayName = "Unk 28";
            public const int Unk_28_sortIndex = 1500;
            [SortOrder(Unk_28_sortIndex)]
            [DisplayName(Unk_28_displayName)]
            public virtual float Unk_28 {
                get => Unk_28_raw;
                set {
                    if (Unk_28_raw == value) return;
                    Unk_28_raw = value;
                    ChangedItems.Add(nameof(Unk_28));
                    OnPropertyChanged(nameof(Unk_28));
                }
            }

            [DisplayName("Offset")]
            public long Unk_28_offset { get; private set; }

            protected float Unk_29_raw;
            public const string Unk_29_displayName = "Unk 29";
            public const int Unk_29_sortIndex = 1550;
            [SortOrder(Unk_29_sortIndex)]
            [DisplayName(Unk_29_displayName)]
            public virtual float Unk_29 {
                get => Unk_29_raw;
                set {
                    if (Unk_29_raw == value) return;
                    Unk_29_raw = value;
                    ChangedItems.Add(nameof(Unk_29));
                    OnPropertyChanged(nameof(Unk_29));
                }
            }

            [DisplayName("Offset")]
            public long Unk_29_offset { get; private set; }

            protected float Unk_30_raw;
            public const string Unk_30_displayName = "Unk 30";
            public const int Unk_30_sortIndex = 1600;
            [SortOrder(Unk_30_sortIndex)]
            [DisplayName(Unk_30_displayName)]
            public virtual float Unk_30 {
                get => Unk_30_raw;
                set {
                    if (Unk_30_raw == value) return;
                    Unk_30_raw = value;
                    ChangedItems.Add(nameof(Unk_30));
                    OnPropertyChanged(nameof(Unk_30));
                }
            }

            [DisplayName("Offset")]
            public long Unk_30_offset { get; private set; }

            protected float Unk_31_raw;
            public const string Unk_31_displayName = "Unk 31";
            public const int Unk_31_sortIndex = 1650;
            [SortOrder(Unk_31_sortIndex)]
            [DisplayName(Unk_31_displayName)]
            public virtual float Unk_31 {
                get => Unk_31_raw;
                set {
                    if (Unk_31_raw == value) return;
                    Unk_31_raw = value;
                    ChangedItems.Add(nameof(Unk_31));
                    OnPropertyChanged(nameof(Unk_31));
                }
            }

            [DisplayName("Offset")]
            public long Unk_31_offset { get; private set; }

            protected float Unk_32_raw;
            public const string Unk_32_displayName = "Unk 32";
            public const int Unk_32_sortIndex = 1700;
            [SortOrder(Unk_32_sortIndex)]
            [DisplayName(Unk_32_displayName)]
            public virtual float Unk_32 {
                get => Unk_32_raw;
                set {
                    if (Unk_32_raw == value) return;
                    Unk_32_raw = value;
                    ChangedItems.Add(nameof(Unk_32));
                    OnPropertyChanged(nameof(Unk_32));
                }
            }

            [DisplayName("Offset")]
            public long Unk_32_offset { get; private set; }

            protected float Unk_33_raw;
            public const string Unk_33_displayName = "Unk 33";
            public const int Unk_33_sortIndex = 1750;
            [SortOrder(Unk_33_sortIndex)]
            [DisplayName(Unk_33_displayName)]
            public virtual float Unk_33 {
                get => Unk_33_raw;
                set {
                    if (Unk_33_raw == value) return;
                    Unk_33_raw = value;
                    ChangedItems.Add(nameof(Unk_33));
                    OnPropertyChanged(nameof(Unk_33));
                }
            }

            [DisplayName("Offset")]
            public long Unk_33_offset { get; private set; }

            protected float Unk_34_raw;
            public const string Unk_34_displayName = "Unk 34";
            public const int Unk_34_sortIndex = 1800;
            [SortOrder(Unk_34_sortIndex)]
            [DisplayName(Unk_34_displayName)]
            public virtual float Unk_34 {
                get => Unk_34_raw;
                set {
                    if (Unk_34_raw == value) return;
                    Unk_34_raw = value;
                    ChangedItems.Add(nameof(Unk_34));
                    OnPropertyChanged(nameof(Unk_34));
                }
            }

            [DisplayName("Offset")]
            public long Unk_34_offset { get; private set; }

            protected float Unk_35_raw;
            public const string Unk_35_displayName = "Unk 35";
            public const int Unk_35_sortIndex = 1850;
            [SortOrder(Unk_35_sortIndex)]
            [DisplayName(Unk_35_displayName)]
            public virtual float Unk_35 {
                get => Unk_35_raw;
                set {
                    if (Unk_35_raw == value) return;
                    Unk_35_raw = value;
                    ChangedItems.Add(nameof(Unk_35));
                    OnPropertyChanged(nameof(Unk_35));
                }
            }

            [DisplayName("Offset")]
            public long Unk_35_offset { get; private set; }

            protected float Unk_36_raw;
            public const string Unk_36_displayName = "Unk 36";
            public const int Unk_36_sortIndex = 1900;
            [SortOrder(Unk_36_sortIndex)]
            [DisplayName(Unk_36_displayName)]
            public virtual float Unk_36 {
                get => Unk_36_raw;
                set {
                    if (Unk_36_raw == value) return;
                    Unk_36_raw = value;
                    ChangedItems.Add(nameof(Unk_36));
                    OnPropertyChanged(nameof(Unk_36));
                }
            }

            [DisplayName("Offset")]
            public long Unk_36_offset { get; private set; }

            protected float Unk_37_raw;
            public const string Unk_37_displayName = "Unk 37";
            public const int Unk_37_sortIndex = 1950;
            [SortOrder(Unk_37_sortIndex)]
            [DisplayName(Unk_37_displayName)]
            public virtual float Unk_37 {
                get => Unk_37_raw;
                set {
                    if (Unk_37_raw == value) return;
                    Unk_37_raw = value;
                    ChangedItems.Add(nameof(Unk_37));
                    OnPropertyChanged(nameof(Unk_37));
                }
            }

            [DisplayName("Offset")]
            public long Unk_37_offset { get; private set; }

            protected float Unk_38_raw;
            public const string Unk_38_displayName = "Unk 38";
            public const int Unk_38_sortIndex = 2000;
            [SortOrder(Unk_38_sortIndex)]
            [DisplayName(Unk_38_displayName)]
            public virtual float Unk_38 {
                get => Unk_38_raw;
                set {
                    if (Unk_38_raw == value) return;
                    Unk_38_raw = value;
                    ChangedItems.Add(nameof(Unk_38));
                    OnPropertyChanged(nameof(Unk_38));
                }
            }

            [DisplayName("Offset")]
            public long Unk_38_offset { get; private set; }

            protected float Unk_39_raw;
            public const string Unk_39_displayName = "Unk 39";
            public const int Unk_39_sortIndex = 2050;
            [SortOrder(Unk_39_sortIndex)]
            [DisplayName(Unk_39_displayName)]
            public virtual float Unk_39 {
                get => Unk_39_raw;
                set {
                    if (Unk_39_raw == value) return;
                    Unk_39_raw = value;
                    ChangedItems.Add(nameof(Unk_39));
                    OnPropertyChanged(nameof(Unk_39));
                }
            }

            [DisplayName("Offset")]
            public long Unk_39_offset { get; private set; }

            protected float Unk_40_raw;
            public const string Unk_40_displayName = "Unk 40";
            public const int Unk_40_sortIndex = 2100;
            [SortOrder(Unk_40_sortIndex)]
            [DisplayName(Unk_40_displayName)]
            public virtual float Unk_40 {
                get => Unk_40_raw;
                set {
                    if (Unk_40_raw == value) return;
                    Unk_40_raw = value;
                    ChangedItems.Add(nameof(Unk_40));
                    OnPropertyChanged(nameof(Unk_40));
                }
            }

            [DisplayName("Offset")]
            public long Unk_40_offset { get; private set; }

            protected float Unk_41_raw;
            public const string Unk_41_displayName = "Unk 41";
            public const int Unk_41_sortIndex = 2150;
            [SortOrder(Unk_41_sortIndex)]
            [DisplayName(Unk_41_displayName)]
            public virtual float Unk_41 {
                get => Unk_41_raw;
                set {
                    if (Unk_41_raw == value) return;
                    Unk_41_raw = value;
                    ChangedItems.Add(nameof(Unk_41));
                    OnPropertyChanged(nameof(Unk_41));
                }
            }

            [DisplayName("Offset")]
            public long Unk_41_offset { get; private set; }

            protected float Unk_42_raw;
            public const string Unk_42_displayName = "Unk 42";
            public const int Unk_42_sortIndex = 2200;
            [SortOrder(Unk_42_sortIndex)]
            [DisplayName(Unk_42_displayName)]
            public virtual float Unk_42 {
                get => Unk_42_raw;
                set {
                    if (Unk_42_raw == value) return;
                    Unk_42_raw = value;
                    ChangedItems.Add(nameof(Unk_42));
                    OnPropertyChanged(nameof(Unk_42));
                }
            }

            [DisplayName("Offset")]
            public long Unk_42_offset { get; private set; }

            protected float Unk_43_raw;
            public const string Unk_43_displayName = "Unk 43";
            public const int Unk_43_sortIndex = 2250;
            [SortOrder(Unk_43_sortIndex)]
            [DisplayName(Unk_43_displayName)]
            public virtual float Unk_43 {
                get => Unk_43_raw;
                set {
                    if (Unk_43_raw == value) return;
                    Unk_43_raw = value;
                    ChangedItems.Add(nameof(Unk_43));
                    OnPropertyChanged(nameof(Unk_43));
                }
            }

            [DisplayName("Offset")]
            public long Unk_43_offset { get; private set; }

            protected float Unk_44_raw;
            public const string Unk_44_displayName = "Unk 44";
            public const int Unk_44_sortIndex = 2300;
            [SortOrder(Unk_44_sortIndex)]
            [DisplayName(Unk_44_displayName)]
            public virtual float Unk_44 {
                get => Unk_44_raw;
                set {
                    if (Unk_44_raw == value) return;
                    Unk_44_raw = value;
                    ChangedItems.Add(nameof(Unk_44));
                    OnPropertyChanged(nameof(Unk_44));
                }
            }

            [DisplayName("Offset")]
            public long Unk_44_offset { get; private set; }

            protected float Unk_45_raw;
            public const string Unk_45_displayName = "Unk 45";
            public const int Unk_45_sortIndex = 2350;
            [SortOrder(Unk_45_sortIndex)]
            [DisplayName(Unk_45_displayName)]
            public virtual float Unk_45 {
                get => Unk_45_raw;
                set {
                    if (Unk_45_raw == value) return;
                    Unk_45_raw = value;
                    ChangedItems.Add(nameof(Unk_45));
                    OnPropertyChanged(nameof(Unk_45));
                }
            }

            [DisplayName("Offset")]
            public long Unk_45_offset { get; private set; }

            protected float Unk_46_raw;
            public const string Unk_46_displayName = "Unk 46";
            public const int Unk_46_sortIndex = 2400;
            [SortOrder(Unk_46_sortIndex)]
            [DisplayName(Unk_46_displayName)]
            public virtual float Unk_46 {
                get => Unk_46_raw;
                set {
                    if (Unk_46_raw == value) return;
                    Unk_46_raw = value;
                    ChangedItems.Add(nameof(Unk_46));
                    OnPropertyChanged(nameof(Unk_46));
                }
            }

            [DisplayName("Offset")]
            public long Unk_46_offset { get; private set; }

            protected float Unk_47_raw;
            public const string Unk_47_displayName = "Unk 47";
            public const int Unk_47_sortIndex = 2450;
            [SortOrder(Unk_47_sortIndex)]
            [DisplayName(Unk_47_displayName)]
            public virtual float Unk_47 {
                get => Unk_47_raw;
                set {
                    if (Unk_47_raw == value) return;
                    Unk_47_raw = value;
                    ChangedItems.Add(nameof(Unk_47));
                    OnPropertyChanged(nameof(Unk_47));
                }
            }

            [DisplayName("Offset")]
            public long Unk_47_offset { get; private set; }

            protected float Unk_48_raw;
            public const string Unk_48_displayName = "Unk 48";
            public const int Unk_48_sortIndex = 2500;
            [SortOrder(Unk_48_sortIndex)]
            [DisplayName(Unk_48_displayName)]
            public virtual float Unk_48 {
                get => Unk_48_raw;
                set {
                    if (Unk_48_raw == value) return;
                    Unk_48_raw = value;
                    ChangedItems.Add(nameof(Unk_48));
                    OnPropertyChanged(nameof(Unk_48));
                }
            }

            [DisplayName("Offset")]
            public long Unk_48_offset { get; private set; }

            protected float Unk_49_raw;
            public const string Unk_49_displayName = "Unk 49";
            public const int Unk_49_sortIndex = 2550;
            [SortOrder(Unk_49_sortIndex)]
            [DisplayName(Unk_49_displayName)]
            public virtual float Unk_49 {
                get => Unk_49_raw;
                set {
                    if (Unk_49_raw == value) return;
                    Unk_49_raw = value;
                    ChangedItems.Add(nameof(Unk_49));
                    OnPropertyChanged(nameof(Unk_49));
                }
            }

            [DisplayName("Offset")]
            public long Unk_49_offset { get; private set; }

            protected float Unk_50_raw;
            public const string Unk_50_displayName = "Unk 50";
            public const int Unk_50_sortIndex = 2600;
            [SortOrder(Unk_50_sortIndex)]
            [DisplayName(Unk_50_displayName)]
            public virtual float Unk_50 {
                get => Unk_50_raw;
                set {
                    if (Unk_50_raw == value) return;
                    Unk_50_raw = value;
                    ChangedItems.Add(nameof(Unk_50));
                    OnPropertyChanged(nameof(Unk_50));
                }
            }

            [DisplayName("Offset")]
            public long Unk_50_offset { get; private set; }

            protected float Unk_51_raw;
            public const string Unk_51_displayName = "Unk 51";
            public const int Unk_51_sortIndex = 2650;
            [SortOrder(Unk_51_sortIndex)]
            [DisplayName(Unk_51_displayName)]
            public virtual float Unk_51 {
                get => Unk_51_raw;
                set {
                    if (Unk_51_raw == value) return;
                    Unk_51_raw = value;
                    ChangedItems.Add(nameof(Unk_51));
                    OnPropertyChanged(nameof(Unk_51));
                }
            }

            [DisplayName("Offset")]
            public long Unk_51_offset { get; private set; }

            protected float Unk_52_raw;
            public const string Unk_52_displayName = "Unk 52";
            public const int Unk_52_sortIndex = 2700;
            [SortOrder(Unk_52_sortIndex)]
            [DisplayName(Unk_52_displayName)]
            public virtual float Unk_52 {
                get => Unk_52_raw;
                set {
                    if (Unk_52_raw == value) return;
                    Unk_52_raw = value;
                    ChangedItems.Add(nameof(Unk_52));
                    OnPropertyChanged(nameof(Unk_52));
                }
            }

            [DisplayName("Offset")]
            public long Unk_52_offset { get; private set; }

            protected float Unk_53_raw;
            public const string Unk_53_displayName = "Unk 53";
            public const int Unk_53_sortIndex = 2750;
            [SortOrder(Unk_53_sortIndex)]
            [DisplayName(Unk_53_displayName)]
            public virtual float Unk_53 {
                get => Unk_53_raw;
                set {
                    if (Unk_53_raw == value) return;
                    Unk_53_raw = value;
                    ChangedItems.Add(nameof(Unk_53));
                    OnPropertyChanged(nameof(Unk_53));
                }
            }

            [DisplayName("Offset")]
            public long Unk_53_offset { get; private set; }

            public const int lastSortIndex = 2800;

            public static ObservableMhwStructCollection<Scoutfly_Params_1_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Scoutfly_Params_1_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Scoutfly_Params_1_ LoadData(BinaryReader reader, ulong i) {
                var data = new Scoutfly_Params_1_();
                data.Index = i;
                data.Magic_1_offset = reader.BaseStream.Position;
                data.Magic_1_raw = reader.ReadUInt32();
                data.GIP_offset = reader.BaseStream.Position;
                data.GIP_raw = reader.ReadChars(4);
                data.Unk_1_offset = reader.BaseStream.Position;
                data.Unk_1_raw = reader.ReadUInt32();
                data.Unk_2_offset = reader.BaseStream.Position;
                data.Unk_2_raw = reader.ReadUInt32();
                data.Unk_3_offset = reader.BaseStream.Position;
                data.Unk_3_raw = reader.ReadUInt32();
                data.Unk_4_offset = reader.BaseStream.Position;
                data.Unk_4_raw = reader.ReadUInt32();
                data.Unk_5_offset = reader.BaseStream.Position;
                data.Unk_5_raw = reader.ReadUInt32();
                data.Unk_6_offset = reader.BaseStream.Position;
                data.Unk_6_raw = reader.ReadUInt32();
                data.Unk_7_offset = reader.BaseStream.Position;
                data.Unk_7_raw = reader.ReadUInt32();
                data.Unk_8_offset = reader.BaseStream.Position;
                data.Unk_8_raw = reader.ReadUInt32();
                data.Unk_9_offset = reader.BaseStream.Position;
                data.Unk_9_raw = reader.ReadUInt32();
                data.Unk_10_offset = reader.BaseStream.Position;
                data.Unk_10_raw = reader.ReadUInt32();
                data.Unk_11_offset = reader.BaseStream.Position;
                data.Unk_11_raw = reader.ReadUInt32();
                data.Unk_12_offset = reader.BaseStream.Position;
                data.Unk_12_raw = reader.ReadSingle();
                data.Unk_13_offset = reader.BaseStream.Position;
                data.Unk_13_raw = reader.ReadSingle();
                data.Unk_14_offset = reader.BaseStream.Position;
                data.Unk_14_raw = reader.ReadSingle();
                data.Unk_15_offset = reader.BaseStream.Position;
                data.Unk_15_raw = reader.ReadSingle();
                data.Unk_16_offset = reader.BaseStream.Position;
                data.Unk_16_raw = reader.ReadSingle();
                data.Unk_17_offset = reader.BaseStream.Position;
                data.Unk_17_raw = reader.ReadSingle();
                data.Unk_18_offset = reader.BaseStream.Position;
                data.Unk_18_raw = reader.ReadSingle();
                data.Unk_19_offset = reader.BaseStream.Position;
                data.Unk_19_raw = reader.ReadSingle();
                data.Unk_20_offset = reader.BaseStream.Position;
                data.Unk_20_raw = reader.ReadSingle();
                data.Unk_21_offset = reader.BaseStream.Position;
                data.Unk_21_raw = reader.ReadSingle();
                data.Unk_22_offset = reader.BaseStream.Position;
                data.Unk_22_raw = reader.ReadSingle();
                data.Unk_23_offset = reader.BaseStream.Position;
                data.Unk_23_raw = reader.ReadSingle();
                data.Unk_24_offset = reader.BaseStream.Position;
                data.Unk_24_raw = reader.ReadSingle();
                data.Unk_25_offset = reader.BaseStream.Position;
                data.Unk_25_raw = reader.ReadSingle();
                data.Unk_26_offset = reader.BaseStream.Position;
                data.Unk_26_raw = reader.ReadSingle();
                data.Unk_27_offset = reader.BaseStream.Position;
                data.Unk_27_raw = reader.ReadSingle();
                data.Unk_28_offset = reader.BaseStream.Position;
                data.Unk_28_raw = reader.ReadSingle();
                data.Unk_29_offset = reader.BaseStream.Position;
                data.Unk_29_raw = reader.ReadSingle();
                data.Unk_30_offset = reader.BaseStream.Position;
                data.Unk_30_raw = reader.ReadSingle();
                data.Unk_31_offset = reader.BaseStream.Position;
                data.Unk_31_raw = reader.ReadSingle();
                data.Unk_32_offset = reader.BaseStream.Position;
                data.Unk_32_raw = reader.ReadSingle();
                data.Unk_33_offset = reader.BaseStream.Position;
                data.Unk_33_raw = reader.ReadSingle();
                data.Unk_34_offset = reader.BaseStream.Position;
                data.Unk_34_raw = reader.ReadSingle();
                data.Unk_35_offset = reader.BaseStream.Position;
                data.Unk_35_raw = reader.ReadSingle();
                data.Unk_36_offset = reader.BaseStream.Position;
                data.Unk_36_raw = reader.ReadSingle();
                data.Unk_37_offset = reader.BaseStream.Position;
                data.Unk_37_raw = reader.ReadSingle();
                data.Unk_38_offset = reader.BaseStream.Position;
                data.Unk_38_raw = reader.ReadSingle();
                data.Unk_39_offset = reader.BaseStream.Position;
                data.Unk_39_raw = reader.ReadSingle();
                data.Unk_40_offset = reader.BaseStream.Position;
                data.Unk_40_raw = reader.ReadSingle();
                data.Unk_41_offset = reader.BaseStream.Position;
                data.Unk_41_raw = reader.ReadSingle();
                data.Unk_42_offset = reader.BaseStream.Position;
                data.Unk_42_raw = reader.ReadSingle();
                data.Unk_43_offset = reader.BaseStream.Position;
                data.Unk_43_raw = reader.ReadSingle();
                data.Unk_44_offset = reader.BaseStream.Position;
                data.Unk_44_raw = reader.ReadSingle();
                data.Unk_45_offset = reader.BaseStream.Position;
                data.Unk_45_raw = reader.ReadSingle();
                data.Unk_46_offset = reader.BaseStream.Position;
                data.Unk_46_raw = reader.ReadSingle();
                data.Unk_47_offset = reader.BaseStream.Position;
                data.Unk_47_raw = reader.ReadSingle();
                data.Unk_48_offset = reader.BaseStream.Position;
                data.Unk_48_raw = reader.ReadSingle();
                data.Unk_49_offset = reader.BaseStream.Position;
                data.Unk_49_raw = reader.ReadSingle();
                data.Unk_50_offset = reader.BaseStream.Position;
                data.Unk_50_raw = reader.ReadSingle();
                data.Unk_51_offset = reader.BaseStream.Position;
                data.Unk_51_raw = reader.ReadSingle();
                data.Unk_52_offset = reader.BaseStream.Position;
                data.Unk_52_raw = reader.ReadSingle();
                data.Unk_53_offset = reader.BaseStream.Position;
                data.Unk_53_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Magic_1_raw);
                writer.Write(GIP_raw);
                writer.Write(Unk_1_raw);
                writer.Write(Unk_2_raw);
                writer.Write(Unk_3_raw);
                writer.Write(Unk_4_raw);
                writer.Write(Unk_5_raw);
                writer.Write(Unk_6_raw);
                writer.Write(Unk_7_raw);
                writer.Write(Unk_8_raw);
                writer.Write(Unk_9_raw);
                writer.Write(Unk_10_raw);
                writer.Write(Unk_11_raw);
                writer.Write(Unk_12_raw);
                writer.Write(Unk_13_raw);
                writer.Write(Unk_14_raw);
                writer.Write(Unk_15_raw);
                writer.Write(Unk_16_raw);
                writer.Write(Unk_17_raw);
                writer.Write(Unk_18_raw);
                writer.Write(Unk_19_raw);
                writer.Write(Unk_20_raw);
                writer.Write(Unk_21_raw);
                writer.Write(Unk_22_raw);
                writer.Write(Unk_23_raw);
                writer.Write(Unk_24_raw);
                writer.Write(Unk_25_raw);
                writer.Write(Unk_26_raw);
                writer.Write(Unk_27_raw);
                writer.Write(Unk_28_raw);
                writer.Write(Unk_29_raw);
                writer.Write(Unk_30_raw);
                writer.Write(Unk_31_raw);
                writer.Write(Unk_32_raw);
                writer.Write(Unk_33_raw);
                writer.Write(Unk_34_raw);
                writer.Write(Unk_35_raw);
                writer.Write(Unk_36_raw);
                writer.Write(Unk_37_raw);
                writer.Write(Unk_38_raw);
                writer.Write(Unk_39_raw);
                writer.Write(Unk_40_raw);
                writer.Write(Unk_41_raw);
                writer.Write(Unk_42_raw);
                writer.Write(Unk_43_raw);
                writer.Write(Unk_44_raw);
                writer.Write(Unk_45_raw);
                writer.Write(Unk_46_raw);
                writer.Write(Unk_47_raw);
                writer.Write(Unk_48_raw);
                writer.Write(Unk_49_raw);
                writer.Write(Unk_50_raw);
                writer.Write(Unk_51_raw);
                writer.Write(Unk_52_raw);
                writer.Write(Unk_53_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Magic 1", "Magic_1", "Magic_1_offset"),
                    new MultiStructItemCustomView(this, "GIP", "GIP", "GIP_offset"),
                    new MultiStructItemCustomView(this, "Unk 1", "Unk_1", "Unk_1_offset"),
                    new MultiStructItemCustomView(this, "Unk 2", "Unk_2", "Unk_2_offset"),
                    new MultiStructItemCustomView(this, "Unk 3", "Unk_3", "Unk_3_offset"),
                    new MultiStructItemCustomView(this, "Unk 4", "Unk_4", "Unk_4_offset"),
                    new MultiStructItemCustomView(this, "Unk 5", "Unk_5", "Unk_5_offset"),
                    new MultiStructItemCustomView(this, "Unk 6", "Unk_6", "Unk_6_offset"),
                    new MultiStructItemCustomView(this, "Unk 7", "Unk_7", "Unk_7_offset"),
                    new MultiStructItemCustomView(this, "Unk 8", "Unk_8", "Unk_8_offset"),
                    new MultiStructItemCustomView(this, "Unk 9", "Unk_9", "Unk_9_offset"),
                    new MultiStructItemCustomView(this, "Unk 10", "Unk_10", "Unk_10_offset"),
                    new MultiStructItemCustomView(this, "Unk 11", "Unk_11", "Unk_11_offset"),
                    new MultiStructItemCustomView(this, "Unk 12", "Unk_12", "Unk_12_offset"),
                    new MultiStructItemCustomView(this, "Unk 13", "Unk_13", "Unk_13_offset"),
                    new MultiStructItemCustomView(this, "Unk 14", "Unk_14", "Unk_14_offset"),
                    new MultiStructItemCustomView(this, "Unk 15", "Unk_15", "Unk_15_offset"),
                    new MultiStructItemCustomView(this, "Unk 16", "Unk_16", "Unk_16_offset"),
                    new MultiStructItemCustomView(this, "Unk 17", "Unk_17", "Unk_17_offset"),
                    new MultiStructItemCustomView(this, "Unk 18", "Unk_18", "Unk_18_offset"),
                    new MultiStructItemCustomView(this, "Unk 19", "Unk_19", "Unk_19_offset"),
                    new MultiStructItemCustomView(this, "Unk 20", "Unk_20", "Unk_20_offset"),
                    new MultiStructItemCustomView(this, "Unk 21", "Unk_21", "Unk_21_offset"),
                    new MultiStructItemCustomView(this, "Unk 22", "Unk_22", "Unk_22_offset"),
                    new MultiStructItemCustomView(this, "Unk 23", "Unk_23", "Unk_23_offset"),
                    new MultiStructItemCustomView(this, "Unk 24", "Unk_24", "Unk_24_offset"),
                    new MultiStructItemCustomView(this, "Unk 25", "Unk_25", "Unk_25_offset"),
                    new MultiStructItemCustomView(this, "Unk 26", "Unk_26", "Unk_26_offset"),
                    new MultiStructItemCustomView(this, "Unk 27", "Unk_27", "Unk_27_offset"),
                    new MultiStructItemCustomView(this, "Unk 28", "Unk_28", "Unk_28_offset"),
                    new MultiStructItemCustomView(this, "Unk 29", "Unk_29", "Unk_29_offset"),
                    new MultiStructItemCustomView(this, "Unk 30", "Unk_30", "Unk_30_offset"),
                    new MultiStructItemCustomView(this, "Unk 31", "Unk_31", "Unk_31_offset"),
                    new MultiStructItemCustomView(this, "Unk 32", "Unk_32", "Unk_32_offset"),
                    new MultiStructItemCustomView(this, "Unk 33", "Unk_33", "Unk_33_offset"),
                    new MultiStructItemCustomView(this, "Unk 34", "Unk_34", "Unk_34_offset"),
                    new MultiStructItemCustomView(this, "Unk 35", "Unk_35", "Unk_35_offset"),
                    new MultiStructItemCustomView(this, "Unk 36", "Unk_36", "Unk_36_offset"),
                    new MultiStructItemCustomView(this, "Unk 37", "Unk_37", "Unk_37_offset"),
                    new MultiStructItemCustomView(this, "Unk 38", "Unk_38", "Unk_38_offset"),
                    new MultiStructItemCustomView(this, "Unk 39", "Unk_39", "Unk_39_offset"),
                    new MultiStructItemCustomView(this, "Unk 40", "Unk_40", "Unk_40_offset"),
                    new MultiStructItemCustomView(this, "Unk 41", "Unk_41", "Unk_41_offset"),
                    new MultiStructItemCustomView(this, "Unk 42", "Unk_42", "Unk_42_offset"),
                    new MultiStructItemCustomView(this, "Unk 43", "Unk_43", "Unk_43_offset"),
                    new MultiStructItemCustomView(this, "Unk 44", "Unk_44", "Unk_44_offset"),
                    new MultiStructItemCustomView(this, "Unk 45", "Unk_45", "Unk_45_offset"),
                    new MultiStructItemCustomView(this, "Unk 46", "Unk_46", "Unk_46_offset"),
                    new MultiStructItemCustomView(this, "Unk 47", "Unk_47", "Unk_47_offset"),
                    new MultiStructItemCustomView(this, "Unk 48", "Unk_48", "Unk_48_offset"),
                    new MultiStructItemCustomView(this, "Unk 49", "Unk_49", "Unk_49_offset"),
                    new MultiStructItemCustomView(this, "Unk 50", "Unk_50", "Unk_50_offset"),
                    new MultiStructItemCustomView(this, "Unk 51", "Unk_51", "Unk_51_offset"),
                    new MultiStructItemCustomView(this, "Unk 52", "Unk_52", "Unk_52_offset"),
                    new MultiStructItemCustomView(this, "Unk 53", "Unk_53", "Unk_53_offset"),
                };
            }
        }

        public partial class Unknown_Arr_1_ : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 12;
            public const string GridName = "Unknown Arr (1)";

            protected byte Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 50;
            [SortOrder(Unk_1_sortIndex)]
            [DisplayName(Unk_1_displayName)]
            public virtual byte Unk_1 {
                get => Unk_1_raw;
                set {
                    if (Unk_1_raw == value) return;
                    Unk_1_raw = value;
                    ChangedItems.Add(nameof(Unk_1));
                    OnPropertyChanged(nameof(Unk_1));
                }
            }

            protected byte Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 100;
            [SortOrder(Unk_2_sortIndex)]
            [DisplayName(Unk_2_displayName)]
            public virtual byte Unk_2 {
                get => Unk_2_raw;
                set {
                    if (Unk_2_raw == value) return;
                    Unk_2_raw = value;
                    ChangedItems.Add(nameof(Unk_2));
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            protected sbyte Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 150;
            [SortOrder(Unk_3_sortIndex)]
            [DisplayName(Unk_3_displayName)]
            public virtual sbyte Unk_3 {
                get => Unk_3_raw;
                set {
                    if (Unk_3_raw == value) return;
                    Unk_3_raw = value;
                    ChangedItems.Add(nameof(Unk_3));
                    OnPropertyChanged(nameof(Unk_3));
                }
            }

            protected sbyte Unk_4_raw;
            public const string Unk_4_displayName = "Unk 4";
            public const int Unk_4_sortIndex = 200;
            [SortOrder(Unk_4_sortIndex)]
            [DisplayName(Unk_4_displayName)]
            public virtual sbyte Unk_4 {
                get => Unk_4_raw;
                set {
                    if (Unk_4_raw == value) return;
                    Unk_4_raw = value;
                    ChangedItems.Add(nameof(Unk_4));
                    OnPropertyChanged(nameof(Unk_4));
                }
            }

            public const int lastSortIndex = 250;

            public static ObservableMhwStructCollection<Unknown_Arr_1_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Unknown_Arr_1_>();
                const ulong count = 12UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Unknown_Arr_1_ LoadData(BinaryReader reader, ulong i) {
                var data = new Unknown_Arr_1_();
                data.Index = i;
                data.Unk_1_raw = reader.ReadByte();
                data.Unk_2_raw = reader.ReadByte();
                data.Unk_3_raw = reader.ReadSByte();
                data.Unk_4_raw = reader.ReadSByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_1_raw);
                writer.Write(Unk_2_raw);
                writer.Write(Unk_3_raw);
                writer.Write(Unk_4_raw);
            }
        }

        public partial class Scoutfly_Params_2_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Scoutfly Params (2)";

            protected float Unk_54_raw;
            public const string Unk_54_displayName = "Unk 54";
            public const int Unk_54_sortIndex = 50;
            [SortOrder(Unk_54_sortIndex)]
            [DisplayName(Unk_54_displayName)]
            public virtual float Unk_54 {
                get => Unk_54_raw;
                set {
                    if (Unk_54_raw == value) return;
                    Unk_54_raw = value;
                    ChangedItems.Add(nameof(Unk_54));
                    OnPropertyChanged(nameof(Unk_54));
                }
            }

            [DisplayName("Offset")]
            public long Unk_54_offset { get; private set; }

            protected float Unk_55_raw;
            public const string Unk_55_displayName = "Unk 55";
            public const int Unk_55_sortIndex = 100;
            [SortOrder(Unk_55_sortIndex)]
            [DisplayName(Unk_55_displayName)]
            public virtual float Unk_55 {
                get => Unk_55_raw;
                set {
                    if (Unk_55_raw == value) return;
                    Unk_55_raw = value;
                    ChangedItems.Add(nameof(Unk_55));
                    OnPropertyChanged(nameof(Unk_55));
                }
            }

            [DisplayName("Offset")]
            public long Unk_55_offset { get; private set; }

            protected float Unk_56_raw;
            public const string Unk_56_displayName = "Unk 56";
            public const int Unk_56_sortIndex = 150;
            [SortOrder(Unk_56_sortIndex)]
            [DisplayName(Unk_56_displayName)]
            public virtual float Unk_56 {
                get => Unk_56_raw;
                set {
                    if (Unk_56_raw == value) return;
                    Unk_56_raw = value;
                    ChangedItems.Add(nameof(Unk_56));
                    OnPropertyChanged(nameof(Unk_56));
                }
            }

            [DisplayName("Offset")]
            public long Unk_56_offset { get; private set; }

            protected float Unk_57_raw;
            public const string Unk_57_displayName = "Unk 57";
            public const int Unk_57_sortIndex = 200;
            [SortOrder(Unk_57_sortIndex)]
            [DisplayName(Unk_57_displayName)]
            public virtual float Unk_57 {
                get => Unk_57_raw;
                set {
                    if (Unk_57_raw == value) return;
                    Unk_57_raw = value;
                    ChangedItems.Add(nameof(Unk_57));
                    OnPropertyChanged(nameof(Unk_57));
                }
            }

            [DisplayName("Offset")]
            public long Unk_57_offset { get; private set; }

            protected float Unk_58_raw;
            public const string Unk_58_displayName = "Unk 58";
            public const int Unk_58_sortIndex = 250;
            [SortOrder(Unk_58_sortIndex)]
            [DisplayName(Unk_58_displayName)]
            public virtual float Unk_58 {
                get => Unk_58_raw;
                set {
                    if (Unk_58_raw == value) return;
                    Unk_58_raw = value;
                    ChangedItems.Add(nameof(Unk_58));
                    OnPropertyChanged(nameof(Unk_58));
                }
            }

            [DisplayName("Offset")]
            public long Unk_58_offset { get; private set; }

            protected float Unk_59_raw;
            public const string Unk_59_displayName = "Unk 59";
            public const int Unk_59_sortIndex = 300;
            [SortOrder(Unk_59_sortIndex)]
            [DisplayName(Unk_59_displayName)]
            public virtual float Unk_59 {
                get => Unk_59_raw;
                set {
                    if (Unk_59_raw == value) return;
                    Unk_59_raw = value;
                    ChangedItems.Add(nameof(Unk_59));
                    OnPropertyChanged(nameof(Unk_59));
                }
            }

            [DisplayName("Offset")]
            public long Unk_59_offset { get; private set; }

            protected float Unk_60_raw;
            public const string Unk_60_displayName = "Unk 60";
            public const int Unk_60_sortIndex = 350;
            [SortOrder(Unk_60_sortIndex)]
            [DisplayName(Unk_60_displayName)]
            public virtual float Unk_60 {
                get => Unk_60_raw;
                set {
                    if (Unk_60_raw == value) return;
                    Unk_60_raw = value;
                    ChangedItems.Add(nameof(Unk_60));
                    OnPropertyChanged(nameof(Unk_60));
                }
            }

            [DisplayName("Offset")]
            public long Unk_60_offset { get; private set; }

            protected float Unk_61_raw;
            public const string Unk_61_displayName = "Unk 61";
            public const int Unk_61_sortIndex = 400;
            [SortOrder(Unk_61_sortIndex)]
            [DisplayName(Unk_61_displayName)]
            public virtual float Unk_61 {
                get => Unk_61_raw;
                set {
                    if (Unk_61_raw == value) return;
                    Unk_61_raw = value;
                    ChangedItems.Add(nameof(Unk_61));
                    OnPropertyChanged(nameof(Unk_61));
                }
            }

            [DisplayName("Offset")]
            public long Unk_61_offset { get; private set; }

            protected float Unk_62_raw;
            public const string Unk_62_displayName = "Unk 62";
            public const int Unk_62_sortIndex = 450;
            [SortOrder(Unk_62_sortIndex)]
            [DisplayName(Unk_62_displayName)]
            public virtual float Unk_62 {
                get => Unk_62_raw;
                set {
                    if (Unk_62_raw == value) return;
                    Unk_62_raw = value;
                    ChangedItems.Add(nameof(Unk_62));
                    OnPropertyChanged(nameof(Unk_62));
                }
            }

            [DisplayName("Offset")]
            public long Unk_62_offset { get; private set; }

            protected float Unk_63_raw;
            public const string Unk_63_displayName = "Unk 63";
            public const int Unk_63_sortIndex = 500;
            [SortOrder(Unk_63_sortIndex)]
            [DisplayName(Unk_63_displayName)]
            public virtual float Unk_63 {
                get => Unk_63_raw;
                set {
                    if (Unk_63_raw == value) return;
                    Unk_63_raw = value;
                    ChangedItems.Add(nameof(Unk_63));
                    OnPropertyChanged(nameof(Unk_63));
                }
            }

            [DisplayName("Offset")]
            public long Unk_63_offset { get; private set; }

            protected float Unk_64_raw;
            public const string Unk_64_displayName = "Unk 64";
            public const int Unk_64_sortIndex = 550;
            [SortOrder(Unk_64_sortIndex)]
            [DisplayName(Unk_64_displayName)]
            public virtual float Unk_64 {
                get => Unk_64_raw;
                set {
                    if (Unk_64_raw == value) return;
                    Unk_64_raw = value;
                    ChangedItems.Add(nameof(Unk_64));
                    OnPropertyChanged(nameof(Unk_64));
                }
            }

            [DisplayName("Offset")]
            public long Unk_64_offset { get; private set; }

            protected float Unk_65_raw;
            public const string Unk_65_displayName = "Unk 65";
            public const int Unk_65_sortIndex = 600;
            [SortOrder(Unk_65_sortIndex)]
            [DisplayName(Unk_65_displayName)]
            public virtual float Unk_65 {
                get => Unk_65_raw;
                set {
                    if (Unk_65_raw == value) return;
                    Unk_65_raw = value;
                    ChangedItems.Add(nameof(Unk_65));
                    OnPropertyChanged(nameof(Unk_65));
                }
            }

            [DisplayName("Offset")]
            public long Unk_65_offset { get; private set; }

            protected float Unk_66_raw;
            public const string Unk_66_displayName = "Unk 66";
            public const int Unk_66_sortIndex = 650;
            [SortOrder(Unk_66_sortIndex)]
            [DisplayName(Unk_66_displayName)]
            public virtual float Unk_66 {
                get => Unk_66_raw;
                set {
                    if (Unk_66_raw == value) return;
                    Unk_66_raw = value;
                    ChangedItems.Add(nameof(Unk_66));
                    OnPropertyChanged(nameof(Unk_66));
                }
            }

            [DisplayName("Offset")]
            public long Unk_66_offset { get; private set; }

            protected float Unk_67_raw;
            public const string Unk_67_displayName = "Unk 67";
            public const int Unk_67_sortIndex = 700;
            [SortOrder(Unk_67_sortIndex)]
            [DisplayName(Unk_67_displayName)]
            public virtual float Unk_67 {
                get => Unk_67_raw;
                set {
                    if (Unk_67_raw == value) return;
                    Unk_67_raw = value;
                    ChangedItems.Add(nameof(Unk_67));
                    OnPropertyChanged(nameof(Unk_67));
                }
            }

            [DisplayName("Offset")]
            public long Unk_67_offset { get; private set; }

            protected float Unk_68_raw;
            public const string Unk_68_displayName = "Unk 68";
            public const int Unk_68_sortIndex = 750;
            [SortOrder(Unk_68_sortIndex)]
            [DisplayName(Unk_68_displayName)]
            public virtual float Unk_68 {
                get => Unk_68_raw;
                set {
                    if (Unk_68_raw == value) return;
                    Unk_68_raw = value;
                    ChangedItems.Add(nameof(Unk_68));
                    OnPropertyChanged(nameof(Unk_68));
                }
            }

            [DisplayName("Offset")]
            public long Unk_68_offset { get; private set; }

            protected float Unk_69_raw;
            public const string Unk_69_displayName = "Unk 69";
            public const int Unk_69_sortIndex = 800;
            [SortOrder(Unk_69_sortIndex)]
            [DisplayName(Unk_69_displayName)]
            public virtual float Unk_69 {
                get => Unk_69_raw;
                set {
                    if (Unk_69_raw == value) return;
                    Unk_69_raw = value;
                    ChangedItems.Add(nameof(Unk_69));
                    OnPropertyChanged(nameof(Unk_69));
                }
            }

            [DisplayName("Offset")]
            public long Unk_69_offset { get; private set; }

            protected float Unk_70_raw;
            public const string Unk_70_displayName = "Unk 70";
            public const int Unk_70_sortIndex = 850;
            [SortOrder(Unk_70_sortIndex)]
            [DisplayName(Unk_70_displayName)]
            public virtual float Unk_70 {
                get => Unk_70_raw;
                set {
                    if (Unk_70_raw == value) return;
                    Unk_70_raw = value;
                    ChangedItems.Add(nameof(Unk_70));
                    OnPropertyChanged(nameof(Unk_70));
                }
            }

            [DisplayName("Offset")]
            public long Unk_70_offset { get; private set; }

            protected float Unk_71_raw;
            public const string Unk_71_displayName = "Unk 71";
            public const int Unk_71_sortIndex = 900;
            [SortOrder(Unk_71_sortIndex)]
            [DisplayName(Unk_71_displayName)]
            public virtual float Unk_71 {
                get => Unk_71_raw;
                set {
                    if (Unk_71_raw == value) return;
                    Unk_71_raw = value;
                    ChangedItems.Add(nameof(Unk_71));
                    OnPropertyChanged(nameof(Unk_71));
                }
            }

            [DisplayName("Offset")]
            public long Unk_71_offset { get; private set; }

            protected float Unk_72_raw;
            public const string Unk_72_displayName = "Unk 72";
            public const int Unk_72_sortIndex = 950;
            [SortOrder(Unk_72_sortIndex)]
            [DisplayName(Unk_72_displayName)]
            public virtual float Unk_72 {
                get => Unk_72_raw;
                set {
                    if (Unk_72_raw == value) return;
                    Unk_72_raw = value;
                    ChangedItems.Add(nameof(Unk_72));
                    OnPropertyChanged(nameof(Unk_72));
                }
            }

            [DisplayName("Offset")]
            public long Unk_72_offset { get; private set; }

            protected float Unk_73_raw;
            public const string Unk_73_displayName = "Unk 73";
            public const int Unk_73_sortIndex = 1000;
            [SortOrder(Unk_73_sortIndex)]
            [DisplayName(Unk_73_displayName)]
            public virtual float Unk_73 {
                get => Unk_73_raw;
                set {
                    if (Unk_73_raw == value) return;
                    Unk_73_raw = value;
                    ChangedItems.Add(nameof(Unk_73));
                    OnPropertyChanged(nameof(Unk_73));
                }
            }

            [DisplayName("Offset")]
            public long Unk_73_offset { get; private set; }

            protected float Unk_74_raw;
            public const string Unk_74_displayName = "Unk 74";
            public const int Unk_74_sortIndex = 1050;
            [SortOrder(Unk_74_sortIndex)]
            [DisplayName(Unk_74_displayName)]
            public virtual float Unk_74 {
                get => Unk_74_raw;
                set {
                    if (Unk_74_raw == value) return;
                    Unk_74_raw = value;
                    ChangedItems.Add(nameof(Unk_74));
                    OnPropertyChanged(nameof(Unk_74));
                }
            }

            [DisplayName("Offset")]
            public long Unk_74_offset { get; private set; }

            protected float Unk_75_raw;
            public const string Unk_75_displayName = "Unk 75";
            public const int Unk_75_sortIndex = 1100;
            [SortOrder(Unk_75_sortIndex)]
            [DisplayName(Unk_75_displayName)]
            public virtual float Unk_75 {
                get => Unk_75_raw;
                set {
                    if (Unk_75_raw == value) return;
                    Unk_75_raw = value;
                    ChangedItems.Add(nameof(Unk_75));
                    OnPropertyChanged(nameof(Unk_75));
                }
            }

            [DisplayName("Offset")]
            public long Unk_75_offset { get; private set; }

            protected float Unk_76_raw;
            public const string Unk_76_displayName = "Unk 76";
            public const int Unk_76_sortIndex = 1150;
            [SortOrder(Unk_76_sortIndex)]
            [DisplayName(Unk_76_displayName)]
            public virtual float Unk_76 {
                get => Unk_76_raw;
                set {
                    if (Unk_76_raw == value) return;
                    Unk_76_raw = value;
                    ChangedItems.Add(nameof(Unk_76));
                    OnPropertyChanged(nameof(Unk_76));
                }
            }

            [DisplayName("Offset")]
            public long Unk_76_offset { get; private set; }

            protected float Unk_77_raw;
            public const string Unk_77_displayName = "Unk 77";
            public const int Unk_77_sortIndex = 1200;
            [SortOrder(Unk_77_sortIndex)]
            [DisplayName(Unk_77_displayName)]
            public virtual float Unk_77 {
                get => Unk_77_raw;
                set {
                    if (Unk_77_raw == value) return;
                    Unk_77_raw = value;
                    ChangedItems.Add(nameof(Unk_77));
                    OnPropertyChanged(nameof(Unk_77));
                }
            }

            [DisplayName("Offset")]
            public long Unk_77_offset { get; private set; }

            protected float Unk_78_raw;
            public const string Unk_78_displayName = "Unk 78";
            public const int Unk_78_sortIndex = 1250;
            [SortOrder(Unk_78_sortIndex)]
            [DisplayName(Unk_78_displayName)]
            public virtual float Unk_78 {
                get => Unk_78_raw;
                set {
                    if (Unk_78_raw == value) return;
                    Unk_78_raw = value;
                    ChangedItems.Add(nameof(Unk_78));
                    OnPropertyChanged(nameof(Unk_78));
                }
            }

            [DisplayName("Offset")]
            public long Unk_78_offset { get; private set; }

            protected float Unk_79_raw;
            public const string Unk_79_displayName = "Unk 79";
            public const int Unk_79_sortIndex = 1300;
            [SortOrder(Unk_79_sortIndex)]
            [DisplayName(Unk_79_displayName)]
            public virtual float Unk_79 {
                get => Unk_79_raw;
                set {
                    if (Unk_79_raw == value) return;
                    Unk_79_raw = value;
                    ChangedItems.Add(nameof(Unk_79));
                    OnPropertyChanged(nameof(Unk_79));
                }
            }

            [DisplayName("Offset")]
            public long Unk_79_offset { get; private set; }

            protected float Unk_80_raw;
            public const string Unk_80_displayName = "Unk 80";
            public const int Unk_80_sortIndex = 1350;
            [SortOrder(Unk_80_sortIndex)]
            [DisplayName(Unk_80_displayName)]
            public virtual float Unk_80 {
                get => Unk_80_raw;
                set {
                    if (Unk_80_raw == value) return;
                    Unk_80_raw = value;
                    ChangedItems.Add(nameof(Unk_80));
                    OnPropertyChanged(nameof(Unk_80));
                }
            }

            [DisplayName("Offset")]
            public long Unk_80_offset { get; private set; }

            protected float Unk_81_raw;
            public const string Unk_81_displayName = "Unk 81";
            public const int Unk_81_sortIndex = 1400;
            [SortOrder(Unk_81_sortIndex)]
            [DisplayName(Unk_81_displayName)]
            public virtual float Unk_81 {
                get => Unk_81_raw;
                set {
                    if (Unk_81_raw == value) return;
                    Unk_81_raw = value;
                    ChangedItems.Add(nameof(Unk_81));
                    OnPropertyChanged(nameof(Unk_81));
                }
            }

            [DisplayName("Offset")]
            public long Unk_81_offset { get; private set; }

            protected float Unk_82_raw;
            public const string Unk_82_displayName = "Unk 82";
            public const int Unk_82_sortIndex = 1450;
            [SortOrder(Unk_82_sortIndex)]
            [DisplayName(Unk_82_displayName)]
            public virtual float Unk_82 {
                get => Unk_82_raw;
                set {
                    if (Unk_82_raw == value) return;
                    Unk_82_raw = value;
                    ChangedItems.Add(nameof(Unk_82));
                    OnPropertyChanged(nameof(Unk_82));
                }
            }

            [DisplayName("Offset")]
            public long Unk_82_offset { get; private set; }

            protected float Unk_83_raw;
            public const string Unk_83_displayName = "Unk 83";
            public const int Unk_83_sortIndex = 1500;
            [SortOrder(Unk_83_sortIndex)]
            [DisplayName(Unk_83_displayName)]
            public virtual float Unk_83 {
                get => Unk_83_raw;
                set {
                    if (Unk_83_raw == value) return;
                    Unk_83_raw = value;
                    ChangedItems.Add(nameof(Unk_83));
                    OnPropertyChanged(nameof(Unk_83));
                }
            }

            [DisplayName("Offset")]
            public long Unk_83_offset { get; private set; }

            protected float Unk_84_raw;
            public const string Unk_84_displayName = "Unk 84";
            public const int Unk_84_sortIndex = 1550;
            [SortOrder(Unk_84_sortIndex)]
            [DisplayName(Unk_84_displayName)]
            public virtual float Unk_84 {
                get => Unk_84_raw;
                set {
                    if (Unk_84_raw == value) return;
                    Unk_84_raw = value;
                    ChangedItems.Add(nameof(Unk_84));
                    OnPropertyChanged(nameof(Unk_84));
                }
            }

            [DisplayName("Offset")]
            public long Unk_84_offset { get; private set; }

            protected float Unk_85_raw;
            public const string Unk_85_displayName = "Unk 85";
            public const int Unk_85_sortIndex = 1600;
            [SortOrder(Unk_85_sortIndex)]
            [DisplayName(Unk_85_displayName)]
            public virtual float Unk_85 {
                get => Unk_85_raw;
                set {
                    if (Unk_85_raw == value) return;
                    Unk_85_raw = value;
                    ChangedItems.Add(nameof(Unk_85));
                    OnPropertyChanged(nameof(Unk_85));
                }
            }

            [DisplayName("Offset")]
            public long Unk_85_offset { get; private set; }

            protected float Unk_86_raw;
            public const string Unk_86_displayName = "Unk 86";
            public const int Unk_86_sortIndex = 1650;
            [SortOrder(Unk_86_sortIndex)]
            [DisplayName(Unk_86_displayName)]
            public virtual float Unk_86 {
                get => Unk_86_raw;
                set {
                    if (Unk_86_raw == value) return;
                    Unk_86_raw = value;
                    ChangedItems.Add(nameof(Unk_86));
                    OnPropertyChanged(nameof(Unk_86));
                }
            }

            [DisplayName("Offset")]
            public long Unk_86_offset { get; private set; }

            protected float Unk_87_raw;
            public const string Unk_87_displayName = "Unk 87";
            public const int Unk_87_sortIndex = 1700;
            [SortOrder(Unk_87_sortIndex)]
            [DisplayName(Unk_87_displayName)]
            public virtual float Unk_87 {
                get => Unk_87_raw;
                set {
                    if (Unk_87_raw == value) return;
                    Unk_87_raw = value;
                    ChangedItems.Add(nameof(Unk_87));
                    OnPropertyChanged(nameof(Unk_87));
                }
            }

            [DisplayName("Offset")]
            public long Unk_87_offset { get; private set; }

            protected float Unk_88_raw;
            public const string Unk_88_displayName = "Unk 88";
            public const int Unk_88_sortIndex = 1750;
            [SortOrder(Unk_88_sortIndex)]
            [DisplayName(Unk_88_displayName)]
            public virtual float Unk_88 {
                get => Unk_88_raw;
                set {
                    if (Unk_88_raw == value) return;
                    Unk_88_raw = value;
                    ChangedItems.Add(nameof(Unk_88));
                    OnPropertyChanged(nameof(Unk_88));
                }
            }

            [DisplayName("Offset")]
            public long Unk_88_offset { get; private set; }

            protected float Unk_89_raw;
            public const string Unk_89_displayName = "Unk 89";
            public const int Unk_89_sortIndex = 1800;
            [SortOrder(Unk_89_sortIndex)]
            [DisplayName(Unk_89_displayName)]
            public virtual float Unk_89 {
                get => Unk_89_raw;
                set {
                    if (Unk_89_raw == value) return;
                    Unk_89_raw = value;
                    ChangedItems.Add(nameof(Unk_89));
                    OnPropertyChanged(nameof(Unk_89));
                }
            }

            [DisplayName("Offset")]
            public long Unk_89_offset { get; private set; }

            protected float Unk_90_raw;
            public const string Unk_90_displayName = "Unk 90";
            public const int Unk_90_sortIndex = 1850;
            [SortOrder(Unk_90_sortIndex)]
            [DisplayName(Unk_90_displayName)]
            public virtual float Unk_90 {
                get => Unk_90_raw;
                set {
                    if (Unk_90_raw == value) return;
                    Unk_90_raw = value;
                    ChangedItems.Add(nameof(Unk_90));
                    OnPropertyChanged(nameof(Unk_90));
                }
            }

            [DisplayName("Offset")]
            public long Unk_90_offset { get; private set; }

            protected float Unk_91_raw;
            public const string Unk_91_displayName = "Unk 91";
            public const int Unk_91_sortIndex = 1900;
            [SortOrder(Unk_91_sortIndex)]
            [DisplayName(Unk_91_displayName)]
            public virtual float Unk_91 {
                get => Unk_91_raw;
                set {
                    if (Unk_91_raw == value) return;
                    Unk_91_raw = value;
                    ChangedItems.Add(nameof(Unk_91));
                    OnPropertyChanged(nameof(Unk_91));
                }
            }

            [DisplayName("Offset")]
            public long Unk_91_offset { get; private set; }

            protected float Unk_92_raw;
            public const string Unk_92_displayName = "Unk 92";
            public const int Unk_92_sortIndex = 1950;
            [SortOrder(Unk_92_sortIndex)]
            [DisplayName(Unk_92_displayName)]
            public virtual float Unk_92 {
                get => Unk_92_raw;
                set {
                    if (Unk_92_raw == value) return;
                    Unk_92_raw = value;
                    ChangedItems.Add(nameof(Unk_92));
                    OnPropertyChanged(nameof(Unk_92));
                }
            }

            [DisplayName("Offset")]
            public long Unk_92_offset { get; private set; }

            protected float Unk_93_raw;
            public const string Unk_93_displayName = "Unk 93";
            public const int Unk_93_sortIndex = 2000;
            [SortOrder(Unk_93_sortIndex)]
            [DisplayName(Unk_93_displayName)]
            public virtual float Unk_93 {
                get => Unk_93_raw;
                set {
                    if (Unk_93_raw == value) return;
                    Unk_93_raw = value;
                    ChangedItems.Add(nameof(Unk_93));
                    OnPropertyChanged(nameof(Unk_93));
                }
            }

            [DisplayName("Offset")]
            public long Unk_93_offset { get; private set; }

            protected float Unk_94_raw;
            public const string Unk_94_displayName = "Unk 94";
            public const int Unk_94_sortIndex = 2050;
            [SortOrder(Unk_94_sortIndex)]
            [DisplayName(Unk_94_displayName)]
            public virtual float Unk_94 {
                get => Unk_94_raw;
                set {
                    if (Unk_94_raw == value) return;
                    Unk_94_raw = value;
                    ChangedItems.Add(nameof(Unk_94));
                    OnPropertyChanged(nameof(Unk_94));
                }
            }

            [DisplayName("Offset")]
            public long Unk_94_offset { get; private set; }

            protected float Unk_95_raw;
            public const string Unk_95_displayName = "Unk 95";
            public const int Unk_95_sortIndex = 2100;
            [SortOrder(Unk_95_sortIndex)]
            [DisplayName(Unk_95_displayName)]
            public virtual float Unk_95 {
                get => Unk_95_raw;
                set {
                    if (Unk_95_raw == value) return;
                    Unk_95_raw = value;
                    ChangedItems.Add(nameof(Unk_95));
                    OnPropertyChanged(nameof(Unk_95));
                }
            }

            [DisplayName("Offset")]
            public long Unk_95_offset { get; private set; }

            protected float Unk_96_raw;
            public const string Unk_96_displayName = "Unk 96";
            public const int Unk_96_sortIndex = 2150;
            [SortOrder(Unk_96_sortIndex)]
            [DisplayName(Unk_96_displayName)]
            public virtual float Unk_96 {
                get => Unk_96_raw;
                set {
                    if (Unk_96_raw == value) return;
                    Unk_96_raw = value;
                    ChangedItems.Add(nameof(Unk_96));
                    OnPropertyChanged(nameof(Unk_96));
                }
            }

            [DisplayName("Offset")]
            public long Unk_96_offset { get; private set; }

            protected float Unk_97_raw;
            public const string Unk_97_displayName = "Unk 97";
            public const int Unk_97_sortIndex = 2200;
            [SortOrder(Unk_97_sortIndex)]
            [DisplayName(Unk_97_displayName)]
            public virtual float Unk_97 {
                get => Unk_97_raw;
                set {
                    if (Unk_97_raw == value) return;
                    Unk_97_raw = value;
                    ChangedItems.Add(nameof(Unk_97));
                    OnPropertyChanged(nameof(Unk_97));
                }
            }

            [DisplayName("Offset")]
            public long Unk_97_offset { get; private set; }

            protected float Unk_98_raw;
            public const string Unk_98_displayName = "Unk 98";
            public const int Unk_98_sortIndex = 2250;
            [SortOrder(Unk_98_sortIndex)]
            [DisplayName(Unk_98_displayName)]
            public virtual float Unk_98 {
                get => Unk_98_raw;
                set {
                    if (Unk_98_raw == value) return;
                    Unk_98_raw = value;
                    ChangedItems.Add(nameof(Unk_98));
                    OnPropertyChanged(nameof(Unk_98));
                }
            }

            [DisplayName("Offset")]
            public long Unk_98_offset { get; private set; }

            protected float Unk_99_raw;
            public const string Unk_99_displayName = "Unk 99";
            public const int Unk_99_sortIndex = 2300;
            [SortOrder(Unk_99_sortIndex)]
            [DisplayName(Unk_99_displayName)]
            public virtual float Unk_99 {
                get => Unk_99_raw;
                set {
                    if (Unk_99_raw == value) return;
                    Unk_99_raw = value;
                    ChangedItems.Add(nameof(Unk_99));
                    OnPropertyChanged(nameof(Unk_99));
                }
            }

            [DisplayName("Offset")]
            public long Unk_99_offset { get; private set; }

            protected float Unk_100_raw;
            public const string Unk_100_displayName = "Unk 100";
            public const int Unk_100_sortIndex = 2350;
            [SortOrder(Unk_100_sortIndex)]
            [DisplayName(Unk_100_displayName)]
            public virtual float Unk_100 {
                get => Unk_100_raw;
                set {
                    if (Unk_100_raw == value) return;
                    Unk_100_raw = value;
                    ChangedItems.Add(nameof(Unk_100));
                    OnPropertyChanged(nameof(Unk_100));
                }
            }

            [DisplayName("Offset")]
            public long Unk_100_offset { get; private set; }

            protected float Unk_101_raw;
            public const string Unk_101_displayName = "Unk 101";
            public const int Unk_101_sortIndex = 2400;
            [SortOrder(Unk_101_sortIndex)]
            [DisplayName(Unk_101_displayName)]
            public virtual float Unk_101 {
                get => Unk_101_raw;
                set {
                    if (Unk_101_raw == value) return;
                    Unk_101_raw = value;
                    ChangedItems.Add(nameof(Unk_101));
                    OnPropertyChanged(nameof(Unk_101));
                }
            }

            [DisplayName("Offset")]
            public long Unk_101_offset { get; private set; }

            protected float Unk_102_raw;
            public const string Unk_102_displayName = "Unk 102";
            public const int Unk_102_sortIndex = 2450;
            [SortOrder(Unk_102_sortIndex)]
            [DisplayName(Unk_102_displayName)]
            public virtual float Unk_102 {
                get => Unk_102_raw;
                set {
                    if (Unk_102_raw == value) return;
                    Unk_102_raw = value;
                    ChangedItems.Add(nameof(Unk_102));
                    OnPropertyChanged(nameof(Unk_102));
                }
            }

            [DisplayName("Offset")]
            public long Unk_102_offset { get; private set; }

            protected float Unk_103_raw;
            public const string Unk_103_displayName = "Unk 103";
            public const int Unk_103_sortIndex = 2500;
            [SortOrder(Unk_103_sortIndex)]
            [DisplayName(Unk_103_displayName)]
            public virtual float Unk_103 {
                get => Unk_103_raw;
                set {
                    if (Unk_103_raw == value) return;
                    Unk_103_raw = value;
                    ChangedItems.Add(nameof(Unk_103));
                    OnPropertyChanged(nameof(Unk_103));
                }
            }

            [DisplayName("Offset")]
            public long Unk_103_offset { get; private set; }

            protected uint Unk_104_raw;
            public const string Unk_104_displayName = "Unk 104";
            public const int Unk_104_sortIndex = 2550;
            [SortOrder(Unk_104_sortIndex)]
            [DisplayName(Unk_104_displayName)]
            public virtual uint Unk_104 {
                get => Unk_104_raw;
                set {
                    if (Unk_104_raw == value) return;
                    Unk_104_raw = value;
                    ChangedItems.Add(nameof(Unk_104));
                    OnPropertyChanged(nameof(Unk_104));
                }
            }

            [DisplayName("Offset")]
            public long Unk_104_offset { get; private set; }

            protected uint Unk_105_raw;
            public const string Unk_105_displayName = "Unk 105";
            public const int Unk_105_sortIndex = 2600;
            [SortOrder(Unk_105_sortIndex)]
            [DisplayName(Unk_105_displayName)]
            public virtual uint Unk_105 {
                get => Unk_105_raw;
                set {
                    if (Unk_105_raw == value) return;
                    Unk_105_raw = value;
                    ChangedItems.Add(nameof(Unk_105));
                    OnPropertyChanged(nameof(Unk_105));
                }
            }

            [DisplayName("Offset")]
            public long Unk_105_offset { get; private set; }

            public const int lastSortIndex = 2650;

            public static ObservableMhwStructCollection<Scoutfly_Params_2_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Scoutfly_Params_2_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Scoutfly_Params_2_ LoadData(BinaryReader reader, ulong i) {
                var data = new Scoutfly_Params_2_();
                data.Index = i;
                data.Unk_54_offset = reader.BaseStream.Position;
                data.Unk_54_raw = reader.ReadSingle();
                data.Unk_55_offset = reader.BaseStream.Position;
                data.Unk_55_raw = reader.ReadSingle();
                data.Unk_56_offset = reader.BaseStream.Position;
                data.Unk_56_raw = reader.ReadSingle();
                data.Unk_57_offset = reader.BaseStream.Position;
                data.Unk_57_raw = reader.ReadSingle();
                data.Unk_58_offset = reader.BaseStream.Position;
                data.Unk_58_raw = reader.ReadSingle();
                data.Unk_59_offset = reader.BaseStream.Position;
                data.Unk_59_raw = reader.ReadSingle();
                data.Unk_60_offset = reader.BaseStream.Position;
                data.Unk_60_raw = reader.ReadSingle();
                data.Unk_61_offset = reader.BaseStream.Position;
                data.Unk_61_raw = reader.ReadSingle();
                data.Unk_62_offset = reader.BaseStream.Position;
                data.Unk_62_raw = reader.ReadSingle();
                data.Unk_63_offset = reader.BaseStream.Position;
                data.Unk_63_raw = reader.ReadSingle();
                data.Unk_64_offset = reader.BaseStream.Position;
                data.Unk_64_raw = reader.ReadSingle();
                data.Unk_65_offset = reader.BaseStream.Position;
                data.Unk_65_raw = reader.ReadSingle();
                data.Unk_66_offset = reader.BaseStream.Position;
                data.Unk_66_raw = reader.ReadSingle();
                data.Unk_67_offset = reader.BaseStream.Position;
                data.Unk_67_raw = reader.ReadSingle();
                data.Unk_68_offset = reader.BaseStream.Position;
                data.Unk_68_raw = reader.ReadSingle();
                data.Unk_69_offset = reader.BaseStream.Position;
                data.Unk_69_raw = reader.ReadSingle();
                data.Unk_70_offset = reader.BaseStream.Position;
                data.Unk_70_raw = reader.ReadSingle();
                data.Unk_71_offset = reader.BaseStream.Position;
                data.Unk_71_raw = reader.ReadSingle();
                data.Unk_72_offset = reader.BaseStream.Position;
                data.Unk_72_raw = reader.ReadSingle();
                data.Unk_73_offset = reader.BaseStream.Position;
                data.Unk_73_raw = reader.ReadSingle();
                data.Unk_74_offset = reader.BaseStream.Position;
                data.Unk_74_raw = reader.ReadSingle();
                data.Unk_75_offset = reader.BaseStream.Position;
                data.Unk_75_raw = reader.ReadSingle();
                data.Unk_76_offset = reader.BaseStream.Position;
                data.Unk_76_raw = reader.ReadSingle();
                data.Unk_77_offset = reader.BaseStream.Position;
                data.Unk_77_raw = reader.ReadSingle();
                data.Unk_78_offset = reader.BaseStream.Position;
                data.Unk_78_raw = reader.ReadSingle();
                data.Unk_79_offset = reader.BaseStream.Position;
                data.Unk_79_raw = reader.ReadSingle();
                data.Unk_80_offset = reader.BaseStream.Position;
                data.Unk_80_raw = reader.ReadSingle();
                data.Unk_81_offset = reader.BaseStream.Position;
                data.Unk_81_raw = reader.ReadSingle();
                data.Unk_82_offset = reader.BaseStream.Position;
                data.Unk_82_raw = reader.ReadSingle();
                data.Unk_83_offset = reader.BaseStream.Position;
                data.Unk_83_raw = reader.ReadSingle();
                data.Unk_84_offset = reader.BaseStream.Position;
                data.Unk_84_raw = reader.ReadSingle();
                data.Unk_85_offset = reader.BaseStream.Position;
                data.Unk_85_raw = reader.ReadSingle();
                data.Unk_86_offset = reader.BaseStream.Position;
                data.Unk_86_raw = reader.ReadSingle();
                data.Unk_87_offset = reader.BaseStream.Position;
                data.Unk_87_raw = reader.ReadSingle();
                data.Unk_88_offset = reader.BaseStream.Position;
                data.Unk_88_raw = reader.ReadSingle();
                data.Unk_89_offset = reader.BaseStream.Position;
                data.Unk_89_raw = reader.ReadSingle();
                data.Unk_90_offset = reader.BaseStream.Position;
                data.Unk_90_raw = reader.ReadSingle();
                data.Unk_91_offset = reader.BaseStream.Position;
                data.Unk_91_raw = reader.ReadSingle();
                data.Unk_92_offset = reader.BaseStream.Position;
                data.Unk_92_raw = reader.ReadSingle();
                data.Unk_93_offset = reader.BaseStream.Position;
                data.Unk_93_raw = reader.ReadSingle();
                data.Unk_94_offset = reader.BaseStream.Position;
                data.Unk_94_raw = reader.ReadSingle();
                data.Unk_95_offset = reader.BaseStream.Position;
                data.Unk_95_raw = reader.ReadSingle();
                data.Unk_96_offset = reader.BaseStream.Position;
                data.Unk_96_raw = reader.ReadSingle();
                data.Unk_97_offset = reader.BaseStream.Position;
                data.Unk_97_raw = reader.ReadSingle();
                data.Unk_98_offset = reader.BaseStream.Position;
                data.Unk_98_raw = reader.ReadSingle();
                data.Unk_99_offset = reader.BaseStream.Position;
                data.Unk_99_raw = reader.ReadSingle();
                data.Unk_100_offset = reader.BaseStream.Position;
                data.Unk_100_raw = reader.ReadSingle();
                data.Unk_101_offset = reader.BaseStream.Position;
                data.Unk_101_raw = reader.ReadSingle();
                data.Unk_102_offset = reader.BaseStream.Position;
                data.Unk_102_raw = reader.ReadSingle();
                data.Unk_103_offset = reader.BaseStream.Position;
                data.Unk_103_raw = reader.ReadSingle();
                data.Unk_104_offset = reader.BaseStream.Position;
                data.Unk_104_raw = reader.ReadUInt32();
                data.Unk_105_offset = reader.BaseStream.Position;
                data.Unk_105_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_54_raw);
                writer.Write(Unk_55_raw);
                writer.Write(Unk_56_raw);
                writer.Write(Unk_57_raw);
                writer.Write(Unk_58_raw);
                writer.Write(Unk_59_raw);
                writer.Write(Unk_60_raw);
                writer.Write(Unk_61_raw);
                writer.Write(Unk_62_raw);
                writer.Write(Unk_63_raw);
                writer.Write(Unk_64_raw);
                writer.Write(Unk_65_raw);
                writer.Write(Unk_66_raw);
                writer.Write(Unk_67_raw);
                writer.Write(Unk_68_raw);
                writer.Write(Unk_69_raw);
                writer.Write(Unk_70_raw);
                writer.Write(Unk_71_raw);
                writer.Write(Unk_72_raw);
                writer.Write(Unk_73_raw);
                writer.Write(Unk_74_raw);
                writer.Write(Unk_75_raw);
                writer.Write(Unk_76_raw);
                writer.Write(Unk_77_raw);
                writer.Write(Unk_78_raw);
                writer.Write(Unk_79_raw);
                writer.Write(Unk_80_raw);
                writer.Write(Unk_81_raw);
                writer.Write(Unk_82_raw);
                writer.Write(Unk_83_raw);
                writer.Write(Unk_84_raw);
                writer.Write(Unk_85_raw);
                writer.Write(Unk_86_raw);
                writer.Write(Unk_87_raw);
                writer.Write(Unk_88_raw);
                writer.Write(Unk_89_raw);
                writer.Write(Unk_90_raw);
                writer.Write(Unk_91_raw);
                writer.Write(Unk_92_raw);
                writer.Write(Unk_93_raw);
                writer.Write(Unk_94_raw);
                writer.Write(Unk_95_raw);
                writer.Write(Unk_96_raw);
                writer.Write(Unk_97_raw);
                writer.Write(Unk_98_raw);
                writer.Write(Unk_99_raw);
                writer.Write(Unk_100_raw);
                writer.Write(Unk_101_raw);
                writer.Write(Unk_102_raw);
                writer.Write(Unk_103_raw);
                writer.Write(Unk_104_raw);
                writer.Write(Unk_105_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 54", "Unk_54", "Unk_54_offset"),
                    new MultiStructItemCustomView(this, "Unk 55", "Unk_55", "Unk_55_offset"),
                    new MultiStructItemCustomView(this, "Unk 56", "Unk_56", "Unk_56_offset"),
                    new MultiStructItemCustomView(this, "Unk 57", "Unk_57", "Unk_57_offset"),
                    new MultiStructItemCustomView(this, "Unk 58", "Unk_58", "Unk_58_offset"),
                    new MultiStructItemCustomView(this, "Unk 59", "Unk_59", "Unk_59_offset"),
                    new MultiStructItemCustomView(this, "Unk 60", "Unk_60", "Unk_60_offset"),
                    new MultiStructItemCustomView(this, "Unk 61", "Unk_61", "Unk_61_offset"),
                    new MultiStructItemCustomView(this, "Unk 62", "Unk_62", "Unk_62_offset"),
                    new MultiStructItemCustomView(this, "Unk 63", "Unk_63", "Unk_63_offset"),
                    new MultiStructItemCustomView(this, "Unk 64", "Unk_64", "Unk_64_offset"),
                    new MultiStructItemCustomView(this, "Unk 65", "Unk_65", "Unk_65_offset"),
                    new MultiStructItemCustomView(this, "Unk 66", "Unk_66", "Unk_66_offset"),
                    new MultiStructItemCustomView(this, "Unk 67", "Unk_67", "Unk_67_offset"),
                    new MultiStructItemCustomView(this, "Unk 68", "Unk_68", "Unk_68_offset"),
                    new MultiStructItemCustomView(this, "Unk 69", "Unk_69", "Unk_69_offset"),
                    new MultiStructItemCustomView(this, "Unk 70", "Unk_70", "Unk_70_offset"),
                    new MultiStructItemCustomView(this, "Unk 71", "Unk_71", "Unk_71_offset"),
                    new MultiStructItemCustomView(this, "Unk 72", "Unk_72", "Unk_72_offset"),
                    new MultiStructItemCustomView(this, "Unk 73", "Unk_73", "Unk_73_offset"),
                    new MultiStructItemCustomView(this, "Unk 74", "Unk_74", "Unk_74_offset"),
                    new MultiStructItemCustomView(this, "Unk 75", "Unk_75", "Unk_75_offset"),
                    new MultiStructItemCustomView(this, "Unk 76", "Unk_76", "Unk_76_offset"),
                    new MultiStructItemCustomView(this, "Unk 77", "Unk_77", "Unk_77_offset"),
                    new MultiStructItemCustomView(this, "Unk 78", "Unk_78", "Unk_78_offset"),
                    new MultiStructItemCustomView(this, "Unk 79", "Unk_79", "Unk_79_offset"),
                    new MultiStructItemCustomView(this, "Unk 80", "Unk_80", "Unk_80_offset"),
                    new MultiStructItemCustomView(this, "Unk 81", "Unk_81", "Unk_81_offset"),
                    new MultiStructItemCustomView(this, "Unk 82", "Unk_82", "Unk_82_offset"),
                    new MultiStructItemCustomView(this, "Unk 83", "Unk_83", "Unk_83_offset"),
                    new MultiStructItemCustomView(this, "Unk 84", "Unk_84", "Unk_84_offset"),
                    new MultiStructItemCustomView(this, "Unk 85", "Unk_85", "Unk_85_offset"),
                    new MultiStructItemCustomView(this, "Unk 86", "Unk_86", "Unk_86_offset"),
                    new MultiStructItemCustomView(this, "Unk 87", "Unk_87", "Unk_87_offset"),
                    new MultiStructItemCustomView(this, "Unk 88", "Unk_88", "Unk_88_offset"),
                    new MultiStructItemCustomView(this, "Unk 89", "Unk_89", "Unk_89_offset"),
                    new MultiStructItemCustomView(this, "Unk 90", "Unk_90", "Unk_90_offset"),
                    new MultiStructItemCustomView(this, "Unk 91", "Unk_91", "Unk_91_offset"),
                    new MultiStructItemCustomView(this, "Unk 92", "Unk_92", "Unk_92_offset"),
                    new MultiStructItemCustomView(this, "Unk 93", "Unk_93", "Unk_93_offset"),
                    new MultiStructItemCustomView(this, "Unk 94", "Unk_94", "Unk_94_offset"),
                    new MultiStructItemCustomView(this, "Unk 95", "Unk_95", "Unk_95_offset"),
                    new MultiStructItemCustomView(this, "Unk 96", "Unk_96", "Unk_96_offset"),
                    new MultiStructItemCustomView(this, "Unk 97", "Unk_97", "Unk_97_offset"),
                    new MultiStructItemCustomView(this, "Unk 98", "Unk_98", "Unk_98_offset"),
                    new MultiStructItemCustomView(this, "Unk 99", "Unk_99", "Unk_99_offset"),
                    new MultiStructItemCustomView(this, "Unk 100", "Unk_100", "Unk_100_offset"),
                    new MultiStructItemCustomView(this, "Unk 101", "Unk_101", "Unk_101_offset"),
                    new MultiStructItemCustomView(this, "Unk 102", "Unk_102", "Unk_102_offset"),
                    new MultiStructItemCustomView(this, "Unk 103", "Unk_103", "Unk_103_offset"),
                    new MultiStructItemCustomView(this, "Unk 104", "Unk_104", "Unk_104_offset"),
                    new MultiStructItemCustomView(this, "Unk 105", "Unk_105", "Unk_105_offset"),
                };
            }
        }

        public partial class Unknown_Arr_2_ : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 10;
            public const string GridName = "Unknown Arr (2)";

            protected uint Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 50;
            [SortOrder(Unk_1_sortIndex)]
            [DisplayName(Unk_1_displayName)]
            public virtual uint Unk_1 {
                get => Unk_1_raw;
                set {
                    if (Unk_1_raw == value) return;
                    Unk_1_raw = value;
                    ChangedItems.Add(nameof(Unk_1));
                    OnPropertyChanged(nameof(Unk_1));
                }
            }

            protected float Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 100;
            [SortOrder(Unk_2_sortIndex)]
            [DisplayName(Unk_2_displayName)]
            public virtual float Unk_2 {
                get => Unk_2_raw;
                set {
                    if (Unk_2_raw == value) return;
                    Unk_2_raw = value;
                    ChangedItems.Add(nameof(Unk_2));
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            protected float Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 150;
            [SortOrder(Unk_3_sortIndex)]
            [DisplayName(Unk_3_displayName)]
            public virtual float Unk_3 {
                get => Unk_3_raw;
                set {
                    if (Unk_3_raw == value) return;
                    Unk_3_raw = value;
                    ChangedItems.Add(nameof(Unk_3));
                    OnPropertyChanged(nameof(Unk_3));
                }
            }

            protected float Unk_4_raw;
            public const string Unk_4_displayName = "Unk 4";
            public const int Unk_4_sortIndex = 200;
            [SortOrder(Unk_4_sortIndex)]
            [DisplayName(Unk_4_displayName)]
            public virtual float Unk_4 {
                get => Unk_4_raw;
                set {
                    if (Unk_4_raw == value) return;
                    Unk_4_raw = value;
                    ChangedItems.Add(nameof(Unk_4));
                    OnPropertyChanged(nameof(Unk_4));
                }
            }

            protected float Unk_5_raw;
            public const string Unk_5_displayName = "Unk 5";
            public const int Unk_5_sortIndex = 250;
            [SortOrder(Unk_5_sortIndex)]
            [DisplayName(Unk_5_displayName)]
            public virtual float Unk_5 {
                get => Unk_5_raw;
                set {
                    if (Unk_5_raw == value) return;
                    Unk_5_raw = value;
                    ChangedItems.Add(nameof(Unk_5));
                    OnPropertyChanged(nameof(Unk_5));
                }
            }

            protected float Unk_6_raw;
            public const string Unk_6_displayName = "Unk 6";
            public const int Unk_6_sortIndex = 300;
            [SortOrder(Unk_6_sortIndex)]
            [DisplayName(Unk_6_displayName)]
            public virtual float Unk_6 {
                get => Unk_6_raw;
                set {
                    if (Unk_6_raw == value) return;
                    Unk_6_raw = value;
                    ChangedItems.Add(nameof(Unk_6));
                    OnPropertyChanged(nameof(Unk_6));
                }
            }

            protected float Unk_7_raw;
            public const string Unk_7_displayName = "Unk 7";
            public const int Unk_7_sortIndex = 350;
            [SortOrder(Unk_7_sortIndex)]
            [DisplayName(Unk_7_displayName)]
            public virtual float Unk_7 {
                get => Unk_7_raw;
                set {
                    if (Unk_7_raw == value) return;
                    Unk_7_raw = value;
                    ChangedItems.Add(nameof(Unk_7));
                    OnPropertyChanged(nameof(Unk_7));
                }
            }

            protected float Unk_8_raw;
            public const string Unk_8_displayName = "Unk 8";
            public const int Unk_8_sortIndex = 400;
            [SortOrder(Unk_8_sortIndex)]
            [DisplayName(Unk_8_displayName)]
            public virtual float Unk_8 {
                get => Unk_8_raw;
                set {
                    if (Unk_8_raw == value) return;
                    Unk_8_raw = value;
                    ChangedItems.Add(nameof(Unk_8));
                    OnPropertyChanged(nameof(Unk_8));
                }
            }

            protected float Unk_9_raw;
            public const string Unk_9_displayName = "Unk 9";
            public const int Unk_9_sortIndex = 450;
            [SortOrder(Unk_9_sortIndex)]
            [DisplayName(Unk_9_displayName)]
            public virtual float Unk_9 {
                get => Unk_9_raw;
                set {
                    if (Unk_9_raw == value) return;
                    Unk_9_raw = value;
                    ChangedItems.Add(nameof(Unk_9));
                    OnPropertyChanged(nameof(Unk_9));
                }
            }

            protected float Unk_10_raw;
            public const string Unk_10_displayName = "Unk 10";
            public const int Unk_10_sortIndex = 500;
            [SortOrder(Unk_10_sortIndex)]
            [DisplayName(Unk_10_displayName)]
            public virtual float Unk_10 {
                get => Unk_10_raw;
                set {
                    if (Unk_10_raw == value) return;
                    Unk_10_raw = value;
                    ChangedItems.Add(nameof(Unk_10));
                    OnPropertyChanged(nameof(Unk_10));
                }
            }

            protected float Unk_11_raw;
            public const string Unk_11_displayName = "Unk 11";
            public const int Unk_11_sortIndex = 550;
            [SortOrder(Unk_11_sortIndex)]
            [DisplayName(Unk_11_displayName)]
            public virtual float Unk_11 {
                get => Unk_11_raw;
                set {
                    if (Unk_11_raw == value) return;
                    Unk_11_raw = value;
                    ChangedItems.Add(nameof(Unk_11));
                    OnPropertyChanged(nameof(Unk_11));
                }
            }

            protected float Unk_12_raw;
            public const string Unk_12_displayName = "Unk 12";
            public const int Unk_12_sortIndex = 600;
            [SortOrder(Unk_12_sortIndex)]
            [DisplayName(Unk_12_displayName)]
            public virtual float Unk_12 {
                get => Unk_12_raw;
                set {
                    if (Unk_12_raw == value) return;
                    Unk_12_raw = value;
                    ChangedItems.Add(nameof(Unk_12));
                    OnPropertyChanged(nameof(Unk_12));
                }
            }

            protected float Unk_13_raw;
            public const string Unk_13_displayName = "Unk 13";
            public const int Unk_13_sortIndex = 650;
            [SortOrder(Unk_13_sortIndex)]
            [DisplayName(Unk_13_displayName)]
            public virtual float Unk_13 {
                get => Unk_13_raw;
                set {
                    if (Unk_13_raw == value) return;
                    Unk_13_raw = value;
                    ChangedItems.Add(nameof(Unk_13));
                    OnPropertyChanged(nameof(Unk_13));
                }
            }

            protected float Unk_14_raw;
            public const string Unk_14_displayName = "Unk 14";
            public const int Unk_14_sortIndex = 700;
            [SortOrder(Unk_14_sortIndex)]
            [DisplayName(Unk_14_displayName)]
            public virtual float Unk_14 {
                get => Unk_14_raw;
                set {
                    if (Unk_14_raw == value) return;
                    Unk_14_raw = value;
                    ChangedItems.Add(nameof(Unk_14));
                    OnPropertyChanged(nameof(Unk_14));
                }
            }

            protected float Unk_15_raw;
            public const string Unk_15_displayName = "Unk 15";
            public const int Unk_15_sortIndex = 750;
            [SortOrder(Unk_15_sortIndex)]
            [DisplayName(Unk_15_displayName)]
            public virtual float Unk_15 {
                get => Unk_15_raw;
                set {
                    if (Unk_15_raw == value) return;
                    Unk_15_raw = value;
                    ChangedItems.Add(nameof(Unk_15));
                    OnPropertyChanged(nameof(Unk_15));
                }
            }

            protected float Unk_16_raw;
            public const string Unk_16_displayName = "Unk 16";
            public const int Unk_16_sortIndex = 800;
            [SortOrder(Unk_16_sortIndex)]
            [DisplayName(Unk_16_displayName)]
            public virtual float Unk_16 {
                get => Unk_16_raw;
                set {
                    if (Unk_16_raw == value) return;
                    Unk_16_raw = value;
                    ChangedItems.Add(nameof(Unk_16));
                    OnPropertyChanged(nameof(Unk_16));
                }
            }

            protected float Unk_17_raw;
            public const string Unk_17_displayName = "Unk 17";
            public const int Unk_17_sortIndex = 850;
            [SortOrder(Unk_17_sortIndex)]
            [DisplayName(Unk_17_displayName)]
            public virtual float Unk_17 {
                get => Unk_17_raw;
                set {
                    if (Unk_17_raw == value) return;
                    Unk_17_raw = value;
                    ChangedItems.Add(nameof(Unk_17));
                    OnPropertyChanged(nameof(Unk_17));
                }
            }

            protected float Unk_18_raw;
            public const string Unk_18_displayName = "Unk 18";
            public const int Unk_18_sortIndex = 900;
            [SortOrder(Unk_18_sortIndex)]
            [DisplayName(Unk_18_displayName)]
            public virtual float Unk_18 {
                get => Unk_18_raw;
                set {
                    if (Unk_18_raw == value) return;
                    Unk_18_raw = value;
                    ChangedItems.Add(nameof(Unk_18));
                    OnPropertyChanged(nameof(Unk_18));
                }
            }

            protected float Unk_19_raw;
            public const string Unk_19_displayName = "Unk 19";
            public const int Unk_19_sortIndex = 950;
            [SortOrder(Unk_19_sortIndex)]
            [DisplayName(Unk_19_displayName)]
            public virtual float Unk_19 {
                get => Unk_19_raw;
                set {
                    if (Unk_19_raw == value) return;
                    Unk_19_raw = value;
                    ChangedItems.Add(nameof(Unk_19));
                    OnPropertyChanged(nameof(Unk_19));
                }
            }

            protected float Unk_20_raw;
            public const string Unk_20_displayName = "Unk 20";
            public const int Unk_20_sortIndex = 1000;
            [SortOrder(Unk_20_sortIndex)]
            [DisplayName(Unk_20_displayName)]
            public virtual float Unk_20 {
                get => Unk_20_raw;
                set {
                    if (Unk_20_raw == value) return;
                    Unk_20_raw = value;
                    ChangedItems.Add(nameof(Unk_20));
                    OnPropertyChanged(nameof(Unk_20));
                }
            }

            public const int lastSortIndex = 1050;

            public static ObservableMhwStructCollection<Unknown_Arr_2_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Unknown_Arr_2_>();
                const ulong count = 10UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Unknown_Arr_2_ LoadData(BinaryReader reader, ulong i) {
                var data = new Unknown_Arr_2_();
                data.Index = i;
                data.Unk_1_raw = reader.ReadUInt32();
                data.Unk_2_raw = reader.ReadSingle();
                data.Unk_3_raw = reader.ReadSingle();
                data.Unk_4_raw = reader.ReadSingle();
                data.Unk_5_raw = reader.ReadSingle();
                data.Unk_6_raw = reader.ReadSingle();
                data.Unk_7_raw = reader.ReadSingle();
                data.Unk_8_raw = reader.ReadSingle();
                data.Unk_9_raw = reader.ReadSingle();
                data.Unk_10_raw = reader.ReadSingle();
                data.Unk_11_raw = reader.ReadSingle();
                data.Unk_12_raw = reader.ReadSingle();
                data.Unk_13_raw = reader.ReadSingle();
                data.Unk_14_raw = reader.ReadSingle();
                data.Unk_15_raw = reader.ReadSingle();
                data.Unk_16_raw = reader.ReadSingle();
                data.Unk_17_raw = reader.ReadSingle();
                data.Unk_18_raw = reader.ReadSingle();
                data.Unk_19_raw = reader.ReadSingle();
                data.Unk_20_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_1_raw);
                writer.Write(Unk_2_raw);
                writer.Write(Unk_3_raw);
                writer.Write(Unk_4_raw);
                writer.Write(Unk_5_raw);
                writer.Write(Unk_6_raw);
                writer.Write(Unk_7_raw);
                writer.Write(Unk_8_raw);
                writer.Write(Unk_9_raw);
                writer.Write(Unk_10_raw);
                writer.Write(Unk_11_raw);
                writer.Write(Unk_12_raw);
                writer.Write(Unk_13_raw);
                writer.Write(Unk_14_raw);
                writer.Write(Unk_15_raw);
                writer.Write(Unk_16_raw);
                writer.Write(Unk_17_raw);
                writer.Write(Unk_18_raw);
                writer.Write(Unk_19_raw);
                writer.Write(Unk_20_raw);
            }
        }

        public partial class Scoutfly_Params_3_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Scoutfly Params (3)";

            protected uint Unk_106_raw;
            public const string Unk_106_displayName = "Unk 106";
            public const int Unk_106_sortIndex = 50;
            [SortOrder(Unk_106_sortIndex)]
            [DisplayName(Unk_106_displayName)]
            public virtual uint Unk_106 {
                get => Unk_106_raw;
                set {
                    if (Unk_106_raw == value) return;
                    Unk_106_raw = value;
                    ChangedItems.Add(nameof(Unk_106));
                    OnPropertyChanged(nameof(Unk_106));
                }
            }

            [DisplayName("Offset")]
            public long Unk_106_offset { get; private set; }

            protected uint Unk_107_raw;
            public const string Unk_107_displayName = "Unk 107";
            public const int Unk_107_sortIndex = 100;
            [SortOrder(Unk_107_sortIndex)]
            [DisplayName(Unk_107_displayName)]
            public virtual uint Unk_107 {
                get => Unk_107_raw;
                set {
                    if (Unk_107_raw == value) return;
                    Unk_107_raw = value;
                    ChangedItems.Add(nameof(Unk_107));
                    OnPropertyChanged(nameof(Unk_107));
                }
            }

            [DisplayName("Offset")]
            public long Unk_107_offset { get; private set; }

            protected uint Unk_108_raw;
            public const string Unk_108_displayName = "Unk 108";
            public const int Unk_108_sortIndex = 150;
            [SortOrder(Unk_108_sortIndex)]
            [DisplayName(Unk_108_displayName)]
            public virtual uint Unk_108 {
                get => Unk_108_raw;
                set {
                    if (Unk_108_raw == value) return;
                    Unk_108_raw = value;
                    ChangedItems.Add(nameof(Unk_108));
                    OnPropertyChanged(nameof(Unk_108));
                }
            }

            [DisplayName("Offset")]
            public long Unk_108_offset { get; private set; }

            protected uint Unk_109_raw;
            public const string Unk_109_displayName = "Unk 109";
            public const int Unk_109_sortIndex = 200;
            [SortOrder(Unk_109_sortIndex)]
            [DisplayName(Unk_109_displayName)]
            public virtual uint Unk_109 {
                get => Unk_109_raw;
                set {
                    if (Unk_109_raw == value) return;
                    Unk_109_raw = value;
                    ChangedItems.Add(nameof(Unk_109));
                    OnPropertyChanged(nameof(Unk_109));
                }
            }

            [DisplayName("Offset")]
            public long Unk_109_offset { get; private set; }

            protected uint Unk_110_raw;
            public const string Unk_110_displayName = "Unk 110";
            public const int Unk_110_sortIndex = 250;
            [SortOrder(Unk_110_sortIndex)]
            [DisplayName(Unk_110_displayName)]
            public virtual uint Unk_110 {
                get => Unk_110_raw;
                set {
                    if (Unk_110_raw == value) return;
                    Unk_110_raw = value;
                    ChangedItems.Add(nameof(Unk_110));
                    OnPropertyChanged(nameof(Unk_110));
                }
            }

            [DisplayName("Offset")]
            public long Unk_110_offset { get; private set; }

            protected uint Unk_111_raw;
            public const string Unk_111_displayName = "Unk 111";
            public const int Unk_111_sortIndex = 300;
            [SortOrder(Unk_111_sortIndex)]
            [DisplayName(Unk_111_displayName)]
            public virtual uint Unk_111 {
                get => Unk_111_raw;
                set {
                    if (Unk_111_raw == value) return;
                    Unk_111_raw = value;
                    ChangedItems.Add(nameof(Unk_111));
                    OnPropertyChanged(nameof(Unk_111));
                }
            }

            [DisplayName("Offset")]
            public long Unk_111_offset { get; private set; }

            protected uint Unk_112_raw;
            public const string Unk_112_displayName = "Unk 112";
            public const int Unk_112_sortIndex = 350;
            [SortOrder(Unk_112_sortIndex)]
            [DisplayName(Unk_112_displayName)]
            public virtual uint Unk_112 {
                get => Unk_112_raw;
                set {
                    if (Unk_112_raw == value) return;
                    Unk_112_raw = value;
                    ChangedItems.Add(nameof(Unk_112));
                    OnPropertyChanged(nameof(Unk_112));
                }
            }

            [DisplayName("Offset")]
            public long Unk_112_offset { get; private set; }

            protected uint Unk_113_raw;
            public const string Unk_113_displayName = "Unk 113";
            public const int Unk_113_sortIndex = 400;
            [SortOrder(Unk_113_sortIndex)]
            [DisplayName(Unk_113_displayName)]
            public virtual uint Unk_113 {
                get => Unk_113_raw;
                set {
                    if (Unk_113_raw == value) return;
                    Unk_113_raw = value;
                    ChangedItems.Add(nameof(Unk_113));
                    OnPropertyChanged(nameof(Unk_113));
                }
            }

            [DisplayName("Offset")]
            public long Unk_113_offset { get; private set; }

            protected uint Unk_114_raw;
            public const string Unk_114_displayName = "Unk 114";
            public const int Unk_114_sortIndex = 450;
            [SortOrder(Unk_114_sortIndex)]
            [DisplayName(Unk_114_displayName)]
            public virtual uint Unk_114 {
                get => Unk_114_raw;
                set {
                    if (Unk_114_raw == value) return;
                    Unk_114_raw = value;
                    ChangedItems.Add(nameof(Unk_114));
                    OnPropertyChanged(nameof(Unk_114));
                }
            }

            [DisplayName("Offset")]
            public long Unk_114_offset { get; private set; }

            protected uint Unk_115_raw;
            public const string Unk_115_displayName = "Unk 115";
            public const int Unk_115_sortIndex = 500;
            [SortOrder(Unk_115_sortIndex)]
            [DisplayName(Unk_115_displayName)]
            public virtual uint Unk_115 {
                get => Unk_115_raw;
                set {
                    if (Unk_115_raw == value) return;
                    Unk_115_raw = value;
                    ChangedItems.Add(nameof(Unk_115));
                    OnPropertyChanged(nameof(Unk_115));
                }
            }

            [DisplayName("Offset")]
            public long Unk_115_offset { get; private set; }

            protected uint Unk_116_raw;
            public const string Unk_116_displayName = "Unk 116";
            public const int Unk_116_sortIndex = 550;
            [SortOrder(Unk_116_sortIndex)]
            [DisplayName(Unk_116_displayName)]
            public virtual uint Unk_116 {
                get => Unk_116_raw;
                set {
                    if (Unk_116_raw == value) return;
                    Unk_116_raw = value;
                    ChangedItems.Add(nameof(Unk_116));
                    OnPropertyChanged(nameof(Unk_116));
                }
            }

            [DisplayName("Offset")]
            public long Unk_116_offset { get; private set; }

            protected float Unk_117_raw;
            public const string Unk_117_displayName = "Unk 117";
            public const int Unk_117_sortIndex = 600;
            [SortOrder(Unk_117_sortIndex)]
            [DisplayName(Unk_117_displayName)]
            public virtual float Unk_117 {
                get => Unk_117_raw;
                set {
                    if (Unk_117_raw == value) return;
                    Unk_117_raw = value;
                    ChangedItems.Add(nameof(Unk_117));
                    OnPropertyChanged(nameof(Unk_117));
                }
            }

            [DisplayName("Offset")]
            public long Unk_117_offset { get; private set; }

            protected float Unk_118_raw;
            public const string Unk_118_displayName = "Unk 118";
            public const int Unk_118_sortIndex = 650;
            [SortOrder(Unk_118_sortIndex)]
            [DisplayName(Unk_118_displayName)]
            public virtual float Unk_118 {
                get => Unk_118_raw;
                set {
                    if (Unk_118_raw == value) return;
                    Unk_118_raw = value;
                    ChangedItems.Add(nameof(Unk_118));
                    OnPropertyChanged(nameof(Unk_118));
                }
            }

            [DisplayName("Offset")]
            public long Unk_118_offset { get; private set; }

            protected float Unk_119_raw;
            public const string Unk_119_displayName = "Unk 119";
            public const int Unk_119_sortIndex = 700;
            [SortOrder(Unk_119_sortIndex)]
            [DisplayName(Unk_119_displayName)]
            public virtual float Unk_119 {
                get => Unk_119_raw;
                set {
                    if (Unk_119_raw == value) return;
                    Unk_119_raw = value;
                    ChangedItems.Add(nameof(Unk_119));
                    OnPropertyChanged(nameof(Unk_119));
                }
            }

            [DisplayName("Offset")]
            public long Unk_119_offset { get; private set; }

            protected float Unk_120_raw;
            public const string Unk_120_displayName = "Unk 120";
            public const int Unk_120_sortIndex = 750;
            [SortOrder(Unk_120_sortIndex)]
            [DisplayName(Unk_120_displayName)]
            public virtual float Unk_120 {
                get => Unk_120_raw;
                set {
                    if (Unk_120_raw == value) return;
                    Unk_120_raw = value;
                    ChangedItems.Add(nameof(Unk_120));
                    OnPropertyChanged(nameof(Unk_120));
                }
            }

            [DisplayName("Offset")]
            public long Unk_120_offset { get; private set; }

            protected float Unk_121_raw;
            public const string Unk_121_displayName = "Unk 121";
            public const int Unk_121_sortIndex = 800;
            [SortOrder(Unk_121_sortIndex)]
            [DisplayName(Unk_121_displayName)]
            public virtual float Unk_121 {
                get => Unk_121_raw;
                set {
                    if (Unk_121_raw == value) return;
                    Unk_121_raw = value;
                    ChangedItems.Add(nameof(Unk_121));
                    OnPropertyChanged(nameof(Unk_121));
                }
            }

            [DisplayName("Offset")]
            public long Unk_121_offset { get; private set; }

            protected float Unk_122_raw;
            public const string Unk_122_displayName = "Unk 122";
            public const int Unk_122_sortIndex = 850;
            [SortOrder(Unk_122_sortIndex)]
            [DisplayName(Unk_122_displayName)]
            public virtual float Unk_122 {
                get => Unk_122_raw;
                set {
                    if (Unk_122_raw == value) return;
                    Unk_122_raw = value;
                    ChangedItems.Add(nameof(Unk_122));
                    OnPropertyChanged(nameof(Unk_122));
                }
            }

            [DisplayName("Offset")]
            public long Unk_122_offset { get; private set; }

            protected float Unk_123_raw;
            public const string Unk_123_displayName = "Unk 123";
            public const int Unk_123_sortIndex = 900;
            [SortOrder(Unk_123_sortIndex)]
            [DisplayName(Unk_123_displayName)]
            public virtual float Unk_123 {
                get => Unk_123_raw;
                set {
                    if (Unk_123_raw == value) return;
                    Unk_123_raw = value;
                    ChangedItems.Add(nameof(Unk_123));
                    OnPropertyChanged(nameof(Unk_123));
                }
            }

            [DisplayName("Offset")]
            public long Unk_123_offset { get; private set; }

            protected float Unk_124_raw;
            public const string Unk_124_displayName = "Unk 124";
            public const int Unk_124_sortIndex = 950;
            [SortOrder(Unk_124_sortIndex)]
            [DisplayName(Unk_124_displayName)]
            public virtual float Unk_124 {
                get => Unk_124_raw;
                set {
                    if (Unk_124_raw == value) return;
                    Unk_124_raw = value;
                    ChangedItems.Add(nameof(Unk_124));
                    OnPropertyChanged(nameof(Unk_124));
                }
            }

            [DisplayName("Offset")]
            public long Unk_124_offset { get; private set; }

            protected float Unk_125_raw;
            public const string Unk_125_displayName = "Unk 125";
            public const int Unk_125_sortIndex = 1000;
            [SortOrder(Unk_125_sortIndex)]
            [DisplayName(Unk_125_displayName)]
            public virtual float Unk_125 {
                get => Unk_125_raw;
                set {
                    if (Unk_125_raw == value) return;
                    Unk_125_raw = value;
                    ChangedItems.Add(nameof(Unk_125));
                    OnPropertyChanged(nameof(Unk_125));
                }
            }

            [DisplayName("Offset")]
            public long Unk_125_offset { get; private set; }

            protected float Unk_126_raw;
            public const string Unk_126_displayName = "Unk 126";
            public const int Unk_126_sortIndex = 1050;
            [SortOrder(Unk_126_sortIndex)]
            [DisplayName(Unk_126_displayName)]
            public virtual float Unk_126 {
                get => Unk_126_raw;
                set {
                    if (Unk_126_raw == value) return;
                    Unk_126_raw = value;
                    ChangedItems.Add(nameof(Unk_126));
                    OnPropertyChanged(nameof(Unk_126));
                }
            }

            [DisplayName("Offset")]
            public long Unk_126_offset { get; private set; }

            protected float Unk_127_raw;
            public const string Unk_127_displayName = "Unk 127";
            public const int Unk_127_sortIndex = 1100;
            [SortOrder(Unk_127_sortIndex)]
            [DisplayName(Unk_127_displayName)]
            public virtual float Unk_127 {
                get => Unk_127_raw;
                set {
                    if (Unk_127_raw == value) return;
                    Unk_127_raw = value;
                    ChangedItems.Add(nameof(Unk_127));
                    OnPropertyChanged(nameof(Unk_127));
                }
            }

            [DisplayName("Offset")]
            public long Unk_127_offset { get; private set; }

            protected float Unk_128_raw;
            public const string Unk_128_displayName = "Unk 128";
            public const int Unk_128_sortIndex = 1150;
            [SortOrder(Unk_128_sortIndex)]
            [DisplayName(Unk_128_displayName)]
            public virtual float Unk_128 {
                get => Unk_128_raw;
                set {
                    if (Unk_128_raw == value) return;
                    Unk_128_raw = value;
                    ChangedItems.Add(nameof(Unk_128));
                    OnPropertyChanged(nameof(Unk_128));
                }
            }

            [DisplayName("Offset")]
            public long Unk_128_offset { get; private set; }

            protected float Unk_129_raw;
            public const string Unk_129_displayName = "Unk 129";
            public const int Unk_129_sortIndex = 1200;
            [SortOrder(Unk_129_sortIndex)]
            [DisplayName(Unk_129_displayName)]
            public virtual float Unk_129 {
                get => Unk_129_raw;
                set {
                    if (Unk_129_raw == value) return;
                    Unk_129_raw = value;
                    ChangedItems.Add(nameof(Unk_129));
                    OnPropertyChanged(nameof(Unk_129));
                }
            }

            [DisplayName("Offset")]
            public long Unk_129_offset { get; private set; }

            protected float Unk_130_raw;
            public const string Unk_130_displayName = "Unk 130";
            public const int Unk_130_sortIndex = 1250;
            [SortOrder(Unk_130_sortIndex)]
            [DisplayName(Unk_130_displayName)]
            public virtual float Unk_130 {
                get => Unk_130_raw;
                set {
                    if (Unk_130_raw == value) return;
                    Unk_130_raw = value;
                    ChangedItems.Add(nameof(Unk_130));
                    OnPropertyChanged(nameof(Unk_130));
                }
            }

            [DisplayName("Offset")]
            public long Unk_130_offset { get; private set; }

            protected float Unk_131_raw;
            public const string Unk_131_displayName = "Unk 131";
            public const int Unk_131_sortIndex = 1300;
            [SortOrder(Unk_131_sortIndex)]
            [DisplayName(Unk_131_displayName)]
            public virtual float Unk_131 {
                get => Unk_131_raw;
                set {
                    if (Unk_131_raw == value) return;
                    Unk_131_raw = value;
                    ChangedItems.Add(nameof(Unk_131));
                    OnPropertyChanged(nameof(Unk_131));
                }
            }

            [DisplayName("Offset")]
            public long Unk_131_offset { get; private set; }

            protected float Unk_132_raw;
            public const string Unk_132_displayName = "Unk 132";
            public const int Unk_132_sortIndex = 1350;
            [SortOrder(Unk_132_sortIndex)]
            [DisplayName(Unk_132_displayName)]
            public virtual float Unk_132 {
                get => Unk_132_raw;
                set {
                    if (Unk_132_raw == value) return;
                    Unk_132_raw = value;
                    ChangedItems.Add(nameof(Unk_132));
                    OnPropertyChanged(nameof(Unk_132));
                }
            }

            [DisplayName("Offset")]
            public long Unk_132_offset { get; private set; }

            protected float Unk_133_raw;
            public const string Unk_133_displayName = "Unk 133";
            public const int Unk_133_sortIndex = 1400;
            [SortOrder(Unk_133_sortIndex)]
            [DisplayName(Unk_133_displayName)]
            public virtual float Unk_133 {
                get => Unk_133_raw;
                set {
                    if (Unk_133_raw == value) return;
                    Unk_133_raw = value;
                    ChangedItems.Add(nameof(Unk_133));
                    OnPropertyChanged(nameof(Unk_133));
                }
            }

            [DisplayName("Offset")]
            public long Unk_133_offset { get; private set; }

            protected float Unk_134_raw;
            public const string Unk_134_displayName = "Unk 134";
            public const int Unk_134_sortIndex = 1450;
            [SortOrder(Unk_134_sortIndex)]
            [DisplayName(Unk_134_displayName)]
            public virtual float Unk_134 {
                get => Unk_134_raw;
                set {
                    if (Unk_134_raw == value) return;
                    Unk_134_raw = value;
                    ChangedItems.Add(nameof(Unk_134));
                    OnPropertyChanged(nameof(Unk_134));
                }
            }

            [DisplayName("Offset")]
            public long Unk_134_offset { get; private set; }

            protected float Unk_135_raw;
            public const string Unk_135_displayName = "Unk 135";
            public const int Unk_135_sortIndex = 1500;
            [SortOrder(Unk_135_sortIndex)]
            [DisplayName(Unk_135_displayName)]
            public virtual float Unk_135 {
                get => Unk_135_raw;
                set {
                    if (Unk_135_raw == value) return;
                    Unk_135_raw = value;
                    ChangedItems.Add(nameof(Unk_135));
                    OnPropertyChanged(nameof(Unk_135));
                }
            }

            [DisplayName("Offset")]
            public long Unk_135_offset { get; private set; }

            protected float Unk_136_raw;
            public const string Unk_136_displayName = "Unk 136";
            public const int Unk_136_sortIndex = 1550;
            [SortOrder(Unk_136_sortIndex)]
            [DisplayName(Unk_136_displayName)]
            public virtual float Unk_136 {
                get => Unk_136_raw;
                set {
                    if (Unk_136_raw == value) return;
                    Unk_136_raw = value;
                    ChangedItems.Add(nameof(Unk_136));
                    OnPropertyChanged(nameof(Unk_136));
                }
            }

            [DisplayName("Offset")]
            public long Unk_136_offset { get; private set; }

            protected float Unk_137_raw;
            public const string Unk_137_displayName = "Unk 137";
            public const int Unk_137_sortIndex = 1600;
            [SortOrder(Unk_137_sortIndex)]
            [DisplayName(Unk_137_displayName)]
            public virtual float Unk_137 {
                get => Unk_137_raw;
                set {
                    if (Unk_137_raw == value) return;
                    Unk_137_raw = value;
                    ChangedItems.Add(nameof(Unk_137));
                    OnPropertyChanged(nameof(Unk_137));
                }
            }

            [DisplayName("Offset")]
            public long Unk_137_offset { get; private set; }

            protected float Unk_138_raw;
            public const string Unk_138_displayName = "Unk 138";
            public const int Unk_138_sortIndex = 1650;
            [SortOrder(Unk_138_sortIndex)]
            [DisplayName(Unk_138_displayName)]
            public virtual float Unk_138 {
                get => Unk_138_raw;
                set {
                    if (Unk_138_raw == value) return;
                    Unk_138_raw = value;
                    ChangedItems.Add(nameof(Unk_138));
                    OnPropertyChanged(nameof(Unk_138));
                }
            }

            [DisplayName("Offset")]
            public long Unk_138_offset { get; private set; }

            protected float Unk_139_raw;
            public const string Unk_139_displayName = "Unk 139";
            public const int Unk_139_sortIndex = 1700;
            [SortOrder(Unk_139_sortIndex)]
            [DisplayName(Unk_139_displayName)]
            public virtual float Unk_139 {
                get => Unk_139_raw;
                set {
                    if (Unk_139_raw == value) return;
                    Unk_139_raw = value;
                    ChangedItems.Add(nameof(Unk_139));
                    OnPropertyChanged(nameof(Unk_139));
                }
            }

            [DisplayName("Offset")]
            public long Unk_139_offset { get; private set; }

            protected float Unk_140_raw;
            public const string Unk_140_displayName = "Unk 140";
            public const int Unk_140_sortIndex = 1750;
            [SortOrder(Unk_140_sortIndex)]
            [DisplayName(Unk_140_displayName)]
            public virtual float Unk_140 {
                get => Unk_140_raw;
                set {
                    if (Unk_140_raw == value) return;
                    Unk_140_raw = value;
                    ChangedItems.Add(nameof(Unk_140));
                    OnPropertyChanged(nameof(Unk_140));
                }
            }

            [DisplayName("Offset")]
            public long Unk_140_offset { get; private set; }

            protected float Unk_141_raw;
            public const string Unk_141_displayName = "Unk 141";
            public const int Unk_141_sortIndex = 1800;
            [SortOrder(Unk_141_sortIndex)]
            [DisplayName(Unk_141_displayName)]
            public virtual float Unk_141 {
                get => Unk_141_raw;
                set {
                    if (Unk_141_raw == value) return;
                    Unk_141_raw = value;
                    ChangedItems.Add(nameof(Unk_141));
                    OnPropertyChanged(nameof(Unk_141));
                }
            }

            [DisplayName("Offset")]
            public long Unk_141_offset { get; private set; }

            protected float Unk_142_raw;
            public const string Unk_142_displayName = "Unk 142";
            public const int Unk_142_sortIndex = 1850;
            [SortOrder(Unk_142_sortIndex)]
            [DisplayName(Unk_142_displayName)]
            public virtual float Unk_142 {
                get => Unk_142_raw;
                set {
                    if (Unk_142_raw == value) return;
                    Unk_142_raw = value;
                    ChangedItems.Add(nameof(Unk_142));
                    OnPropertyChanged(nameof(Unk_142));
                }
            }

            [DisplayName("Offset")]
            public long Unk_142_offset { get; private set; }

            protected uint Unk_143_raw;
            public const string Unk_143_displayName = "Unk 143";
            public const int Unk_143_sortIndex = 1900;
            [SortOrder(Unk_143_sortIndex)]
            [DisplayName(Unk_143_displayName)]
            public virtual uint Unk_143 {
                get => Unk_143_raw;
                set {
                    if (Unk_143_raw == value) return;
                    Unk_143_raw = value;
                    ChangedItems.Add(nameof(Unk_143));
                    OnPropertyChanged(nameof(Unk_143));
                }
            }

            [DisplayName("Offset")]
            public long Unk_143_offset { get; private set; }

            protected float Unk_144_raw;
            public const string Unk_144_displayName = "Unk 144";
            public const int Unk_144_sortIndex = 1950;
            [SortOrder(Unk_144_sortIndex)]
            [DisplayName(Unk_144_displayName)]
            public virtual float Unk_144 {
                get => Unk_144_raw;
                set {
                    if (Unk_144_raw == value) return;
                    Unk_144_raw = value;
                    ChangedItems.Add(nameof(Unk_144));
                    OnPropertyChanged(nameof(Unk_144));
                }
            }

            [DisplayName("Offset")]
            public long Unk_144_offset { get; private set; }

            protected float Unk_145_raw;
            public const string Unk_145_displayName = "Unk 145";
            public const int Unk_145_sortIndex = 2000;
            [SortOrder(Unk_145_sortIndex)]
            [DisplayName(Unk_145_displayName)]
            public virtual float Unk_145 {
                get => Unk_145_raw;
                set {
                    if (Unk_145_raw == value) return;
                    Unk_145_raw = value;
                    ChangedItems.Add(nameof(Unk_145));
                    OnPropertyChanged(nameof(Unk_145));
                }
            }

            [DisplayName("Offset")]
            public long Unk_145_offset { get; private set; }

            protected float Unk_146_raw;
            public const string Unk_146_displayName = "Unk 146";
            public const int Unk_146_sortIndex = 2050;
            [SortOrder(Unk_146_sortIndex)]
            [DisplayName(Unk_146_displayName)]
            public virtual float Unk_146 {
                get => Unk_146_raw;
                set {
                    if (Unk_146_raw == value) return;
                    Unk_146_raw = value;
                    ChangedItems.Add(nameof(Unk_146));
                    OnPropertyChanged(nameof(Unk_146));
                }
            }

            [DisplayName("Offset")]
            public long Unk_146_offset { get; private set; }

            protected float Unk_147_raw;
            public const string Unk_147_displayName = "Unk 147";
            public const int Unk_147_sortIndex = 2100;
            [SortOrder(Unk_147_sortIndex)]
            [DisplayName(Unk_147_displayName)]
            public virtual float Unk_147 {
                get => Unk_147_raw;
                set {
                    if (Unk_147_raw == value) return;
                    Unk_147_raw = value;
                    ChangedItems.Add(nameof(Unk_147));
                    OnPropertyChanged(nameof(Unk_147));
                }
            }

            [DisplayName("Offset")]
            public long Unk_147_offset { get; private set; }

            protected float Unk_148_raw;
            public const string Unk_148_displayName = "Unk 148";
            public const int Unk_148_sortIndex = 2150;
            [SortOrder(Unk_148_sortIndex)]
            [DisplayName(Unk_148_displayName)]
            public virtual float Unk_148 {
                get => Unk_148_raw;
                set {
                    if (Unk_148_raw == value) return;
                    Unk_148_raw = value;
                    ChangedItems.Add(nameof(Unk_148));
                    OnPropertyChanged(nameof(Unk_148));
                }
            }

            [DisplayName("Offset")]
            public long Unk_148_offset { get; private set; }

            protected uint Unk_149_raw;
            public const string Unk_149_displayName = "Unk 149";
            public const int Unk_149_sortIndex = 2200;
            [SortOrder(Unk_149_sortIndex)]
            [DisplayName(Unk_149_displayName)]
            public virtual uint Unk_149 {
                get => Unk_149_raw;
                set {
                    if (Unk_149_raw == value) return;
                    Unk_149_raw = value;
                    ChangedItems.Add(nameof(Unk_149));
                    OnPropertyChanged(nameof(Unk_149));
                }
            }

            [DisplayName("Offset")]
            public long Unk_149_offset { get; private set; }

            protected uint Unk_150_raw;
            public const string Unk_150_displayName = "Unk 150";
            public const int Unk_150_sortIndex = 2250;
            [SortOrder(Unk_150_sortIndex)]
            [DisplayName(Unk_150_displayName)]
            public virtual uint Unk_150 {
                get => Unk_150_raw;
                set {
                    if (Unk_150_raw == value) return;
                    Unk_150_raw = value;
                    ChangedItems.Add(nameof(Unk_150));
                    OnPropertyChanged(nameof(Unk_150));
                }
            }

            [DisplayName("Offset")]
            public long Unk_150_offset { get; private set; }

            protected uint Unk_151_raw;
            public const string Unk_151_displayName = "Unk 151";
            public const int Unk_151_sortIndex = 2300;
            [SortOrder(Unk_151_sortIndex)]
            [DisplayName(Unk_151_displayName)]
            public virtual uint Unk_151 {
                get => Unk_151_raw;
                set {
                    if (Unk_151_raw == value) return;
                    Unk_151_raw = value;
                    ChangedItems.Add(nameof(Unk_151));
                    OnPropertyChanged(nameof(Unk_151));
                }
            }

            [DisplayName("Offset")]
            public long Unk_151_offset { get; private set; }

            protected uint Unk_152_raw;
            public const string Unk_152_displayName = "Unk 152";
            public const int Unk_152_sortIndex = 2350;
            [SortOrder(Unk_152_sortIndex)]
            [DisplayName(Unk_152_displayName)]
            public virtual uint Unk_152 {
                get => Unk_152_raw;
                set {
                    if (Unk_152_raw == value) return;
                    Unk_152_raw = value;
                    ChangedItems.Add(nameof(Unk_152));
                    OnPropertyChanged(nameof(Unk_152));
                }
            }

            [DisplayName("Offset")]
            public long Unk_152_offset { get; private set; }

            protected byte Unk_153_raw;
            public const string Unk_153_displayName = "Unk 153";
            public const int Unk_153_sortIndex = 2400;
            [SortOrder(Unk_153_sortIndex)]
            [DisplayName(Unk_153_displayName)]
            public virtual byte Unk_153 {
                get => Unk_153_raw;
                set {
                    if (Unk_153_raw == value) return;
                    Unk_153_raw = value;
                    ChangedItems.Add(nameof(Unk_153));
                    OnPropertyChanged(nameof(Unk_153));
                }
            }

            [DisplayName("Offset")]
            public long Unk_153_offset { get; private set; }

            protected byte Unk_154_raw;
            public const string Unk_154_displayName = "Unk 154";
            public const int Unk_154_sortIndex = 2450;
            [SortOrder(Unk_154_sortIndex)]
            [DisplayName(Unk_154_displayName)]
            public virtual byte Unk_154 {
                get => Unk_154_raw;
                set {
                    if (Unk_154_raw == value) return;
                    Unk_154_raw = value;
                    ChangedItems.Add(nameof(Unk_154));
                    OnPropertyChanged(nameof(Unk_154));
                }
            }

            [DisplayName("Offset")]
            public long Unk_154_offset { get; private set; }

            protected sbyte Unk_155_raw;
            public const string Unk_155_displayName = "Unk 155";
            public const int Unk_155_sortIndex = 2500;
            [SortOrder(Unk_155_sortIndex)]
            [DisplayName(Unk_155_displayName)]
            public virtual sbyte Unk_155 {
                get => Unk_155_raw;
                set {
                    if (Unk_155_raw == value) return;
                    Unk_155_raw = value;
                    ChangedItems.Add(nameof(Unk_155));
                    OnPropertyChanged(nameof(Unk_155));
                }
            }

            [DisplayName("Offset")]
            public long Unk_155_offset { get; private set; }

            protected sbyte Unk_156_raw;
            public const string Unk_156_displayName = "Unk 156";
            public const int Unk_156_sortIndex = 2550;
            [SortOrder(Unk_156_sortIndex)]
            [DisplayName(Unk_156_displayName)]
            public virtual sbyte Unk_156 {
                get => Unk_156_raw;
                set {
                    if (Unk_156_raw == value) return;
                    Unk_156_raw = value;
                    ChangedItems.Add(nameof(Unk_156));
                    OnPropertyChanged(nameof(Unk_156));
                }
            }

            [DisplayName("Offset")]
            public long Unk_156_offset { get; private set; }

            protected byte Unk_157_raw;
            public const string Unk_157_displayName = "Unk 157";
            public const int Unk_157_sortIndex = 2600;
            [SortOrder(Unk_157_sortIndex)]
            [DisplayName(Unk_157_displayName)]
            public virtual byte Unk_157 {
                get => Unk_157_raw;
                set {
                    if (Unk_157_raw == value) return;
                    Unk_157_raw = value;
                    ChangedItems.Add(nameof(Unk_157));
                    OnPropertyChanged(nameof(Unk_157));
                }
            }

            [DisplayName("Offset")]
            public long Unk_157_offset { get; private set; }

            protected byte Unk_158_raw;
            public const string Unk_158_displayName = "Unk 158";
            public const int Unk_158_sortIndex = 2650;
            [SortOrder(Unk_158_sortIndex)]
            [DisplayName(Unk_158_displayName)]
            public virtual byte Unk_158 {
                get => Unk_158_raw;
                set {
                    if (Unk_158_raw == value) return;
                    Unk_158_raw = value;
                    ChangedItems.Add(nameof(Unk_158));
                    OnPropertyChanged(nameof(Unk_158));
                }
            }

            [DisplayName("Offset")]
            public long Unk_158_offset { get; private set; }

            protected sbyte Unk_159_raw;
            public const string Unk_159_displayName = "Unk 159";
            public const int Unk_159_sortIndex = 2700;
            [SortOrder(Unk_159_sortIndex)]
            [DisplayName(Unk_159_displayName)]
            public virtual sbyte Unk_159 {
                get => Unk_159_raw;
                set {
                    if (Unk_159_raw == value) return;
                    Unk_159_raw = value;
                    ChangedItems.Add(nameof(Unk_159));
                    OnPropertyChanged(nameof(Unk_159));
                }
            }

            [DisplayName("Offset")]
            public long Unk_159_offset { get; private set; }

            protected sbyte Unk_160_raw;
            public const string Unk_160_displayName = "Unk 160";
            public const int Unk_160_sortIndex = 2750;
            [SortOrder(Unk_160_sortIndex)]
            [DisplayName(Unk_160_displayName)]
            public virtual sbyte Unk_160 {
                get => Unk_160_raw;
                set {
                    if (Unk_160_raw == value) return;
                    Unk_160_raw = value;
                    ChangedItems.Add(nameof(Unk_160));
                    OnPropertyChanged(nameof(Unk_160));
                }
            }

            [DisplayName("Offset")]
            public long Unk_160_offset { get; private set; }

            protected uint Unk_161_raw;
            public const string Unk_161_displayName = "Unk 161";
            public const int Unk_161_sortIndex = 2800;
            [SortOrder(Unk_161_sortIndex)]
            [DisplayName(Unk_161_displayName)]
            public virtual uint Unk_161 {
                get => Unk_161_raw;
                set {
                    if (Unk_161_raw == value) return;
                    Unk_161_raw = value;
                    ChangedItems.Add(nameof(Unk_161));
                    OnPropertyChanged(nameof(Unk_161));
                }
            }

            [DisplayName("Offset")]
            public long Unk_161_offset { get; private set; }

            protected byte Unk_162_raw;
            public const string Unk_162_displayName = "Unk 162";
            public const int Unk_162_sortIndex = 2850;
            [SortOrder(Unk_162_sortIndex)]
            [DisplayName(Unk_162_displayName)]
            public virtual byte Unk_162 {
                get => Unk_162_raw;
                set {
                    if (Unk_162_raw == value) return;
                    Unk_162_raw = value;
                    ChangedItems.Add(nameof(Unk_162));
                    OnPropertyChanged(nameof(Unk_162));
                }
            }

            [DisplayName("Offset")]
            public long Unk_162_offset { get; private set; }

            protected byte Unk_163_raw;
            public const string Unk_163_displayName = "Unk 163";
            public const int Unk_163_sortIndex = 2900;
            [SortOrder(Unk_163_sortIndex)]
            [DisplayName(Unk_163_displayName)]
            public virtual byte Unk_163 {
                get => Unk_163_raw;
                set {
                    if (Unk_163_raw == value) return;
                    Unk_163_raw = value;
                    ChangedItems.Add(nameof(Unk_163));
                    OnPropertyChanged(nameof(Unk_163));
                }
            }

            [DisplayName("Offset")]
            public long Unk_163_offset { get; private set; }

            protected sbyte Unk_164_raw;
            public const string Unk_164_displayName = "Unk 164";
            public const int Unk_164_sortIndex = 2950;
            [SortOrder(Unk_164_sortIndex)]
            [DisplayName(Unk_164_displayName)]
            public virtual sbyte Unk_164 {
                get => Unk_164_raw;
                set {
                    if (Unk_164_raw == value) return;
                    Unk_164_raw = value;
                    ChangedItems.Add(nameof(Unk_164));
                    OnPropertyChanged(nameof(Unk_164));
                }
            }

            [DisplayName("Offset")]
            public long Unk_164_offset { get; private set; }

            protected sbyte Unk_165_raw;
            public const string Unk_165_displayName = "Unk 165";
            public const int Unk_165_sortIndex = 3000;
            [SortOrder(Unk_165_sortIndex)]
            [DisplayName(Unk_165_displayName)]
            public virtual sbyte Unk_165 {
                get => Unk_165_raw;
                set {
                    if (Unk_165_raw == value) return;
                    Unk_165_raw = value;
                    ChangedItems.Add(nameof(Unk_165));
                    OnPropertyChanged(nameof(Unk_165));
                }
            }

            [DisplayName("Offset")]
            public long Unk_165_offset { get; private set; }

            protected uint Unk_166_raw;
            public const string Unk_166_displayName = "Unk 166";
            public const int Unk_166_sortIndex = 3050;
            [SortOrder(Unk_166_sortIndex)]
            [DisplayName(Unk_166_displayName)]
            public virtual uint Unk_166 {
                get => Unk_166_raw;
                set {
                    if (Unk_166_raw == value) return;
                    Unk_166_raw = value;
                    ChangedItems.Add(nameof(Unk_166));
                    OnPropertyChanged(nameof(Unk_166));
                }
            }

            [DisplayName("Offset")]
            public long Unk_166_offset { get; private set; }

            protected uint Unk_167_raw;
            public const string Unk_167_displayName = "Unk 167";
            public const int Unk_167_sortIndex = 3100;
            [SortOrder(Unk_167_sortIndex)]
            [DisplayName(Unk_167_displayName)]
            public virtual uint Unk_167 {
                get => Unk_167_raw;
                set {
                    if (Unk_167_raw == value) return;
                    Unk_167_raw = value;
                    ChangedItems.Add(nameof(Unk_167));
                    OnPropertyChanged(nameof(Unk_167));
                }
            }

            [DisplayName("Offset")]
            public long Unk_167_offset { get; private set; }

            protected uint Unk_168_raw;
            public const string Unk_168_displayName = "Unk 168";
            public const int Unk_168_sortIndex = 3150;
            [SortOrder(Unk_168_sortIndex)]
            [DisplayName(Unk_168_displayName)]
            public virtual uint Unk_168 {
                get => Unk_168_raw;
                set {
                    if (Unk_168_raw == value) return;
                    Unk_168_raw = value;
                    ChangedItems.Add(nameof(Unk_168));
                    OnPropertyChanged(nameof(Unk_168));
                }
            }

            [DisplayName("Offset")]
            public long Unk_168_offset { get; private set; }

            protected float Unk_169_raw;
            public const string Unk_169_displayName = "Unk 169";
            public const int Unk_169_sortIndex = 3200;
            [SortOrder(Unk_169_sortIndex)]
            [DisplayName(Unk_169_displayName)]
            public virtual float Unk_169 {
                get => Unk_169_raw;
                set {
                    if (Unk_169_raw == value) return;
                    Unk_169_raw = value;
                    ChangedItems.Add(nameof(Unk_169));
                    OnPropertyChanged(nameof(Unk_169));
                }
            }

            [DisplayName("Offset")]
            public long Unk_169_offset { get; private set; }

            protected uint Unk_170_raw;
            public const string Unk_170_displayName = "Unk 170";
            public const int Unk_170_sortIndex = 3250;
            [SortOrder(Unk_170_sortIndex)]
            [DisplayName(Unk_170_displayName)]
            public virtual uint Unk_170 {
                get => Unk_170_raw;
                set {
                    if (Unk_170_raw == value) return;
                    Unk_170_raw = value;
                    ChangedItems.Add(nameof(Unk_170));
                    OnPropertyChanged(nameof(Unk_170));
                }
            }

            [DisplayName("Offset")]
            public long Unk_170_offset { get; private set; }

            protected uint Unk_171_raw;
            public const string Unk_171_displayName = "Unk 171";
            public const int Unk_171_sortIndex = 3300;
            [SortOrder(Unk_171_sortIndex)]
            [DisplayName(Unk_171_displayName)]
            public virtual uint Unk_171 {
                get => Unk_171_raw;
                set {
                    if (Unk_171_raw == value) return;
                    Unk_171_raw = value;
                    ChangedItems.Add(nameof(Unk_171));
                    OnPropertyChanged(nameof(Unk_171));
                }
            }

            [DisplayName("Offset")]
            public long Unk_171_offset { get; private set; }

            protected uint Unk_172_raw;
            public const string Unk_172_displayName = "Unk 172";
            public const int Unk_172_sortIndex = 3350;
            [SortOrder(Unk_172_sortIndex)]
            [DisplayName(Unk_172_displayName)]
            public virtual uint Unk_172 {
                get => Unk_172_raw;
                set {
                    if (Unk_172_raw == value) return;
                    Unk_172_raw = value;
                    ChangedItems.Add(nameof(Unk_172));
                    OnPropertyChanged(nameof(Unk_172));
                }
            }

            [DisplayName("Offset")]
            public long Unk_172_offset { get; private set; }

            protected float Unk_173_raw;
            public const string Unk_173_displayName = "Unk 173";
            public const int Unk_173_sortIndex = 3400;
            [SortOrder(Unk_173_sortIndex)]
            [DisplayName(Unk_173_displayName)]
            public virtual float Unk_173 {
                get => Unk_173_raw;
                set {
                    if (Unk_173_raw == value) return;
                    Unk_173_raw = value;
                    ChangedItems.Add(nameof(Unk_173));
                    OnPropertyChanged(nameof(Unk_173));
                }
            }

            [DisplayName("Offset")]
            public long Unk_173_offset { get; private set; }

            protected float Unk_174_raw;
            public const string Unk_174_displayName = "Unk 174";
            public const int Unk_174_sortIndex = 3450;
            [SortOrder(Unk_174_sortIndex)]
            [DisplayName(Unk_174_displayName)]
            public virtual float Unk_174 {
                get => Unk_174_raw;
                set {
                    if (Unk_174_raw == value) return;
                    Unk_174_raw = value;
                    ChangedItems.Add(nameof(Unk_174));
                    OnPropertyChanged(nameof(Unk_174));
                }
            }

            [DisplayName("Offset")]
            public long Unk_174_offset { get; private set; }

            protected float Unk_175_raw;
            public const string Unk_175_displayName = "Unk 175";
            public const int Unk_175_sortIndex = 3500;
            [SortOrder(Unk_175_sortIndex)]
            [DisplayName(Unk_175_displayName)]
            public virtual float Unk_175 {
                get => Unk_175_raw;
                set {
                    if (Unk_175_raw == value) return;
                    Unk_175_raw = value;
                    ChangedItems.Add(nameof(Unk_175));
                    OnPropertyChanged(nameof(Unk_175));
                }
            }

            [DisplayName("Offset")]
            public long Unk_175_offset { get; private set; }

            protected byte Unk_176_raw;
            public const string Unk_176_displayName = "Unk 176";
            public const int Unk_176_sortIndex = 3550;
            [SortOrder(Unk_176_sortIndex)]
            [DisplayName(Unk_176_displayName)]
            public virtual byte Unk_176 {
                get => Unk_176_raw;
                set {
                    if (Unk_176_raw == value) return;
                    Unk_176_raw = value;
                    ChangedItems.Add(nameof(Unk_176));
                    OnPropertyChanged(nameof(Unk_176));
                }
            }

            [DisplayName("Offset")]
            public long Unk_176_offset { get; private set; }

            protected byte Unk_177_raw;
            public const string Unk_177_displayName = "Unk 177";
            public const int Unk_177_sortIndex = 3600;
            [SortOrder(Unk_177_sortIndex)]
            [DisplayName(Unk_177_displayName)]
            public virtual byte Unk_177 {
                get => Unk_177_raw;
                set {
                    if (Unk_177_raw == value) return;
                    Unk_177_raw = value;
                    ChangedItems.Add(nameof(Unk_177));
                    OnPropertyChanged(nameof(Unk_177));
                }
            }

            [DisplayName("Offset")]
            public long Unk_177_offset { get; private set; }

            protected sbyte Unk_178_raw;
            public const string Unk_178_displayName = "Unk 178";
            public const int Unk_178_sortIndex = 3650;
            [SortOrder(Unk_178_sortIndex)]
            [DisplayName(Unk_178_displayName)]
            public virtual sbyte Unk_178 {
                get => Unk_178_raw;
                set {
                    if (Unk_178_raw == value) return;
                    Unk_178_raw = value;
                    ChangedItems.Add(nameof(Unk_178));
                    OnPropertyChanged(nameof(Unk_178));
                }
            }

            [DisplayName("Offset")]
            public long Unk_178_offset { get; private set; }

            protected sbyte Unk_179_raw;
            public const string Unk_179_displayName = "Unk 179";
            public const int Unk_179_sortIndex = 3700;
            [SortOrder(Unk_179_sortIndex)]
            [DisplayName(Unk_179_displayName)]
            public virtual sbyte Unk_179 {
                get => Unk_179_raw;
                set {
                    if (Unk_179_raw == value) return;
                    Unk_179_raw = value;
                    ChangedItems.Add(nameof(Unk_179));
                    OnPropertyChanged(nameof(Unk_179));
                }
            }

            [DisplayName("Offset")]
            public long Unk_179_offset { get; private set; }

            protected float Unk_180_raw;
            public const string Unk_180_displayName = "Unk 180";
            public const int Unk_180_sortIndex = 3750;
            [SortOrder(Unk_180_sortIndex)]
            [DisplayName(Unk_180_displayName)]
            public virtual float Unk_180 {
                get => Unk_180_raw;
                set {
                    if (Unk_180_raw == value) return;
                    Unk_180_raw = value;
                    ChangedItems.Add(nameof(Unk_180));
                    OnPropertyChanged(nameof(Unk_180));
                }
            }

            [DisplayName("Offset")]
            public long Unk_180_offset { get; private set; }

            protected float Unk_181_raw;
            public const string Unk_181_displayName = "Unk 181";
            public const int Unk_181_sortIndex = 3800;
            [SortOrder(Unk_181_sortIndex)]
            [DisplayName(Unk_181_displayName)]
            public virtual float Unk_181 {
                get => Unk_181_raw;
                set {
                    if (Unk_181_raw == value) return;
                    Unk_181_raw = value;
                    ChangedItems.Add(nameof(Unk_181));
                    OnPropertyChanged(nameof(Unk_181));
                }
            }

            [DisplayName("Offset")]
            public long Unk_181_offset { get; private set; }

            protected float Unk_182_raw;
            public const string Unk_182_displayName = "Unk 182";
            public const int Unk_182_sortIndex = 3850;
            [SortOrder(Unk_182_sortIndex)]
            [DisplayName(Unk_182_displayName)]
            public virtual float Unk_182 {
                get => Unk_182_raw;
                set {
                    if (Unk_182_raw == value) return;
                    Unk_182_raw = value;
                    ChangedItems.Add(nameof(Unk_182));
                    OnPropertyChanged(nameof(Unk_182));
                }
            }

            [DisplayName("Offset")]
            public long Unk_182_offset { get; private set; }

            protected float Unk_183_raw;
            public const string Unk_183_displayName = "Unk 183";
            public const int Unk_183_sortIndex = 3900;
            [SortOrder(Unk_183_sortIndex)]
            [DisplayName(Unk_183_displayName)]
            public virtual float Unk_183 {
                get => Unk_183_raw;
                set {
                    if (Unk_183_raw == value) return;
                    Unk_183_raw = value;
                    ChangedItems.Add(nameof(Unk_183));
                    OnPropertyChanged(nameof(Unk_183));
                }
            }

            [DisplayName("Offset")]
            public long Unk_183_offset { get; private set; }

            protected float Unk_184_raw;
            public const string Unk_184_displayName = "Unk 184";
            public const int Unk_184_sortIndex = 3950;
            [SortOrder(Unk_184_sortIndex)]
            [DisplayName(Unk_184_displayName)]
            public virtual float Unk_184 {
                get => Unk_184_raw;
                set {
                    if (Unk_184_raw == value) return;
                    Unk_184_raw = value;
                    ChangedItems.Add(nameof(Unk_184));
                    OnPropertyChanged(nameof(Unk_184));
                }
            }

            [DisplayName("Offset")]
            public long Unk_184_offset { get; private set; }

            protected float Unk_185_raw;
            public const string Unk_185_displayName = "Unk 185";
            public const int Unk_185_sortIndex = 4000;
            [SortOrder(Unk_185_sortIndex)]
            [DisplayName(Unk_185_displayName)]
            public virtual float Unk_185 {
                get => Unk_185_raw;
                set {
                    if (Unk_185_raw == value) return;
                    Unk_185_raw = value;
                    ChangedItems.Add(nameof(Unk_185));
                    OnPropertyChanged(nameof(Unk_185));
                }
            }

            [DisplayName("Offset")]
            public long Unk_185_offset { get; private set; }

            protected float Unk_186_raw;
            public const string Unk_186_displayName = "Unk 186";
            public const int Unk_186_sortIndex = 4050;
            [SortOrder(Unk_186_sortIndex)]
            [DisplayName(Unk_186_displayName)]
            public virtual float Unk_186 {
                get => Unk_186_raw;
                set {
                    if (Unk_186_raw == value) return;
                    Unk_186_raw = value;
                    ChangedItems.Add(nameof(Unk_186));
                    OnPropertyChanged(nameof(Unk_186));
                }
            }

            [DisplayName("Offset")]
            public long Unk_186_offset { get; private set; }

            protected float Unk_187_raw;
            public const string Unk_187_displayName = "Unk 187";
            public const int Unk_187_sortIndex = 4100;
            [SortOrder(Unk_187_sortIndex)]
            [DisplayName(Unk_187_displayName)]
            public virtual float Unk_187 {
                get => Unk_187_raw;
                set {
                    if (Unk_187_raw == value) return;
                    Unk_187_raw = value;
                    ChangedItems.Add(nameof(Unk_187));
                    OnPropertyChanged(nameof(Unk_187));
                }
            }

            [DisplayName("Offset")]
            public long Unk_187_offset { get; private set; }

            protected float Unk_188_raw;
            public const string Unk_188_displayName = "Unk 188";
            public const int Unk_188_sortIndex = 4150;
            [SortOrder(Unk_188_sortIndex)]
            [DisplayName(Unk_188_displayName)]
            public virtual float Unk_188 {
                get => Unk_188_raw;
                set {
                    if (Unk_188_raw == value) return;
                    Unk_188_raw = value;
                    ChangedItems.Add(nameof(Unk_188));
                    OnPropertyChanged(nameof(Unk_188));
                }
            }

            [DisplayName("Offset")]
            public long Unk_188_offset { get; private set; }

            protected float Unk_189_raw;
            public const string Unk_189_displayName = "Unk 189";
            public const int Unk_189_sortIndex = 4200;
            [SortOrder(Unk_189_sortIndex)]
            [DisplayName(Unk_189_displayName)]
            public virtual float Unk_189 {
                get => Unk_189_raw;
                set {
                    if (Unk_189_raw == value) return;
                    Unk_189_raw = value;
                    ChangedItems.Add(nameof(Unk_189));
                    OnPropertyChanged(nameof(Unk_189));
                }
            }

            [DisplayName("Offset")]
            public long Unk_189_offset { get; private set; }

            protected float Unk_190_raw;
            public const string Unk_190_displayName = "Unk 190";
            public const int Unk_190_sortIndex = 4250;
            [SortOrder(Unk_190_sortIndex)]
            [DisplayName(Unk_190_displayName)]
            public virtual float Unk_190 {
                get => Unk_190_raw;
                set {
                    if (Unk_190_raw == value) return;
                    Unk_190_raw = value;
                    ChangedItems.Add(nameof(Unk_190));
                    OnPropertyChanged(nameof(Unk_190));
                }
            }

            [DisplayName("Offset")]
            public long Unk_190_offset { get; private set; }

            protected float Unk_191_raw;
            public const string Unk_191_displayName = "Unk 191";
            public const int Unk_191_sortIndex = 4300;
            [SortOrder(Unk_191_sortIndex)]
            [DisplayName(Unk_191_displayName)]
            public virtual float Unk_191 {
                get => Unk_191_raw;
                set {
                    if (Unk_191_raw == value) return;
                    Unk_191_raw = value;
                    ChangedItems.Add(nameof(Unk_191));
                    OnPropertyChanged(nameof(Unk_191));
                }
            }

            [DisplayName("Offset")]
            public long Unk_191_offset { get; private set; }

            protected float Unk_192_raw;
            public const string Unk_192_displayName = "Unk 192";
            public const int Unk_192_sortIndex = 4350;
            [SortOrder(Unk_192_sortIndex)]
            [DisplayName(Unk_192_displayName)]
            public virtual float Unk_192 {
                get => Unk_192_raw;
                set {
                    if (Unk_192_raw == value) return;
                    Unk_192_raw = value;
                    ChangedItems.Add(nameof(Unk_192));
                    OnPropertyChanged(nameof(Unk_192));
                }
            }

            [DisplayName("Offset")]
            public long Unk_192_offset { get; private set; }

            protected float Unk_193_raw;
            public const string Unk_193_displayName = "Unk 193";
            public const int Unk_193_sortIndex = 4400;
            [SortOrder(Unk_193_sortIndex)]
            [DisplayName(Unk_193_displayName)]
            public virtual float Unk_193 {
                get => Unk_193_raw;
                set {
                    if (Unk_193_raw == value) return;
                    Unk_193_raw = value;
                    ChangedItems.Add(nameof(Unk_193));
                    OnPropertyChanged(nameof(Unk_193));
                }
            }

            [DisplayName("Offset")]
            public long Unk_193_offset { get; private set; }

            protected float Unk_194_raw;
            public const string Unk_194_displayName = "Unk 194";
            public const int Unk_194_sortIndex = 4450;
            [SortOrder(Unk_194_sortIndex)]
            [DisplayName(Unk_194_displayName)]
            public virtual float Unk_194 {
                get => Unk_194_raw;
                set {
                    if (Unk_194_raw == value) return;
                    Unk_194_raw = value;
                    ChangedItems.Add(nameof(Unk_194));
                    OnPropertyChanged(nameof(Unk_194));
                }
            }

            [DisplayName("Offset")]
            public long Unk_194_offset { get; private set; }

            protected float Unk_195_raw;
            public const string Unk_195_displayName = "Unk 195";
            public const int Unk_195_sortIndex = 4500;
            [SortOrder(Unk_195_sortIndex)]
            [DisplayName(Unk_195_displayName)]
            public virtual float Unk_195 {
                get => Unk_195_raw;
                set {
                    if (Unk_195_raw == value) return;
                    Unk_195_raw = value;
                    ChangedItems.Add(nameof(Unk_195));
                    OnPropertyChanged(nameof(Unk_195));
                }
            }

            [DisplayName("Offset")]
            public long Unk_195_offset { get; private set; }

            protected float Unk_196_raw;
            public const string Unk_196_displayName = "Unk 196";
            public const int Unk_196_sortIndex = 4550;
            [SortOrder(Unk_196_sortIndex)]
            [DisplayName(Unk_196_displayName)]
            public virtual float Unk_196 {
                get => Unk_196_raw;
                set {
                    if (Unk_196_raw == value) return;
                    Unk_196_raw = value;
                    ChangedItems.Add(nameof(Unk_196));
                    OnPropertyChanged(nameof(Unk_196));
                }
            }

            [DisplayName("Offset")]
            public long Unk_196_offset { get; private set; }

            protected float Unk_197_raw;
            public const string Unk_197_displayName = "Unk 197";
            public const int Unk_197_sortIndex = 4600;
            [SortOrder(Unk_197_sortIndex)]
            [DisplayName(Unk_197_displayName)]
            public virtual float Unk_197 {
                get => Unk_197_raw;
                set {
                    if (Unk_197_raw == value) return;
                    Unk_197_raw = value;
                    ChangedItems.Add(nameof(Unk_197));
                    OnPropertyChanged(nameof(Unk_197));
                }
            }

            [DisplayName("Offset")]
            public long Unk_197_offset { get; private set; }

            protected float Unk_198_raw;
            public const string Unk_198_displayName = "Unk 198";
            public const int Unk_198_sortIndex = 4650;
            [SortOrder(Unk_198_sortIndex)]
            [DisplayName(Unk_198_displayName)]
            public virtual float Unk_198 {
                get => Unk_198_raw;
                set {
                    if (Unk_198_raw == value) return;
                    Unk_198_raw = value;
                    ChangedItems.Add(nameof(Unk_198));
                    OnPropertyChanged(nameof(Unk_198));
                }
            }

            [DisplayName("Offset")]
            public long Unk_198_offset { get; private set; }

            protected float Unk_199_raw;
            public const string Unk_199_displayName = "Unk 199";
            public const int Unk_199_sortIndex = 4700;
            [SortOrder(Unk_199_sortIndex)]
            [DisplayName(Unk_199_displayName)]
            public virtual float Unk_199 {
                get => Unk_199_raw;
                set {
                    if (Unk_199_raw == value) return;
                    Unk_199_raw = value;
                    ChangedItems.Add(nameof(Unk_199));
                    OnPropertyChanged(nameof(Unk_199));
                }
            }

            [DisplayName("Offset")]
            public long Unk_199_offset { get; private set; }

            protected float Unk_200_raw;
            public const string Unk_200_displayName = "Unk 200";
            public const int Unk_200_sortIndex = 4750;
            [SortOrder(Unk_200_sortIndex)]
            [DisplayName(Unk_200_displayName)]
            public virtual float Unk_200 {
                get => Unk_200_raw;
                set {
                    if (Unk_200_raw == value) return;
                    Unk_200_raw = value;
                    ChangedItems.Add(nameof(Unk_200));
                    OnPropertyChanged(nameof(Unk_200));
                }
            }

            [DisplayName("Offset")]
            public long Unk_200_offset { get; private set; }

            protected float Unk_201_raw;
            public const string Unk_201_displayName = "Unk 201";
            public const int Unk_201_sortIndex = 4800;
            [SortOrder(Unk_201_sortIndex)]
            [DisplayName(Unk_201_displayName)]
            public virtual float Unk_201 {
                get => Unk_201_raw;
                set {
                    if (Unk_201_raw == value) return;
                    Unk_201_raw = value;
                    ChangedItems.Add(nameof(Unk_201));
                    OnPropertyChanged(nameof(Unk_201));
                }
            }

            [DisplayName("Offset")]
            public long Unk_201_offset { get; private set; }

            protected float Unk_202_raw;
            public const string Unk_202_displayName = "Unk 202";
            public const int Unk_202_sortIndex = 4850;
            [SortOrder(Unk_202_sortIndex)]
            [DisplayName(Unk_202_displayName)]
            public virtual float Unk_202 {
                get => Unk_202_raw;
                set {
                    if (Unk_202_raw == value) return;
                    Unk_202_raw = value;
                    ChangedItems.Add(nameof(Unk_202));
                    OnPropertyChanged(nameof(Unk_202));
                }
            }

            [DisplayName("Offset")]
            public long Unk_202_offset { get; private set; }

            protected float Unk_203_raw;
            public const string Unk_203_displayName = "Unk 203";
            public const int Unk_203_sortIndex = 4900;
            [SortOrder(Unk_203_sortIndex)]
            [DisplayName(Unk_203_displayName)]
            public virtual float Unk_203 {
                get => Unk_203_raw;
                set {
                    if (Unk_203_raw == value) return;
                    Unk_203_raw = value;
                    ChangedItems.Add(nameof(Unk_203));
                    OnPropertyChanged(nameof(Unk_203));
                }
            }

            [DisplayName("Offset")]
            public long Unk_203_offset { get; private set; }

            protected float Unk_204_raw;
            public const string Unk_204_displayName = "Unk 204";
            public const int Unk_204_sortIndex = 4950;
            [SortOrder(Unk_204_sortIndex)]
            [DisplayName(Unk_204_displayName)]
            public virtual float Unk_204 {
                get => Unk_204_raw;
                set {
                    if (Unk_204_raw == value) return;
                    Unk_204_raw = value;
                    ChangedItems.Add(nameof(Unk_204));
                    OnPropertyChanged(nameof(Unk_204));
                }
            }

            [DisplayName("Offset")]
            public long Unk_204_offset { get; private set; }

            protected float Unk_205_raw;
            public const string Unk_205_displayName = "Unk 205";
            public const int Unk_205_sortIndex = 5000;
            [SortOrder(Unk_205_sortIndex)]
            [DisplayName(Unk_205_displayName)]
            public virtual float Unk_205 {
                get => Unk_205_raw;
                set {
                    if (Unk_205_raw == value) return;
                    Unk_205_raw = value;
                    ChangedItems.Add(nameof(Unk_205));
                    OnPropertyChanged(nameof(Unk_205));
                }
            }

            [DisplayName("Offset")]
            public long Unk_205_offset { get; private set; }

            protected float Unk_206_raw;
            public const string Unk_206_displayName = "Unk 206";
            public const int Unk_206_sortIndex = 5050;
            [SortOrder(Unk_206_sortIndex)]
            [DisplayName(Unk_206_displayName)]
            public virtual float Unk_206 {
                get => Unk_206_raw;
                set {
                    if (Unk_206_raw == value) return;
                    Unk_206_raw = value;
                    ChangedItems.Add(nameof(Unk_206));
                    OnPropertyChanged(nameof(Unk_206));
                }
            }

            [DisplayName("Offset")]
            public long Unk_206_offset { get; private set; }

            protected float Unk_207_raw;
            public const string Unk_207_displayName = "Unk 207";
            public const int Unk_207_sortIndex = 5100;
            [SortOrder(Unk_207_sortIndex)]
            [DisplayName(Unk_207_displayName)]
            public virtual float Unk_207 {
                get => Unk_207_raw;
                set {
                    if (Unk_207_raw == value) return;
                    Unk_207_raw = value;
                    ChangedItems.Add(nameof(Unk_207));
                    OnPropertyChanged(nameof(Unk_207));
                }
            }

            [DisplayName("Offset")]
            public long Unk_207_offset { get; private set; }

            protected float Unk_208_raw;
            public const string Unk_208_displayName = "Unk 208";
            public const int Unk_208_sortIndex = 5150;
            [SortOrder(Unk_208_sortIndex)]
            [DisplayName(Unk_208_displayName)]
            public virtual float Unk_208 {
                get => Unk_208_raw;
                set {
                    if (Unk_208_raw == value) return;
                    Unk_208_raw = value;
                    ChangedItems.Add(nameof(Unk_208));
                    OnPropertyChanged(nameof(Unk_208));
                }
            }

            [DisplayName("Offset")]
            public long Unk_208_offset { get; private set; }

            protected float Unk_209_raw;
            public const string Unk_209_displayName = "Unk 209";
            public const int Unk_209_sortIndex = 5200;
            [SortOrder(Unk_209_sortIndex)]
            [DisplayName(Unk_209_displayName)]
            public virtual float Unk_209 {
                get => Unk_209_raw;
                set {
                    if (Unk_209_raw == value) return;
                    Unk_209_raw = value;
                    ChangedItems.Add(nameof(Unk_209));
                    OnPropertyChanged(nameof(Unk_209));
                }
            }

            [DisplayName("Offset")]
            public long Unk_209_offset { get; private set; }

            protected float Unk_210_raw;
            public const string Unk_210_displayName = "Unk 210";
            public const int Unk_210_sortIndex = 5250;
            [SortOrder(Unk_210_sortIndex)]
            [DisplayName(Unk_210_displayName)]
            public virtual float Unk_210 {
                get => Unk_210_raw;
                set {
                    if (Unk_210_raw == value) return;
                    Unk_210_raw = value;
                    ChangedItems.Add(nameof(Unk_210));
                    OnPropertyChanged(nameof(Unk_210));
                }
            }

            [DisplayName("Offset")]
            public long Unk_210_offset { get; private set; }

            protected float Unk_211_raw;
            public const string Unk_211_displayName = "Unk 211";
            public const int Unk_211_sortIndex = 5300;
            [SortOrder(Unk_211_sortIndex)]
            [DisplayName(Unk_211_displayName)]
            public virtual float Unk_211 {
                get => Unk_211_raw;
                set {
                    if (Unk_211_raw == value) return;
                    Unk_211_raw = value;
                    ChangedItems.Add(nameof(Unk_211));
                    OnPropertyChanged(nameof(Unk_211));
                }
            }

            [DisplayName("Offset")]
            public long Unk_211_offset { get; private set; }

            protected float Unk_212_raw;
            public const string Unk_212_displayName = "Unk 212";
            public const int Unk_212_sortIndex = 5350;
            [SortOrder(Unk_212_sortIndex)]
            [DisplayName(Unk_212_displayName)]
            public virtual float Unk_212 {
                get => Unk_212_raw;
                set {
                    if (Unk_212_raw == value) return;
                    Unk_212_raw = value;
                    ChangedItems.Add(nameof(Unk_212));
                    OnPropertyChanged(nameof(Unk_212));
                }
            }

            [DisplayName("Offset")]
            public long Unk_212_offset { get; private set; }

            protected float Unk_213_raw;
            public const string Unk_213_displayName = "Unk 213";
            public const int Unk_213_sortIndex = 5400;
            [SortOrder(Unk_213_sortIndex)]
            [DisplayName(Unk_213_displayName)]
            public virtual float Unk_213 {
                get => Unk_213_raw;
                set {
                    if (Unk_213_raw == value) return;
                    Unk_213_raw = value;
                    ChangedItems.Add(nameof(Unk_213));
                    OnPropertyChanged(nameof(Unk_213));
                }
            }

            [DisplayName("Offset")]
            public long Unk_213_offset { get; private set; }

            protected float Unk_214_raw;
            public const string Unk_214_displayName = "Unk 214";
            public const int Unk_214_sortIndex = 5450;
            [SortOrder(Unk_214_sortIndex)]
            [DisplayName(Unk_214_displayName)]
            public virtual float Unk_214 {
                get => Unk_214_raw;
                set {
                    if (Unk_214_raw == value) return;
                    Unk_214_raw = value;
                    ChangedItems.Add(nameof(Unk_214));
                    OnPropertyChanged(nameof(Unk_214));
                }
            }

            [DisplayName("Offset")]
            public long Unk_214_offset { get; private set; }

            protected float Unk_215_raw;
            public const string Unk_215_displayName = "Unk 215";
            public const int Unk_215_sortIndex = 5500;
            [SortOrder(Unk_215_sortIndex)]
            [DisplayName(Unk_215_displayName)]
            public virtual float Unk_215 {
                get => Unk_215_raw;
                set {
                    if (Unk_215_raw == value) return;
                    Unk_215_raw = value;
                    ChangedItems.Add(nameof(Unk_215));
                    OnPropertyChanged(nameof(Unk_215));
                }
            }

            [DisplayName("Offset")]
            public long Unk_215_offset { get; private set; }

            protected float Unk_216_raw;
            public const string Unk_216_displayName = "Unk 216";
            public const int Unk_216_sortIndex = 5550;
            [SortOrder(Unk_216_sortIndex)]
            [DisplayName(Unk_216_displayName)]
            public virtual float Unk_216 {
                get => Unk_216_raw;
                set {
                    if (Unk_216_raw == value) return;
                    Unk_216_raw = value;
                    ChangedItems.Add(nameof(Unk_216));
                    OnPropertyChanged(nameof(Unk_216));
                }
            }

            [DisplayName("Offset")]
            public long Unk_216_offset { get; private set; }

            protected float Unk_217_raw;
            public const string Unk_217_displayName = "Unk 217";
            public const int Unk_217_sortIndex = 5600;
            [SortOrder(Unk_217_sortIndex)]
            [DisplayName(Unk_217_displayName)]
            public virtual float Unk_217 {
                get => Unk_217_raw;
                set {
                    if (Unk_217_raw == value) return;
                    Unk_217_raw = value;
                    ChangedItems.Add(nameof(Unk_217));
                    OnPropertyChanged(nameof(Unk_217));
                }
            }

            [DisplayName("Offset")]
            public long Unk_217_offset { get; private set; }

            protected float Unk_218_raw;
            public const string Unk_218_displayName = "Unk 218";
            public const int Unk_218_sortIndex = 5650;
            [SortOrder(Unk_218_sortIndex)]
            [DisplayName(Unk_218_displayName)]
            public virtual float Unk_218 {
                get => Unk_218_raw;
                set {
                    if (Unk_218_raw == value) return;
                    Unk_218_raw = value;
                    ChangedItems.Add(nameof(Unk_218));
                    OnPropertyChanged(nameof(Unk_218));
                }
            }

            [DisplayName("Offset")]
            public long Unk_218_offset { get; private set; }

            protected float Unk_219_raw;
            public const string Unk_219_displayName = "Unk 219";
            public const int Unk_219_sortIndex = 5700;
            [SortOrder(Unk_219_sortIndex)]
            [DisplayName(Unk_219_displayName)]
            public virtual float Unk_219 {
                get => Unk_219_raw;
                set {
                    if (Unk_219_raw == value) return;
                    Unk_219_raw = value;
                    ChangedItems.Add(nameof(Unk_219));
                    OnPropertyChanged(nameof(Unk_219));
                }
            }

            [DisplayName("Offset")]
            public long Unk_219_offset { get; private set; }

            protected float Unk_220_raw;
            public const string Unk_220_displayName = "Unk 220";
            public const int Unk_220_sortIndex = 5750;
            [SortOrder(Unk_220_sortIndex)]
            [DisplayName(Unk_220_displayName)]
            public virtual float Unk_220 {
                get => Unk_220_raw;
                set {
                    if (Unk_220_raw == value) return;
                    Unk_220_raw = value;
                    ChangedItems.Add(nameof(Unk_220));
                    OnPropertyChanged(nameof(Unk_220));
                }
            }

            [DisplayName("Offset")]
            public long Unk_220_offset { get; private set; }

            protected float Unk_221_raw;
            public const string Unk_221_displayName = "Unk 221";
            public const int Unk_221_sortIndex = 5800;
            [SortOrder(Unk_221_sortIndex)]
            [DisplayName(Unk_221_displayName)]
            public virtual float Unk_221 {
                get => Unk_221_raw;
                set {
                    if (Unk_221_raw == value) return;
                    Unk_221_raw = value;
                    ChangedItems.Add(nameof(Unk_221));
                    OnPropertyChanged(nameof(Unk_221));
                }
            }

            [DisplayName("Offset")]
            public long Unk_221_offset { get; private set; }

            protected float Unk_222_raw;
            public const string Unk_222_displayName = "Unk 222";
            public const int Unk_222_sortIndex = 5850;
            [SortOrder(Unk_222_sortIndex)]
            [DisplayName(Unk_222_displayName)]
            public virtual float Unk_222 {
                get => Unk_222_raw;
                set {
                    if (Unk_222_raw == value) return;
                    Unk_222_raw = value;
                    ChangedItems.Add(nameof(Unk_222));
                    OnPropertyChanged(nameof(Unk_222));
                }
            }

            [DisplayName("Offset")]
            public long Unk_222_offset { get; private set; }

            protected float Unk_223_raw;
            public const string Unk_223_displayName = "Unk 223";
            public const int Unk_223_sortIndex = 5900;
            [SortOrder(Unk_223_sortIndex)]
            [DisplayName(Unk_223_displayName)]
            public virtual float Unk_223 {
                get => Unk_223_raw;
                set {
                    if (Unk_223_raw == value) return;
                    Unk_223_raw = value;
                    ChangedItems.Add(nameof(Unk_223));
                    OnPropertyChanged(nameof(Unk_223));
                }
            }

            [DisplayName("Offset")]
            public long Unk_223_offset { get; private set; }

            protected float Unk_224_raw;
            public const string Unk_224_displayName = "Unk 224";
            public const int Unk_224_sortIndex = 5950;
            [SortOrder(Unk_224_sortIndex)]
            [DisplayName(Unk_224_displayName)]
            public virtual float Unk_224 {
                get => Unk_224_raw;
                set {
                    if (Unk_224_raw == value) return;
                    Unk_224_raw = value;
                    ChangedItems.Add(nameof(Unk_224));
                    OnPropertyChanged(nameof(Unk_224));
                }
            }

            [DisplayName("Offset")]
            public long Unk_224_offset { get; private set; }

            protected float Unk_225_raw;
            public const string Unk_225_displayName = "Unk 225";
            public const int Unk_225_sortIndex = 6000;
            [SortOrder(Unk_225_sortIndex)]
            [DisplayName(Unk_225_displayName)]
            public virtual float Unk_225 {
                get => Unk_225_raw;
                set {
                    if (Unk_225_raw == value) return;
                    Unk_225_raw = value;
                    ChangedItems.Add(nameof(Unk_225));
                    OnPropertyChanged(nameof(Unk_225));
                }
            }

            [DisplayName("Offset")]
            public long Unk_225_offset { get; private set; }

            protected float Unk_226_raw;
            public const string Unk_226_displayName = "Unk 226";
            public const int Unk_226_sortIndex = 6050;
            [SortOrder(Unk_226_sortIndex)]
            [DisplayName(Unk_226_displayName)]
            public virtual float Unk_226 {
                get => Unk_226_raw;
                set {
                    if (Unk_226_raw == value) return;
                    Unk_226_raw = value;
                    ChangedItems.Add(nameof(Unk_226));
                    OnPropertyChanged(nameof(Unk_226));
                }
            }

            [DisplayName("Offset")]
            public long Unk_226_offset { get; private set; }

            protected float Unk_227_raw;
            public const string Unk_227_displayName = "Unk 227";
            public const int Unk_227_sortIndex = 6100;
            [SortOrder(Unk_227_sortIndex)]
            [DisplayName(Unk_227_displayName)]
            public virtual float Unk_227 {
                get => Unk_227_raw;
                set {
                    if (Unk_227_raw == value) return;
                    Unk_227_raw = value;
                    ChangedItems.Add(nameof(Unk_227));
                    OnPropertyChanged(nameof(Unk_227));
                }
            }

            [DisplayName("Offset")]
            public long Unk_227_offset { get; private set; }

            protected float Unk_228_raw;
            public const string Unk_228_displayName = "Unk 228";
            public const int Unk_228_sortIndex = 6150;
            [SortOrder(Unk_228_sortIndex)]
            [DisplayName(Unk_228_displayName)]
            public virtual float Unk_228 {
                get => Unk_228_raw;
                set {
                    if (Unk_228_raw == value) return;
                    Unk_228_raw = value;
                    ChangedItems.Add(nameof(Unk_228));
                    OnPropertyChanged(nameof(Unk_228));
                }
            }

            [DisplayName("Offset")]
            public long Unk_228_offset { get; private set; }

            protected float Unk_229_raw;
            public const string Unk_229_displayName = "Unk 229";
            public const int Unk_229_sortIndex = 6200;
            [SortOrder(Unk_229_sortIndex)]
            [DisplayName(Unk_229_displayName)]
            public virtual float Unk_229 {
                get => Unk_229_raw;
                set {
                    if (Unk_229_raw == value) return;
                    Unk_229_raw = value;
                    ChangedItems.Add(nameof(Unk_229));
                    OnPropertyChanged(nameof(Unk_229));
                }
            }

            [DisplayName("Offset")]
            public long Unk_229_offset { get; private set; }

            protected float Unk_230_raw;
            public const string Unk_230_displayName = "Unk 230";
            public const int Unk_230_sortIndex = 6250;
            [SortOrder(Unk_230_sortIndex)]
            [DisplayName(Unk_230_displayName)]
            public virtual float Unk_230 {
                get => Unk_230_raw;
                set {
                    if (Unk_230_raw == value) return;
                    Unk_230_raw = value;
                    ChangedItems.Add(nameof(Unk_230));
                    OnPropertyChanged(nameof(Unk_230));
                }
            }

            [DisplayName("Offset")]
            public long Unk_230_offset { get; private set; }

            protected float Unk_231_raw;
            public const string Unk_231_displayName = "Unk 231";
            public const int Unk_231_sortIndex = 6300;
            [SortOrder(Unk_231_sortIndex)]
            [DisplayName(Unk_231_displayName)]
            public virtual float Unk_231 {
                get => Unk_231_raw;
                set {
                    if (Unk_231_raw == value) return;
                    Unk_231_raw = value;
                    ChangedItems.Add(nameof(Unk_231));
                    OnPropertyChanged(nameof(Unk_231));
                }
            }

            [DisplayName("Offset")]
            public long Unk_231_offset { get; private set; }

            protected float Unk_232_raw;
            public const string Unk_232_displayName = "Unk 232";
            public const int Unk_232_sortIndex = 6350;
            [SortOrder(Unk_232_sortIndex)]
            [DisplayName(Unk_232_displayName)]
            public virtual float Unk_232 {
                get => Unk_232_raw;
                set {
                    if (Unk_232_raw == value) return;
                    Unk_232_raw = value;
                    ChangedItems.Add(nameof(Unk_232));
                    OnPropertyChanged(nameof(Unk_232));
                }
            }

            [DisplayName("Offset")]
            public long Unk_232_offset { get; private set; }

            protected float Unk_233_raw;
            public const string Unk_233_displayName = "Unk 233";
            public const int Unk_233_sortIndex = 6400;
            [SortOrder(Unk_233_sortIndex)]
            [DisplayName(Unk_233_displayName)]
            public virtual float Unk_233 {
                get => Unk_233_raw;
                set {
                    if (Unk_233_raw == value) return;
                    Unk_233_raw = value;
                    ChangedItems.Add(nameof(Unk_233));
                    OnPropertyChanged(nameof(Unk_233));
                }
            }

            [DisplayName("Offset")]
            public long Unk_233_offset { get; private set; }

            public const int lastSortIndex = 6450;

            public static ObservableMhwStructCollection<Scoutfly_Params_3_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Scoutfly_Params_3_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Scoutfly_Params_3_ LoadData(BinaryReader reader, ulong i) {
                var data = new Scoutfly_Params_3_();
                data.Index = i;
                data.Unk_106_offset = reader.BaseStream.Position;
                data.Unk_106_raw = reader.ReadUInt32();
                data.Unk_107_offset = reader.BaseStream.Position;
                data.Unk_107_raw = reader.ReadUInt32();
                data.Unk_108_offset = reader.BaseStream.Position;
                data.Unk_108_raw = reader.ReadUInt32();
                data.Unk_109_offset = reader.BaseStream.Position;
                data.Unk_109_raw = reader.ReadUInt32();
                data.Unk_110_offset = reader.BaseStream.Position;
                data.Unk_110_raw = reader.ReadUInt32();
                data.Unk_111_offset = reader.BaseStream.Position;
                data.Unk_111_raw = reader.ReadUInt32();
                data.Unk_112_offset = reader.BaseStream.Position;
                data.Unk_112_raw = reader.ReadUInt32();
                data.Unk_113_offset = reader.BaseStream.Position;
                data.Unk_113_raw = reader.ReadUInt32();
                data.Unk_114_offset = reader.BaseStream.Position;
                data.Unk_114_raw = reader.ReadUInt32();
                data.Unk_115_offset = reader.BaseStream.Position;
                data.Unk_115_raw = reader.ReadUInt32();
                data.Unk_116_offset = reader.BaseStream.Position;
                data.Unk_116_raw = reader.ReadUInt32();
                data.Unk_117_offset = reader.BaseStream.Position;
                data.Unk_117_raw = reader.ReadSingle();
                data.Unk_118_offset = reader.BaseStream.Position;
                data.Unk_118_raw = reader.ReadSingle();
                data.Unk_119_offset = reader.BaseStream.Position;
                data.Unk_119_raw = reader.ReadSingle();
                data.Unk_120_offset = reader.BaseStream.Position;
                data.Unk_120_raw = reader.ReadSingle();
                data.Unk_121_offset = reader.BaseStream.Position;
                data.Unk_121_raw = reader.ReadSingle();
                data.Unk_122_offset = reader.BaseStream.Position;
                data.Unk_122_raw = reader.ReadSingle();
                data.Unk_123_offset = reader.BaseStream.Position;
                data.Unk_123_raw = reader.ReadSingle();
                data.Unk_124_offset = reader.BaseStream.Position;
                data.Unk_124_raw = reader.ReadSingle();
                data.Unk_125_offset = reader.BaseStream.Position;
                data.Unk_125_raw = reader.ReadSingle();
                data.Unk_126_offset = reader.BaseStream.Position;
                data.Unk_126_raw = reader.ReadSingle();
                data.Unk_127_offset = reader.BaseStream.Position;
                data.Unk_127_raw = reader.ReadSingle();
                data.Unk_128_offset = reader.BaseStream.Position;
                data.Unk_128_raw = reader.ReadSingle();
                data.Unk_129_offset = reader.BaseStream.Position;
                data.Unk_129_raw = reader.ReadSingle();
                data.Unk_130_offset = reader.BaseStream.Position;
                data.Unk_130_raw = reader.ReadSingle();
                data.Unk_131_offset = reader.BaseStream.Position;
                data.Unk_131_raw = reader.ReadSingle();
                data.Unk_132_offset = reader.BaseStream.Position;
                data.Unk_132_raw = reader.ReadSingle();
                data.Unk_133_offset = reader.BaseStream.Position;
                data.Unk_133_raw = reader.ReadSingle();
                data.Unk_134_offset = reader.BaseStream.Position;
                data.Unk_134_raw = reader.ReadSingle();
                data.Unk_135_offset = reader.BaseStream.Position;
                data.Unk_135_raw = reader.ReadSingle();
                data.Unk_136_offset = reader.BaseStream.Position;
                data.Unk_136_raw = reader.ReadSingle();
                data.Unk_137_offset = reader.BaseStream.Position;
                data.Unk_137_raw = reader.ReadSingle();
                data.Unk_138_offset = reader.BaseStream.Position;
                data.Unk_138_raw = reader.ReadSingle();
                data.Unk_139_offset = reader.BaseStream.Position;
                data.Unk_139_raw = reader.ReadSingle();
                data.Unk_140_offset = reader.BaseStream.Position;
                data.Unk_140_raw = reader.ReadSingle();
                data.Unk_141_offset = reader.BaseStream.Position;
                data.Unk_141_raw = reader.ReadSingle();
                data.Unk_142_offset = reader.BaseStream.Position;
                data.Unk_142_raw = reader.ReadSingle();
                data.Unk_143_offset = reader.BaseStream.Position;
                data.Unk_143_raw = reader.ReadUInt32();
                data.Unk_144_offset = reader.BaseStream.Position;
                data.Unk_144_raw = reader.ReadSingle();
                data.Unk_145_offset = reader.BaseStream.Position;
                data.Unk_145_raw = reader.ReadSingle();
                data.Unk_146_offset = reader.BaseStream.Position;
                data.Unk_146_raw = reader.ReadSingle();
                data.Unk_147_offset = reader.BaseStream.Position;
                data.Unk_147_raw = reader.ReadSingle();
                data.Unk_148_offset = reader.BaseStream.Position;
                data.Unk_148_raw = reader.ReadSingle();
                data.Unk_149_offset = reader.BaseStream.Position;
                data.Unk_149_raw = reader.ReadUInt32();
                data.Unk_150_offset = reader.BaseStream.Position;
                data.Unk_150_raw = reader.ReadUInt32();
                data.Unk_151_offset = reader.BaseStream.Position;
                data.Unk_151_raw = reader.ReadUInt32();
                data.Unk_152_offset = reader.BaseStream.Position;
                data.Unk_152_raw = reader.ReadUInt32();
                data.Unk_153_offset = reader.BaseStream.Position;
                data.Unk_153_raw = reader.ReadByte();
                data.Unk_154_offset = reader.BaseStream.Position;
                data.Unk_154_raw = reader.ReadByte();
                data.Unk_155_offset = reader.BaseStream.Position;
                data.Unk_155_raw = reader.ReadSByte();
                data.Unk_156_offset = reader.BaseStream.Position;
                data.Unk_156_raw = reader.ReadSByte();
                data.Unk_157_offset = reader.BaseStream.Position;
                data.Unk_157_raw = reader.ReadByte();
                data.Unk_158_offset = reader.BaseStream.Position;
                data.Unk_158_raw = reader.ReadByte();
                data.Unk_159_offset = reader.BaseStream.Position;
                data.Unk_159_raw = reader.ReadSByte();
                data.Unk_160_offset = reader.BaseStream.Position;
                data.Unk_160_raw = reader.ReadSByte();
                data.Unk_161_offset = reader.BaseStream.Position;
                data.Unk_161_raw = reader.ReadUInt32();
                data.Unk_162_offset = reader.BaseStream.Position;
                data.Unk_162_raw = reader.ReadByte();
                data.Unk_163_offset = reader.BaseStream.Position;
                data.Unk_163_raw = reader.ReadByte();
                data.Unk_164_offset = reader.BaseStream.Position;
                data.Unk_164_raw = reader.ReadSByte();
                data.Unk_165_offset = reader.BaseStream.Position;
                data.Unk_165_raw = reader.ReadSByte();
                data.Unk_166_offset = reader.BaseStream.Position;
                data.Unk_166_raw = reader.ReadUInt32();
                data.Unk_167_offset = reader.BaseStream.Position;
                data.Unk_167_raw = reader.ReadUInt32();
                data.Unk_168_offset = reader.BaseStream.Position;
                data.Unk_168_raw = reader.ReadUInt32();
                data.Unk_169_offset = reader.BaseStream.Position;
                data.Unk_169_raw = reader.ReadSingle();
                data.Unk_170_offset = reader.BaseStream.Position;
                data.Unk_170_raw = reader.ReadUInt32();
                data.Unk_171_offset = reader.BaseStream.Position;
                data.Unk_171_raw = reader.ReadUInt32();
                data.Unk_172_offset = reader.BaseStream.Position;
                data.Unk_172_raw = reader.ReadUInt32();
                data.Unk_173_offset = reader.BaseStream.Position;
                data.Unk_173_raw = reader.ReadSingle();
                data.Unk_174_offset = reader.BaseStream.Position;
                data.Unk_174_raw = reader.ReadSingle();
                data.Unk_175_offset = reader.BaseStream.Position;
                data.Unk_175_raw = reader.ReadSingle();
                data.Unk_176_offset = reader.BaseStream.Position;
                data.Unk_176_raw = reader.ReadByte();
                data.Unk_177_offset = reader.BaseStream.Position;
                data.Unk_177_raw = reader.ReadByte();
                data.Unk_178_offset = reader.BaseStream.Position;
                data.Unk_178_raw = reader.ReadSByte();
                data.Unk_179_offset = reader.BaseStream.Position;
                data.Unk_179_raw = reader.ReadSByte();
                data.Unk_180_offset = reader.BaseStream.Position;
                data.Unk_180_raw = reader.ReadSingle();
                data.Unk_181_offset = reader.BaseStream.Position;
                data.Unk_181_raw = reader.ReadSingle();
                data.Unk_182_offset = reader.BaseStream.Position;
                data.Unk_182_raw = reader.ReadSingle();
                data.Unk_183_offset = reader.BaseStream.Position;
                data.Unk_183_raw = reader.ReadSingle();
                data.Unk_184_offset = reader.BaseStream.Position;
                data.Unk_184_raw = reader.ReadSingle();
                data.Unk_185_offset = reader.BaseStream.Position;
                data.Unk_185_raw = reader.ReadSingle();
                data.Unk_186_offset = reader.BaseStream.Position;
                data.Unk_186_raw = reader.ReadSingle();
                data.Unk_187_offset = reader.BaseStream.Position;
                data.Unk_187_raw = reader.ReadSingle();
                data.Unk_188_offset = reader.BaseStream.Position;
                data.Unk_188_raw = reader.ReadSingle();
                data.Unk_189_offset = reader.BaseStream.Position;
                data.Unk_189_raw = reader.ReadSingle();
                data.Unk_190_offset = reader.BaseStream.Position;
                data.Unk_190_raw = reader.ReadSingle();
                data.Unk_191_offset = reader.BaseStream.Position;
                data.Unk_191_raw = reader.ReadSingle();
                data.Unk_192_offset = reader.BaseStream.Position;
                data.Unk_192_raw = reader.ReadSingle();
                data.Unk_193_offset = reader.BaseStream.Position;
                data.Unk_193_raw = reader.ReadSingle();
                data.Unk_194_offset = reader.BaseStream.Position;
                data.Unk_194_raw = reader.ReadSingle();
                data.Unk_195_offset = reader.BaseStream.Position;
                data.Unk_195_raw = reader.ReadSingle();
                data.Unk_196_offset = reader.BaseStream.Position;
                data.Unk_196_raw = reader.ReadSingle();
                data.Unk_197_offset = reader.BaseStream.Position;
                data.Unk_197_raw = reader.ReadSingle();
                data.Unk_198_offset = reader.BaseStream.Position;
                data.Unk_198_raw = reader.ReadSingle();
                data.Unk_199_offset = reader.BaseStream.Position;
                data.Unk_199_raw = reader.ReadSingle();
                data.Unk_200_offset = reader.BaseStream.Position;
                data.Unk_200_raw = reader.ReadSingle();
                data.Unk_201_offset = reader.BaseStream.Position;
                data.Unk_201_raw = reader.ReadSingle();
                data.Unk_202_offset = reader.BaseStream.Position;
                data.Unk_202_raw = reader.ReadSingle();
                data.Unk_203_offset = reader.BaseStream.Position;
                data.Unk_203_raw = reader.ReadSingle();
                data.Unk_204_offset = reader.BaseStream.Position;
                data.Unk_204_raw = reader.ReadSingle();
                data.Unk_205_offset = reader.BaseStream.Position;
                data.Unk_205_raw = reader.ReadSingle();
                data.Unk_206_offset = reader.BaseStream.Position;
                data.Unk_206_raw = reader.ReadSingle();
                data.Unk_207_offset = reader.BaseStream.Position;
                data.Unk_207_raw = reader.ReadSingle();
                data.Unk_208_offset = reader.BaseStream.Position;
                data.Unk_208_raw = reader.ReadSingle();
                data.Unk_209_offset = reader.BaseStream.Position;
                data.Unk_209_raw = reader.ReadSingle();
                data.Unk_210_offset = reader.BaseStream.Position;
                data.Unk_210_raw = reader.ReadSingle();
                data.Unk_211_offset = reader.BaseStream.Position;
                data.Unk_211_raw = reader.ReadSingle();
                data.Unk_212_offset = reader.BaseStream.Position;
                data.Unk_212_raw = reader.ReadSingle();
                data.Unk_213_offset = reader.BaseStream.Position;
                data.Unk_213_raw = reader.ReadSingle();
                data.Unk_214_offset = reader.BaseStream.Position;
                data.Unk_214_raw = reader.ReadSingle();
                data.Unk_215_offset = reader.BaseStream.Position;
                data.Unk_215_raw = reader.ReadSingle();
                data.Unk_216_offset = reader.BaseStream.Position;
                data.Unk_216_raw = reader.ReadSingle();
                data.Unk_217_offset = reader.BaseStream.Position;
                data.Unk_217_raw = reader.ReadSingle();
                data.Unk_218_offset = reader.BaseStream.Position;
                data.Unk_218_raw = reader.ReadSingle();
                data.Unk_219_offset = reader.BaseStream.Position;
                data.Unk_219_raw = reader.ReadSingle();
                data.Unk_220_offset = reader.BaseStream.Position;
                data.Unk_220_raw = reader.ReadSingle();
                data.Unk_221_offset = reader.BaseStream.Position;
                data.Unk_221_raw = reader.ReadSingle();
                data.Unk_222_offset = reader.BaseStream.Position;
                data.Unk_222_raw = reader.ReadSingle();
                data.Unk_223_offset = reader.BaseStream.Position;
                data.Unk_223_raw = reader.ReadSingle();
                data.Unk_224_offset = reader.BaseStream.Position;
                data.Unk_224_raw = reader.ReadSingle();
                data.Unk_225_offset = reader.BaseStream.Position;
                data.Unk_225_raw = reader.ReadSingle();
                data.Unk_226_offset = reader.BaseStream.Position;
                data.Unk_226_raw = reader.ReadSingle();
                data.Unk_227_offset = reader.BaseStream.Position;
                data.Unk_227_raw = reader.ReadSingle();
                data.Unk_228_offset = reader.BaseStream.Position;
                data.Unk_228_raw = reader.ReadSingle();
                data.Unk_229_offset = reader.BaseStream.Position;
                data.Unk_229_raw = reader.ReadSingle();
                data.Unk_230_offset = reader.BaseStream.Position;
                data.Unk_230_raw = reader.ReadSingle();
                data.Unk_231_offset = reader.BaseStream.Position;
                data.Unk_231_raw = reader.ReadSingle();
                data.Unk_232_offset = reader.BaseStream.Position;
                data.Unk_232_raw = reader.ReadSingle();
                data.Unk_233_offset = reader.BaseStream.Position;
                data.Unk_233_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_106_raw);
                writer.Write(Unk_107_raw);
                writer.Write(Unk_108_raw);
                writer.Write(Unk_109_raw);
                writer.Write(Unk_110_raw);
                writer.Write(Unk_111_raw);
                writer.Write(Unk_112_raw);
                writer.Write(Unk_113_raw);
                writer.Write(Unk_114_raw);
                writer.Write(Unk_115_raw);
                writer.Write(Unk_116_raw);
                writer.Write(Unk_117_raw);
                writer.Write(Unk_118_raw);
                writer.Write(Unk_119_raw);
                writer.Write(Unk_120_raw);
                writer.Write(Unk_121_raw);
                writer.Write(Unk_122_raw);
                writer.Write(Unk_123_raw);
                writer.Write(Unk_124_raw);
                writer.Write(Unk_125_raw);
                writer.Write(Unk_126_raw);
                writer.Write(Unk_127_raw);
                writer.Write(Unk_128_raw);
                writer.Write(Unk_129_raw);
                writer.Write(Unk_130_raw);
                writer.Write(Unk_131_raw);
                writer.Write(Unk_132_raw);
                writer.Write(Unk_133_raw);
                writer.Write(Unk_134_raw);
                writer.Write(Unk_135_raw);
                writer.Write(Unk_136_raw);
                writer.Write(Unk_137_raw);
                writer.Write(Unk_138_raw);
                writer.Write(Unk_139_raw);
                writer.Write(Unk_140_raw);
                writer.Write(Unk_141_raw);
                writer.Write(Unk_142_raw);
                writer.Write(Unk_143_raw);
                writer.Write(Unk_144_raw);
                writer.Write(Unk_145_raw);
                writer.Write(Unk_146_raw);
                writer.Write(Unk_147_raw);
                writer.Write(Unk_148_raw);
                writer.Write(Unk_149_raw);
                writer.Write(Unk_150_raw);
                writer.Write(Unk_151_raw);
                writer.Write(Unk_152_raw);
                writer.Write(Unk_153_raw);
                writer.Write(Unk_154_raw);
                writer.Write(Unk_155_raw);
                writer.Write(Unk_156_raw);
                writer.Write(Unk_157_raw);
                writer.Write(Unk_158_raw);
                writer.Write(Unk_159_raw);
                writer.Write(Unk_160_raw);
                writer.Write(Unk_161_raw);
                writer.Write(Unk_162_raw);
                writer.Write(Unk_163_raw);
                writer.Write(Unk_164_raw);
                writer.Write(Unk_165_raw);
                writer.Write(Unk_166_raw);
                writer.Write(Unk_167_raw);
                writer.Write(Unk_168_raw);
                writer.Write(Unk_169_raw);
                writer.Write(Unk_170_raw);
                writer.Write(Unk_171_raw);
                writer.Write(Unk_172_raw);
                writer.Write(Unk_173_raw);
                writer.Write(Unk_174_raw);
                writer.Write(Unk_175_raw);
                writer.Write(Unk_176_raw);
                writer.Write(Unk_177_raw);
                writer.Write(Unk_178_raw);
                writer.Write(Unk_179_raw);
                writer.Write(Unk_180_raw);
                writer.Write(Unk_181_raw);
                writer.Write(Unk_182_raw);
                writer.Write(Unk_183_raw);
                writer.Write(Unk_184_raw);
                writer.Write(Unk_185_raw);
                writer.Write(Unk_186_raw);
                writer.Write(Unk_187_raw);
                writer.Write(Unk_188_raw);
                writer.Write(Unk_189_raw);
                writer.Write(Unk_190_raw);
                writer.Write(Unk_191_raw);
                writer.Write(Unk_192_raw);
                writer.Write(Unk_193_raw);
                writer.Write(Unk_194_raw);
                writer.Write(Unk_195_raw);
                writer.Write(Unk_196_raw);
                writer.Write(Unk_197_raw);
                writer.Write(Unk_198_raw);
                writer.Write(Unk_199_raw);
                writer.Write(Unk_200_raw);
                writer.Write(Unk_201_raw);
                writer.Write(Unk_202_raw);
                writer.Write(Unk_203_raw);
                writer.Write(Unk_204_raw);
                writer.Write(Unk_205_raw);
                writer.Write(Unk_206_raw);
                writer.Write(Unk_207_raw);
                writer.Write(Unk_208_raw);
                writer.Write(Unk_209_raw);
                writer.Write(Unk_210_raw);
                writer.Write(Unk_211_raw);
                writer.Write(Unk_212_raw);
                writer.Write(Unk_213_raw);
                writer.Write(Unk_214_raw);
                writer.Write(Unk_215_raw);
                writer.Write(Unk_216_raw);
                writer.Write(Unk_217_raw);
                writer.Write(Unk_218_raw);
                writer.Write(Unk_219_raw);
                writer.Write(Unk_220_raw);
                writer.Write(Unk_221_raw);
                writer.Write(Unk_222_raw);
                writer.Write(Unk_223_raw);
                writer.Write(Unk_224_raw);
                writer.Write(Unk_225_raw);
                writer.Write(Unk_226_raw);
                writer.Write(Unk_227_raw);
                writer.Write(Unk_228_raw);
                writer.Write(Unk_229_raw);
                writer.Write(Unk_230_raw);
                writer.Write(Unk_231_raw);
                writer.Write(Unk_232_raw);
                writer.Write(Unk_233_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 106", "Unk_106", "Unk_106_offset"),
                    new MultiStructItemCustomView(this, "Unk 107", "Unk_107", "Unk_107_offset"),
                    new MultiStructItemCustomView(this, "Unk 108", "Unk_108", "Unk_108_offset"),
                    new MultiStructItemCustomView(this, "Unk 109", "Unk_109", "Unk_109_offset"),
                    new MultiStructItemCustomView(this, "Unk 110", "Unk_110", "Unk_110_offset"),
                    new MultiStructItemCustomView(this, "Unk 111", "Unk_111", "Unk_111_offset"),
                    new MultiStructItemCustomView(this, "Unk 112", "Unk_112", "Unk_112_offset"),
                    new MultiStructItemCustomView(this, "Unk 113", "Unk_113", "Unk_113_offset"),
                    new MultiStructItemCustomView(this, "Unk 114", "Unk_114", "Unk_114_offset"),
                    new MultiStructItemCustomView(this, "Unk 115", "Unk_115", "Unk_115_offset"),
                    new MultiStructItemCustomView(this, "Unk 116", "Unk_116", "Unk_116_offset"),
                    new MultiStructItemCustomView(this, "Unk 117", "Unk_117", "Unk_117_offset"),
                    new MultiStructItemCustomView(this, "Unk 118", "Unk_118", "Unk_118_offset"),
                    new MultiStructItemCustomView(this, "Unk 119", "Unk_119", "Unk_119_offset"),
                    new MultiStructItemCustomView(this, "Unk 120", "Unk_120", "Unk_120_offset"),
                    new MultiStructItemCustomView(this, "Unk 121", "Unk_121", "Unk_121_offset"),
                    new MultiStructItemCustomView(this, "Unk 122", "Unk_122", "Unk_122_offset"),
                    new MultiStructItemCustomView(this, "Unk 123", "Unk_123", "Unk_123_offset"),
                    new MultiStructItemCustomView(this, "Unk 124", "Unk_124", "Unk_124_offset"),
                    new MultiStructItemCustomView(this, "Unk 125", "Unk_125", "Unk_125_offset"),
                    new MultiStructItemCustomView(this, "Unk 126", "Unk_126", "Unk_126_offset"),
                    new MultiStructItemCustomView(this, "Unk 127", "Unk_127", "Unk_127_offset"),
                    new MultiStructItemCustomView(this, "Unk 128", "Unk_128", "Unk_128_offset"),
                    new MultiStructItemCustomView(this, "Unk 129", "Unk_129", "Unk_129_offset"),
                    new MultiStructItemCustomView(this, "Unk 130", "Unk_130", "Unk_130_offset"),
                    new MultiStructItemCustomView(this, "Unk 131", "Unk_131", "Unk_131_offset"),
                    new MultiStructItemCustomView(this, "Unk 132", "Unk_132", "Unk_132_offset"),
                    new MultiStructItemCustomView(this, "Unk 133", "Unk_133", "Unk_133_offset"),
                    new MultiStructItemCustomView(this, "Unk 134", "Unk_134", "Unk_134_offset"),
                    new MultiStructItemCustomView(this, "Unk 135", "Unk_135", "Unk_135_offset"),
                    new MultiStructItemCustomView(this, "Unk 136", "Unk_136", "Unk_136_offset"),
                    new MultiStructItemCustomView(this, "Unk 137", "Unk_137", "Unk_137_offset"),
                    new MultiStructItemCustomView(this, "Unk 138", "Unk_138", "Unk_138_offset"),
                    new MultiStructItemCustomView(this, "Unk 139", "Unk_139", "Unk_139_offset"),
                    new MultiStructItemCustomView(this, "Unk 140", "Unk_140", "Unk_140_offset"),
                    new MultiStructItemCustomView(this, "Unk 141", "Unk_141", "Unk_141_offset"),
                    new MultiStructItemCustomView(this, "Unk 142", "Unk_142", "Unk_142_offset"),
                    new MultiStructItemCustomView(this, "Unk 143", "Unk_143", "Unk_143_offset"),
                    new MultiStructItemCustomView(this, "Unk 144", "Unk_144", "Unk_144_offset"),
                    new MultiStructItemCustomView(this, "Unk 145", "Unk_145", "Unk_145_offset"),
                    new MultiStructItemCustomView(this, "Unk 146", "Unk_146", "Unk_146_offset"),
                    new MultiStructItemCustomView(this, "Unk 147", "Unk_147", "Unk_147_offset"),
                    new MultiStructItemCustomView(this, "Unk 148", "Unk_148", "Unk_148_offset"),
                    new MultiStructItemCustomView(this, "Unk 149", "Unk_149", "Unk_149_offset"),
                    new MultiStructItemCustomView(this, "Unk 150", "Unk_150", "Unk_150_offset"),
                    new MultiStructItemCustomView(this, "Unk 151", "Unk_151", "Unk_151_offset"),
                    new MultiStructItemCustomView(this, "Unk 152", "Unk_152", "Unk_152_offset"),
                    new MultiStructItemCustomView(this, "Unk 153", "Unk_153", "Unk_153_offset"),
                    new MultiStructItemCustomView(this, "Unk 154", "Unk_154", "Unk_154_offset"),
                    new MultiStructItemCustomView(this, "Unk 155", "Unk_155", "Unk_155_offset"),
                    new MultiStructItemCustomView(this, "Unk 156", "Unk_156", "Unk_156_offset"),
                    new MultiStructItemCustomView(this, "Unk 157", "Unk_157", "Unk_157_offset"),
                    new MultiStructItemCustomView(this, "Unk 158", "Unk_158", "Unk_158_offset"),
                    new MultiStructItemCustomView(this, "Unk 159", "Unk_159", "Unk_159_offset"),
                    new MultiStructItemCustomView(this, "Unk 160", "Unk_160", "Unk_160_offset"),
                    new MultiStructItemCustomView(this, "Unk 161", "Unk_161", "Unk_161_offset"),
                    new MultiStructItemCustomView(this, "Unk 162", "Unk_162", "Unk_162_offset"),
                    new MultiStructItemCustomView(this, "Unk 163", "Unk_163", "Unk_163_offset"),
                    new MultiStructItemCustomView(this, "Unk 164", "Unk_164", "Unk_164_offset"),
                    new MultiStructItemCustomView(this, "Unk 165", "Unk_165", "Unk_165_offset"),
                    new MultiStructItemCustomView(this, "Unk 166", "Unk_166", "Unk_166_offset"),
                    new MultiStructItemCustomView(this, "Unk 167", "Unk_167", "Unk_167_offset"),
                    new MultiStructItemCustomView(this, "Unk 168", "Unk_168", "Unk_168_offset"),
                    new MultiStructItemCustomView(this, "Unk 169", "Unk_169", "Unk_169_offset"),
                    new MultiStructItemCustomView(this, "Unk 170", "Unk_170", "Unk_170_offset"),
                    new MultiStructItemCustomView(this, "Unk 171", "Unk_171", "Unk_171_offset"),
                    new MultiStructItemCustomView(this, "Unk 172", "Unk_172", "Unk_172_offset"),
                    new MultiStructItemCustomView(this, "Unk 173", "Unk_173", "Unk_173_offset"),
                    new MultiStructItemCustomView(this, "Unk 174", "Unk_174", "Unk_174_offset"),
                    new MultiStructItemCustomView(this, "Unk 175", "Unk_175", "Unk_175_offset"),
                    new MultiStructItemCustomView(this, "Unk 176", "Unk_176", "Unk_176_offset"),
                    new MultiStructItemCustomView(this, "Unk 177", "Unk_177", "Unk_177_offset"),
                    new MultiStructItemCustomView(this, "Unk 178", "Unk_178", "Unk_178_offset"),
                    new MultiStructItemCustomView(this, "Unk 179", "Unk_179", "Unk_179_offset"),
                    new MultiStructItemCustomView(this, "Unk 180", "Unk_180", "Unk_180_offset"),
                    new MultiStructItemCustomView(this, "Unk 181", "Unk_181", "Unk_181_offset"),
                    new MultiStructItemCustomView(this, "Unk 182", "Unk_182", "Unk_182_offset"),
                    new MultiStructItemCustomView(this, "Unk 183", "Unk_183", "Unk_183_offset"),
                    new MultiStructItemCustomView(this, "Unk 184", "Unk_184", "Unk_184_offset"),
                    new MultiStructItemCustomView(this, "Unk 185", "Unk_185", "Unk_185_offset"),
                    new MultiStructItemCustomView(this, "Unk 186", "Unk_186", "Unk_186_offset"),
                    new MultiStructItemCustomView(this, "Unk 187", "Unk_187", "Unk_187_offset"),
                    new MultiStructItemCustomView(this, "Unk 188", "Unk_188", "Unk_188_offset"),
                    new MultiStructItemCustomView(this, "Unk 189", "Unk_189", "Unk_189_offset"),
                    new MultiStructItemCustomView(this, "Unk 190", "Unk_190", "Unk_190_offset"),
                    new MultiStructItemCustomView(this, "Unk 191", "Unk_191", "Unk_191_offset"),
                    new MultiStructItemCustomView(this, "Unk 192", "Unk_192", "Unk_192_offset"),
                    new MultiStructItemCustomView(this, "Unk 193", "Unk_193", "Unk_193_offset"),
                    new MultiStructItemCustomView(this, "Unk 194", "Unk_194", "Unk_194_offset"),
                    new MultiStructItemCustomView(this, "Unk 195", "Unk_195", "Unk_195_offset"),
                    new MultiStructItemCustomView(this, "Unk 196", "Unk_196", "Unk_196_offset"),
                    new MultiStructItemCustomView(this, "Unk 197", "Unk_197", "Unk_197_offset"),
                    new MultiStructItemCustomView(this, "Unk 198", "Unk_198", "Unk_198_offset"),
                    new MultiStructItemCustomView(this, "Unk 199", "Unk_199", "Unk_199_offset"),
                    new MultiStructItemCustomView(this, "Unk 200", "Unk_200", "Unk_200_offset"),
                    new MultiStructItemCustomView(this, "Unk 201", "Unk_201", "Unk_201_offset"),
                    new MultiStructItemCustomView(this, "Unk 202", "Unk_202", "Unk_202_offset"),
                    new MultiStructItemCustomView(this, "Unk 203", "Unk_203", "Unk_203_offset"),
                    new MultiStructItemCustomView(this, "Unk 204", "Unk_204", "Unk_204_offset"),
                    new MultiStructItemCustomView(this, "Unk 205", "Unk_205", "Unk_205_offset"),
                    new MultiStructItemCustomView(this, "Unk 206", "Unk_206", "Unk_206_offset"),
                    new MultiStructItemCustomView(this, "Unk 207", "Unk_207", "Unk_207_offset"),
                    new MultiStructItemCustomView(this, "Unk 208", "Unk_208", "Unk_208_offset"),
                    new MultiStructItemCustomView(this, "Unk 209", "Unk_209", "Unk_209_offset"),
                    new MultiStructItemCustomView(this, "Unk 210", "Unk_210", "Unk_210_offset"),
                    new MultiStructItemCustomView(this, "Unk 211", "Unk_211", "Unk_211_offset"),
                    new MultiStructItemCustomView(this, "Unk 212", "Unk_212", "Unk_212_offset"),
                    new MultiStructItemCustomView(this, "Unk 213", "Unk_213", "Unk_213_offset"),
                    new MultiStructItemCustomView(this, "Unk 214", "Unk_214", "Unk_214_offset"),
                    new MultiStructItemCustomView(this, "Unk 215", "Unk_215", "Unk_215_offset"),
                    new MultiStructItemCustomView(this, "Unk 216", "Unk_216", "Unk_216_offset"),
                    new MultiStructItemCustomView(this, "Unk 217", "Unk_217", "Unk_217_offset"),
                    new MultiStructItemCustomView(this, "Unk 218", "Unk_218", "Unk_218_offset"),
                    new MultiStructItemCustomView(this, "Unk 219", "Unk_219", "Unk_219_offset"),
                    new MultiStructItemCustomView(this, "Unk 220", "Unk_220", "Unk_220_offset"),
                    new MultiStructItemCustomView(this, "Unk 221", "Unk_221", "Unk_221_offset"),
                    new MultiStructItemCustomView(this, "Unk 222", "Unk_222", "Unk_222_offset"),
                    new MultiStructItemCustomView(this, "Unk 223", "Unk_223", "Unk_223_offset"),
                    new MultiStructItemCustomView(this, "Unk 224", "Unk_224", "Unk_224_offset"),
                    new MultiStructItemCustomView(this, "Unk 225", "Unk_225", "Unk_225_offset"),
                    new MultiStructItemCustomView(this, "Unk 226", "Unk_226", "Unk_226_offset"),
                    new MultiStructItemCustomView(this, "Unk 227", "Unk_227", "Unk_227_offset"),
                    new MultiStructItemCustomView(this, "Unk 228", "Unk_228", "Unk_228_offset"),
                    new MultiStructItemCustomView(this, "Unk 229", "Unk_229", "Unk_229_offset"),
                    new MultiStructItemCustomView(this, "Unk 230", "Unk_230", "Unk_230_offset"),
                    new MultiStructItemCustomView(this, "Unk 231", "Unk_231", "Unk_231_offset"),
                    new MultiStructItemCustomView(this, "Unk 232", "Unk_232", "Unk_232_offset"),
                    new MultiStructItemCustomView(this, "Unk 233", "Unk_233", "Unk_233_offset"),
                };
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var Scoutfly_Params_1__ = new MhwStructDataContainer<Scoutfly_Params_1_>(Scoutfly_Params_1_.LoadData(reader), typeof(Scoutfly_Params_1_));
            data.AddLast(Scoutfly_Params_1__);
            var Unknown_Arr_1__ = new MhwStructDataContainer<Unknown_Arr_1_>(Unknown_Arr_1_.LoadData(reader), typeof(Unknown_Arr_1_));
            data.AddLast(Unknown_Arr_1__);
            var Scoutfly_Params_2__ = new MhwStructDataContainer<Scoutfly_Params_2_>(Scoutfly_Params_2_.LoadData(reader), typeof(Scoutfly_Params_2_));
            data.AddLast(Scoutfly_Params_2__);
            var Unknown_Arr_2__ = new MhwStructDataContainer<Unknown_Arr_2_>(Unknown_Arr_2_.LoadData(reader), typeof(Unknown_Arr_2_));
            data.AddLast(Unknown_Arr_2__);
            var Scoutfly_Params_3__ = new MhwStructDataContainer<Scoutfly_Params_3_>(Scoutfly_Params_3_.LoadData(reader), typeof(Scoutfly_Params_3_));
            data.AddLast(Scoutfly_Params_3__);
        }
    }
}