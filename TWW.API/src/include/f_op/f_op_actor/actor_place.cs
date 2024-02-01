//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TWW.API {
    
    
    public class actor_place {
        
        [System.Text.Json.Serialization.JsonIgnoreAttribute()]
        private u32 pointer;
        
        public cXyz pos {get => this._pos(); set => this._pos(value);}//;
        
        public csXyz angle {get => this._angle(); set => this._angle(value);}//;
        
        public s8 roomNo {get => this._roomNo(); set => this._roomNo(value);}//;
        
        public u8 field_0x13 {get => this._field_0x13(); set => this._field_0x13(value);}//;
        
        public actor_place(u32 pointer) {
           this.pointer = pointer;
        }
        
        public static uint getSize() {
          return 0x0; // DEADBEEF TODO: Fix Addr
        }
        
        private cXyz _pos() {
            return new cXyz(this.pointer + 0x00);
        }
        
        private void _pos(cXyz value) {
        }
        
        private csXyz _angle() {
            return new csXyz(this.pointer + 0x0C);
        }
        
        private void _angle(csXyz value) {
        }
        
        private s8 _roomNo() {
            return Memory.RAM.ReadS8(this.pointer + 0x12);
        }
        
        private void _roomNo(s8 value) {
            Memory.RAM.WriteS8(this.pointer + 0x12, value);
        }
        
        private u8 _field_0x13() {
            return Memory.RAM.ReadU8(this.pointer + 0x13);
        }
        
        private void _field_0x13(u8 value) {
            Memory.RAM.WriteU8(this.pointer + 0x13, value);
        }
    }
}