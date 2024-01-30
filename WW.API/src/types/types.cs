namespace WW.API
{
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

    public class csXyz
    {
        public u32 pointer;
        public csXyz(u32 pointer)
        {
            this.pointer = pointer;
        }

        public s16 x { get => _x(); set => _x(value); }
        public s16 y { get => _y(); set => _y(value); }
        public s16 z { get => _z(); set => _z(value); }

        private s16 _x()
        {
            return Memory.RAM.ReadS16(pointer + 0x0);
        }
        private void _x(s16 value)
        {
            Memory.RAM.WriteS16(pointer + 0x0, value);
        }

        private s16 _y()
        {
            return Memory.RAM.ReadS16(pointer + 0x4);
        }
        private void _y(s16 value)
        {
            Memory.RAM.WriteS16(pointer + 0x4, value);
        }

        private s16 _z()
        {
            return Memory.RAM.ReadS16(pointer + 0x8);
        }
        private void _z(s16 value)
        {
            Memory.RAM.WriteS16(pointer + 0x8, value);
        }
    }
}
