//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TWW.API {
    
    
    public class stage_pselect_info_class {
        
        [System.Text.Json.Serialization.JsonIgnoreAttribute()]
        private u32 pointer;
        
        public u8[] mPalIdx {get => this._mPalIdx(); set => this._mPalIdx(value);}//;
        
        public f32 mChangeRate {get => this._mChangeRate(); set => this._mChangeRate(value);}//;
        
        public stage_pselect_info_class(u32 pointer) {
           this.pointer = pointer;
        }
        
        public static uint getSize() {
          return 0x0; // DEADBEEF TODO: Fix Addr
        }
        
        // #ARRCOUNT 8
        private u8[] _mPalIdx() {
            u8[] bytes = new u8[8]; for(u32 i = 0; i < 8; i++){bytes[i] = Memory.RAM.ReadU8(this.pointer + 0x0 + (i * 1));} return bytes;
        }
        
        private void _mPalIdx(u8[] value) {
            for(u32 i = 0; i < 8; i++){Memory.RAM.WriteU8(this.pointer + 0x0 + (i * 1), value[i]);}
        }
        
        private f32 _mChangeRate() {
            return Memory.RAM.ReadF32(this.pointer + 0x8);
        }
        
        private void _mChangeRate(f32 value) {
            Memory.RAM.WriteF32(this.pointer + 0x8, value);
        }
    }
}
