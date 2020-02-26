using System.Collections.ObjectModel;
using MHW_Editor.Models;

namespace MHW_Editor.PlData {
    public partial class PlPlayerParam {
        public ObservableCollection<PlDataItemCustomView> GetCustomView() {
            return new ObservableCollection<PlDataItemCustomView> {
                new PlDataItemCustomView(this, "Unk1", "Unk1", Bytes, 8),
                new PlDataItemCustomView(this, "Unk2", "Unk2", Bytes, 12),
                new PlDataItemCustomView(this, "Unk3", "Unk3", Bytes, 16),
                new PlDataItemCustomView(this, "Unk4", "Unk4", Bytes, 20),
                new PlDataItemCustomView(this, "Unk5", "Unk5", Bytes, 24),
                new PlDataItemCustomView(this, "Unk6", "Unk6", Bytes, 28),
                new PlDataItemCustomView(this, "Unk7", "Unk7", Bytes, 32),
                new PlDataItemCustomView(this, "Unk8", "Unk8", Bytes, 36),
                new PlDataItemCustomView(this, "Unk9", "Unk9", Bytes, 40),
                new PlDataItemCustomView(this, "Unk10", "Unk10", Bytes, 44),
                new PlDataItemCustomView(this, "Unk11", "Unk11", Bytes, 48),
                new PlDataItemCustomView(this, "Unk12", "Unk12", Bytes, 52),
                new PlDataItemCustomView(this, "Unk13", "Unk13", Bytes, 56),
                new PlDataItemCustomView(this, "Unk14", "Unk14", Bytes, 60),
                new PlDataItemCustomView(this, "Unk15", "Unk15", Bytes, 64),
                new PlDataItemCustomView(this, "Unk16", "Unk16", Bytes, 68),
                new PlDataItemCustomView(this, "Unk17", "Unk17", Bytes, 72),
                new PlDataItemCustomView(this, "Unk18", "Unk18", Bytes, 76),
                new PlDataItemCustomView(this, "Unk19", "Unk19", Bytes, 80),
                new PlDataItemCustomView(this, "Unk20", "Unk20", Bytes, 84),
                new PlDataItemCustomView(this, "Unk21", "Unk21", Bytes, 88),
                new PlDataItemCustomView(this, "Unk22", "Unk22", Bytes, 92),
                new PlDataItemCustomView(this, "Unk23", "Unk23", Bytes, 96),
                new PlDataItemCustomView(this, "Unk24", "Unk24", Bytes, 100),
                new PlDataItemCustomView(this, "Unk25", "Unk25", Bytes, 104),
                new PlDataItemCustomView(this, "Unk26", "Unk26", Bytes, 108),
                new PlDataItemCustomView(this, "Unk27", "Unk27", Bytes, 112),
                new PlDataItemCustomView(this, "Unk28", "Unk28", Bytes, 116),
                new PlDataItemCustomView(this, "Unk29", "Unk29", Bytes, 120),
                new PlDataItemCustomView(this, "Unk30", "Unk30", Bytes, 124),
                new PlDataItemCustomView(this, "Unk31", "Unk31", Bytes, 128),
                new PlDataItemCustomView(this, "Unk32", "Unk32", Bytes, 132),
                new PlDataItemCustomView(this, "Unk33", "Unk33", Bytes, 136),
                new PlDataItemCustomView(this, "Unk34", "Unk34", Bytes, 140),
                new PlDataItemCustomView(this, "Unk35", "Unk35", Bytes, 144),
                new PlDataItemCustomView(this, "Unk36", "Unk36", Bytes, 148),
                new PlDataItemCustomView(this, "Unk37", "Unk37", Bytes, 152),
                new PlDataItemCustomView(this, "Unk38", "Unk38", Bytes, 156),
                new PlDataItemCustomView(this, "Unk39", "Unk39", Bytes, 160),
                new PlDataItemCustomView(this, "Unk40", "Unk40", Bytes, 164),
                new PlDataItemCustomView(this, "Unk41", "Unk41", Bytes, 168),
                new PlDataItemCustomView(this, "Unk42", "Unk42", Bytes, 172),
                new PlDataItemCustomView(this, "Unk43", "Unk43", Bytes, 176),
                new PlDataItemCustomView(this, "Unk44", "Unk44", Bytes, 180),
                new PlDataItemCustomView(this, "Unk45", "Unk45", Bytes, 184),
                new PlDataItemCustomView(this, "Unk46", "Unk46", Bytes, 188),
                new PlDataItemCustomView(this, "Unk47", "Unk47", Bytes, 192),
                new PlDataItemCustomView(this, "Unk48", "Unk48", Bytes, 196),
                new PlDataItemCustomView(this, "Unk49", "Unk49", Bytes, 200),
                new PlDataItemCustomView(this, "Unk50", "Unk50", Bytes, 204),
                new PlDataItemCustomView(this, "Unk51", "Unk51", Bytes, 208),
                new PlDataItemCustomView(this, "Unk52", "Unk52", Bytes, 212),
                new PlDataItemCustomView(this, "Unk53", "Unk53", Bytes, 216),
                new PlDataItemCustomView(this, "Unk54", "Unk54", Bytes, 220),
                new PlDataItemCustomView(this, "Unk55", "Unk55", Bytes, 224),
                new PlDataItemCustomView(this, "Unk56", "Unk56", Bytes, 228),
                new PlDataItemCustomView(this, "Unk57", "Unk57", Bytes, 232),
                new PlDataItemCustomView(this, "Unk58", "Unk58", Bytes, 236),
                new PlDataItemCustomView(this, "Unk59", "Unk59", Bytes, 237),
                new PlDataItemCustomView(this, "Unk60", "Unk60", Bytes, 239),
                new PlDataItemCustomView(this, "Unk61", "Unk61", Bytes, 241),
                new PlDataItemCustomView(this, "Unk62", "Unk62", Bytes, 245),
                new PlDataItemCustomView(this, "Unk63", "Unk63", Bytes, 246),
                new PlDataItemCustomView(this, "Unk64", "Unk64", Bytes, 248),
                new PlDataItemCustomView(this, "Unk65", "Unk65", Bytes, 250),
                new PlDataItemCustomView(this, "Unk66", "Unk66", Bytes, 252),
                new PlDataItemCustomView(this, "------Skipping ahead 1.", "_Skipping_ahead_1_", Bytes, 256),
                new PlDataItemCustomView(this, "Health Initial Value", "Health_Initial_Value", Bytes, 408),
                new PlDataItemCustomView(this, "Health Max Value", "Health_Max_Value", Bytes, 412),
                new PlDataItemCustomView(this, "Health Damage Recovery Rate", "Health_Damage_Recovery_Rate", Bytes, 416),
                new PlDataItemCustomView(this, "Health Damage Recovery Wait Time", "Health_Damage_Recovery_Wait_Time", Bytes, 420),
                new PlDataItemCustomView(this, "Health Damage Recovery Interval", "Health_Damage_Recovery_Interval", Bytes, 424),
                new PlDataItemCustomView(this, "Health Damage Recovery Value", "Health_Damage_Recovery_Value", Bytes, 428),
                new PlDataItemCustomView(this, "Stamina Initial Value", "Stamina_Initial_Value", Bytes, 432),
                new PlDataItemCustomView(this, "Stamina Max Value", "Stamina_Max_Value", Bytes, 436),
                new PlDataItemCustomView(this, "Stamina Min Value", "Stamina_Min_Value", Bytes, 440),
                new PlDataItemCustomView(this, "Stamina Tired Value", "Stamina_Tired_Value", Bytes, 444),
                new PlDataItemCustomView(this, "Stamina Auto Recover", "Stamina_Auto_Recover", Bytes, 448),
                new PlDataItemCustomView(this, "Stamina Auto Max Reduce", "Stamina_Auto_Max_Reduce", Bytes, 452),
                new PlDataItemCustomView(this, "Stamina Auto Max Reduce Time", "Stamina_Auto_Max_Reduce_Time", Bytes, 456),
                new PlDataItemCustomView(this, "Stamina IB Unknown", "Stamina_IB_Unknown", Bytes, 460),
                new PlDataItemCustomView(this, "Stamina Escape Dash Rate", "Stamina_Escape_Dash_Rate", Bytes, 464),
                new PlDataItemCustomView(this, "Stamina Out of Battle Rate", "Stamina_Out_of_Battle_Rate", Bytes, 468),
                new PlDataItemCustomView(this, "Stamina Reduce Rate Limit Trigger", "Stamina_Reduce_Rate_Limit_Trigger", Bytes, 472),
                new PlDataItemCustomView(this, "Stamina Reduce Rate Limit Time", "Stamina_Reduce_Rate_Limit_Time", Bytes, 476),
                new PlDataItemCustomView(this, "Stamina Mount Endurance Rate", "Stamina_Mount_Endurance_Rate", Bytes, 480),
                new PlDataItemCustomView(this, "Stamina Consumption: Dodge", "Stamina_Consumption_Dodge", Bytes, 484),
                new PlDataItemCustomView(this, "Stamina Consumption: LS Counter", "Stamina_Consumption_LS_Counter", Bytes, 488),
                new PlDataItemCustomView(this, "Stamina Consumption: Unk1", "Stamina_Consumption_Unk1", Bytes, 492),
                new PlDataItemCustomView(this, "Stamina Consumption: Unk2", "Stamina_Consumption_Unk2", Bytes, 496),
                new PlDataItemCustomView(this, "Stamina Consumption: Unk3", "Stamina_Consumption_Unk3", Bytes, 500),
                new PlDataItemCustomView(this, "Stamina Consumption: Unk4", "Stamina_Consumption_Unk4", Bytes, 504),
                new PlDataItemCustomView(this, "Stamina Consumption: Bow Shoot", "Stamina_Consumption_Bow_Shoot", Bytes, 508),
                new PlDataItemCustomView(this, "Stamina Consumption: Unk5", "Stamina_Consumption_Unk5", Bytes, 512),
                new PlDataItemCustomView(this, "Stamina Consumption: Unk6", "Stamina_Consumption_Unk6", Bytes, 516),
                new PlDataItemCustomView(this, "Stamina Consumption: Unk7", "Stamina_Consumption_Unk7", Bytes, 520),
                new PlDataItemCustomView(this, "Stamina Consumption: Bow Charge Step", "Stamina_Consumption_Bow_Charge_Step", Bytes, 524),
                new PlDataItemCustomView(this, "Stamina Consumption: Unk8", "Stamina_Consumption_Unk8", Bytes, 528),
                new PlDataItemCustomView(this, "Stamina Consumption: IB Unk9", "Stamina_Consumption_IB_Unk9", Bytes, 532),
                new PlDataItemCustomView(this, "Stamina Consumption: IB Unk10", "Stamina_Consumption_IB_Unk10", Bytes, 536),
                new PlDataItemCustomView(this, "Stamina Consumption: IB Unk11", "Stamina_Consumption_IB_Unk11", Bytes, 540),
                new PlDataItemCustomView(this, "Stamina Consumption: IB Unk12", "Stamina_Consumption_IB_Unk12", Bytes, 544),
                new PlDataItemCustomView(this, "Stamina Consumption: Unk13", "Stamina_Consumption_Unk13", Bytes, 548),
                new PlDataItemCustomView(this, "Stamina Consumption: Unk14", "Stamina_Consumption_Unk14", Bytes, 552),
                new PlDataItemCustomView(this, "Stamina Time Reduce mCore: Unk1", "Stamina_Time_Reduce_mCore_Unk1", Bytes, 556),
                new PlDataItemCustomView(this, "Stamina Time Reduce mCore: Unk2", "Stamina_Time_Reduce_mCore_Unk2", Bytes, 560),
                new PlDataItemCustomView(this, "Stamina Time Reduce mCore: Unk3", "Stamina_Time_Reduce_mCore_Unk3", Bytes, 564),
                new PlDataItemCustomView(this, "Stamina Time Reduce mCore: Unk4", "Stamina_Time_Reduce_mCore_Unk4", Bytes, 568),
                new PlDataItemCustomView(this, "Stamina Time Reduce mCore: Unk5", "Stamina_Time_Reduce_mCore_Unk5", Bytes, 572),
                new PlDataItemCustomView(this, "Stamina Time Reduce mCore: Unk6", "Stamina_Time_Reduce_mCore_Unk6", Bytes, 576),
                new PlDataItemCustomView(this, "Stamina Time Reduce mCore: Unk7", "Stamina_Time_Reduce_mCore_Unk7", Bytes, 580),
                new PlDataItemCustomView(this, "Stamina Time Reduce mCore: Unk8", "Stamina_Time_Reduce_mCore_Unk8", Bytes, 584),
                new PlDataItemCustomView(this, "Stamina Time Reduce mCore: Unk9", "Stamina_Time_Reduce_mCore_Unk9", Bytes, 588),
                new PlDataItemCustomView(this, "Stamina Time Reduce mCore: Unk10", "Stamina_Time_Reduce_mCore_Unk10", Bytes, 592),
                new PlDataItemCustomView(this, "Stamina Time Reduce mCore: Unk11", "Stamina_Time_Reduce_mCore_Unk11", Bytes, 596),
                new PlDataItemCustomView(this, "Stamina Time Reduce mCore: Unk12", "Stamina_Time_Reduce_mCore_Unk12", Bytes, 600),
                new PlDataItemCustomView(this, "Stamina Time Reduce mCore: Unk13", "Stamina_Time_Reduce_mCore_Unk13", Bytes, 604),
                new PlDataItemCustomView(this, "Stamina Time Reduce mCore: Unk14", "Stamina_Time_Reduce_mCore_Unk14", Bytes, 608),
                new PlDataItemCustomView(this, "Stamina Time Reduce mCore: Unk15", "Stamina_Time_Reduce_mCore_Unk15", Bytes, 612),
                new PlDataItemCustomView(this, "Stamina Time Reduce mCore: Unk16", "Stamina_Time_Reduce_mCore_Unk16", Bytes, 616),
                new PlDataItemCustomView(this, "Stamina Time Reduce mCore: Unk17", "Stamina_Time_Reduce_mCore_Unk17", Bytes, 620),
                new PlDataItemCustomView(this, "Stamina Time Reduce mCore: Unk18", "Stamina_Time_Reduce_mCore_Unk18", Bytes, 624),
                new PlDataItemCustomView(this, "Mount Reduce Stamina mCore: Unk1", "Mount_Reduce_Stamina_mCore_Unk1", Bytes, 628),
                new PlDataItemCustomView(this, "Mount Reduce Stamina mCore: Unk2", "Mount_Reduce_Stamina_mCore_Unk2", Bytes, 632),
                new PlDataItemCustomView(this, "Mount Life Reduce Stamina mCore: Unk1", "Mount_Life_Reduce_Stamina_mCore_Unk1", Bytes, 636),
                new PlDataItemCustomView(this, "Mount Life Reduce Stamina mCore: Unk2", "Mount_Life_Reduce_Stamina_mCore_Unk2", Bytes, 640),
                new PlDataItemCustomView(this, "Mount Life Reduce Stamina mCore: Unk3", "Mount_Life_Reduce_Stamina_mCore_Unk3", Bytes, 644),
                new PlDataItemCustomView(this, "Mount Life Reduce Stamina mCore: Unk4", "Mount_Life_Reduce_Stamina_mCore_Unk4", Bytes, 648),
                new PlDataItemCustomView(this, "Unk67", "Unk67", Bytes, 652),
                new PlDataItemCustomView(this, "Unk68", "Unk68", Bytes, 656),
                new PlDataItemCustomView(this, "Unk69", "Unk69", Bytes, 660),
                new PlDataItemCustomView(this, "Explosive HR Fixed Attack Rate", "Explosive_HR_Fixed_Attack_Rate", Bytes, 664),
                new PlDataItemCustomView(this, "Explosive MR Fixed Attack Rate", "Explosive_MR_Fixed_Attack_Rate", Bytes, 668),
                new PlDataItemCustomView(this, "Critical Attack Rate", "Critical_Attack_Rate", Bytes, 672),
                new PlDataItemCustomView(this, "Bad Critical Attack Rate", "Bad_Critical_Attack_Rate", Bytes, 676),
                new PlDataItemCustomView(this, "Sharpness Recoil Reduction %", "Sharpness_Recoil_Reduction_", Bytes, 680),
                new PlDataItemCustomView(this, "Sharpness Recoil Reduction Value", "Sharpness_Recoil_Reduction_Value", Bytes, 681),
                new PlDataItemCustomView(this, "Unk70", "Unk70", Bytes, 682),
                new PlDataItemCustomView(this, "Unk71", "Unk71", Bytes, 686),
                new PlDataItemCustomView(this, "Unk72", "Unk72", Bytes, 690),
                new PlDataItemCustomView(this, "Unk73", "Unk73", Bytes, 694),
                new PlDataItemCustomView(this, "Unk74", "Unk74", Bytes, 698),
                new PlDataItemCustomView(this, "Physical Attack Rate Limit", "Physical_Attack_Rate_Limit", Bytes, 702),
                new PlDataItemCustomView(this, "Elemental Attack Rate Limit", "Elemental_Attack_Rate_Limit", Bytes, 706),
                new PlDataItemCustomView(this, "Condition Attack Flat Limit", "Condition_Attack_Flat_Limit", Bytes, 710),
                new PlDataItemCustomView(this, "Bowgun Elemental Attack Rate Limit", "Bowgun_Elemental_Attack_Rate_Limit", Bytes, 714),
                new PlDataItemCustomView(this, "Condition Attack Rate Limit", "Condition_Attack_Rate_Limit", Bytes, 718),
                new PlDataItemCustomView(this, "Stun Attack Rate Limit", "Stun_Attack_Rate_Limit", Bytes, 722),
                new PlDataItemCustomView(this, "Stamina Attack Rate Limit", "Stamina_Attack_Rate_Limit", Bytes, 726),
                new PlDataItemCustomView(this, "Mount Attack Rate Limit", "Mount_Attack_Rate_Limit", Bytes, 730),
                new PlDataItemCustomView(this, "Super Armor Stun Damage Rate", "Super_Armor_Stun_Damage_Rate", Bytes, 734),
                new PlDataItemCustomView(this, "Hyper Armor Damage Rate", "Hyper_Armor_Damage_Rate", Bytes, 738),
                new PlDataItemCustomView(this, "Hyper Armor Stun Damage Rate", "Hyper_Armor_Stun_Damage_Rate", Bytes, 742),
                new PlDataItemCustomView(this, "Gunner Defense Rate", "Gunner_Defense_Rate", Bytes, 746),
                new PlDataItemCustomView(this, "Gunner Elemental Resistance Bonus", "Gunner_Elemental_Resistance_Bonus", Bytes, 750),
                new PlDataItemCustomView(this, "------Skipping ahead 2.", "_Skipping_ahead_2_", Bytes, 751),
                new PlDataItemCustomView(this, "Dodge IFrames: Normal: Evasion 0", "Dodge_IFrames_Normal_Evasion_0", Bytes, 1157),
                new PlDataItemCustomView(this, "Dodge IFrames: Normal: Evasion 1", "Dodge_IFrames_Normal_Evasion_1", Bytes, 1161),
                new PlDataItemCustomView(this, "Dodge IFrames: Normal: Evasion 2", "Dodge_IFrames_Normal_Evasion_2", Bytes, 1165),
                new PlDataItemCustomView(this, "Dodge IFrames: Normal: Evasion 3", "Dodge_IFrames_Normal_Evasion_3", Bytes, 1169),
                new PlDataItemCustomView(this, "Dodge IFrames: Normal: Evasion 4", "Dodge_IFrames_Normal_Evasion_4", Bytes, 1173),
                new PlDataItemCustomView(this, "Dodge IFrames: Normal: Evasion 5", "Dodge_IFrames_Normal_Evasion_5", Bytes, 1177),
                new PlDataItemCustomView(this, "Dodge IFrames: Normal: Evasion Mantle", "Dodge_IFrames_Normal_Evasion_Mantle", Bytes, 1181),
                new PlDataItemCustomView(this, "Dodge IFrames: Step: Evasion 0", "Dodge_IFrames_Step_Evasion_0", Bytes, 1185),
                new PlDataItemCustomView(this, "Dodge IFrames: Step: Evasion 1", "Dodge_IFrames_Step_Evasion_1", Bytes, 1189),
                new PlDataItemCustomView(this, "Dodge IFrames: Step: Evasion 2", "Dodge_IFrames_Step_Evasion_2", Bytes, 1193),
                new PlDataItemCustomView(this, "Dodge IFrames: Step: Evasion 3", "Dodge_IFrames_Step_Evasion_3", Bytes, 1197),
                new PlDataItemCustomView(this, "Dodge IFrames: Step: Evasion 4", "Dodge_IFrames_Step_Evasion_4", Bytes, 1201),
                new PlDataItemCustomView(this, "Dodge IFrames: Step: Evasion 5", "Dodge_IFrames_Step_Evasion_5", Bytes, 1205),
                new PlDataItemCustomView(this, "Dodge IFrames: Step: Evasion Mantle", "Dodge_IFrames_Step_Evasion_Mantle", Bytes, 1209),
                new PlDataItemCustomView(this, "Dodge IFrames: Sword & Shield Back Step: Evasion 0", "Dodge_IFrames_Sword_Shield_Back_Step_Evasion_0", Bytes, 1213),
                new PlDataItemCustomView(this, "Dodge IFrames: Sword & Shield Back Step: Evasion 1", "Dodge_IFrames_Sword_Shield_Back_Step_Evasion_1", Bytes, 1217),
                new PlDataItemCustomView(this, "Dodge IFrames: Sword & Shield Back Step: Evasion 2", "Dodge_IFrames_Sword_Shield_Back_Step_Evasion_2", Bytes, 1221),
                new PlDataItemCustomView(this, "Dodge IFrames: Sword & Shield Back Step: Evasion 3", "Dodge_IFrames_Sword_Shield_Back_Step_Evasion_3", Bytes, 1225),
                new PlDataItemCustomView(this, "Dodge IFrames: Sword & Shield Back Step: Evasion 4", "Dodge_IFrames_Sword_Shield_Back_Step_Evasion_4", Bytes, 1229),
                new PlDataItemCustomView(this, "Dodge IFrames: Sword & Shield Back Step: Evasion 5", "Dodge_IFrames_Sword_Shield_Back_Step_Evasion_5", Bytes, 1233),
                new PlDataItemCustomView(this, "Dodge IFrames: Sword & Shield Back Step: Evasion Mantle", "Dodge_IFrames_Sword_Shield_Back_Step_Evasion_Mantle", Bytes, 1237),
                new PlDataItemCustomView(this, "Dodge IFrames: Dual Blades DemonMode Step: Evasion 0", "Dodge_IFrames_Dual_Blades_DemonMode_Step_Evasion_0", Bytes, 1241),
                new PlDataItemCustomView(this, "Dodge IFrames: Dual Blades DemonMode Step: Evasion 1", "Dodge_IFrames_Dual_Blades_DemonMode_Step_Evasion_1", Bytes, 1245),
                new PlDataItemCustomView(this, "Dodge IFrames: Dual Blades DemonMode Step: Evasion 2", "Dodge_IFrames_Dual_Blades_DemonMode_Step_Evasion_2", Bytes, 1249),
                new PlDataItemCustomView(this, "Dodge IFrames: Dual Blades DemonMode Step: Evasion 3", "Dodge_IFrames_Dual_Blades_DemonMode_Step_Evasion_3", Bytes, 1253),
                new PlDataItemCustomView(this, "Dodge IFrames: Dual Blades DemonMode Step: Evasion 4", "Dodge_IFrames_Dual_Blades_DemonMode_Step_Evasion_4", Bytes, 1257),
                new PlDataItemCustomView(this, "Dodge IFrames: Dual Blades DemonMode Step: Evasion 5", "Dodge_IFrames_Dual_Blades_DemonMode_Step_Evasion_5", Bytes, 1261),
                new PlDataItemCustomView(this, "Dodge IFrames: Dual Blades DemonMode Step: Evasion Mantle", "Dodge_IFrames_Dual_Blades_DemonMode_Step_Evasion_Mantle", Bytes, 1265),
                new PlDataItemCustomView(this, "Dodge IFrames: Long Sword Counter: Evasion 0", "Dodge_IFrames_Long_Sword_Counter_Evasion_0", Bytes, 1269),
                new PlDataItemCustomView(this, "Dodge IFrames: Long Sword Counter: Evasion 1", "Dodge_IFrames_Long_Sword_Counter_Evasion_1", Bytes, 1273),
                new PlDataItemCustomView(this, "Dodge IFrames: Long Sword Counter: Evasion 2", "Dodge_IFrames_Long_Sword_Counter_Evasion_2", Bytes, 1277),
                new PlDataItemCustomView(this, "Dodge IFrames: Long Sword Counter: Evasion 3", "Dodge_IFrames_Long_Sword_Counter_Evasion_3", Bytes, 1281),
                new PlDataItemCustomView(this, "Dodge IFrames: Long Sword Counter: Evasion 4", "Dodge_IFrames_Long_Sword_Counter_Evasion_4", Bytes, 1285),
                new PlDataItemCustomView(this, "Dodge IFrames: Long Sword Counter: Evasion 5", "Dodge_IFrames_Long_Sword_Counter_Evasion_5", Bytes, 1289),
                new PlDataItemCustomView(this, "Dodge IFrames: Long Sword Counter: Evasion Mantle", "Dodge_IFrames_Long_Sword_Counter_Evasion_Mantle", Bytes, 1293),
                new PlDataItemCustomView(this, "Dodge IFrames: Bow Charge Step: Evasion 0", "Dodge_IFrames_Bow_Charge_Step_Evasion_0", Bytes, 1297),
                new PlDataItemCustomView(this, "Dodge IFrames: Bow Charge Step: Evasion 1", "Dodge_IFrames_Bow_Charge_Step_Evasion_1", Bytes, 1301),
                new PlDataItemCustomView(this, "Dodge IFrames: Bow Charge Step: Evasion 2", "Dodge_IFrames_Bow_Charge_Step_Evasion_2", Bytes, 1305),
                new PlDataItemCustomView(this, "Dodge IFrames: Bow Charge Step: Evasion 3", "Dodge_IFrames_Bow_Charge_Step_Evasion_3", Bytes, 1309),
                new PlDataItemCustomView(this, "Dodge IFrames: Bow Charge Step: Evasion 4", "Dodge_IFrames_Bow_Charge_Step_Evasion_4", Bytes, 1313),
                new PlDataItemCustomView(this, "Dodge IFrames: Bow Charge Step: Evasion 5", "Dodge_IFrames_Bow_Charge_Step_Evasion_5", Bytes, 1317),
                new PlDataItemCustomView(this, "Dodge IFrames: Bow Charge Step: Evasion Mantle", "Dodge_IFrames_Bow_Charge_Step_Evasion_Mantle", Bytes, 1321),
                new PlDataItemCustomView(this, "Dodge IFrames: HBG Roll Dodge: Evasion 0", "Dodge_IFrames_HBG_Roll_Dodge_Evasion_0", Bytes, 1325),
                new PlDataItemCustomView(this, "Dodge IFrames: HBG Roll Dodge: Evasion 1", "Dodge_IFrames_HBG_Roll_Dodge_Evasion_1", Bytes, 1329),
                new PlDataItemCustomView(this, "Dodge IFrames: HBG Roll Dodge: Evasion 2", "Dodge_IFrames_HBG_Roll_Dodge_Evasion_2", Bytes, 1333),
                new PlDataItemCustomView(this, "Dodge IFrames: HBG Roll Dodge: Evasion 3", "Dodge_IFrames_HBG_Roll_Dodge_Evasion_3", Bytes, 1337),
                new PlDataItemCustomView(this, "Dodge IFrames: HBG Roll Dodge: Evasion 4", "Dodge_IFrames_HBG_Roll_Dodge_Evasion_4", Bytes, 1341),
                new PlDataItemCustomView(this, "Dodge IFrames: HBG Roll Dodge: Evasion 5", "Dodge_IFrames_HBG_Roll_Dodge_Evasion_5", Bytes, 1345),
                new PlDataItemCustomView(this, "Dodge IFrames: HBG Roll Dodge: Evasion Mantle", "Dodge_IFrames_HBG_Roll_Dodge_Evasion_Mantle", Bytes, 1349),
                new PlDataItemCustomView(this, "Dodge IFrames: LBG Side Dodge: Evasion 0", "Dodge_IFrames_LBG_Side_Dodge_Evasion_0", Bytes, 1353),
                new PlDataItemCustomView(this, "Dodge IFrames: LBG Side Dodge: Evasion 1", "Dodge_IFrames_LBG_Side_Dodge_Evasion_1", Bytes, 1357),
                new PlDataItemCustomView(this, "Dodge IFrames: LBG Side Dodge: Evasion 2", "Dodge_IFrames_LBG_Side_Dodge_Evasion_2", Bytes, 1361),
                new PlDataItemCustomView(this, "Dodge IFrames: LBG Side Dodge: Evasion 3", "Dodge_IFrames_LBG_Side_Dodge_Evasion_3", Bytes, 1365),
                new PlDataItemCustomView(this, "Dodge IFrames: LBG Side Dodge: Evasion 4", "Dodge_IFrames_LBG_Side_Dodge_Evasion_4", Bytes, 1369),
                new PlDataItemCustomView(this, "Dodge IFrames: LBG Side Dodge: Evasion 5", "Dodge_IFrames_LBG_Side_Dodge_Evasion_5", Bytes, 1373),
                new PlDataItemCustomView(this, "Dodge IFrames: LBG Side Dodge: Evasion Mantle", "Dodge_IFrames_LBG_Side_Dodge_Evasion_Mantle", Bytes, 1377),
                new PlDataItemCustomView(this, "Dodge IFrames: IB Unk1: Evasion 0", "Dodge_IFrames_IB_Unk1_Evasion_0", Bytes, 1381),
                new PlDataItemCustomView(this, "Dodge IFrames: IB Unk1: Evasion 1", "Dodge_IFrames_IB_Unk1_Evasion_1", Bytes, 1385),
                new PlDataItemCustomView(this, "Dodge IFrames: IB Unk1: Evasion 2", "Dodge_IFrames_IB_Unk1_Evasion_2", Bytes, 1389),
                new PlDataItemCustomView(this, "Dodge IFrames: IB Unk1: Evasion 3", "Dodge_IFrames_IB_Unk1_Evasion_3", Bytes, 1393),
                new PlDataItemCustomView(this, "Dodge IFrames: IB Unk1: Evasion 4", "Dodge_IFrames_IB_Unk1_Evasion_4", Bytes, 1397),
                new PlDataItemCustomView(this, "Dodge IFrames: IB Unk1: Evasion 5", "Dodge_IFrames_IB_Unk1_Evasion_5", Bytes, 1401),
                new PlDataItemCustomView(this, "Dodge IFrames: IB Unk1: Evasion Mantle", "Dodge_IFrames_IB_Unk1_Evasion_Mantle", Bytes, 1405),
                new PlDataItemCustomView(this, "Dodge IFrames: IB Unk2: Evasion 0", "Dodge_IFrames_IB_Unk2_Evasion_0", Bytes, 1409),
                new PlDataItemCustomView(this, "Dodge IFrames: IB Unk2: Evasion 1", "Dodge_IFrames_IB_Unk2_Evasion_1", Bytes, 1413),
                new PlDataItemCustomView(this, "Dodge IFrames: IB Unk2: Evasion 2", "Dodge_IFrames_IB_Unk2_Evasion_2", Bytes, 1417),
                new PlDataItemCustomView(this, "Dodge IFrames: IB Unk2: Evasion 3", "Dodge_IFrames_IB_Unk2_Evasion_3", Bytes, 1421),
                new PlDataItemCustomView(this, "Dodge IFrames: IB Unk2: Evasion 4", "Dodge_IFrames_IB_Unk2_Evasion_4", Bytes, 1425),
                new PlDataItemCustomView(this, "Dodge IFrames: IB Unk2: Evasion 5", "Dodge_IFrames_IB_Unk2_Evasion_5", Bytes, 1429),
                new PlDataItemCustomView(this, "Dodge IFrames: IB Unk2: Evasion Mantle", "Dodge_IFrames_IB_Unk2_Evasion_Mantle", Bytes, 1433),
                new PlDataItemCustomView(this, "Evade: Normal: Distance 1", "Evade_Normal_Distance_1", Bytes, 1437),
                new PlDataItemCustomView(this, "Evade: Normal: Distance 2", "Evade_Normal_Distance_2", Bytes, 1441),
                new PlDataItemCustomView(this, "Evade: Normal: Distance 3", "Evade_Normal_Distance_3", Bytes, 1445),
                new PlDataItemCustomView(this, "Evade: Step: Distance 1", "Evade_Step_Distance_1", Bytes, 1449),
                new PlDataItemCustomView(this, "Evade: Step: Distance 2", "Evade_Step_Distance_2", Bytes, 1453),
                new PlDataItemCustomView(this, "Evade: Step: Distance 3", "Evade_Step_Distance_3", Bytes, 1457),
                new PlDataItemCustomView(this, "Evade: Sword & Shield Back Step: Distance 1", "Evade_Sword_Shield_Back_Step_Distance_1", Bytes, 1461),
                new PlDataItemCustomView(this, "Evade: Sword & Shield Back Step: Distance 2", "Evade_Sword_Shield_Back_Step_Distance_2", Bytes, 1465),
                new PlDataItemCustomView(this, "Evade: Sword & Shield Back Step: Distance 3", "Evade_Sword_Shield_Back_Step_Distance_3", Bytes, 1469),
                new PlDataItemCustomView(this, "Evade: Dual Blades DemonMode Step: Distance 1", "Evade_Dual_Blades_DemonMode_Step_Distance_1", Bytes, 1473),
                new PlDataItemCustomView(this, "Evade: Dual Blades DemonMode Step: Distance 2", "Evade_Dual_Blades_DemonMode_Step_Distance_2", Bytes, 1477),
                new PlDataItemCustomView(this, "Evade: Dual Blades DemonMode Step: Distance 3", "Evade_Dual_Blades_DemonMode_Step_Distance_3", Bytes, 1481),
                new PlDataItemCustomView(this, "Evade: Long Sword Counter: Distance 1", "Evade_Long_Sword_Counter_Distance_1", Bytes, 1485),
                new PlDataItemCustomView(this, "Evade: Long Sword Counter: Distance 2", "Evade_Long_Sword_Counter_Distance_2", Bytes, 1489),
                new PlDataItemCustomView(this, "Evade: Long Sword Counter: Distance 3", "Evade_Long_Sword_Counter_Distance_3", Bytes, 1493),
                new PlDataItemCustomView(this, "Evade: Insect Glaive Air Dodge: Distance 1", "Evade_Insect_Glaive_Air_Dodge_Distance_1", Bytes, 1497),
                new PlDataItemCustomView(this, "Evade: Insect Glaive Air Dodge: Distance 2", "Evade_Insect_Glaive_Air_Dodge_Distance_2", Bytes, 1501),
                new PlDataItemCustomView(this, "Evade: Insect Glaive Air Dodge: Distance 3", "Evade_Insect_Glaive_Air_Dodge_Distance_3", Bytes, 1505),
                new PlDataItemCustomView(this, "Evade: Bow Charge Step: Distance 1", "Evade_Bow_Charge_Step_Distance_1", Bytes, 1509),
                new PlDataItemCustomView(this, "Evade: Bow Charge Step: Distance 2", "Evade_Bow_Charge_Step_Distance_2", Bytes, 1513),
                new PlDataItemCustomView(this, "Evade: Bow Charge Step: Distance 3", "Evade_Bow_Charge_Step_Distance_3", Bytes, 1517),
                new PlDataItemCustomView(this, "Evade: HBG Roll Dodge: Distance 1", "Evade_HBG_Roll_Dodge_Distance_1", Bytes, 1521),
                new PlDataItemCustomView(this, "Evade: HBG Roll Dodge: Distance 2", "Evade_HBG_Roll_Dodge_Distance_2", Bytes, 1525),
                new PlDataItemCustomView(this, "Evade: HBG Roll Dodge: Distance 3", "Evade_HBG_Roll_Dodge_Distance_3", Bytes, 1529),
                new PlDataItemCustomView(this, "Evade: LBG Side Dodge: Distance 1", "Evade_LBG_Side_Dodge_Distance_1", Bytes, 1533),
                new PlDataItemCustomView(this, "Evade: LBG Side Dodge: Distance 2", "Evade_LBG_Side_Dodge_Distance_2", Bytes, 1537),
                new PlDataItemCustomView(this, "Evade: LBG Side Dodge: Distance 3", "Evade_LBG_Side_Dodge_Distance_3", Bytes, 1541),
                new PlDataItemCustomView(this, "Evade: IB Unk1: Distance 1", "Evade_IB_Unk1_Distance_1", Bytes, 1545),
                new PlDataItemCustomView(this, "Evade: IB Unk1: Distance 2", "Evade_IB_Unk1_Distance_2", Bytes, 1549),
                new PlDataItemCustomView(this, "Evade: IB Unk1: Distance 3", "Evade_IB_Unk1_Distance_3", Bytes, 1553),
                new PlDataItemCustomView(this, "Evade: IB Unk2: Distance 1", "Evade_IB_Unk2_Distance_1", Bytes, 1557),
                new PlDataItemCustomView(this, "Evade: IB Unk2: Distance 2", "Evade_IB_Unk2_Distance_2", Bytes, 1561),
                new PlDataItemCustomView(this, "Evade: IB Unk2: Distance 3", "Evade_IB_Unk2_Distance_3", Bytes, 1565),
                new PlDataItemCustomView(this, "------Skipping ahead 3.", "_Skipping_ahead_3_", Bytes, 1569),
                new PlDataItemCustomView(this, "Wp HR Augment Attack Add (1)", "Wp_HR_Augment_Attack_Add_1_", Bytes, 8571),
                new PlDataItemCustomView(this, "Wp HR Augment Attack Add (2)", "Wp_HR_Augment_Attack_Add_2_", Bytes, 8572),
                new PlDataItemCustomView(this, "Wp HR Augment Attack Add (3)", "Wp_HR_Augment_Attack_Add_3_", Bytes, 8573),
                new PlDataItemCustomView(this, "Wp HR Augment Critical Add (1)", "Wp_HR_Augment_Critical_Add_1_", Bytes, 8574),
                new PlDataItemCustomView(this, "Wp HR Augment Critical Add (2)", "Wp_HR_Augment_Critical_Add_2_", Bytes, 8575),
                new PlDataItemCustomView(this, "Wp HR Augment Critical Add (3)", "Wp_HR_Augment_Critical_Add_3_", Bytes, 8576),
                new PlDataItemCustomView(this, "Wp HR Augment Defense Add (1)", "Wp_HR_Augment_Defense_Add_1_", Bytes, 8577),
                new PlDataItemCustomView(this, "Wp HR Augment Defense Add (2)", "Wp_HR_Augment_Defense_Add_2_", Bytes, 8578),
                new PlDataItemCustomView(this, "Wp HR Augment Defense Add (3)", "Wp_HR_Augment_Defense_Add_3_", Bytes, 8579),
                new PlDataItemCustomView(this, "Wp HR Augment Divine Blessing Chance (1)", "Wp_HR_Augment_Divine_Blessing_Chance_1_", Bytes, 8580),
                new PlDataItemCustomView(this, "Wp HR Augment Divine Blessing Chance (2)", "Wp_HR_Augment_Divine_Blessing_Chance_2_", Bytes, 8581),
                new PlDataItemCustomView(this, "Wp HR Augment Divine Blessing Chance (3)", "Wp_HR_Augment_Divine_Blessing_Chance_3_", Bytes, 8582),
                new PlDataItemCustomView(this, "Wp HR Augment Divine Blessing Reduction (1)", "Wp_HR_Augment_Divine_Blessing_Reduction_1_", Bytes, 8583),
                new PlDataItemCustomView(this, "Wp HR Augment Divine Blessing Reduction (2)", "Wp_HR_Augment_Divine_Blessing_Reduction_2_", Bytes, 8587),
                new PlDataItemCustomView(this, "Wp HR Augment Divine Blessing Reduction (3)", "Wp_HR_Augment_Divine_Blessing_Reduction_3_", Bytes, 8591),
                new PlDataItemCustomView(this, "Wp HR Augment Defense Heal Damage Rate (1)", "Wp_HR_Augment_Defense_Heal_Damage_Rate_1_", Bytes, 8595),
                new PlDataItemCustomView(this, "Wp HR Augment Defense Heal Damage Rate (2)", "Wp_HR_Augment_Defense_Heal_Damage_Rate_2_", Bytes, 8599),
                new PlDataItemCustomView(this, "Wp HR Augment Defense Heal Damage Rate (3)", "Wp_HR_Augment_Defense_Heal_Damage_Rate_3_", Bytes, 8603),
                new PlDataItemCustomView(this, "Wp HR Augment IB Unk", "Wp_HR_Augment_IB_Unk", Bytes, 8607),
                new PlDataItemCustomView(this, "Wp HR Augment Lifesteal Cooldown", "Wp_HR_Augment_Lifesteal_Cooldown", Bytes, 8611),
                new PlDataItemCustomView(this, "Wp MR Augment Attack (1)", "Wp_MR_Augment_Attack_1_", Bytes, 8615),
                new PlDataItemCustomView(this, "Wp MR Augment Attack (2)", "Wp_MR_Augment_Attack_2_", Bytes, 8616),
                new PlDataItemCustomView(this, "Wp MR Augment Attack (3)", "Wp_MR_Augment_Attack_3_", Bytes, 8617),
                new PlDataItemCustomView(this, "Wp MR Augment Attack (4)", "Wp_MR_Augment_Attack_4_", Bytes, 8618),
                new PlDataItemCustomView(this, "Wp MR Augment Critical (1)", "Wp_MR_Augment_Critical_1_", Bytes, 8619),
                new PlDataItemCustomView(this, "Wp MR Augment Critical (2)", "Wp_MR_Augment_Critical_2_", Bytes, 8620),
                new PlDataItemCustomView(this, "Wp MR Augment Critical (3)", "Wp_MR_Augment_Critical_3_", Bytes, 8621),
                new PlDataItemCustomView(this, "Wp MR Augment Critical (4)", "Wp_MR_Augment_Critical_4_", Bytes, 8622),
                new PlDataItemCustomView(this, "Wp MR Augment Defense (1)", "Wp_MR_Augment_Defense_1_", Bytes, 8623),
                new PlDataItemCustomView(this, "Wp MR Augment Defense (2)", "Wp_MR_Augment_Defense_2_", Bytes, 8624),
                new PlDataItemCustomView(this, "Wp MR Augment Defense (3)", "Wp_MR_Augment_Defense_3_", Bytes, 8625),
                new PlDataItemCustomView(this, "Wp MR Augment Defense (4)", "Wp_MR_Augment_Defense_4_", Bytes, 8626),
                new PlDataItemCustomView(this, "IB Unk1", "IB_Unk1", Bytes, 8627),
                new PlDataItemCustomView(this, "IB Unk2", "IB_Unk2", Bytes, 8628),
                new PlDataItemCustomView(this, "IB Unk3", "IB_Unk3", Bytes, 8629),
                new PlDataItemCustomView(this, "IB Unk4", "IB_Unk4", Bytes, 8630),
                new PlDataItemCustomView(this, "Wp MR Augment Defense Percent Reduction (1)", "Wp_MR_Augment_Defense_Percent_Reduction_1_", Bytes, 8631),
                new PlDataItemCustomView(this, "Wp MR Augment Defense Percent Reduction (2)", "Wp_MR_Augment_Defense_Percent_Reduction_2_", Bytes, 8635),
                new PlDataItemCustomView(this, "Wp MR Augment Defense Percent Reduction (3)", "Wp_MR_Augment_Defense_Percent_Reduction_3_", Bytes, 8639),
                new PlDataItemCustomView(this, "Wp MR Augment Defense Percent Activation", "Wp_MR_Augment_Defense_Percent_Activation", Bytes, 8643),
                new PlDataItemCustomView(this, "Wp MR Augment Health Percent (1)", "Wp_MR_Augment_Health_Percent_1_", Bytes, 8647),
                new PlDataItemCustomView(this, "Wp MR Augment Health Percent (2)", "Wp_MR_Augment_Health_Percent_2_", Bytes, 8651),
                new PlDataItemCustomView(this, "Wp MR Augment Health Percent (3)", "Wp_MR_Augment_Health_Percent_3_", Bytes, 8655),
                new PlDataItemCustomView(this, "Wp MR Augment Health Percent (4)", "Wp_MR_Augment_Health_Percent_4_", Bytes, 8659),
                new PlDataItemCustomView(this, "IB Unk5", "IB_Unk5", Bytes, 8663),
                new PlDataItemCustomView(this, "Wp MR Augment Lifesteal Cooldown", "Wp_MR_Augment_Lifesteal_Cooldown", Bytes, 8667),
                new PlDataItemCustomView(this, "Wp MR Augment Element (1)", "Wp_MR_Augment_Element_1_", Bytes, 8671),
                new PlDataItemCustomView(this, "Wp MR Augment Element (2)", "Wp_MR_Augment_Element_2_", Bytes, 8672),
                new PlDataItemCustomView(this, "Wp MR Augment Element (3)", "Wp_MR_Augment_Element_3_", Bytes, 8673),
                new PlDataItemCustomView(this, "Wp MR Augment Element (4)", "Wp_MR_Augment_Element_4_", Bytes, 8674),
            };
        }
    }
}