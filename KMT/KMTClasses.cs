using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KMT
{
    public enum KmtGameMode:UInt16
    {
        Miniturbo = 0x0000,
        LapRun01 = 0x0001,
        LapRun02 = 0x0002,
        Drift = 0x0003,
        ItemBox = 0x0004,
        EnemyDown01 = 0x0005,
        EnemyDown02 = 0x0006,
        EnemyDown03 = 0x0007,
        CoinGet01 = 0x0008,
        ToGate01 = 0x0009,
        RocketStart = 0x000A,
        ItemHit = 0x000B,
        Wheelie = 0x000C,
        Slipstream = 0x000D,
    }
    public enum KmtCourse:byte
    {
        MarioCircuit = 0x00,
        MooMooMeadows = 0x01,
        MushroomGorge = 0x02,
        GrumbleVolcano = 0x03,
        ToadsFactory = 0x04,
        CoconutMall = 0x05,
        DKSummit = 0x06,
        WariosGoldMine = 0x07,
        LuigiCircuit = 0x08,
        DaisyCircuit = 0x09,
        MoonviewHighway = 0x0A,
        MapleTreeway = 0x0B,
        BowsersCastle = 0x0C,
        RainbowRoad = 0x0D,
        DryDryRuins = 0x0E,
        KoopaCape = 0x0F,
        GCNPeachBeach = 0x10,
        GCNMarioCircuit = 0x11,
        GCNWaluigiStadium = 0x12,
        GCNDKMountain = 0x13,
        DSYoshiFalls = 0x14,
        DSDesertHills = 0x15,
        DSPeachGardens = 0x16,
        DSDelfinoSquare = 0x17,
        SNESMarioCircuit3 = 0x18,
        SNESGhostValley2 = 0x19,
        N64MarioRaceway = 0x1A,
        N64SherbetLand = 0x1B,
        N64BowsersCastle = 0x1C,
        N64DKJungleParkway = 0x1D,
        GBABowserCastle3 = 0x1E,
        GBAShyGuyBeach = 0x1F,
        DelfinoPier = 0x20,
        BlockPlaza = 0x21,
        ChainChompWheel = 0x22,
        FunkyStadium = 0x23,
        ThwompDesert = 0x24,
        GCNCookieLand = 0x25,
        DSTwilightHouse = 0x26,
        SNESBattleCourse4 = 0x27,
        GBABattleCourse3 = 0x28,
        N64Skyscraper = 0x29,
        Unknown0x2A = 0x2A,
        Unknown0x2B = 0x2B,
        Unknown0x2C = 0x2C,
        Unknown0x2D = 0x2D,
        Unknown0x2E = 0x2E,
        Unknown0x2F = 0x2F,
        Unknown0x30 = 0x30,
        Unknown0x31 = 0x31,
        Unknown0x32 = 0x32,
        Unknown0x33 = 0x33,
        Unknown0x34 = 0x34,
        Unknown0x35 = 0x35,
        GalaxyColosseum = 0x36,
        winingrun_demo = 0x37,
        loser_demo = 0x38,
        draw_demo = 0x39,
        ending_demo = 0x3A,
    }
    public enum KmtCharacter:byte
    {
        Mario = 0x00,
        BabyPeach = 0x01,
        Waluigi = 0x02,
        Bowser = 0x03,
        BabyDaisy = 0x04,
        DryBones = 0x05,
        BabyMario = 0x06,
        Luigi = 0x07,
        Toad = 0x08,
        DonkeyKong = 0x09,
        Yoshi = 0x0A,
        Wario = 0x0B,
        BabyLuigi = 0x0C,
        Toadette = 0x0D,
        Koopa = 0x0E,
        Daisy = 0x0F,
        Peach = 0x10,
        Birdo = 0x11,
        DiddyKong = 0x12,
        KingBoo = 0x13,
        BowserJr = 0x14,
        DryBowser = 0x15,
        FunkyKong = 0x16,
        Rosalina = 0x17,
        SMiiAM = 0x18,
        SMiiAF = 0x19,
        SMiiBM = 0x1A,
        SMiiBF = 0x1B,
        SMiiCM = 0x1C,
        SMiiCF = 0x1D,
        MMiiAM = 0x1E,
        MMiiAF = 0x1F,
        MMiiBM = 0x20,
        MMiiBF = 0x21,
        MMiiCM = 0x22,
        MMiiCF = 0x23,
        LMiiAM = 0x24,
        LMiiAF = 0x25,
        LMiiBM = 0x26,
        LMiiBF = 0x27,
        LMiiCM = 0x28,
        LMiiCF = 0x29,
        MMii = 0x2A,
        SMii = 0x2B,
        LMii = 0x2C,
    }
    public enum KmtVehicle:byte
    {
        StandardKartS = 0x00,
        StandardKartM = 0x01,
        StandardKartL = 0x02,
        BoosterSeat = 0x03,
        ClassicDragster = 0x04,
        Offroader = 0x05,
        MiniBeast = 0x06,
        WildWing = 0x07,
        FlameFlyer = 0x08,
        CheepCharger = 0x09,
        SuperBlooper = 0x0A,
        PiranhaProwler = 0x0B,
        TinyTitan = 0x0C,
        Daytripper = 0x0D,
        Jetsetter = 0x0E,
        BlueFalcon = 0x0F,
        Sprinter = 0x10,
        Honeycoupe = 0x11,
        StandardBikeS = 0x12,
        StandardBikeM = 0x13,
        StandardBikeL = 0x14,
        BulletBike = 0x15,
        MachBike = 0x16,
        FlameRunner = 0x17,
        BitBike = 0x18,
        Sugarscoot = 0x19,
        WarioBike = 0x1A,
        Quacker = 0x1B,
        ZipZip = 0x1C,
        ShootingStar = 0x1D,
        Magikruiser = 0x1E,
        Sneakster = 0x1F,
        Spear = 0x20,
        JetBubble = 0x21,
        DolphinDasher = 0x22,
        Phantom = 0x23,
    }
    public enum KmtEngineClass:byte
    {
        e50cc = 0,
        e100cc = 1,
        e150cc = 2,
        Battle = 3,
    }
    public enum KmtCameraMode:UInt16
    {
        Unknown0x0000 = 0x0000,
        Unknown0x0001 = 0x0001,
        Unknown0x0002 = 0x0002,
        Default = 0x0003,
        Unknown0x0004 = 0x0004,
        Unknown0x0005 = 0x0005,
        Unknown0x0006 = 0x0006,
        FromAbove = 0x0007,
    }
    public class KmtCPUEntry
    {
        public KmtCharacter Character { set; get; }
        public KmtVehicle Vehicle { set; get; }

        public KmtCPUEntry()
        {
            Character = KmtCharacter.Mario;
            Vehicle = KmtVehicle.StandardKartM;
        }
        public KmtCPUEntry(KmtCharacter character, KmtVehicle vehicle)
        {
            Character = character;
            Vehicle = vehicle;
        }
    }
    public class KmtCPUEntryList
    {
        private List<KmtCPUEntry> datalist;
        
        public KmtCPUEntry this[int index]
        {
            get
            {
                return datalist[index];
            }
            set
            {
                datalist[index] = value;
            }
        }
        public int Count
        {
            get
            {
                return datalist.Count;
            }
        }

        public const int MaxCount = 11;
        

        public KmtCPUEntryList()
        {
            datalist = new List<KmtCPUEntry>();
        }

        public KmtCPUEntry[] ToArray()
        {
            return datalist.ToArray();
        }
        public void Add(KmtCPUEntry item)
        {
            if (datalist.Count >= MaxCount)
            {
                throw new Exception("KmtCPUEntryList can only have 11 entries");
            }
            datalist.Add(item);
        }
        public void AddRange(KmtCPUEntry[] collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("collection", "collection is null");
            }
            else if ((datalist.Count + collection.Length) > MaxCount)
            {
                throw new Exception("KmtCPUEntryList can only have 11 entries");
            }
            datalist.AddRange(collection);
        }
        public void Insert(int index, KmtCPUEntry item)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("index", "index is less than 0");
            }
            else if (index > datalist.Count)
            {
                throw new ArgumentOutOfRangeException("index", "index is greater than Count");
            }
            else if (datalist.Count >= MaxCount)
            {
                throw new Exception("KmtCPUEntryList can only have 11 entries");
            }
            datalist.Insert(index, item);
        }
        public void InsertRange(int index, KmtCPUEntry[] collection)
        {

            if (collection == null)
            {
                throw new ArgumentNullException("collection", "collection is null");
            }
            else if (index < 0)
            {
                throw new ArgumentOutOfRangeException("index", "index is less than 0");
            }
            else if (index > datalist.Count)
            {
                throw new ArgumentOutOfRangeException("index", "index is greater than Count");
            }
            else if ((datalist.Count + collection.Length) > MaxCount)
            {
                throw new Exception("KmtCPUEntryList can only have 11 entries");
            }
            datalist.InsertRange(index, collection);
        }
        public bool Remove(KmtCPUEntry item)
        {
            return datalist.Remove(item);
        }
        public void RemoveAt(int index)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("index", "index is less than 0");
            }
            else if (index >= datalist.Count)
            {
                throw new ArgumentOutOfRangeException("index", "index is equal to or greater than Count");
            }
            datalist.RemoveAt(index);
        }
        public void RemoveRange(int index, int count)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("index", "index is less than 0");
            }
            else if (count < 0)
            {
                throw new ArgumentOutOfRangeException("count", "count is less than 0");
            }
            else if ((index + count) >= datalist.Count)
            {
                throw new ArgumentOutOfRangeException("index", "index and count do not denote a valid range of elements in the KmtCPUEntryList");
            }
            datalist.RemoveRange(index, count);
        }
        public void Clear()
        {
            datalist.Clear();
        }
        public int IndexOf(KmtCPUEntry item)
        {
            return datalist.IndexOf(item);
        }
        public int IndexOf(KmtCPUEntry item, int index)
        {
            if (index < 0 | index >= datalist.Count)
            {
                throw new ArgumentOutOfRangeException("index", "index is outside the range of valid indexes for the KmtCPUEntryList");
            }
            return datalist.IndexOf(item, index);
        }
        public int IndexOf(KmtCPUEntry item, int index, int count)
        {
            if (index < 0 | index >= datalist.Count)
            {
                throw new ArgumentOutOfRangeException("index", "is outside the range of valid indexes for the KmtCPUEntryList");
            }
            else if (count < 0)
            {
                throw new ArgumentOutOfRangeException("count", "count is less than 0");
            }
            else if ((index + count) >= datalist.Count)
            {
                throw new ArgumentOutOfRangeException("index", "index and count do not specify a valid section in the KmtCPUEntryList");
            }
            return datalist.IndexOf(item, index, count);
        }
    }
    public class KmtEntry
    {
        public UInt16 MissionRunFile { set; get; }
        public KmtGameMode GameMode { set; get; }
        public KmtCourse Course { set; get; }
        public KmtCharacter Character { set; get; }
        public KmtVehicle Vehicle { set; get; }
        public KmtEngineClass EngineClass { set; get; }
        public UInt16 TimeLimit { set; get; }
        public uint Score { set; get; }
        public KmtCameraMode CameraMode { set; get; }
        public UInt16 CannonFlag { set; get; }

        public KmtCPUEntryList CPUs { set; get; }
        
        public byte ControllerRestriction { set; get; }
        public UInt16 Minimap { set; get; }

        public KmtEntry()
        {
            MissionRunFile = 0;
            GameMode = KmtGameMode.Miniturbo;
            Course = KmtCourse.MarioCircuit;
            Character = KmtCharacter.Mario;
            Vehicle = KmtVehicle.StandardKartM;
            EngineClass = KmtEngineClass.e50cc;
            TimeLimit = 60;
            Score = 10;
            CameraMode = KmtCameraMode.Default;
            CannonFlag = 0;
            CPUs = new KmtCPUEntryList();
            ControllerRestriction = 0;
            Minimap = 0;
        }
    }
    public class KmtEntryList
    {
        private List<KmtEntry> datalist;

        public KmtEntry this[int index]
        {
            get
            {
                return datalist[index];
            }
            set
            {
                datalist[index] = value;
            }
        }
        public int Count
        {
            get
            {
                return datalist.Count;
            }
        }

        public KmtEntryList()
        {
            datalist = new List<KmtEntry>();
        }

        public KmtEntry[] ToArray()
        {
            return datalist.ToArray();
        }
        public void Add(KmtEntry item)
        {
            datalist.Add(item);
        }
        public void AddRange(KmtEntry[] collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("collection", "collection is null");
            }
            datalist.AddRange(collection);
        }
        public void Insert(int index, KmtEntry item)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("index", "index is less than 0");
            }
            else if (index > datalist.Count)
            {
                throw new ArgumentOutOfRangeException("index", "index is greater than Count");
            }
            datalist.Insert(index, item);
        }
        public void InsertRange(int index, KmtEntry[] collection)
        {

            if (collection == null)
            {
                throw new ArgumentNullException("collection", "collection is null");
            }
            else if (index < 0)
            {
                throw new ArgumentOutOfRangeException("index", "index is less than 0");
            }
            else if (index > datalist.Count)
            {
                throw new ArgumentOutOfRangeException("index", "index is greater than Count");
            }
            datalist.InsertRange(index, collection);
        }
        public bool Remove(KmtEntry item)
        {
            return datalist.Remove(item);
        }
        public void RemoveAt(int index)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("index", "index is less than 0");
            }
            else if (index >= datalist.Count)
            {
                throw new ArgumentOutOfRangeException("index", "index is equal to or greater than Count");
            }
            datalist.RemoveAt(index);
        }
        public void RemoveRange(int index, int count)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("index", "index is less than 0");
            }
            else if (count < 0)
            {
                throw new ArgumentOutOfRangeException("count", "count is less than 0");
            }
            else if ((index + count) >= datalist.Count)
            {
                throw new ArgumentOutOfRangeException("index", "index and count do not denote a valid range of elements in the KmtCPUEntryList");
            }
            datalist.RemoveRange(index, count);
        }
        public void Clear()
        {
            datalist.Clear();
        }
        public int IndexOf(KmtEntry item)
        {
            return datalist.IndexOf(item);
        }
        public int IndexOf(KmtEntry item, int index)
        {
            if (index < 0 | index >= datalist.Count)
            {
                throw new ArgumentOutOfRangeException("index", "index is outside the range of valid indexes for the KmtCPUEntryList");
            }
            return datalist.IndexOf(item, index);
        }
        public int IndexOf(KmtEntry item, int index, int count)
        {
            if (index < 0 | index >= datalist.Count)
            {
                throw new ArgumentOutOfRangeException("index", "is outside the range of valid indexes for the KmtCPUEntryList");
            }
            else if (count < 0)
            {
                throw new ArgumentOutOfRangeException("count", "count is less than 0");
            }
            else if ((index + count) >= datalist.Count)
            {
                throw new ArgumentOutOfRangeException("index", "index and count do not specify a valid section in the KmtCPUEntryList");
            }
            return datalist.IndexOf(item, index, count);
        }
    }
    public class Kmt
    {
        public KmtEntryList Entries { get; set; }

        public Kmt()
        {
            Entries = new KmtEntryList();
        }

        const uint headerlength = 0x10;
        const uint entrylength = 0x70;
        const uint CPUOffset = 0x58;
        private void load(byte[] data, string propertyname)
        {
            string NotSupportedText = String.Format(
                "{0} is in an invalid format"
                , propertyname);

            Int16 GetInt16(byte[] bbb, uint index)
            {
                byte[] bb = {
                        bbb[index + 1],
                        bbb[index]
                    };
                return BitConverter.ToInt16(bb, 0);
            }
            UInt16 GetUInt16(byte[] bbb, uint index)
            {
                byte[] bb = {
                        bbb[index + 1],
                        bbb[index]
                    };
                return BitConverter.ToUInt16(bb, 0);
            }
            UInt16 GetUInt32(byte[] bbb, uint index)
            {
                byte[] bb = {
                        bbb[index + 3],
                        bbb[index + 2],
                        bbb[index + 1],
                        bbb[index]
                    };
                return BitConverter.ToUInt16(bb, 0);
            }

            bool kill = false;

            if (data.Length < headerlength)
            {
                kill = true;
                throw new NotSupportedException(NotSupportedText);
            }

            short entrycount = 0;
            if (!kill)
            {
                uint lengthminusheader = (uint)data.Length - headerlength;
                entrycount = (short)(lengthminusheader / entrylength);

                if (lengthminusheader != (entrycount * entrylength))
                {
                    kill = true;
                    throw new NotSupportedException(NotSupportedText);
                }
            }

            int n = 0;
            while (n < entrycount & (!kill))
            {
                KmtEntry newentry = new KmtEntry();
                byte[] entry = new byte[entrylength];
                Array.Copy(data, headerlength + entrylength * n, entry, 0, entrylength);

                //Game Mode
                if (!kill)
                {
                    UInt16 gamemode = GetUInt16(entry, 0x02);
                    if (!Enum.IsDefined(typeof(KmtGameMode), gamemode))
                    {
                        kill = true;
                        throw new NotSupportedException(NotSupportedText);
                    }
                    else
                    {
                        newentry.GameMode = (KmtGameMode)gamemode;
                    }
                }

                //Course ID
                if (!kill)
                {
                    byte courseid = entry[0x04];
                    if (!Enum.IsDefined(typeof(KmtCourse), courseid))
                    {
                        kill = true;
                        throw new NotSupportedException(NotSupportedText);
                    }
                    else
                    {
                        newentry.Course = (KmtCourse)courseid;
                    }
                }
                
                //Character ID
                if (!kill)
                {
                    byte characterid = entry[0x05];
                    if (!Enum.IsDefined(typeof(KmtCharacter), characterid))
                    {
                        kill = true;
                        throw new NotSupportedException(NotSupportedText);
                    }
                    else
                    {
                        newentry.Character = (KmtCharacter)characterid;
                    }
                }
                
                //Vehicle ID
                if (!kill)
                {
                    byte vehicleid = entry[0x06];
                    if (!Enum.IsDefined(typeof(KmtVehicle), vehicleid))
                    {
                        kill = true;
                        throw new NotSupportedException(NotSupportedText);
                    }
                    else
                    {
                        newentry.Vehicle = (KmtVehicle)vehicleid;
                    }
                }
                
                //Engine Class
                if (!kill)
                {
                    byte engineclass = entry[0x07];
                    if (!Enum.IsDefined(typeof(KmtEngineClass), engineclass))
                    {
                        kill = true;
                        throw new NotSupportedException(NotSupportedText);
                    }
                    else
                    {
                        newentry.EngineClass = (KmtEngineClass)engineclass;
                    }
                }
                
                //Camera Mode
                if (!kill)
                {
                    UInt16 cameramode = GetUInt16(entry, 0x48);
                    if (!Enum.IsDefined(typeof(KmtCameraMode), cameramode))
                    {
                        kill = true;
                        throw new NotSupportedException(NotSupportedText);
                    }
                    else
                    {
                        newentry.CameraMode = (KmtCameraMode)cameramode;
                    }
                }

                //CPUs
                if (!kill)
                {
                    UInt16 cpucount = GetUInt16(entry, CPUOffset);
                    if (cpucount > 11)
                    {
                        kill = true;
                        throw new NotSupportedException(NotSupportedText);
                    }
                    else
                    {
                        int m = 0;
                        while (m < cpucount & !kill)
                        {
                            byte characterid = entry[CPUOffset + 2 + (m * 2)];
                            byte vehicleid = entry[CPUOffset + 2 + (m * 2) + 1];
                            if (!Enum.IsDefined(typeof(KmtCharacter), characterid))
                            {
                                kill = true;
                                throw new NotSupportedException(NotSupportedText);
                            }
                            else if (!Enum.IsDefined(typeof(KmtVehicle), vehicleid))
                            {
                                kill = true;
                                throw new NotSupportedException(NotSupportedText);
                            }
                            else
                            {
                                KmtCPUEntry newcpu = new KmtCPUEntry();
                                newcpu.Character = (KmtCharacter)characterid;
                                newcpu.Vehicle = (KmtVehicle)vehicleid;
                                newentry.CPUs.Add(newcpu);
                            }
                            m += 1;
                        }
                    }
                }
                
                //Everything else
                if (!kill)
                {
                    newentry.MissionRunFile = GetUInt16(entry, 0x00);
                    newentry.TimeLimit = GetUInt16(entry, 0x2C);
                    newentry.ControllerRestriction = entry[0x2F];
                    newentry.Score = GetUInt32(entry, 0x30);
                    newentry.Minimap = GetUInt16(entry, 0x4A);
                    newentry.CannonFlag = GetUInt16(entry, 0x50);
                    Entries.Add(newentry);
                }

                n += 1;
            }
        }
        private byte[] save()
        {
            byte[] NewByteArray(long length)
            {
                byte[] newbyte = new byte[length];
                for (int n = 0; n < newbyte.Length; n += 1)
                {
                    newbyte[n] = 0x00;
                }
                return newbyte;
            }

            void SetInt16(byte[] bbb, uint index, short value)
            {
                byte[] bytes = BitConverter.GetBytes(value);
                Array.Reverse(bytes);
                for (int n = 0; n < bytes.Length; n += 1)
                {
                    bbb[index + n] = bytes[n];
                }
            }
            void SetUInt16(byte[] bbb, uint index, ushort value)
            {
                byte[] bytes = BitConverter.GetBytes(value);
                Array.Reverse(bytes);
                for (int n = 0; n < bytes.Length; n += 1)
                {
                    bbb[index + n] = bytes[n];
                }
            }
            void SetUInt32(byte[] bbb, uint index, uint value)
            {
                byte[] bytes = BitConverter.GetBytes(value);
                Array.Reverse(bytes);
                for (int n = 0; n < bytes.Length; n += 1)
                {
                    bbb[index + n] = bytes[n];
                }
            }
            
            List<byte> data = new List<byte>();

            #region Header
            byte[] header = NewByteArray(headerlength);
            SetInt16(header, 0x08, (short)Entries.Count);
            data.AddRange(header);
            #endregion

            #region Entries
            for (int n = 0; n < Entries.Count; n += 1)
            {
                KmtEntry entry = Entries[n];
                byte[] newentry = NewByteArray(entrylength);
                SetUInt16(newentry, 0x00, entry.MissionRunFile);
                SetUInt16(newentry, 0x02, (ushort)entry.GameMode);
                newentry[0x04] = (byte)entry.Course;
                newentry[0x05] = (byte)entry.Character;
                newentry[0x06] = (byte)entry.Vehicle;
                newentry[0x07] = (byte)entry.EngineClass;
                SetUInt16(newentry, 0x2C, entry.TimeLimit);
                newentry[0x2F] = entry.ControllerRestriction;
                SetUInt32(newentry, 0x30, entry.Score);
                SetUInt16(newentry, 0x48, (ushort)entry.CameraMode);
                SetUInt16(newentry, 0x4A, (ushort)entry.Minimap);
                SetUInt16(newentry, 0x50, (ushort)entry.CannonFlag);
                SetUInt16(newentry, CPUOffset, (ushort)entry.CPUs.Count);
                for (int m = 0; m < entry.CPUs.Count; m += 1)
                {
                    KmtCPUEntry cpuentry = entry.CPUs[m];
                    newentry[CPUOffset + 0x02 + (m * 2)] = (byte)cpuentry.Character;
                    newentry[CPUOffset + 0x02 + (m * 2) + 1] = (byte)cpuentry.Vehicle;
                }
                data.AddRange(newentry);
            }
            #endregion

            return data.ToArray();
        }
        public void Load(byte[] data)
        {
            load(data, "data");
        }
        public void Load(string filename)
        {
            byte[] data = null;
            try
            {
                data = File.ReadAllBytes(filename);
            }
            catch (Exception ex)
            {
                Type type = ex.GetType();
                if (type == typeof(ArgumentException))
                {
                    throw new ArgumentException(ex.Message, "filename");
                }
                else if (type == typeof(ArgumentNullException))
                {
                    throw new ArgumentNullException("filename", ex.Message);
                }
                else if (type == typeof(PathTooLongException))
                {
                    throw new PathTooLongException(ex.Message);
                }
                else if (type == typeof(DirectoryNotFoundException))
                {
                    throw new DirectoryNotFoundException(ex.Message);
                }
                else if (type == typeof(IOException))
                {
                    throw new IOException(ex.Message);
                }
                else if (type == typeof(UnauthorizedAccessException))
                {
                    throw new UnauthorizedAccessException(ex.Message);
                }
                else if (type == typeof(FileNotFoundException))
                {
                    throw new FileNotFoundException(ex.Message);
                }
                else if (type == typeof(NotSupportedException))
                {
                    throw new NotSupportedException(ex.Message);
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            if (data != null)
            {
                load(data, "filename");
            }
        }
        public void Save(out byte[] data)
        {
            data = save();
        }
        public void Save(string filename)
        {
            File.WriteAllBytes(filename, save());
        }
    }
}
