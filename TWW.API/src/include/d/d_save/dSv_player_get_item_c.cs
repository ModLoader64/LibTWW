//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TWW.API {
    
    
    public class dSv_player_get_item_c {
        
        [System.Text.Json.Serialization.JsonIgnoreAttribute()]
        private u32 pointer;
        
        public u8[] mItemFlags {get => this._mItemFlags(); set => this._mItemFlags(value);}//;
        
        public dSv_player_get_item_c(u32 pointer) {
           this.pointer = pointer;
        }
        
        public static uint getSize() {
          return 0x15;
        }
        
        // #ARRCOUNT 21
        private u8[] _mItemFlags() {
            u8[] bytes = new u8[21]; for(u32 i = 0; i < 21; i++){bytes[i] = Memory.RAM.ReadU8(this.pointer + 0x0 + (i * 1));} return bytes;
        }
        
        private void _mItemFlags(u8[] value) {
            for(u32 i = 0; i < 21; i++){Memory.RAM.WriteU8(this.pointer + 0x0 + (i * 1), value[i]);}
        }
    }
}