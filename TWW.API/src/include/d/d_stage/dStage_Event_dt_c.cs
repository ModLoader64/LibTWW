//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TWW.API {
    
    
    public class dStage_Event_dt_c {
        
        [System.Text.Json.Serialization.JsonIgnoreAttribute()]
        private u32 pointer;
        
        public u8 field_0x0 {get => this._field_0x0(); set => this._field_0x0(value);}//;
        
        public char[] mName {get => this._mName(); set => this._mName(value);}//;
        
        public u8 field_0x10 {get => this._field_0x10(); set => this._field_0x10(value);}//;
        
        public u8 field_0x11 {get => this._field_0x11(); set => this._field_0x11(value);}//;
        
        public u8 field_0x12 {get => this._field_0x12(); set => this._field_0x12(value);}//;
        
        public u8 field_0x13 {get => this._field_0x13(); set => this._field_0x13(value);}//;
        
        public u8 field_0x14 {get => this._field_0x14(); set => this._field_0x14(value);}//;
        
        public u8 field_0x15 {get => this._field_0x15(); set => this._field_0x15(value);}//;
        
        public u8 field_0x16 {get => this._field_0x16(); set => this._field_0x16(value);}//;
        
        public u8 field_0x17 {get => this._field_0x17(); set => this._field_0x17(value);}//;
        
        public dStage_Event_dt_c(u32 pointer) {
           this.pointer = pointer;
        }
        
        public static uint getSize() {
          return 0x18;
        }
        
        private u8 _field_0x0() {
            return Memory.RAM.ReadU8(this.pointer + 0x00);
        }
        
        private void _field_0x0(u8 value) {
            Memory.RAM.WriteU8(this.pointer + 0x00, value);
        }
        
        // #ARRCOUNT 15
        private char[] _mName() {
            char[] bytes = new char[15]; for(u32 i = 0; i < 15; i++){bytes[i] = (char)Memory.RAM.ReadU8(this.pointer + 0x04 + (i * 1));} return bytes;
        }
        
        private void _mName(char[] value) {
            for(u32 i = 0; i < 15; i++){Memory.RAM.WriteU8(this.pointer + 0x04 + (i * 1), (u8)value[i]);}
        }
        
        private u8 _field_0x10() {
            return Memory.RAM.ReadU8(this.pointer + 0x10);
        }
        
        private void _field_0x10(u8 value) {
            Memory.RAM.WriteU8(this.pointer + 0x10, value);
        }
        
        private u8 _field_0x11() {
            return Memory.RAM.ReadU8(this.pointer + 0x11);
        }
        
        private void _field_0x11(u8 value) {
            Memory.RAM.WriteU8(this.pointer + 0x11, value);
        }
        
        private u8 _field_0x12() {
            return Memory.RAM.ReadU8(this.pointer + 0x12);
        }
        
        private void _field_0x12(u8 value) {
            Memory.RAM.WriteU8(this.pointer + 0x12, value);
        }
        
        private u8 _field_0x13() {
            return Memory.RAM.ReadU8(this.pointer + 0x13);
        }
        
        private void _field_0x13(u8 value) {
            Memory.RAM.WriteU8(this.pointer + 0x13, value);
        }
        
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
    }
}
