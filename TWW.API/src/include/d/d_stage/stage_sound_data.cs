//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TWW.API {
    
    
    public class stage_sound_data {
        
        [System.Text.Json.Serialization.JsonIgnoreAttribute()]
        private u32 pointer;
        
        public char[] field_0x0 {get => this._field_0x0(); set => this._field_0x0(value);}//;
        
        //public Vec field_0x8 {get => this._field_0x8(); set => this._field_0x8(value);}//;
        
        public u8 field_0x14 {get => this._field_0x14(); set => this._field_0x14(value);}//;
        
        public u8 field_0x15 {get => this._field_0x15(); set => this._field_0x15(value);}//;
        
        public u8 field_0x16 {get => this._field_0x16(); set => this._field_0x16(value);}//;
        
        public u8 field_0x17 {get => this._field_0x17(); set => this._field_0x17(value);}//;
        
        public u8 field_0x18 {get => this._field_0x18(); set => this._field_0x18(value);}//;
        
        public u8 field_0x19 {get => this._field_0x19(); set => this._field_0x19(value);}//;
        
        public u8 field_0x1a {get => this._field_0x1a(); set => this._field_0x1a(value);}//;
        
        public stage_sound_data(u32 pointer) {
           this.pointer = pointer;
        }
        
        public static uint getSize() {
          return 0x1C;
        }
        
        // #ARRCOUNT 8
        private char[] _field_0x0() {
            char[] bytes = new char[8]; for(u32 i = 0; i < 8; i++){bytes[i] = (char)Memory.RAM.ReadU8(this.pointer + 0x00 + (i * 1));} return bytes;
        }
        
        private void _field_0x0(char[] value) {
            for(u32 i = 0; i < 8; i++){Memory.RAM.WriteU8(this.pointer + 0x00 + (i * 1), (u8)value[i]);}
        }
        
        /*private Vec _field_0x8() {
            return new Vec(this.pointer + 0x08);
        }
        
        private void _field_0x8(Vec value) {
        }*/
        
        private u8 _field_0x14() {
            return Memory.RAM.ReadU8(this.pointer + 0x14);
        }
        
        private void _field_0x14(u8 value) {
            Memory.RAM.WriteU8(this.pointer + 0x14, value);
        }
        
        private u8 _field_0x15() {
            return Memory.RAM.ReadU8(this.pointer + 0x15);
        }
        
        private void _field_0x15(u8 value) {
            Memory.RAM.WriteU8(this.pointer + 0x15, value);
        }
        
        private u8 _field_0x16() {
            return Memory.RAM.ReadU8(this.pointer + 0x16);
        }
        
        private void _field_0x16(u8 value) {
            Memory.RAM.WriteU8(this.pointer + 0x16, value);
        }
        
        private u8 _field_0x17() {
            return Memory.RAM.ReadU8(this.pointer + 0x17);
        }
        
        private void _field_0x17(u8 value) {
            Memory.RAM.WriteU8(this.pointer + 0x17, value);
        }
        
        private u8 _field_0x18() {
            return Memory.RAM.ReadU8(this.pointer + 0x18);
        }
        
        private void _field_0x18(u8 value) {
            Memory.RAM.WriteU8(this.pointer + 0x18, value);
        }
        
        private u8 _field_0x19() {
            return Memory.RAM.ReadU8(this.pointer + 0x19);
        }
        
        private void _field_0x19(u8 value) {
            Memory.RAM.WriteU8(this.pointer + 0x19, value);
        }
        
        private u8 _field_0x1a() {
            return Memory.RAM.ReadU8(this.pointer + 0x1A);
        }
        
        private void _field_0x1a(u8 value) {
            Memory.RAM.WriteU8(this.pointer + 0x1A, value);
        }
    }
}
