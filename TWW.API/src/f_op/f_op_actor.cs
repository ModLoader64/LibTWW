namespace TWW.API
{

    public class fopAc_ac_c
    {
        [System.Text.Json.Serialization.JsonIgnore()]
        public u32 pointer;

        public fopAc_ac_c(u32 pointer)
        {
            this.pointer = pointer;
        }

        /* 0x1D0 */
        public actor_place home { get => _home(); set => _home(value); }
        /* 0x1E4 */
        public actor_place old { get => _old(); set => _old(value); }
        /* 0x1F8 */
        public actor_place current { get => _current(); set => _current(value); }
        /* 0x20C */
        public csXyz shape_angle { get => _shape_angle(); set => _shape_angle(value); }
        /* 0x214 */
        public cXyz mScale { get => _mScale(); set => _mScale(value); }
        /* 0x220 */
        public cXyz speed { get => _speed(); set => _speed(value); }
        /* 0x254 */
        public f32 speedF { get => _speedF(); set => _speedF(value); }
        /* 0x258 */
        public f32 mGravity { get => _mGravity(); set => _mGravity(value); }

        private actor_place _home()
        {
            return new actor_place(pointer + 0x1D0);
        }
        private void _home(actor_place value)
        {

        }

        private actor_place _old()
        {
            return new actor_place(pointer + 0x1E4);
        }
        private void _old(actor_place value)
        {

        }

        private actor_place _current()
        {
            return new actor_place(pointer + 0x1F8);
        }
        private void _current(actor_place value)
        {

        }

        private csXyz _shape_angle()
        {
            return new csXyz(pointer + 0x20C);
        }
        private void _shape_angle(csXyz value)
        {

        }

        private cXyz _mScale()
        {
            return new cXyz(pointer + 0x214);
        }
        private void _mScale(cXyz value)
        {

        }

        private cXyz _speed()
        {
            return new cXyz(pointer + 0x220);
        }
        private void _speed(cXyz value)
        {

        }

        private f32 _speedF()
        {
            return Memory.RAM.ReadF32(pointer + 0x254);
        }
        private void _speedF(f32 value)
        {
            Memory.RAM.WriteF32(pointer + 0x254, value);
        }

        private f32 _mGravity()
        {
            return Memory.RAM.ReadF32(pointer + 0x258);
        }
        private void _mGravity(f32 value)
        {
            Memory.RAM.WriteF32(pointer + 0x258, value);
        }
    }

    public class actor_place
    {
        public u32 pointer;

        public actor_place(u32 pointer)
        {
            this.pointer = pointer;
        }

        /* 0x00 */
        public cXyz pos { get => _pos(); set => _pos(value); }
        /* 0x0C */
        public csXyz angle { get => _angle(); set => _angle(value); }
        /* 0x12 */
        public s8 roomNo { get => _roomNo(); set => _roomNo(value); }
        /* 0x13 */
        public u8 field_0x13 { get => _field_0x13(); set => _field_0x13(value); }

        private cXyz _pos()
        {
            return new cXyz(pointer + 0x0);
        }
        private void _pos(cXyz value)
        {
        }

        private csXyz _angle()
        {
            return new csXyz(pointer + 0xC);
        }
        private void _angle(csXyz value)
        {
        }

        private s8 _roomNo()
        {
            return Memory.RAM.ReadS8(pointer + 0x12);
        }
        private void _roomNo(s8 value)
        {
            Memory.RAM.WriteS8(pointer + 0x12, value);
        }

        private u8 _field_0x13()
        {
            return Memory.RAM.ReadU8(pointer + 0x13);
        }
        private void _field_0x13(u8 value)
        {
            Memory.RAM.WriteU8(pointer + 0x13, value);
        }


    };

}
