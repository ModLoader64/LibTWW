namespace WW.API
{
    public class dComIfG_inf_c
    {
        [System.Text.Json.Serialization.JsonIgnore()]
        public u32 pointer;

        public dComIfG_inf_c(u32 pointer)
        {
            this.pointer = pointer;
        }

        /* 0x00000 */
        public dSv_info_c save { get => _save(); set => _save(value); }

        /* 0x012A0 */
        public dComIfG_play_c play { get => _play(); set => _play(value); }

        private dSv_info_c _save()
        {
            return new dSv_info_c(pointer + 0x0);
        }
        private void _save(dSv_info_c value)
        {
        }

        private dComIfG_play_c _play()
        {
            return new dComIfG_play_c(pointer + 0x012A0);
        }
        private void _play(dComIfG_play_c value)
        {
        }

    }

    public class dComIfG_play_c
    {
        [System.Text.Json.Serialization.JsonIgnore()]
        public u32 pointer;

        public dComIfG_play_c(u32 pointer)
        {
            this.pointer = pointer;
        }

        // TODO: Gonna cherry pick some stuff, do the rest of the classes later

        /* 0x48A4 #ARRCOUNT 1*/
        public daPy_py_c[] mpPlayer { get => _mpPlayer(); set => _mpPlayer(value); }

        /* 0x48AC #ARRCOUNT 3*/
        public fopAc_ac_c[] mpPlayerPtr { get => _mpPlayerPtr(); set => _mpPlayerPtr(value); }

        /* 0x48C0 */
        public int mItemRupeeCount { get; set; }

        /* 0x48D4 */
        public s16 mItemKeyNumCount { get; set; }

        /* 0x48D6 */
        public s16 mItemMaxLifeCount { get; set; }

        /* 0x48D8 */
        public s16 mItemMagicCount { get; set; }

        /* 0x48DC */
        public s16 mItemMaxMagicCount { get; set; }

        /* 0x48E0 */
        public s16 mItemArrowNumCount { get; set; }

        /* 0x48E4 */
        public s16 mItemBombNumCount { get; set; }

        /* 0x48E8 */ /* #ARRCOUNT 8 */
        public s16[] mItemBeastNumCounts { get; set; }

        /* 0x4924 */
        public s16 mCurrHP { get; set; }

        /* 0x4926 */
        public s16 mRupyCountDisplay { get; set; }

        /* 0x492E */
        public u8 mCurrButtonBAction { get; set; }

        /* 0x4933 */ /* #ARRCOUNT 4 */
        public u8[] mSelectItem { get; set; }

        /* 0x4937 */ /* #ARRCOUNT 4 */
        public u8[] mSelectEquip { get; set; }

        /* 0x493D */
        public u8 mItemSlot { get; set; }

        /* 0x493E */
        public u8 mItemNo { get; set; }

        /* 0x4950 */
        public u8 mMelodyNum { get; set; }

        /* 0x495E */
        public u8 mPictureStatus { get; set; }

        private daPy_py_c[] _mpPlayer()
        {
            daPy_py_c[] mpPlayer = new daPy_py_c[1];
            for(int i = 0; i < 1; i++)
            {
                mpPlayer[i] = new daPy_py_c(Memory.RAM.ReadU32((u32)(pointer + 0x48A4 + (i * 4))));
            }
            return mpPlayer;
        }
        private void _mpPlayer(daPy_py_c[] value)
        {

        }

        private fopAc_ac_c[] _mpPlayerPtr()
        {
            fopAc_ac_c[] mpPlayerPtr = new daPy_py_c[3];
            for (int i = 0; i < 3; i++)
            {
                mpPlayerPtr[i] = new fopAc_ac_c(Memory.RAM.ReadU32((u32)(pointer + 0x48AC + (i * 4))));
            }
            return mpPlayerPtr;
        }
        private void _mpPlayerPtr(fopAc_ac_c[] value)
        {

        }

    }
}
