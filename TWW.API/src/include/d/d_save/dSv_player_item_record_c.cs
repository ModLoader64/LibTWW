//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TWW.API {
    
    
    public class dSv_player_item_record_c {
        
        [System.Text.Json.Serialization.JsonIgnoreAttribute()]
        private u32 pointer;
        
        public u16 mTimer {get => this._mTimer(); set => this._mTimer(value);}//;
        
        public dSv_player_item_record2_c mItemRecord2 {get => this._mItemRecord2(); set => this._mItemRecord2(value);}//;
        
        public u8[] mBottleNum {get => this._mBottleNum(); set => this._mBottleNum(value);}//;
        
        public dSv_player_item_record_c(u32 pointer) {
           this.pointer = pointer;
        }
        
        public static uint getSize() {
          return 0x8;
        }
        
        private u16 _mTimer() {
            return Memory.RAM.ReadU16(this.pointer + 0x0);
        }
        
        private void _mTimer(u16 value) {
            Memory.RAM.WriteU16(this.pointer + 0x0, value);
        }
        
        private dSv_player_item_record2_c _mItemRecord2() {
            return new dSv_player_item_record2_c(this.pointer + 0x2);
        }
        
        private void _mItemRecord2(dSv_player_item_record2_c value) {
        }
        
        // #ARRCOUNT 3
        private u8[] _mBottleNum() {
            u8[] bytes = new u8[3]; for(u32 i = 0; i < 3; i++){bytes[i] = Memory.RAM.ReadU8(this.pointer + 0x5 + (i * 1));} return bytes;
        }
        
        private void _mBottleNum(u8[] value) {
            for(u32 i = 0; i < 3; i++){Memory.RAM.WriteU8(this.pointer + 0x5 + (i * 1), value[i]);}
        }
    }
}