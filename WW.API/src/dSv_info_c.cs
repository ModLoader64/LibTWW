namespace WW.API.src
{
    public class dSv_info_c
    {
        [System.Text.Json.Serialization.JsonIgnore()]
        public readonly u32 pointer;

        public dSv_info_c(u32 pointer)
        {
            this.pointer = pointer;
        }

        /* 0x0000 */ public dSv_save_c mSavedata { get => _mSavedata(); set => _mSavedata(value); }

        private dSv_save_c _mSavedata()
        {
            return new dSv_save_c(pointer);
        }

        private void _mSavedata(dSv_save_c value)
        {

        }
    }

}
