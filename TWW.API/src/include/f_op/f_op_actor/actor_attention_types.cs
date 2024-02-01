//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TWW.API {
    
    
    public class actor_attention_types {
        
        [System.Text.Json.Serialization.JsonIgnoreAttribute()]
        private u32 pointer;
        
        public u8[] mDistances {get => this._mDistances(); set => this._mDistances(value);}//;
        
        public cXyz mPosition {get => this._mPosition(); set => this._mPosition(value);}//;
        
        public u32 mFlags {get => this._mFlags(); set => this._mFlags(value);}//;
        
        public actor_attention_types(u32 pointer) {
           this.pointer = pointer;
        }
        
        public static uint getSize() {
          return 0x0; // DEADBEEF TODO: Fix Addr
        }
        
        // #ARRCOUNT 8
        private u8[] _mDistances() {
            u8[] bytes = new u8[8]; for(u32 i = 0; i < 8; i++){bytes[i] = Memory.RAM.ReadU8(this.pointer + 0x00 + (i * 1));} return bytes;
        }
        
        private void _mDistances(u8[] value) {
            for(u32 i = 0; i < 8; i++){Memory.RAM.WriteU8(this.pointer + 0x00 + (i * 1), value[i]);}
        }
        
        private cXyz _mPosition() {
            return new cXyz(this.pointer + 0x08);
        }
        
        private void _mPosition(cXyz value) {
        }
        
        private u32 _mFlags() {
            return Memory.RAM.ReadU32(this.pointer + 0x14);
        }
        
        private void _mFlags(u32 value) {
            Memory.RAM.WriteU32(this.pointer + 0x14, value);
        }
        
    }
}
