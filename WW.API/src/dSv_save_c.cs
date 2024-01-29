namespace WW.API.src
{
    public class dSv_save_c
    {
        public u32 pointer;

        public dSv_save_c(u32 pointer)
        {
            this.pointer = pointer;
        }

        /* 0x0000 */ public dSv_player_c mPlayer { get => _mPlayer(); set => _mPlayer(value); }

        private dSv_player_c _mPlayer()
        {
            return new dSv_player_c(pointer);
        }

        private void _mPlayer(dSv_player_c value)
        {

        }

    }

}
