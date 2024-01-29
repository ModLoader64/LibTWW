namespace WW.API.src
{
    public class dComIfG_inf_c
    {
        [System.Text.Json.Serialization.JsonIgnore()]
        public readonly u32 pointer;

        public dComIfG_inf_c(u32 pointer)
        {
            this.pointer = pointer;
        }

        /* 0x0000 */ public dSv_info_c save { get => _save(); set => _save(value); }

        private dSv_info_c _save()
        {
            return new dSv_info_c(pointer);
        }

        private void _save(dSv_info_c value)
        {

        }
    }

}
