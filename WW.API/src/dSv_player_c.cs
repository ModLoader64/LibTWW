using Newtonsoft.Json.Linq;

namespace WW.API.src
{

    public class dSv_player_c
    {
        public u32 pointer;

        public dSv_player_c(u32 pointer)
        {
            this.pointer = pointer;
        }

        /* 0x000 */
        public dSv_player_status_a_c mPlayerStatusA { get => _mPlayerStatusA(); set => _mPlayerStatusA(value); }
        /* 0x018 */
        public dSv_player_status_b_c mPlayerStatusB { get => _mPlayerStatusB(); set => _mPlayerStatusB(value); }
        /* 0x030 */
        public dSv_player_return_place_c mReturnPlace { get => _mReturnPlace(); set => _mReturnPlace(value); }
        /* 0x03C */
        public dSv_player_item_c mPlayerItem { get => _mPlayerItem(); set => _mPlayerItem(value); }
        /* 0x051 */
        public dSv_player_get_item_c mGetItem { get => _mGetItem(); set => _mGetItem(value); }
        /* 0x066 */
        public dSv_player_item_record_c mItemRecord { get => _mItemRecord(); set => _mItemRecord(value); }
        /* 0x06E */
        public dSv_player_item_max_c mItemMax { get => _mItemMax(); set => _mItemMax(value); }
        /* 0x076 */
        public dSv_player_bag_item_c mBagItem { get => _mBagItem(); set => _mBagItem(value); }
        /* 0x08E */
        public u16 padding_0x8E { get => _padding_0x8E(); set => _padding_0x8E(value); } /* 2 bytes of alignment padding */
        /* 0x090 */
        public dSv_player_get_bag_item_c mGetBagItem { get => _mGetBagItem(); set => _mGetBagItem(value); }
        /* 0x09C */
        public dSv_player_bag_item_record_c mBagItemRecord { get => _mBagItemRecord(); set => _mBagItemRecord(value); }
        /* 0x0B4 */
        public dSv_player_collect_c mCollect { get => _mCollect(); set => _mCollect(value); }
        /* 0x0C1 */
        public u8[] padding_0xC1 { get => _padding_0xC1(); set => _padding_0xC1(value); } /* 3 bytes of alignment padding */
        /* 0x0C4 */
        public dSv_player_map_c mMap { get => _mMap(); set => _mMap(value); }
        /* 0x148 */
        public dSv_player_info_c mInfo { get => _mInfo(); set => _mInfo(value); }
        /* 0x1A4 */
        public dSv_player_config_c mConfig { get => _mConfig(); set => _mConfig(value); }
        /* 0x1A9 */
        public u8[] padding_0x1A9 { get => _padding_0x1A9(); set => _padding_0x1A9(value); } /* 3 bytes of alignment padding */
        /* 0x1AC */
        public dSv_player_priest_c mPriest { get => _mPriest(); set => _mPriest(value); }
        /* 0x1BC */
        public dSv_player_status_c_c[] mStatusC { get => _mStatusC(); set => _mStatusC(value); }

        private dSv_player_status_a_c _mPlayerStatusA()
        {
            return new dSv_player_status_a_c(pointer + 0x00);
        }
        private void _mPlayerStatusA(dSv_player_status_a_c value)
        {
        }

        private dSv_player_status_b_c _mPlayerStatusB()
        {
            return new dSv_player_status_b_c(pointer + 0x18);
        }
        private void _mPlayerStatusB(dSv_player_status_b_c value)
        {
        }

        private dSv_player_return_place_c _mReturnPlace()
        {
            return new dSv_player_return_place_c(pointer + 0x30);
        }
        private void _mReturnPlace(dSv_player_return_place_c value)
        {
        }

        private dSv_player_item_c _mPlayerItem()
        {
            return new dSv_player_item_c(pointer + 0x3C);
        }
        private void _mPlayerItem(dSv_player_item_c value)
        {
        }

        private dSv_player_get_item_c _mGetItem()
        {
            return new dSv_player_get_item_c(pointer + 0x51);
        }
        private void _mGetItem(dSv_player_get_item_c value)
        {
        }

        private dSv_player_item_record_c _mItemRecord()
        {
            return new dSv_player_item_record_c(pointer + 0x66);
        }
        private void _mItemRecord(dSv_player_item_record_c value)
        {
        }

        private dSv_player_item_max_c _mItemMax()
        {
            return new dSv_player_item_max_c(pointer + 0x6E);
        }
        private void _mItemMax(dSv_player_item_max_c value)
        {
        }

        private dSv_player_bag_item_c _mBagItem()
        {
            return new dSv_player_bag_item_c(pointer + 0x76);
        }
        private void _mBagItem(dSv_player_bag_item_c value)
        {
        }

        // #ARRCOUNT 3
        private u8[] _padding_0xC1()
        {
            u8[] bytes = new u8[3]; for (u32 i = 0; i < 3; i++) { bytes[i] = Memory.RAM.ReadU8(this.pointer + 0xC1 + (i * 1)); }
            return bytes;
        }
        private void _padding_0xC1(u8[] value)
        {
            for (u32 i = 0; i < 3; i++) { Memory.RAM.WriteU8(this.pointer + 0xC1 + (i * 1), value[i]); }
        }

        private dSv_player_get_bag_item_c _mGetBagItem()
        {
            return new dSv_player_get_bag_item_c(pointer + 0x90);
        }
        private void _mGetBagItem(dSv_player_get_bag_item_c value)
        {
        }

        private dSv_player_bag_item_record_c _mBagItemRecord()
        {
            return new dSv_player_bag_item_record_c(pointer + 0x9C);
        }
        private void _mBagItemRecord(dSv_player_bag_item_record_c value)
        {
        }

        private dSv_player_collect_c _mCollect()
        {
            return new dSv_player_collect_c(pointer + 0xB4);
        }
        private void _mCollect(dSv_player_collect_c value)
        {
        }

        private u16 _padding_0x8E()
        {
            return Memory.RAM.ReadU16(pointer + 0x8E);
        }
        private void _padding_0x8E(u16 value)
        {
            Memory.RAM.WriteU16(pointer + 0x8E, value);
        }

        private dSv_player_map_c _mMap()
        {
            return new dSv_player_map_c(pointer + 0xC4);
        }
        private void _mMap(dSv_player_map_c value)
        {
        }

        private dSv_player_info_c _mInfo()
        {
            return new dSv_player_info_c(pointer + 0x148);
        }
        private void _mInfo(dSv_player_info_c value)
        {
        }

        private dSv_player_config_c _mConfig()
        {
            return new dSv_player_config_c(pointer + 0x1A4);
        }
        private void _mConfig(dSv_player_config_c value)
        {
        }

        // #ARRCOUNT 3
        private u8[] _padding_0x1A9()
        {
            u8[] bytes = new u8[3]; for (u32 i = 0; i < 3; i++) { bytes[i] = Memory.RAM.ReadU8(this.pointer + 0x1A9 + (i * 1)); }
            return bytes;
        }
        private void _padding_0x1A9(u8[] value)
        {
            for (u32 i = 0; i < 3; i++) { Memory.RAM.WriteU8(this.pointer + 0x1A9 + (i * 1), value[i]); }
        }

        private dSv_player_priest_c _mPriest()
        {
            return new dSv_player_priest_c(pointer + 0x1AC);
        }
        private void _mPriest(dSv_player_priest_c value)
        {
        }

        // #ARRCOUNT 4
        private dSv_player_status_c_c[] _mStatusC()
        {
            dSv_player_status_c_c[] substructs = new dSv_player_status_c_c[4]; for (u32 i = 0; i < 124; i++) { substructs[i] = new dSv_player_status_c_c(this.pointer + 0x00D4 + (i * dSv_player_status_c_c.getSize())); };
            return substructs;
        }
        private void _mStatusC(dSv_player_status_c_c[] value)
        {
        }

        private u32 _padding_0x37C()
        {
            return Memory.RAM.ReadU32(pointer + 0x37C);
        }
        private void _padding_0x37C(u32 value)
        {
            Memory.RAM.WriteU32(pointer + 0x37C, value);
        }
    }

    public class dSv_player_status_a_c
    {
        public u32 pointer;
        public dSv_player_status_a_c(u32 pointer)
        {
            this.pointer = pointer;
        }

        /* 0x00 */
        public u16 mMaxLife { get => this._mMaxLife(); set => _mMaxLife(value); }
        /* 0x02 */
        public u16 mLife { get => this._mLife(); set => _mLife(value); }
        /* 0x04 */
        public u16 mRupee { get => this._mRupee(); set => _mRupee(value); }
        /* 0x06 */
        public u16 field_0x6 { get => this._field_0x6(); set => _field_0x6(value); }
        /* 0x08 */
        public u8 field_0x8 { get => this._field_0x8(); set => _field_0x8(value); }
        /* 0x09 */
        public u8[] mSelectItem { get => this._mSelectItem(); set => _mSelectItem(value); }
        /* 0x0E */
        public u8[] mSelectEquip { get => this._mSelectEquip(); set => _mSelectEquip(value); }
        /* 0x12 */
        public u8 mWalletSize { get => this._mWalletSize(); set => _mWalletSize(value); }
        /* 0x13 */
        public u8 mMaxMagic { get => this._mMaxMagic(); set => _mMaxMagic(value); }
        /* 0x14 */
        public u8 mMagic { get => this._mMagic(); set => _mMagic(value); }
        /* 0x15 */
        public u8 field_0x15 { get => this._field_0x15(); set => _field_0x15(value); }
        /* 0x16 */
        public u8 field_0x16 { get => this._field_0x16(); set => _field_0x16(value); }
        /* 0x17 */
        public u8 padding_0x17 { get => this._padding_0x17(); set => _padding_0x17(value); }

        private u16 _mMaxLife()
        {
            return Memory.RAM.ReadU16(pointer + 0x0);
        }
        private void _mMaxLife(u16 value)
        {
            Memory.RAM.WriteU16(pointer + 0x0, value);
        }

        private u16 _mLife()
        {
            return Memory.RAM.ReadU16(pointer + 0x2);
        }
        private void _mLife(u16 value)
        {
            Memory.RAM.WriteU16(pointer + 0x2, value);
        }

        private u16 _mRupee()
        {
            return Memory.RAM.ReadU16(pointer + 0x4);
        }
        private void _mRupee(u16 value)
        {
            Memory.RAM.WriteU16(pointer + 0x4, value);
        }

        private u16 _field_0x6()
        {
            return Memory.RAM.ReadU16(pointer + 0x6);
        }
        private void _field_0x6(u16 value)
        {
            Memory.RAM.WriteU16(pointer + 0x6, value);
        }

        private u8 _field_0x8()
        {
            return Memory.RAM.ReadU8(pointer + 0x8);
        }
        private void _field_0x8(u8 value)
        {
            Memory.RAM.WriteU8(pointer + 0x8, value);
        }

        // #ARRCOUNT 5
        private u8[] _mSelectItem()
        {
            u8[] bytes = new u8[5]; for (u32 i = 0; i < 5; i++) { bytes[i] = Memory.RAM.ReadU8(this.pointer + 0x9 + (i * 1)); }
            return bytes;
        }
        private void _mSelectItem(u8[] value)
        {
            for (u32 i = 0; i < 5; i++) { Memory.RAM.WriteU8(this.pointer + 0x9 + (i * 1), value[i]); }
        }

        // #ARRCOUNT 4
        private u8[] _mSelectEquip()
        {
            u8[] bytes = new u8[4]; for (u32 i = 0; i < 4; i++) { bytes[i] = Memory.RAM.ReadU8(this.pointer + 0xE + (i * 1)); }
            return bytes;
        }
        private void _mSelectEquip(u8[] value)
        {
            for (u32 i = 0; i < 4; i++) { Memory.RAM.WriteU8(this.pointer + 0xE + (i * 1), value[i]); }
        }

        private u8 _mWalletSize()
        {
            return Memory.RAM.ReadU8(pointer + 0x12);
        }
        private void _mWalletSize(u8 value)
        {
            Memory.RAM.WriteU8(pointer + 0x12, value);
        }

        private u8 _mMaxMagic()
        {
            return Memory.RAM.ReadU8(pointer + 0x13);
        }
        private void _mMaxMagic(u8 value)
        {
            Memory.RAM.WriteU8(pointer + 0x13, value);
        }

        private u8 _mMagic()
        {
            return Memory.RAM.ReadU8(pointer + 0x14);
        }
        private void _mMagic(u8 value)
        {
            Memory.RAM.WriteU8(pointer + 0x14, value);
        }

        private u8 _field_0x15()
        {
            return Memory.RAM.ReadU8(pointer + 0x15);
        }
        private void _field_0x15(u8 value)
        {
            Memory.RAM.WriteU8(pointer + 0x15, value);
        }

        private u8 _field_0x16()
        {
            return Memory.RAM.ReadU8(pointer + 0x16);
        }
        private void _field_0x16(u8 value)
        {
            Memory.RAM.WriteU8(pointer + 0x16, value);
        }

        private u8 _padding_0x17()
        {
            return Memory.RAM.ReadU8(pointer + 0x17);
        }
        private void _padding_0x17(u8 value)
        {
            Memory.RAM.WriteU8(pointer + 0x17, value);
        }


    } // Size: 0x18

    public class dSv_player_status_b_c
    {
        public u32 pointer;
        public dSv_player_status_b_c(u32 pointer)
        {
            this.pointer = pointer;
        }

        public uint getSize()
        {
            return 0x18;
        }

        public u64 mDateIPL { get => _mDateIPL(); set => _mDateIPL(value); }
        public f32 field_0x8 { get => _field_0x8(); set => _field_0x8(value); }
        public f32 mTime { get => _mTime(); set => _mTime(value); }
        public u16 mDate { get => _mDate(); set => _mDate(value); }
        public s16 mTactWindAngleX { get => _mTactWindAngleX(); set => _mTactWindAngleX(value); }
        public s16 mTactWindAngleY { get => _mTactWindAngleY(); set => _mTactWindAngleY(value); }
        public u16 padding_0x16 { get => _padding_0x16(); set => _padding_0x16(value); }

        private u64 _mDateIPL()
        {
            return Memory.RAM.ReadU64(pointer + 0x0);
        }
        private void _mDateIPL(u64 value)
        {
            Memory.RAM.WriteU64(pointer + 0x0, value);
        }

        private f32 _field_0x8()
        {
            return Memory.RAM.ReadF32(pointer + 0x8);
        }
        private void _field_0x8(f32 value)
        {
            Memory.RAM.WriteF32(pointer + 0x8, value);
        }

        private f32 _mTime()
        {
            return Memory.RAM.ReadF32(pointer + 0xC);
        }
        private void _mTime(f32 value)
        {
            Memory.RAM.WriteF32(pointer + 0xC, value);
        }

        private u16 _mDate()
        {
            return Memory.RAM.ReadU16(pointer + 0x10);
        }
        private void _mDate(u16 value)
        {
            Memory.RAM.WriteU16(pointer + 0x10, value);
        }

        private s16 _mTactWindAngleX()
        {
            return Memory.RAM.ReadS16(pointer + 0x12);
        }
        private void _mTactWindAngleX(s16 value)
        {
            Memory.RAM.WriteS16(pointer + 0x12, value);
        }

        private s16 _mTactWindAngleY()
        {
            return Memory.RAM.ReadS16(pointer + 0x14);
        }
        private void _mTactWindAngleY(s16 value)
        {
            Memory.RAM.WriteS16(pointer + 0x14, value);
        }

        private u16 _padding_0x16()
        {
            return Memory.RAM.ReadU16(pointer + 0x16);
        }
        private void _padding_0x16(u16 value)
        {
            Memory.RAM.WriteU16(pointer + 0x16, value);
        }
    }

    public class dSv_player_return_place_c
    {
        public u32 pointer;
        public dSv_player_return_place_c(u32 pointer)
        {
            this.pointer = pointer;
        }

        public char[] mName { get => _mName(); set => _mName(value); }
        public s8 mRoomNo { get => _mRoomNo(); set => _mRoomNo(value); }
        public u8 mPoint { get => _mPoint(); set => _mPoint(value); }
        public u8 unk_0xa { get => _unk_0xa(); set => _unk_0xa(value); }
        public u8 unk_0xb { get => _unk_0xb(); set => _unk_0xb(value); }

        public uint getSize()
        {
            return 0xC;
        }

        // #ARRCOUNT 8
        private char[] _mName()
        {
            char[] bytes = new char[8]; for (u32 i = 0; i < 8; i++) { bytes[i] = (char)Memory.RAM.ReadU8(this.pointer + 0x0 + (i * 1)); }
            return bytes;
        }
        private void _mName(char[] value)
        {
            for (u32 i = 0; i < 8; i++) { Memory.RAM.WriteU8(this.pointer + 0x0 + (i * 1), (u8)value[i]); }
        }

        private s8 _mRoomNo()
        {
            return Memory.RAM.ReadS8(pointer + 0x8);
        }
        private void _mRoomNo(s8 value)
        {
            Memory.RAM.WriteS8(pointer + 0x8, value);
        }

        private u8 _mPoint()
        {
            return Memory.RAM.ReadU8(pointer + 0x9);
        }
        private void _mPoint(u8 value)
        {
            Memory.RAM.WriteU8(pointer + 0x9, value);
        }

        private u8 _unk_0xa()
        {
            return Memory.RAM.ReadU8(pointer + 0xA);
        }
        private void _unk_0xa(u8 value)
        {
            Memory.RAM.WriteU8(pointer + 0xA, value);
        }

        private u8 _unk_0xb()
        {
            return Memory.RAM.ReadU8(pointer + 0xB);
        }
        private void _unk_0xb(u8 value)
        {
            Memory.RAM.WriteU8(pointer + 0xB, value);
        }


    }

    public class dSv_player_item_c
    {
        public u32 pointer;
        public dSv_player_item_c(u32 pointer)
        {
            this.pointer = pointer;
        }

        public uint getSize()
        {
            return 0x15;
        }

        public u8[] mItems { get => _mItems(); set => _mItems(value); }

        // #ARRCOUNT 21
        private u8[] _mItems()
        {
            u8[] bytes = new u8[21]; for (u32 i = 0; i < 21; i++) { bytes[i] = Memory.RAM.ReadU8(this.pointer + 0x0 + (i * 1)); }
            return bytes;
        }
        private void _mItems(u8[] value)
        {
            for (u32 i = 0; i < 21; i++) { Memory.RAM.WriteU8(this.pointer + 0x0 + (i * 1), value[i]); }
        }
    }

    public class dSv_player_get_item_c
    {
        public u32 pointer;
        public dSv_player_get_item_c(u32 pointer)
        {
            this.pointer = pointer;
        }

        public uint getSize()
        {
            return 0x15;
        }

        public u8[] mItemFlags { get => _mItemFlags(); set => _mItemFlags(value); }

        // #ARRCOUNT 21
        private u8[] _mItemFlags()
        {
            u8[] bytes = new u8[21]; for (u32 i = 0; i < 21; i++) { bytes[i] = Memory.RAM.ReadU8(this.pointer + 0x0 + (i * 1)); }
            return bytes;
        }
        private void _mItemFlags(u8[] value)
        {
            for (u32 i = 0; i < 21; i++) { Memory.RAM.WriteU8(this.pointer + 0x0 + (i * 1), value[i]); }
        }
    }

    public class dSv_player_item_record_c
    {
        public u32 pointer;
        public dSv_player_item_record_c(u32 pointer)
        {
            this.pointer = pointer;
        }

        public uint getSize()
        {
            return 0x8;
        }

        public u16 mTimer { get => _mTimer(); set => _mTimer(value); }
        public dSv_player_item_record2_c mItemRecord2 { get => _mItemRecord2(); set => _mItemRecord2(value); }
        public u8[] mBottleNum { get => _mBottleNum(); set => _mBottleNum(value); }

        private u16 _mTimer()
        {
            return Memory.RAM.ReadU16(pointer + 0x0);
        }
        private void _mTimer(u16 value)
        {
            Memory.RAM.WriteU16(pointer + 0x0, value);
        }

        private dSv_player_item_record2_c _mItemRecord2()
        {
            return new dSv_player_item_record2_c(pointer + 0x2);
        }
        private void _mItemRecord2(dSv_player_item_record2_c value)
        {
        }

        // #ARRCOUNT 3
        private u8[] _mBottleNum()
        {
            u8[] bytes = new u8[3]; for (u32 i = 0; i < 3; i++) { bytes[i] = Memory.RAM.ReadU8(this.pointer + 0x5 + (i * 1)); }
            return bytes;
        }
        private void _mBottleNum(u8[] value)
        {
            for (u32 i = 0; i < 3; i++) { Memory.RAM.WriteU8(this.pointer + 0x5 + (i * 1), value[i]); }
        }
    }

    public class dSv_player_item_max_c
    {
        public u32 pointer;
        public dSv_player_item_max_c(u32 pointer)
        {
            this.pointer = pointer;
        }

        public uint getSize()
        {
            return 0x8;
        }

        public dSv_player_item_max2_c mItemMax2 { get => _mItemMax2(); set => _mItemMax2(value); }
        public u8[] field_0x3 { get => _field_0x3(); set => _field_0x3(value); }

        private dSv_player_item_max2_c _mItemMax2() 
        {
            return new dSv_player_item_max2_c(pointer + 0x0);
        }
        private void _mItemMax2(dSv_player_item_max2_c value)
        {
        }

        // #ARRCOUNT 5
        private u8[] _field_0x3()
        {
            u8[] bytes = new u8[5]; for (u32 i = 0; i < 5; i++) { bytes[i] = Memory.RAM.ReadU8(this.pointer + 0x3 + (i * 1)); }
            return bytes;
        }
        private void _field_0x3(u8[] value)
        {
            for (u32 i = 0; i < 5; i++) { Memory.RAM.WriteU8(this.pointer + 0x3 + (i * 1), value[i]); }
        }

    }

    public class dSv_player_bag_item_c
    {
        public u32 pointer;
        public dSv_player_bag_item_c(u32 pointer)
        {
            this.pointer = pointer;
        }

        public uint getSize()
        {
            return 0x18;
        }

        public u8[] mBeast { get => _mBeast(); set => _mBeast(value); }
        public u8[] mBait { get => _mBait(); set => _mBait(value); }
        public u8[] mReserve { get => _mReserve(); set => _mReserve(value); }

        // #ARRCOUNT 8
        private u8[] _mBeast()
        {
            u8[] bytes = new u8[8]; for (u32 i = 0; i < 8; i++) { bytes[i] = Memory.RAM.ReadU8(this.pointer + 0x0 + (i * 1)); }
            return bytes;
        }
        private void _mBeast(u8[] value)
        {
            for (u32 i = 0; i < 8; i++) { Memory.RAM.WriteU8(this.pointer + 0x0 + (i * 1), value[i]); }
        }

        // #ARRCOUNT 8
        private u8[] _mBait()
        {
            u8[] bytes = new u8[8]; for (u32 i = 0; i < 8; i++) { bytes[i] = Memory.RAM.ReadU8(this.pointer + 0x80 + (i * 1)); }
            return bytes;
        }
        private void _mBait(u8[] value)
        {
            for (u32 i = 0; i < 8; i++) { Memory.RAM.WriteU8(this.pointer + 0x8 + (i * 1), value[i]); }
        }

        // #ARRCOUNT 8
        private u8[] _mReserve()
        {
            u8[] bytes = new u8[8]; for (u32 i = 0; i < 8; i++) { bytes[i] = Memory.RAM.ReadU8(this.pointer + 0x10 + (i * 1)); }
            return bytes;
        }
        private void _mReserve(u8[] value)
        {
            for (u32 i = 0; i < 8; i++) { Memory.RAM.WriteU8(this.pointer + 0x10 + (i * 1), value[i]); }
        }
    }

    public class dSv_player_get_bag_item_c
    {
        public u32 pointer;
        public dSv_player_get_bag_item_c(u32 pointer)
        {
            this.pointer = pointer;
        }

        public static uint getSize()
        {
            return 0xC;
        }

        public u32 mReserveFlags { get => _mReserveFlags(); set => _mReserveFlags(value); }
        public u8 mBeastFlags { get => _mBeastFlags(); set => _mBeastFlags(value); }
        public u8 mBaitFlags { get => _mBaitFlags(); set => _mBaitFlags(value); }
        public u8[] unk_0x6 { get => _unk_0x6(); set => _unk_0x6(value); }

        private u32 _mReserveFlags()
        {
            return Memory.RAM.ReadU32(pointer + 0x0);
        }
        private void _mReserveFlags(u32 value)
        {
            Memory.RAM.WriteU32(pointer + 0x0, value);
        }

        private u8 _mBeastFlags()
        {
            return Memory.RAM.ReadU8(pointer + 0x4);
        }
        private void _mBeastFlags(u8 value)
        {
            Memory.RAM.WriteU8(pointer + 0x4, value);
        }

        private u8 _mBaitFlags()
        {
            return Memory.RAM.ReadU8(pointer + 0x5);
        }
        private void _mBaitFlags(u8 value)
        {
            Memory.RAM.WriteU8(pointer + 0x5, value);
        }

        // #ARRCOUNT 6
        private u8[] _unk_0x6()
        {
            u8[] bytes = new u8[6]; for (u32 i = 0; i < 6; i++) { bytes[i] = Memory.RAM.ReadU8(this.pointer + 0x6 + (i * 1)); }
            return bytes;
        }
        private void _unk_0x6(u8[] value)
        {
            for (u32 i = 0; i < 6; i++) { Memory.RAM.WriteU8(this.pointer + 0x6 + (i * 1), value[i]); }
        }
    }

    public class dSv_player_bag_item_record_c
    {
        public u32 pointer;
        public dSv_player_bag_item_record_c(u32 pointer)
        {
            this.pointer = pointer;
        }

        public uint getSize()
        {
            return 0x18;

        }
        public u8[] mBeastNum { get => _mBeastNum(); set => _mBeastNum(value); }
        public u8[] mBaitNum { get => _mBaitNum(); set => _mBaitNum(value); }
        public u8[] mReserveNum { get => _mReserveNum(); set => _mReserveNum(value); }

        // #ARRCOUNT 8
        private u8[] _mBeastNum()
        {
            u8[] bytes = new u8[8]; for (u32 i = 0; i < 8; i++) { bytes[i] = Memory.RAM.ReadU8(this.pointer + 0x0 + (i * 1)); }
            return bytes;
        }
        private void _mBeastNum(u8[] value)
        {
            for (u32 i = 0; i < 8; i++) { Memory.RAM.WriteU8(this.pointer + 0x0 + (i * 1), value[i]); }
        }

        // #ARRCOUNT 8
        private u8[] _mBaitNum()
        {
            u8[] bytes = new u8[8]; for (u32 i = 0; i < 8; i++) { bytes[i] = Memory.RAM.ReadU8(this.pointer + 0x80 + (i * 1)); }
            return bytes;
        }
        private void _mBaitNum(u8[] value)
        {
            for (u32 i = 0; i < 8; i++) { Memory.RAM.WriteU8(this.pointer + 0x8 + (i * 1), value[i]); }
        }

        // #ARRCOUNT 8
        private u8[] _mReserveNum()
        {
            u8[] bytes = new u8[8]; for (u32 i = 0; i < 8; i++) { bytes[i] = Memory.RAM.ReadU8(this.pointer + 0x10 + (i * 1)); }
            return bytes;
        }
        private void _mReserveNum(u8[] value)
        {
            for (u32 i = 0; i < 8; i++) { Memory.RAM.WriteU8(this.pointer + 0x10 + (i * 1), value[i]); }
        }
    }

    public class dSv_player_collect_c
    {
        public u32 pointer;
        public dSv_player_collect_c(u32 pointer)
        {
            this.pointer = pointer;
        }

        public uint getSize()
        {
            return 0xD;
        }
        
        public u8[] mCollect { get => _mCollect(); set => _mCollect(value); }
        public u8 field_0x8 { get => _field_0x8(); set => _field_0x8(value); }
        public u8 mTact { get => _mTact(); set => _mTact(value); }
        public u8 mTriforce { get => _mTriforce(); set => _mTriforce(value); }
        public u8 mSymbol { get => _mSymbol(); set => _mSymbol(value);  }
        public u8 field_0xc { get => _field_0xc(); set => _field_0xc(value); }

        // #ARRCOUNT 8
        private u8[] _mCollect()
        {
            u8[] bytes = new u8[8]; for (u32 i = 0; i < 8; i++) { bytes[i] = Memory.RAM.ReadU8(this.pointer + 0x0 + (i * 1)); }
            return bytes;
        }
        private void _mCollect(u8[] value)
        {
            for (u32 i = 0; i < 8; i++) { Memory.RAM.WriteU8(this.pointer + 0x0 + (i * 1), value[i]); }
        }

        private u8 _field_0x8()
        {
            return Memory.RAM.ReadU8(pointer + 0x8);
        }
        private void _field_0x8(u8 value)
        {
            Memory.RAM.WriteU8(pointer + 0x8, value);
        }

        private u8 _mTact()
        {
            return Memory.RAM.ReadU8(pointer + 0x9);
        }
        private void _mTact(u8 value)
        {
            Memory.RAM.WriteU8(pointer + 0x9, value);
        }

        private u8 _mTriforce()
        {
            return Memory.RAM.ReadU8(pointer + 0xA);
        }
        private void _mTriforce(u8 value)
        {
            Memory.RAM.WriteU8(pointer + 0xA, value);
        }

        private u8 _mSymbol()
        {
            return Memory.RAM.ReadU8(pointer + 0xB);
        }
        private void _mSymbol(u8 value)
        {
            Memory.RAM.WriteU8(pointer + 0xB, value);
        }

        private u8 _field_0xc()
        {
            return Memory.RAM.ReadU8(pointer + 0xC);
        }
        private void _field_0xc(u8 value)
        {
            Memory.RAM.WriteU8(pointer + 0xC, value);
        }

    }

    public class dSv_player_map_c
    {
        public u32 pointer;
        public dSv_player_map_c(u32 pointer)
        {
            this.pointer = pointer;
        }

        public uint getSize()
        {
            return 0x84;
        }

        public u32[][] field_0x0 { get => _field_0x0(); set => _field_0x0(value); }
        public u8[] field_0x40 { get => _field_0x40(); set => _field_0x40(value); }
        public u8[] field_0x71 { get => _field_0x71(); set => _field_0x71(value); }
        public u8 field_0x81 { get => _field_0x81(); set => _field_0x81(value); }
        public u8[] field_0x82 { get => _field_0x82(); set => _field_0x82(value); }

        // WTF am i doing. TODO: Make into a buffer
        private u32[][] _field_0x0()
        {
            u32[][] bytes = new u32[4][];
            for (u32 i = 0; i < 4; i++)
            {
                for (u32 j = 0; j < 4; j++)
                {
                    bytes[i][j] = Memory.RAM.ReadU32(this.pointer + 0x0 + ((i * 4) * j));
                }
            }
            return bytes;
        }
        private void _field_0x0(u32[][] value)
        {
            for (u32 i = 0; i < 4; i++)
            {
                for (u32 j = 0; j < 4; j++)
                {
                    Memory.RAM.WriteU32(this.pointer + 0x0 + ((i * 4) * j), value[i][j]);
                }
            }
        }

        // #ARRCOUNT 49
        private u8[] _field_0x40()
        {
            u8[] bytes = new u8[49]; for (u32 i = 0; i < 49; i++) { bytes[i] = Memory.RAM.ReadU8(this.pointer + 0x40 + (i * 1)); }
            return bytes;
        }
        private void _field_0x40(u8[] value)
        {
            for (u32 i = 0; i < 49; i++) { Memory.RAM.WriteU8(this.pointer + 0x40 + (i * 1), value[i]); }
        }

        // #ARRCOUNT 16
        private u8[] _field_0x71()
        {
            u8[] bytes = new u8[16]; for (u32 i = 0; i < 16; i++) { bytes[i] = Memory.RAM.ReadU8(this.pointer + 0x71 + (i * 1)); }
            return bytes;
        }
        private void _field_0x71(u8[] value)
        {
            for (u32 i = 0; i < 16; i++) { Memory.RAM.WriteU8(this.pointer + 0x71 + (i * 1), value[i]); }
        }

        private u8 _field_0x81()
        {
            return Memory.RAM.ReadU8(pointer + 0x81);
        }
        private void _field_0x81(u8 value)
        {
            Memory.RAM.WriteU8(pointer + 0x81, value);
        }

        // #ARRCOUNT 2
        private u8[] _field_0x82()
        {
            u8[] bytes = new u8[2]; for (u32 i = 0; i < 2; i++) { bytes[i] = Memory.RAM.ReadU8(this.pointer + 0x82 + (i * 1)); }
            return bytes;
        }
        private void _field_0x82(u8[] value)
        {
            for (u32 i = 0; i < 2; i++) { Memory.RAM.WriteU8(this.pointer + 0x82 + (i * 1), value[i]); }
        }
    }

    public class dSv_player_info_c
    {
        public u32 pointer;
        public dSv_player_info_c(u32 pointer)
        {
            this.pointer = pointer;
        }

        public uint getSize()
        {
            return 0x5C;
        }

        public u8[] field_0x0 { get => _field_0x0(); set => _field_0x0(value); }
        public u16 field_0x10 { get => _field_0x10(); set => _field_0x10(value); }
        public u16 mDeathCount { get => _mDeathCount(); set => _mDeathCount(value); }
        public char[] mPlayerName { get => _mPlayerName(); set => _mPlayerName(value); }
        public char[] field_0x25 { get => _field_0x25(); set => _field_0x25(value); }
        public char[] field_0x36 { get => _field_0x36(); set => _field_0x36(value); }
        public char[] field_0x47 { get => _field_0x47(); set => _field_0x47(value); }
        public u8 mClearCount { get => _mClearCount(); set => _mClearCount(value); }
        public u8 mRandomSalvagePoint { get => _mRandomSalvagePoint(); set => _mRandomSalvagePoint(value); }
        public u8[] field_0x05a { get => _field_0x5a(); set => _field_0x5a(value); }

        // #ARRCOUNT 10
        private u8[] _field_0x0()
        {
            u8[] bytes = new u8[10]; for (u32 i = 0; i < 10; i++) { bytes[i] = Memory.RAM.ReadU8(this.pointer + 0x0 + (i * 1)); }
            return bytes;
        }
        private void _field_0x0(u8[] value)
        {
            for (u32 i = 0; i < 10; i++) { Memory.RAM.WriteU8(this.pointer + 0x0 + (i * 1), value[i]); }
        }

        private u16 _field_0x10()
        {
            return Memory.RAM.ReadU16(pointer + 0x10);
        }
        private void _field_0x10(u16 value)
        {
            Memory.RAM.WriteU16(pointer + 0x10, value);
        }

        private u16 _mDeathCount()
        {
            return Memory.RAM.ReadU16(pointer + 0x12);
        }
        private void _mDeathCount(u16 value)
        {
            Memory.RAM.WriteU16(pointer + 0x12, value);
        }

        // #ARRCOUNT 17
        private char[] _mPlayerName()
        {
            char[] bytes = new char[17]; for (u32 i = 0; i < 17; i++) { bytes[i] = (char)Memory.RAM.ReadU8(pointer + 0x14 + (i * 1)); }
            return bytes;
        }
        private void _mPlayerName(char[] value)
        {
            for (u32 i = 0; i < 17; i++) { Memory.RAM.WriteU8(this.pointer + 0x14 + (i * 1), (u8)value[i]); }
        }

        // #ARRCOUNT 17
        private char[] _field_0x25()
        {
            char[] bytes = new char[17]; for (u32 i = 0; i < 17; i++) { bytes[i] = (char)Memory.RAM.ReadU8(pointer + 0x25 + (i * 1)); }
            return bytes;
        }
        private void _field_0x25(char[] value)
        {
            for (u32 i = 0; i < 17; i++) { Memory.RAM.WriteU8(this.pointer + 0x25 + (i * 1), (u8)value[i]); }
        }

        // #ARRCOUNT 17
        private char[] _field_0x36()
        {
            char[] bytes = new char[17]; for (u32 i = 0; i < 17; i++) { bytes[i] = (char)Memory.RAM.ReadU8(pointer + 0x36 + (i * 1)); }
            return bytes;
        }
        private void _field_0x36(char[] value)
        {
            for (u32 i = 0; i < 17; i++) { Memory.RAM.WriteU8(this.pointer + 0x36 + (i * 1), (u8)value[i]); }
        }

        // #ARRCOUNT 17
        private char[] _field_0x47()
        {
            char[] bytes = new char[17]; for (u32 i = 0; i < 17; i++) { bytes[i] = (char)Memory.RAM.ReadU8(pointer + 0x47 + (i * 1)); }
            return bytes;
        }
        private void _field_0x47(char[] value)
        {
            for (u32 i = 0; i < 17; i++) { Memory.RAM.WriteU8(this.pointer + 0x47 + (i * 1), (u8)value[i]); }
        }

        private u8 _mClearCount()
        {
            return Memory.RAM.ReadU8(pointer + 0x58);
        }
        private void _mClearCount(u8 value)
        {
            Memory.RAM.WriteU8(pointer + 0x58, value);
        }

        private u8 _mRandomSalvagePoint()
        {
            return Memory.RAM.ReadU8(pointer + 0x59);
        }
        private void _mRandomSalvagePoint(u8 value)
        {
            Memory.RAM.WriteU8(pointer + 0x59, value);
        }

        // #ARRCOUNT 2
        private u8[] _field_0x5a()
        {
            u8[] bytes = new u8[2]; for (u32 i = 0; i < 2; i++) { bytes[i] = Memory.RAM.ReadU8(pointer + 0x5a + (i * 1)); }
            return bytes;
        }
        private void _field_0x5a(u8[] value)
        {
            for (u32 i = 0; i < 2; i++) { Memory.RAM.WriteU8(this.pointer + 0x5a + (i * 1), value[i]); }
        }

    }

    public class cXyz
    {
        public u32 pointer;
        public cXyz(u32 pointer)
        {
            this.pointer = pointer;
        }

        public f32 x { get => _x(); set => _x(value); }
        public f32 y { get => _y(); set => _y(value); }
        public f32 z { get => _z(); set => _z(value); }

        private f32 _x()
        {
            return Memory.RAM.ReadF32(pointer + 0x0);
        }
        private void _x(f32 value)
        {
            Memory.RAM.WriteF32(pointer + 0x0, value);
        }

        private f32 _y()
        {
            return Memory.RAM.ReadF32(pointer + 0x4);
        }
        private void _y(f32 value)
        {
            Memory.RAM.WriteF32(pointer + 0x4, value);
        }

        private f32 _z()
        {
            return Memory.RAM.ReadF32(pointer + 0x8);
        }
        private void _z(f32 value)
        {
            Memory.RAM.WriteF32(pointer + 0x8, value);
        }
    }

    public class dSv_player_config_c
    {
        public u32 pointer;
        public dSv_player_config_c(u32 pointer)
        {
            this.pointer = pointer;
        }

        public uint getSize()
        {
            return 0x5;
        }

        public u8 mRuby { get => _mRuby(); set => _mRuby(value); }
        public u8 mSoundMode { get => _mSoundMode(); set => _mSoundMode(value); }
        public u8 mAttentionType { get => _mAttentionType(); set => _mAttentionType(value); }
        public u8 mVibration { get => _mVibration(); set => _mVibration(value); }
        public u8 field_0x4 { get => _field_0x4(); set => _field_0x4(value); }

        private u8 _mRuby()
        {
            return Memory.RAM.ReadU8(pointer + 0x0);
        }
        private void _mRuby(u8 value)
        {
            Memory.RAM.WriteU8(pointer + 0x0, value);
        }

        private u8 _mSoundMode()
        {
            return Memory.RAM.ReadU8(pointer + 0x1);
        }
        private void _mSoundMode(u8 value)
        {
            Memory.RAM.WriteU8(pointer + 0x1, value);
        }

        private u8 _mAttentionType()
        {
            return Memory.RAM.ReadU8(pointer + 0x2);
        }
        private void _mAttentionType(u8 value)
        {
            Memory.RAM.WriteU8(pointer + 0x2, value);
        }

        private u8 _mVibration()
        {
            return Memory.RAM.ReadU8(pointer + 0x3);
        }
        private void _mVibration(u8 value)
        {
            Memory.RAM.WriteU8(pointer + 0x3, value);
        }

        private u8 _field_0x4()
        {
            return Memory.RAM.ReadU8(pointer + 0x4);
        }
        private void _field_0x4(u8 value)
        {
            Memory.RAM.WriteU8(pointer + 0x4, value);
        }
    }

    public class dSv_player_priest_c
    {
        public u32 pointer;
        public dSv_player_priest_c(u32 pointer)
        {
            this.pointer = pointer;
        }

        public uint getSize()
        {
            return 0x10;
        }

        public cXyz field_0x0 { get => _field_0x0(); set => _field_0x0(value); }
        public s16 field_0xc { get => _field_0xc(); set => _field_0xc(value); }
        public s8 field_0xe { get => _field_0xe(); set => _field_0xe(value); }
        public u8 field_0xf { get => _field_0xf(); set => _field_0xf(value); }

        private cXyz _field_0x0()
        {
            return new cXyz(pointer + 0x0);
        }
        private void _field_0x0(cXyz value)
        {
        }

        public s16 _field_0xc()
        {
            return Memory.RAM.ReadS16(pointer + 0xC);
        }
        public void _field_0xc(s16 value)
        {
            Memory.RAM.WriteS16(pointer + 0xC, value);
        }

        public s8 _field_0xe()
        {
            return Memory.RAM.ReadS8(pointer + 0xC);
        }
        public void _field_0xe(s8 value)
        {
            Memory.RAM.WriteS8(pointer + 0xC, value);
        }

        public u8 _field_0xf()
        {
            return Memory.RAM.ReadU8(pointer + 0xC);
        }
        public void _field_0xf(u8 value)
        {
            Memory.RAM.WriteU8(pointer + 0xC, value);
        }
    }

    public class dSv_player_item_record2_c
    {
        public u32 pointer;
        public dSv_player_item_record2_c(u32 pointer)
        {
            this.pointer = pointer;
        }

        public u8 mPictureNum { get => _mPictureNum(); set => _mPictureNum(value); }
        public u8 mArrowNum { get => _mArrowNum(); set => _mArrowNum(value); }
        public u8 mBombNum { get => _mBombNum(); set => _mBombNum(value); }

        public static uint getSize()
        {
            return 0x3;
        }

        private u8 _mPictureNum()
        {
            return Memory.RAM.ReadU8(pointer + 0x0);
        }
        private void _mPictureNum(u8 value)
        {
            Memory.RAM.WriteU8(pointer + 0x0, value);
        }

        private u8 _mArrowNum()
        {
            return Memory.RAM.ReadU8(pointer + 0x1);
        }
        private void _mArrowNum(u8 value)
        {
            Memory.RAM.WriteU8(pointer + 0x1, value);
        }

        private u8 _mBombNum()
        {
            return Memory.RAM.ReadU8(pointer + 0x2);
        }
        private void _mBombNum(u8 value)
        {
            Memory.RAM.WriteU8(pointer + 0x2, value);
        }
    }

    public class dSv_player_item_max2_c
    {
        public u32 pointer;
        public dSv_player_item_max2_c(u32 pointer)
        {
            this.pointer = pointer;
        }

        public u8 mReserved1Num { get => _mReserved1Num(); set => _mReserved1Num(value); }
        public u8 mArrowNum { get => _mArrowNum(); set => _mArrowNum(value); }
        public u8 mBombNum { get => _mBombNum(); set => _mBombNum(value); }

        public static uint getSize()
        {
            return 0x3;
        }

        private u8 _mReserved1Num()
        {
            return Memory.RAM.ReadU8(pointer + 0x0);
        }
        private void _mReserved1Num(u8 value)
        {
            Memory.RAM.WriteU8(pointer + 0x0, value);
        }

        private u8 _mArrowNum()
        {
            return Memory.RAM.ReadU8(pointer + 0x1);
        }
        private void _mArrowNum(u8 value)
        {
            Memory.RAM.WriteU8(pointer + 0x1, value);
        }

        private u8 _mBombNum()
        {
            return Memory.RAM.ReadU8(pointer + 0x2);
        }
        private void _mBombNum(u8 value)
        {
            Memory.RAM.WriteU8(pointer + 0x2, value);
        }
    }

    public class dSv_player_status_c_c
    {
        public u32 pointer;
        public dSv_player_status_c_c(u32 pointer)
        {
            this.pointer = pointer;
        }

        /* 0x00 */
        public dSv_player_status_a_c mRecollectStatusA { get => _mRecollectStatusA(); set => _mRecollectStatusA(value); }
        /* 0x18 */
        public dSv_player_item_c mRecollectItem { get => _mRecollectItem(); set => _mRecollectItem(value); }
        /* 0x2D */
        public dSv_player_item_record2_c mRecollectItemRecord { get => _mRecollectItemRecord(); set => _mRecollectItemRecord(value); }
        /* 0x30 */
        public dSv_player_item_max2_c mRecollectItemMax { get => _mRecollectItemMax(); set => _mRecollectItemMax(value); }
        /* 0x33 */
        public dSv_player_bag_item_c mRecollectBagItem { get => _mRecollectBagItem(); set => _mRecollectBagItem(value); }
        /* 0x48 */
        public dSv_player_bag_item_record_c mRecollectBagItemRecord { get => _mRecollectBagItemRecord(); set => _mRecollectBagItemRecord(value); }
        /* 0x63 */
        public dSv_player_collect_c mRecollectCollect { get => _mRecollectCollect(); set => _mRecollectCollect(value); }

        public static uint getSize()
        {
            return 0x70;
        }

        private dSv_player_status_a_c _mRecollectStatusA() 
        {
            return new dSv_player_status_a_c(pointer + 0x0);
        }
        private void _mRecollectStatusA(dSv_player_status_a_c value)
        {
        }

        private dSv_player_item_c _mRecollectItem()
        {
            return new dSv_player_item_c(pointer + 0x18);
        }
        private void _mRecollectItem(dSv_player_item_c value)
        {
        }

        private dSv_player_item_record2_c _mRecollectItemRecord()
        {
            return new dSv_player_item_record2_c(pointer + 0x2D);
        }
        private void _mRecollectItemRecord(dSv_player_item_record2_c value)
        {
        }

        private dSv_player_item_max2_c _mRecollectItemMax()
        {
            return new dSv_player_item_max2_c(pointer + 0x30);
        }
        private void _mRecollectItemMax(dSv_player_item_max2_c value)
        {
        }

        private dSv_player_bag_item_c _mRecollectBagItem()
        {
            return new dSv_player_bag_item_c(pointer + 0x33);
        }
        private void _mRecollectBagItem(dSv_player_bag_item_c value)
        {
        }

        private dSv_player_bag_item_record_c _mRecollectBagItemRecord()
        {
            return new dSv_player_bag_item_record_c(pointer + 0x4B);
        }
        private void _mRecollectBagItemRecord(dSv_player_bag_item_record_c value)
        {
        }

        private dSv_player_collect_c _mRecollectCollect()
        {
            return new dSv_player_collect_c(pointer + 0x63);
        }
        private void _mRecollectCollect(dSv_player_collect_c value)
        {
        }

    }
    /*
        public class dSv_player_status_a_c
        {
            public u32 pointer;
            public dSv_player_status_a_c(u32 pointer)
            {
                this.pointer = pointer;
            }
        }

        public class dSv_player_status_a_c
        {
            public u32 pointer;
            public dSv_player_status_a_c(u32 pointer)
            {
                this.pointer = pointer;
            }
        }

        public class dSv_player_status_a_c
        {
            public u32 pointer;
            public dSv_player_status_a_c(u32 pointer)
            {
                this.pointer = pointer;
            }
        }

        public class dSv_player_status_a_c
        {
            public u32 pointer;
            public dSv_player_status_a_c(u32 pointer)
            {
                this.pointer = pointer;
            }
        }

        public class dSv_player_status_a_c
        {
            public u32 pointer;
            public dSv_player_status_a_c(u32 pointer)
            {
                this.pointer = pointer;
            }
        }

        public class dSv_player_status_a_c
        {
            public u32 pointer;
            public dSv_player_status_a_c(u32 pointer)
            {
                this.pointer = pointer;
            }
        }

        public class dSv_player_status_a_c
        {
            public u32 pointer;
            public dSv_player_status_a_c(u32 pointer)
            {
                this.pointer = pointer;
            }
        }

        public class dSv_player_status_a_c
        {
            public u32 pointer;
            public dSv_player_status_a_c(u32 pointer)
            {
                this.pointer = pointer;
            }
        }*/

}
